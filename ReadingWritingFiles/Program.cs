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
            string path = @"map.txt";
            string testPath = @"test.txt";

            string testText = "Hi! I'm A test file that was written to in my program file!";

            Console.WriteLine();

            File.WriteAllText(testPath, testText);

            string[] testFileContents = File.ReadAllLines(testPath);

            for (int i = 0; i < testFileContents.Length; i++)
            {
                string line = testFileContents[i];
                for (int j = 0; j < line.Length; j++)
                {
                    char character = line[j];
                    Console.Write(character);
                }
                Console.WriteLine();
            }
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
