# SentinelKey
A physical security project that turns an Arduino Micro into a hardware key for your Windows computer.

## What it does
The Arduino constantly sends a secret string over USB. A C# app on the computer listens for that string. If it stops hearing it because you unplugged the Arduino, the program locks the computer.

It's basically a low cost hardware security token, built from scratch.

## What you need
- Arduino Micro (or any board with the ATmega32U4 chip)
- Micro USB cable
- Windows 10 or 11
- .NET 10 SDK

## How to use it
1. Flash the code from `Firmware/SentinelKey.ino` to your Arduino
2. Open `DesktopApp` in Visual Studio or run it with `dotnet run`
3. Update the COM port in `Program.cs` to match your Arduino
4. Run the app, it should print "Auth Success" as long as the Arduino is connected

## Why I built this
I wanted to learn how software and hardware communicate. Most security tutorials only cover one or the other so I decided to build something that does both.

## What's next
- Add the actual Windows lock feature
- Handle reconnections without crashing
- Maybe explore challenge response auth instead of a static key
