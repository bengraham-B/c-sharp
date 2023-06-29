<<<<<<< HEAD
﻿using System;
=======
﻿

using System;
>>>>>>> b54771b546eec405cb64a3c15c0fa45171a42749

class Program
{
    static void Main()
    {
<<<<<<< HEAD
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
=======

        Console.WriteLine("Enter your Name: ");
        string name, age;
        //int age;
        name = Console.ReadLine();
        Console.WriteLine("Hello " + name);

        Console.WriteLine("What is your age?");
        age = Console.ReadLine();
        Console.WriteLine(age + " That is a preety fun age");

        Console.ReadLine();

    }
}
>>>>>>> b54771b546eec405cb64a3c15c0fa45171a42749
