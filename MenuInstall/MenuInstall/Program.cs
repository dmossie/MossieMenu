using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MenuInstall
{
    class Program
    {
        static void Main(string[] args)
        {
            String startPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

            Console.WriteLine("Welcome to the menu installer!\n");
            Console.WriteLine("This menu installer will move the desired programs to your startup folder,\nso they will be launched when you login\n");
            Console.WriteLine("Press any key to proceed");
            Console.ReadKey();
            Console.WriteLine();

            //NewMenu
            if (File.Exists("NewMenu.exe"))
            {
                if (File.Exists(startPath + "/NewMenu.exe")){
                    File.Delete(startPath + "/NewMenu.exe");
                }
                File.SetAttributes("NewMenu.exe", FileAttributes.Normal);
                File.Move("NewMenu.exe", startPath + "/NewMenu.exe");
                File.SetAttributes(startPath + "/NewMenu.exe", FileAttributes.Normal);
                Console.WriteLine("NewMenu.exe installed");
            }
            else Console.WriteLine("NewMenu.exe not found");

            //PowerMenu
            if (File.Exists("PowerMenu.exe"))
            {
                if (File.Exists(startPath + "/PowerMenu.exe")){
                    File.Delete(startPath + "/PowerMenu.exe");
                }
                File.SetAttributes("PowerMenu.exe", FileAttributes.Normal);
                File.Move("PowerMenu.exe", startPath + "/PowerMenu.exe");
                File.SetAttributes(startPath + "/PowerMenu.exe", FileAttributes.Normal);
                Console.WriteLine("PowerMenu.exe installed");
            }
            else Console.WriteLine("PowerMenu.exe not found");

            Console.WriteLine("\nInstall Complete");
            Console.ReadKey();
        }
    }
}
