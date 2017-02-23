using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StringWriter
{
    public partial class StringWriteForm : Form
    {
        public static TCPGecko gecko = null;
        private string bytePrev;

        //variables for when the form loads for sizing and location
        private int FormScale;
        private int boxWidth, AutoWidth;
        private int sHeight, bHeight, uHeight;
        private int bAutoY, uAutoY;
        private int bLabelY, uLabelY;
        private int bRTBYDiff, uRTBYDiff;
        private int convertButton2YDiff;
        private int iLabelYDiff;
        private int tipLabelX, tipLabelY;

        public StringWriteForm()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ////TCPGecko Connection area
            //This becomes both a connect and a recalc button
            if (gecko == null)
            {
                gecko = new TCPGecko(IPBox.Text, 7331);
                try
                {
                    gecko.Connect();
                }
                catch (ETCPGeckoException)
                {
                    gecko = null;
                    MessageBox.Show("Could not connect to TCPGecko.", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                //saves IP address
                IPData.savIP(IPBox.Text);
                ConnectButton.BackColor = Color.FromArgb(50, 145, 245); //light blue change indicating connection established
                DisconnButton.BackColor = Color.FromArgb(225, 39, 39);
            }
        }

        private void DisconnButton_Click(object sender, EventArgs e)
        {
            if (gecko != null)
            {
                gecko.Disconnect();
                gecko = null;
                ConnectButton.Text = "Connect";
                ConnectButton.BackColor = Color.FromArgb(90, 200, 92);
                DisconnButton.BackColor = Color.FromArgb(200, 40, 50);
            }
        }

        //reads bytes to a certain range
        private void readButton_Click(object sender, EventArgs e)
        {
            if (gecko != null)
            {
                //create memory stream
                MemoryStream stream = new MemoryStream();
                uint baddress = (uint)(addrNumericUpDown.Value);
                uint eaddress = 0;

                //select radio buttons for length
                uint i;
                uint diff = (uint)(endNumericUpDown.Value - addrNumericUpDown.Value);
                if (readRadioButton.Checked == true)
                {
                    eaddress = (uint)(readSizeNumericUpDown.Value);
                    i = 256 - (256 - eaddress);
                }
                else
                {
                    eaddress = diff;
                    i = 256 - (256 - diff);
                }

                //dumps data from memory
                gecko.Dump(baddress, baddress + eaddress, stream);

                //define byte array
                stream.Seek(0, SeekOrigin.Begin);
                byte[] stringbyte = stream.GetBuffer();
                byte[] ba = new byte[i];
                Array.Copy(stringbyte, ba, i);

                //convert bytes to ASCII
                string sa = ASCIIDecoder(ba);
                ASCIIRTB.Text = sa;

                //convert bytes to unicode
                string ua = unicodeDecoder(ba);
                unicodeRTB.Text = ua;

                //convert byte to byte string
                string hex = BitConverter.ToString(ba);
                hex = hex.Replace("-", "");
                byteRTB.Text = hex;

                //change font colors to organize data every 4 bytes
                /*stringFontColors();*/
                byteFontColors();

                //update read length numbers
                readASCIILengthLabel.Text = "0x" + (sa.Length).ToString("X");
                readByteLengthLabel.Text = "0x" + ((int)(roundLowest(hex.Length, 2) / 2)).ToString("X");
                readUnicodeLengthLabel.Text = "0x" + (ua.Length * 2).ToString("X");
            }
            else
                msg("No conn...");
        }

        //injects bytes to ram
        private void writerButton_Click(object sender, EventArgs e)
        {
            byte[] sa;

            if (byteRTB.Text != "" && gecko != null)
            {
                //converts hex to byte array and handles potential error
                try
                {
                    sa = hex2Bytes(byteRTB.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Atleast one of the digits are unrecognizable. Ensure that all bytes are in the form of a hexdecimal.", "Byte Injection Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                //converts byte array to string, then injects data to memory and handles potential error
                try
                {
                    writeString((uint)(addrNumericUpDown.Value), Encoding.GetEncoding("iso-8859-1").GetString(sa));
                    msg("Success!");
                }
                catch (Exception)
                {
                    if (readByteLabel.Text != currentByteLengthLabel.Text)
                    {
                        DisconnButton_Click(sender, e);
                        MessageBox.Show("The connection to the Wii U has been lost. The program's connection has been terminated." +
                            "\n\nNotice: The read and current byte length were not identical, which could shift the intented injections to memory. Your game might have crashed because of this.",
                            "Connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        DisconnButton_Click(sender, e);
                        MessageBox.Show("The connection to the Wii U has been lost. The program's connection has been terminated", "Connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                    return;
                }
            }
            else if (gecko == null)
                msg("No conn...");
        }

        //zeros all addresses within the specified address range from the radio buttons
        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (gecko != null)
            {
                //create empty array based on specified length
                uint ZeroSize;
                if (readRadioButton.Checked == true)
                    ZeroSize = (uint)(readSizeNumericUpDown.Value);
                else
                    ZeroSize = (uint)(endNumericUpDown.Value - addrNumericUpDown.Value);

                byte[] az = new byte[ZeroSize];

                //inject empty array
                try
                {
                    writeString((uint)(addrNumericUpDown.Value), Encoding.ASCII.GetString(az));
                    msg("Success!");
                }
                catch (Exception)
                {
                    DisconnButton_Click(sender, e);
                    MessageBox.Show("The connection to the Wii U has been lost. The program's connection has been terminated", "Connection Lost", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
                msg("No conn...");
        }

        //convert ascii to byte into the byte text box
        private void ASCII2byteButton_Click(object sender, EventArgs e)
        {
            if (ASCII2byteButton.Focused || ASCIIRTB.Focused || ASCIIAutoCheck.Focused)
            {
                byte[] b1 = Encoding.GetEncoding("iso-8859-1").GetBytes(ASCIIRTB.Text);
                byte[] b2 = ReplaceBytes(b1, "2E", "B6", "00");
                byteRTB.Text = bytePrev;
                byteFontColors();
            }
        }

        //convert byte to ascii into the ascii text box
        private void byte2ASCIIButton_Click(object sender, EventArgs e)
        {
                bytevalid(byteRTB.Text);
                try
                {
                    byte[] b = hex2Bytes(byteRTB.Text);
                    string stringVert = ASCIIDecoder(b);
                    ASCIIRTB.Text = stringVert;
                    /*stringFontColors();*/
                }
                catch (Exception)
                {
                    if (!byteAutoCheck.Checked || byte2ASCIIButton.Focused)
                        MessageBox.Show("Atleast one of the hexdecimals are unrecognizable. Ensure that all bytes are in the form of a hexdecimal.", "Byte to ASCII Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
        }


        //convert unicode to byte into the byte text box
        private void unicode2byteButton_Click(object sender, EventArgs e)
        {
            if (unicode2byteButton.Focused || unicodeRTB.Focused || unicodeAutoCheck.Focused)
            {
                byte[] b1 = Encoding.BigEndianUnicode.GetBytes(unicodeRTB.Text);
                byte[] b2 = ReplaceBytes(b1, "002E", "00B6", "0000");
                byteRTB.Text = bytePrev;
                byteFontColors();
            }
        }

        //convert byte to unicode into the unicode text box
        private void byte2unicodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = hex2Bytes(byteRTB.Text);
                string stringVert = unicodeDecoder(b);
                unicodeRTB.Text = stringVert;
            }
            catch (Exception)
            {
                if (!byteAutoCheck.Checked || byte2unicodeButton.Focused)
                    MessageBox.Show("Atleast one of the hexdecimals are unrecognizable. Ensure that all bytes are in the form of a hexdecimal.", "Byte to Unicode Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
        }

        //counts current text length of the ascii text box
        private void ASCIIRTB_TextChanged(object sender, EventArgs e)
        {
            currentASCIILengthLabel.Text = "0x" + (ASCIIRTB.TextLength).ToString("X");
        }

        //counts current text length of the byte text box and handles auto update for both ascii and unicode when checked
        private void byteRTB_TextChanged(object sender, EventArgs e)
        {
            currentByteLengthLabel.Text = "0x" + ((int)(roundLowest(byteRTB.TextLength, 2) / 2)).ToString("X");

            if (byteRTB.Focused || ASCII2byteButton.Focused || unicode2byteButton.Focused)
                bytevalid(byteRTB.Text);

            if (byteAutoCheck.Checked && byteRTB.Focused)
            {
                byte2ASCIIButton_Click(sender, e);
                byte2unicodeButton_Click(sender, e);
            }
        }

        //counts current text length of the ascii text box
        private void unicodeRTB_TextChanged(object sender, EventArgs e)
        {
            currentUnicodeLengthLabel.Text = "0x" + (unicodeRTB.TextLength * 2).ToString("X");

        }

        //toggles auto updater for ascii to byte by tieing the handlers to the button converters
        private void stringAutoCheck_CheckedChanged(object sender, EventArgs e) 
        {
            if (ASCIIAutoCheck.Checked)
            {
                ASCIIRTB.TextChanged += new EventHandler(ASCII2byteButton_Click);
                ASCII2byteButton_Click(sender, e);
            }
            else ASCIIRTB.TextChanged -= new EventHandler(ASCII2byteButton_Click);
        }

        //calls conversion from byte to ascii and unicode upon checking. Hacky since no extra handlers handlers are defined
        private void byteAutoCheck_CheckedChanged(object sender, EventArgs e) 
        {
            byteRTB_TextChanged(sender, e);
        }


        //toggles auto updater for unicode to byte by tieing the handlers to the button converters
        private void unicodeAutoCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (unicodeAutoCheck.Checked)
            {
                unicodeRTB.TextChanged += new EventHandler(unicode2byteButton_Click);
                unicode2byteButton_Click(sender, e);
            }
            else unicodeRTB.TextChanged -= new EventHandler(unicode2byteButton_Click);
        }

        //font colors changed to display organized 32 bit data when leaving the text box
        private void ASCIIRTB_Leave(object sender, EventArgs e) { /*stringFontColors();*/ }
        private void byteRTB_Leave(object sender, EventArgs e) { byteFontColors(); }

        //simplified method for rounding numbers to the lowest given number
        private decimal roundLowest(decimal val, int roundNum)
        {
            return Math.Floor(val / roundNum) * roundNum;
        }

        //rewritten writeString for effeciency
        private void writeString(uint address, string s)
        {
            writeString(address, s, s.Length);
        }

        private void writeString(uint address, string s, int len)
        {
            uint raddress = address - (address % 4);

            //dumps first address from memory into byte array
            MemoryStream faddr = new MemoryStream();

            gecko.Dump(raddress, raddress + 4, faddr);

            faddr.Seek(0, SeekOrigin.Begin);
            byte[] fb = faddr.GetBuffer();

            //closes stream properly
            faddr.Close();

            //stack remaining chars to the char array
            for (uint i = address % 4; i > 0; i--)
            {
                s = (char)fb[i - 1] + s;
                len++;
            }

            //define final char array
            char[] c = new char[len];
            for (int i = 0; i < s.Length && i < len; i++)
                c[i] = s[i];

            //poke all of the char array until it goes out of range and the exception is thrown
            uint val = 0;
            for (uint i = 0; i < len; i += 4)
            {
                try
                {
                    val = 0;
                    for (int j = 0; j < 4; j++)
                        val += (uint)(c[j + i] << (8 * (3 - j)));

                    gecko.poke(raddress + i, val);
                }
                //catch the end of the char array and peek the final address
                catch (IndexOutOfRangeException)
                {
                    //dumps first address from memory into byte array
                    MemoryStream laddr = new MemoryStream();

                    gecko.Dump(raddress + i, raddress + i + 4, laddr);

                    laddr.Seek(0, SeekOrigin.Begin);
                    byte[] stringbyte = laddr.GetBuffer();

                    //null bytes depending on remainder
                    for (int j = 0; j < len % 4; j++)
                        stringbyte[j] = 0;

                    //add the remaining chars to val in uint form
                    uint laddress = 0;
                    for (int j = 0; j < 4; j++)
                        laddress += (uint)(stringbyte[j] << (8 * (3 - j)));

                    val += laddress;

                    gecko.poke(raddress + i, val);

                    //closes stream properly
                    laddr.Close();
                }
            }
        }
        
        //changes byte font colors
        private void byteFontColors()
        {
            //make all characters upper case
            byteRTB.Text = byteRTB.Text.ToUpper();
            if (byteRTB.TextLength < 0x8000)
            {
                //byte text box
                StringBuilder sb2 = new StringBuilder();
                sb2.Append("{\\rtf1\\ansi\\ansicpg1250\\deff0\\deflang1050{\\fonttbl{\\f0\\fnil\\fcharset238 Microsoft Sans Serif;}}\r\n{\\colortbl ;\\red0\\green0\\blue254;\\red250\\green0\\blue0;}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17");
                string[] col2 = new string[] { "\\cf1 ", "\\cf2 " };
                int idxCol2 = 0;
                for (int i = 0; i < byteRTB.TextLength; i++)
                {
                    if (i % 8 == 0)
                    {
                        sb2.Append(col2[idxCol2]);
                        idxCol2 = (idxCol2 + 1) % 2;
                    }
                    sb2.Append(byteRTB.Text[i]);
                }
                sb2.Append("\\par\r\n}\r\n");

                byteRTB.Rtf = sb2.ToString();
            }
            else
                msg("Format error.");
        }

        //changes string font colors (not used)
        private void stringFontColors()
        {
            if (byteRTB.TextLength < 0x8000)
            {
                //string text box
                StringBuilder sb = new StringBuilder();
            sb.Append("{\\rtf1\\ansi\\ansicpg1250\\deff0\\deflang1050{\\fonttbl{\\f0\\fnil\\fcharset238 Microsoft Sans Serif;}}\r\n{\\colortbl ;\\red0\\green0\\blue254;\\red250\\green0\\blue0;}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17");
            string[] col = new string[] { "\\cf1 ", "\\cf2 " };
            int idxCol = 0;
            for (int i = 0; i < ASCIIRTB.TextLength; i++)
            {
                if (i % 4 == 0)
                {
                    sb.Append(col[idxCol]);
                    idxCol = (idxCol + 1) % 2;
                }
                sb.Append(ASCIIRTB.Text[i]);
            }
            sb.Append("\\par\r\n}\r\n");
            ASCIIRTB.Rtf = sb.ToString();
            }
            else
                msg("Format error.");
        }

        //validates hex values to prevent byte conversion errors
        private bool bytevalid(string input)
        {
            if (Regex.IsMatch(input, @"[^0-9A-Fa-f]"))
            {
                byteRTB.BackColor = Color.FromArgb(255, 200, 200);

                return true;
            }
            else
            {
                byteRTB.BackColor = SystemColors.Window;
                return false;
            }
        }

        //reads a byte array and converts it to modified ascii. CREDITS to Chadderz
        private static string ASCIIDecoder(byte[] buffer)
        {
            string cstring = "";
            for (int FormScale = 0; FormScale < buffer.Length; FormScale++)
            {
                byte bInput = buffer[FormScale];
                if (bInput >= 0x20 && bInput < 0x7F)
                    cstring += (char)bInput;
                else if (bInput < 0x20 && bInput > 0x0)
                    cstring += "¶";
                else
                    cstring += ".";
            }
            return cstring;
        }

        //reads a byte array and converts it to modified unicode. CREDITS to Chadderz and Lean
        private static string unicodeDecoder(byte[] buffer)
        {
            string cstring = "";
            for (int FormScale = 0; FormScale < buffer.Length - 1; FormScale+=2)
            {
                int bInput = (buffer[FormScale] * 256 + buffer[FormScale + 1]);
                if (bInput >= 0x20)
                    cstring += (char)bInput;
                else if (bInput < 0x20 && bInput > 0x0)
                    cstring += "¶";
                else
                    cstring += ".";
            }
            return cstring;
        }

        //replaces periods etc, before converting ascii or unicode to byte array (pure data is lost as in the undisplayable control chars)
        public byte[] ReplaceBytes(byte[] src, string replace, string replacetwo, string replacewith)
        {
            string hex = BitConverter.ToString(src);
            hex = hex.Replace("-", "");
            hex = hex.Replace(replace, replacewith);
            hex = hex.Replace(replacetwo, replacewith);

            //weird place to put define the variable...
            bytePrev = hex;

            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        //conversion from hex to byte array
        public byte[] hex2Bytes(string hex)
        {
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        //a methos set for displaying a message on the read button
        private void msg(string msg)
        {
            readButton.Text = msg;
            msgTimer.Stop();
            msgTimer.Start();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        //timer that runs once to revert read button message to the original
        private void msgTimer_Tick(object sender, EventArgs e)
        {
            readButton.Text = "Read";
            readButton.Font = new Font(readButton.Font.FontFamily, 8.25f);
            msgTimer.Stop();
        }

        //handles the values of the numeric boxes from reading wrong ranges when clicking the read button
        private void addrnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!endNumericUpDown.Focused)
                if (addrNumericUpDown.Value >= endNumericUpDown.Value) endNumericUpDown.Value = addrNumericUpDown.Value + 0x1;
        }

        private void endNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!addrNumericUpDown.Focused)
                if (endNumericUpDown.Value <= addrNumericUpDown.Value) addrNumericUpDown.Value = endNumericUpDown.Value - 0x1;
        }

        //gui area
        //allows user to press the return key to connect
        private void IPBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
                ConnectButton_Click(sender, e);
        }

        //loads default values for form sizing and the IP address
        private void StringWriteForm_Load(object sender, EventArgs e)
        {
            //GUI
            //abbreviations such as s = string, b = byte, and u = unicode in variables are objects for scaling mathmatically depending on the form size
            //every variable stores default size and location of sizable objects

            //universal scale for form when resizing
            FormScale = (int)3.5;

            //variables for sizing the form's horizontal change
            boxWidth = Size.Width - byteRTB.Width;
            AutoWidth = Size.Width - ASCIIAutoCheck.Location.X;

            //variables for location and sizing the form's vertical change
            sHeight =  Size.Height / FormScale - ASCIIRTB.Height;
            bHeight = Size.Height / FormScale - byteRTB.Height;
            bLabelY = byteRTB.Location.Y - byteLabel.Location.Y;
            bAutoY = byteRTB.Location.Y - byteAutoCheck.Location.Y;
            bRTBYDiff = byte2ASCIIButton.Height + 1;
            uHeight = Size.Height / FormScale - unicodeRTB.Height;
            uLabelY = unicodeRTB.Location.Y - unicodeLabel.Location.Y;
            uAutoY = unicodeRTB.Location.Y - unicodeAutoCheck.Location.Y;
            uRTBYDiff = byte2unicodeButton.Height + 1;
            convertButton2YDiff = byte2unicodeButton.Location.Y - unicodeRTB.Location.Y;

            //location for infoLabel
            iLabelYDiff = infoLabel.Location.Y - (unicodeRTB.Location.Y + unicodeRTB.Height);

            //location for tipLabel
            tipLabelX = Size.Width - tipLabel.Location.X;
            tipLabelY = Size.Height - tipLabel.Location.Y;

            //loads saved IP address
            IPBox.Text = IPData.loadIP();
        }

        //handles all adjustable objects' size and location depending how the user changes the form size
        private void StringWriteForm_SizeChanged(object sender, EventArgs e) //changes text box size relative to the form control automatically
        {
            int i = Size.Width;
            int j = Size.Height;

            ////extend horizontally
            //richTextBox sizes
            ASCIIRTB.Size = new Size(i - boxWidth, ASCIIRTB.Height);
            byteRTB.Size = new Size(i - boxWidth, byteRTB.Height);
            unicodeRTB.Size = new Size(i - boxWidth, unicodeRTB.Height);

            //auto update checkBox location
            ASCIIAutoCheck.Location = new Point(Size.Width - AutoWidth, ASCIIAutoCheck.Location.Y);
            byteAutoCheck.Location = new Point(Size.Width - AutoWidth, byteAutoCheck.Location.Y);
            unicodeAutoCheck.Location = new Point(Size.Width - AutoWidth, unicodeAutoCheck.Location.Y);

            ////extend veritcally
            //size and location of ASCII obects
            ASCIIRTB.Size = new Size(ASCIIRTB.Width, j / FormScale - sHeight);
            stringLabel.Location = new Point(stringLabel.Location.X, ASCIIRTB.Location.Y - bLabelY);
            ASCIIAutoCheck.Location = new Point(ASCIIAutoCheck.Location.X, ASCIIRTB.Location.Y - bAutoY);
            ASCII2byteButton.Location = new Point(ASCII2byteButton.Location.X, ASCIIRTB.Height + ASCIIRTB.Location.Y + 1);
            byte2ASCIIButton.Location = new Point(byte2ASCIIButton.Location.X, ASCIIRTB.Height + ASCIIRTB.Location.Y + 1);

            //size and location of byte obects
            byteRTB.Size = new Size(byteRTB.Width, j / FormScale - bHeight);
            byteRTB.Location = new Point(byteRTB.Location.X, byte2ASCIIButton.Location.Y + bRTBYDiff);
            byteLabel.Location = new Point(byteLabel.Location.X, byteRTB.Location.Y - bLabelY);
            byteAutoCheck.Location = new Point(byteAutoCheck.Location.X, byteRTB.Location.Y - bAutoY);
            byte2unicodeButton.Location = new Point(byte2unicodeButton.Location.X, byteRTB.Height + byteRTB.Location.Y + 1);
            unicode2byteButton.Location = new Point(unicode2byteButton.Location.X, byteRTB.Height + byteRTB.Location.Y + 1);

            //size and location of unicode obects
            unicodeRTB.Size = new Size(unicodeRTB.Width, j / FormScale - uHeight);
            unicodeRTB.Location = new Point(unicodeRTB.Location.X, unicode2byteButton.Location.Y + uRTBYDiff);
            unicodeLabel.Location = new Point(unicodeLabel.Location.X, unicodeRTB.Location.Y - uLabelY);
            unicodeAutoCheck.Location = new Point(unicodeAutoCheck.Location.X, unicodeRTB.Location.Y - uAutoY);
            byte2unicodeButton.Location = new Point(byte2unicodeButton.Location.X, unicodeRTB.Location.Y + convertButton2YDiff);
            unicode2byteButton.Location = new Point(unicode2byteButton.Location.X, unicodeRTB.Location.Y + convertButton2YDiff);

            //infoormation label at the bottom of the form
            infoLabel.Location = new Point(infoLabel.Location.X, unicodeRTB.Location.Y + unicodeRTB.Height + iLabelYDiff);

            //tip label at the bottom of the form
            tipLabel.Location = new Point((Size.Width > 595 ? Size.Width - tipLabelX : 451), Size.Height - tipLabelY);
        }
    }
}