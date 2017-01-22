# StringWriter for TCPGecko

<p align="center">
  <img src="http://i.imgur.com/rpvjpsC.png" alt="StringWriter Image"/>
</p>


StringWriter is a modified program that allows to patch strings in the raw Wii U memory. This is a project that was created with an educational purpose in mind ~~and for helping a friend~~, despite knowing there are limitations to how raw data that can be displayed as a string. But it stays well accurate once you know how to use it.

###Information

Reading the memory with this program displays the raw data in three forms simultaneously; _ASCII_, _byte_, and _unicode_ in their own text boxes. You could easily edit your ascii or unicode text and convert them to byte for easy conversion and injection.

However if you're editing certain areas with bytes below \1F, **DO NOT** convert ascii or unicode to byte, or else it will \00 them out in the byte text box after the conversion. Possible lost bytes before the conversion can be visible on text with the pilcrow sign (¶).

This is why strings are **not** always reliable for injecting, because of the some unreadable control chars that are near impossible to convert to byte before injection.Therefore, it's better for reading data _with your eyes_ if the pilcrow is visible in your text. Although the displayed byte in its own text box is extremely accurate and recommended to base all edits from there.

It's also recommended to keep in mind that the read byte length and the current byte length that should be matched before injecting data . However if you're experienced enough and you don't feel the need to, that should be fine.

###Requirements

+ Windows Vista or higher (Mac and Linux users, use Wine)
+ [.NET Framework 4.5.2](http://go.microsoft.com/fwlink/?LinkId=328843)
+ Wii U System Firmware 5.5.1 or below
+ TCPGecko + kernel from loadiine.ovh website, Cortney's [code handler](https://gbatemp.net/threads/post-your-wiiu-cheat-codes-here.395443/), or [geckiine](https://gbatemp.net/threads/release-geckiine-tcpgecko-and-cafiine-combined.433057/)

##Credits

Special thanks to all for their useful stuff; Chadderz, Amibu, Lean, Splatonka, and NWPlayer123.

####Links

For the best way to view the Wii U's memory, view Chadderz's Github page for tcpgeckodotnet [here](https://github.com/Chadderz121/tcp-gecko-dotnet) or download the program directly from [MediaFire](http://www.mediafire.com/download/a8ix5ofcqh9xgb6/Debug.zip)