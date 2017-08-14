using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilePerformanceTester
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = args[0];
            string movePath = args[1];
            

            Console.WriteLine("checking if file exists 100,000 times");
            //check if file exists
            int j = 0;
            for (int i =0; i < 100000; i++)
            {
                j++;
                if(j == 10000)
                {
                    Console.WriteLine(i.ToString());
                    j = 0;
                }
                if(!File.Exists(sourceFile))
                {
                    Console.WriteLine(String.Format("{0} does not exist", sourceFile));
                }
            }


            string src = sourceFile;
            string dst = movePath;
            j = 0;
            for(int i = 0; i < 100000; i++)
            {
                j++;
                if (j == 10000)
                {
                    Console.WriteLine(i.ToString());
                    j = 0;
                }

                string holder;
                File.Move(src, dst);
                

                if (!File.Exists(dst))
                {
                    Console.WriteLine(String.Format("{0} does not exist", sourceFile));
                }

                holder = dst;
                dst = src;
                src = holder;
            }

            //Console.WriteLine("Moving File back and forth and checking existence");


            //create 20 new files from source file
            //read 20 new files

            //move file back and forth and try to read


            //if(ReadFile(filename))
            //{

            //}
            //else
            //{

            //}

           // Movefile(filename, Path.Combine(movePath, Path.GetFileName(filename)));
        }

        

        static string MakeFile()
        {
            return null;
        }

        static bool ReadFile(string path)
        {
            return false;
        }

        static string Movefile(string source, string destination)
        {
            return null;
        }


    }
}
