# StringWriter for TCPGecko

<p align="center">
  <img src="http://i.imgur.com/rpvjpsC.png" alt="StringWriter Image"/>
</p>


StringWriter is a program that allows you to patch strings in the raw Wii U memory. This is a project that was created with an educational purpose in mind *and for helping a friend*.

### Information

This program can read the Wii U memory in 3 forms; _ASCII_, _Byte_, and _Unicode_. You can easily edit your _ASCII_ or _Unicode_ text and convert them to byte for easy conversion and injection.

Bytes between **\00 - \1F** are automatically nulled as **\00** when converting from _Byte_ to _ASCII_/_Unicode_, since it's nature can't be easily handled. Thus handle this with care, converting _ASCII_/_Unicode_ to _Byte_ **with nulled bytes (¶)** will convert some of the data to \00s, and accuracy is lost. Possible lost bytes before the conversion can be visible on the text with the pilcrow sign **(¶)**.

Pressing the **Apply** button will inject only the _Byte_ data. To inject _ASCII_/_Unicode_, convert them to _Byte_ first. Also, injecting the data only injects the length of the bytes in the textbox, so the **Byte Length:**, value on the left of the form, does not apply for injecting, but only for reading. However, **Byte Length:** does apply to the **Apply 0s within range** button.

When reading and then modifying the data, it's recommended to match the **Current byte length** and the **Read byte length** before injecting the data. Without proper care, you will shift the data and inject it improperly.

## What are these three types of Data?

ASCII - Represents a character/letter from the American Standard code, relative to the byte value. The size of each ASCII character is 8 bit (aka bytes with 2 digits).
Byte - Represents a numerical value with base 16, instead of the common base 10. Sizes of bytes can vary from 8 bit to 32 bit on the Wii U.
unicode - Represets a character like ASCII, but the size of each character is 16-bit instead (bytes with 4 digits). The bigger size is to accomodate the support for all languages and special characters.

Also, In most cases the Wii U uses ASCII for most ram mods. Unicode is likely used for only game texts instead.

## Requirements

+ Windows Vista or higher (Mac and Linux users, use Wine)
+ [.NET Framework 4.5.2](http://go.microsoft.com/fwlink/?LinkId=328843)
+ Wii U System Firmware 5.5.1 or below
+ Local IP for the Wii U ([See the guide here](https://github.com/OatmealDome/SplatoonUtilities/blob/master/Misc/FindingWiiUIP.md))
+ TCPGecko + kernel from loadiine.ovh website, Cortney's [code handler](https://gbatemp.net/threads/post-your-wiiu-cheat-codes-here.395443/), or [geckiine](https://gbatemp.net/threads/release-geckiine-tcpgecko-and-cafiine-combined.433057/)

## Credits

Special thanks to all for their useful stuff; Chadderz, Amibu, Lean, Splatonka, and NWPlayer123.

#### Links

Check the releases for StringWriter in the release tab or [right here](https://github.com/yahya14/StringWriter_Gecko/releases)

To view the Wii U's memory the classic way, view Chadderz's Github page for tcpgeckodotnet [here](https://github.com/Chadderz121/tcp-gecko-dotnet) or download the program directly from [MediaFire](http://www.mediafire.com/download/a8ix5ofcqh9xgb6/Debug.zip)
