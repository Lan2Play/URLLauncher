using System;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace urllauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3 || args.Length == 4 || (args.Length == 1 && args[0] == "/?"))
            {
                if (args.Length == 3 || args.Length == 4)
                {
                    string urlparam = Regex.Replace(args[0], "^.*://", "");
                    
                    if ( args.Length == 4 && args[3] == "true")
                    {
                        if (urlparam.Substring(urlparam.Length - 1) == "/")
                        {
                            urlparam = urlparam.Remove(urlparam.Length - 1);
                        }
                    }

                    var process = new Process();
                    process.StartInfo.FileName = args[1];
                    process.StartInfo.Arguments = args[2] + urlparam;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                    
                }
                if (args[0] == "/?")
                {
                    Console.WriteLine("URLLauncher");
                    Console.WriteLine();
                    Console.WriteLine("This software removes an URL Prefix from the passed url and adds it to the end of the arguments parameter which then gets passed to the destination software. It becomes handy to use custom URL Handlers on windows with software that dont support handling full urls in Parameters.");
                    Console.WriteLine();
                    Console.WriteLine("example: urllauncher.exe <url> <software to startup> <software to startup args> <optional: true for removing the end / of the url> ");
                }


            }
            else
            {
                Console.WriteLine("You must pass 3 Arguments! open with /? to get help!");
            }
        }
    }
}
