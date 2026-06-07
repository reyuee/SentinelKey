# SentinelKey

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![Arduino](https://img.shields.io/badge/Arduino-00979D?style=for-the-badge&logo=arduino&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)

A simple, small project I built to improve my programming skills and understand how hardware and code can communicate with each other. It turns an Arduino Micro into a hardware key for my Windows computer.

## What it does
The Arduino constantly sends a secret string over USB. A C# program on the computer listens for that string. If you unplug the Arduino while the program is running it locks the computer.

## What you need
- Arduino Micro {or any board with the ATmega32U4 chip}
- Micro USB cable
- Windows
- .NET 10 SDK

## How to use it
1. Flash the code from `Firmware/SentinelKey.ino` to your Arduino
2. Open `DesktopApp` in Visual Studio or run it with `dotnet run`
3. Update the COM port in `Program.cs` to match your Arduino. You can find it in Device Manager under Ports or in the Arduino IDE under Tools then Port. For now you have to change it manually in the code
4. Run the app it should print "Auth Success" as long as the Arduino is connected
5. Unplug the Arduino and your computer will lock

## Why I built this
I built this to improve my programming skills and understand how hardware and code can communicate with each other.

## What's next
- Fix the crash when the program starts without the Arduino plugged in
- Auto detect the COM port so users do not have to edit the code
- Handle reconnection so the program does not have to be restarted
- Maybe try challenge response auth instead of a static key
