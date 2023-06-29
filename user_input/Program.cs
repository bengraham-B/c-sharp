using System;

class Program
{
    static void Main()
    {
        var osVersion = Environment.OSVersion;

        if (osVersion.Platform == PlatformID.Win32NT)
        {
            Console.WriteLine("Windows");
        }
        else if (osVersion.Platform == PlatformID.Unix)
        {
            Console.WriteLine("Unix-like");
            Console.WriteLine(osVersion.Platform);
        }
        else if (osVersion.Platform == PlatformID.MacOSX)
        {
            Console.WriteLine("macOS");
        }
        else
        {
            Console.WriteLine("Unknown");
        }


    }
}