using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadingWritingFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Reading / Writing Files");
            Console.WriteLine();

            //read file
            string path = @"test.txt";
            string input;
            input = File.ReadAllText(path);
            Console.WriteLine(input);

            Console.WriteLine();

            string[] mapRows;
            mapRows = File.ReadAllLines(path);
            for (int y = 0; y < mapRows.Length; y++)
            {
                string mapRow = mapRows[y];
                //Console.WriteLine(mapRow);
                for (int x =  0; x < mapRow.Length; x++)
                {
                    char tile = mapRow[x];
                    Console.Write(tile);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);

        }
    }
}
