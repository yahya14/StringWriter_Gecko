# StringWriter for TCPGecko

<p align="center">
  <img src="http://i.imgur.com/rpvjpsC.png" alt="StringWriter Image"/>
</p>


StringWriter is a program that allows to patch strings in the raw Wii U memory. This is a project that was created with an educational purpose in mind ~~and for helping a friend~~.

###Information

This program can read the Wii U memory in 3 forms; _ASCII_, _Byte_, and _Unicode_. You could easily edit your _ASCII_ or _Unicode_ text and convert them to byte for easy conversion and injection.

Bytes between **\00 - \1F** are automatically nulled when converting from _Byte_ to _ASCII_/_Unicode_, since it's nature can't be easily handled. Thus handle this with care, converting _ASCII_/_Unicode_ to _Byte_ **with null bytes (¶)** will convert some of the data to /00s, and accuracy is lost. Possible lost bytes before the conversion can be visible on text with the pilcrow sign (¶).

Pressing the **Apply** button will inject only the _Byte_ data. To inject _ASCII_/_Unicode_, convert them to _Byte_ first. Also, injecting the data only injects the length of the bytes in the textbox, so the **Byte Length:** does not apply for injecting, but only for reading.

When reading and then modifying the data, it's recommended to match the **Current byte length** and the **Read byte length** before injecting the data. Without proper care, you will shift the data and inject it improperly. 



###Requirements

+ Windows Vista or higher (Mac and Linux users, use Wine)
+ [.NET Framework 4.5.2](http://go.microsoft.com/fwlink/?LinkId=328843)
+ Wii U System Firmware 5.5.1 or below
+ TCPGecko + kernel from loadiine.ovh website, Cortney's [code handler](https://gbatemp.net/threads/post-your-wiiu-cheat-codes-here.395443/), or [geckiine](https://gbatemp.net/threads/release-geckiine-tcpgecko-and-cafiine-combined.433057/)

##Credits

Special thanks to all for their useful stuff; Chadderz, Amibu, Lean, Splatonka, and NWPlayer123.

####Links

For the best way to view the Wii U's memory, view Chadderz's Github page for tcpgeckodotnet [here](https://github.com/Chadderz121/tcp-gecko-dotnet) or download the program directly from [MediaFire](http://www.mediafire.com/download/a8ix5ofcqh9xgb6/Debug.zip)