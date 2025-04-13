# Polynomial's Mouse Inverter

This is a simple tool to invert your mouse's X and Y movements. I originally wrote this in 2012 for [this SuperUser question](https://superuser.com/questions/406502/how-can-i-reverse-mouse-movement-x-y-axis-system-wide-win-7-x64).

More recently (Win11, and newer Win10 releases) one of the hotkeys stopped working. I lost the original source code a long time ago, but I decompiled the binary back to source using [dnSpyEx](https://github.com/dnSpyEx/dnSpy) and have updated the code to fall back to alternative hotkeys when the primary hotkeys can't be registered.

As of version 1.1, the hotkeys are as follows:

| Function           | Primary   | Secondary   |
| ------------------ | --------- | ----------- |
| Toggle X inversion | Win+Alt+X | Win+Shift+X |
| Toggle Y inversion | Win+Alt+Y | Win+Shift+Y |

You'll receive a popup message on startup if the fallback hotkeys are in use.

## Support

Please do not open issues asking for new features. This tool is designed to do one thing, which it already does.

If you find bugs, please open an issue, but I have very little time for maintaining old projects so I can't guarantee anything.

## License

This code is released under [MIT license](license.txt).

