using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PrinterReportParser
{
    class Program
    {
        static void Main(string[] args)
        {

            //string source = "A-1,2,3,4B-1,2";
            //Regex pattern = new Regex(@"(?<com>[A-Z])-((?<param>[0-9]+),?)+");

            string source = "AD001,002B3,4,5x0030c123.234.234,255.255.255.0D100";
            //Regex pattern = new Regex(@"(?<com>[a-z]|[A-Z]+)((?<param>[0-9]+\.?),?)+");
            Regex pattern = new Regex(@"(?<com>[a-z]|[A-Z]+)((?<param>([0-9]+\.?)+),?)+");

            MatchCollection matches = pattern.Matches(source);

            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                {
                    Console.Write(m.Groups["com"].Value + ":");
                    for (int i = 0; i < m.Groups["param"].Captures.Count; i++)
                        Console.Write("[" + m.Groups["param"].Captures[i].Value + "]");

                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("no mA");
            //    string source = "AD001B3,4,5x0030c123.234.234,255.255.255.0D100";
            //    Regex pattern = new Regex(@"([a-z]|[A-Z])+[^a-z-A-Z]*");//  \d*(,*\d)*");

                //    Dictionary<string, List<string>> d = new Dictionary<string, List<string>>();

                //    MatchCollection matches = pattern.Matches(source);

                //    if (matches.Count > 0)
                //    {
                //        string patternCommand = new Regex(@"(?<Command>[a-z]|[A-Z]+)((?<params>([^,]+)))");
                //        string patternParams
                //        MatchCollection coms;
                //        foreach (Match m in matches)
                //        {
                //       //     Console.WriteLine(m.Value);
                //            coms = pattern.Matches(m.Value);
                //            if (coms.Count > 0)
                //            {
                //                foreach (Match mm in coms)
                //                {
                //                    Console.WriteLine(mm.Groups["params"].Captures.Count + ":");

                //                    for (int i = 0; i < mm.Groups["params"].Captures.Count; i++)
                //                        Console.Write(mm.Groups["params"].Captures[i].Value + "  ");
                //                    Console.WriteLine();
                //                }
                //            }
                //            else
                //                Console.WriteLine("No matches");



                //        }
                //    }
                //    else
                //        Console.WriteLine("No matches");

                    Console.ReadKey();
        }
    }
}
