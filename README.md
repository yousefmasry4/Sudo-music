# Sudo-music

> This Project is Based on **KA RADIO**.

> The idea of this project is to create a **PCB KA RADIO** and Create Desktop App to control this Hardware and enjoy its benefits.

 *KA RADIO* is a WiFi shoutcast player based on ESP8266 and VS1053b chips, For more info and Guide Refer To: [INFO](https://github.com/karawin/Ka-Radio#-esp8266--vs1053-wifi-webradio-) , Thanks Karawin.

## Node MCU
using **Node MCU** based on **KA RADIO** it takes the data from internet then processe it using a decoder.

What is *Node MCU* ...?
*Node MCU* is an open source IoT platform. It includes firmware which runs on the ESP8266 Wi-Fi SoC from Espressif Systems, and hardware which is based on the ESP-12 module. The term "NodeMCU" by default refers to the firmware rather than the development kits. The firmware uses the Lua scripting language. It is based on the eLua project, and built on the Espressif Non-OS SDK for ESP8266. It uses many open source projects, such as lua-cjson and SPIFFS.

>Using the Node MCU and IOT we can have **WIFI Radio**, and also with an Application we can have control over the exchange and change channel and also control the sound volume which are all perks of a **Music app** (Except its not a radio) so for the heck of it naming ***Sudo Music!***
 
 ### What is IOT?
 
 >IOT is a shortcut for **Internet Of Things**
 
 Technically -- > “The Internet of Things (IoT) is a system of interrelated computing devices, mechanical and digital machines, objects, animals or people that are provided with unique identifiers and the ability to transfer data over a network without requiring human-to-human or human-to-computer interaction.”
 
 Simply --> it means taking all the things in the world and connecting them to the internet. When something is connected to the internet, that means that it can **send information or receive information, or both**. This ability to send and/or receive information makes things smart, and smart is good. ;)
 
 If you are intruiged or even don't understand and want to understand more of IOT, Refer to this Link [IOT](https://www.iotforall.com/what-is-iot-simple-explanation/)
 
 ## Application
 ![alt text](https://scontent-hbe1-1.xx.fbcdn.net/v/t1.15752-9/79911672_552752855308852_8621852598510551040_n.jpg?_nc_cat=106&_nc_ohc=46k2VBXABEIAQli6xOLgoYOYDYOgeduSYPBuAF1rTCUJr9U2OPOpbSvXw&_nc_ht=scontent-hbe1-1.xx&oh=4a00ab05c36ea84d2bae5c2c237792fa&oe=5EA9B001)
 
 It is a desktop application ...**END** or so i wish! but sadly it has much more perks! (TBH ITS 2!)
 
 This Application can track/monitor what ever is playing and if desired obviously can also control the sound volume.
 
 **BUT ITS NOT THAT SIMPLE!** the volume has basically **6 settings**
 
 1.Its main normal just high and low volume.
 
 2.Treble Control.
 
 3.Treble Frequency.
 
 4.Bass Enhance.
 
 5.Bass Frequency.
 
 6.And last but not least Specialization. 0.0
 
 All those mentioned above settings can be tweaked seperately for different Sound Quality.
 
 ### But how this happens?...
 
 Well basically the Sound being tweeked going into the decoder goes to FM transmitter.
 
 The FM transmitter turns the Sound to FM signal at the range of 100-150 meter.
 
 ## Radio reciever
 
 >This project includes Radio reciever....duh!
 
 Simply what it does--> Using the Radio reciever module, gives the arduino the ability to recieve radio signal and Convert it to SOUND.
 
 Technically--> It uses an antenna to capture radio waves, processes those waves to extract only those waves that are vibrating at the desired frequency, extracts the audio signals that were added to those waves, amplifies the audio signals, and finally plays them on a speaker.
 
 ## Remotes
 
 >It includes 2 Remotes (FR & IR)
 
 ### Remote (FR)
 
 >Remote FR in the most Simplest Explanation --> controls radio channel :)
 
 The use of this Remote is to change the currently turned on channel on the radio.
 
 ### Remote (IR)
 
 >Remote IR in the most Simplest Explanation --> controls volume and frequency ...ha!
 
 The use of this Remote is to control the volume and the frequency of the transmitted signal.
 
 
# Conclusion

This Project was made with the help of info provided by Karawin, Link to karawin was provided above (as INFO) but incase here you go again! [GithubKarawin](https://github.com/karawin/Ka-Radio#-esp8266--vs1053-wifi-webradio-) 

again thank you karawin for your contribution :)

This project was made by: Youssef Elmasry & Mohamed Ahmed Ramadan.

Language used in this project :

1.Assembly

2.HTML

3.Css

4.Sql

5.C,C#

## END
 
