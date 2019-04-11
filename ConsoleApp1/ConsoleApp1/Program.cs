﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Assignment_4
{
    class Program
    {
        ArrayList Beowulf;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();
            p.ReadTextFiles();
            Console.ReadKey();

        }
        public void Run()
        {
            this.ReadTextFiles();
        }

        public void ReadTextFiles()
        {
            // Read file using StramReader. Read file line by line
            using (StreamReader file = new StreamReader("U:/Users/696464/ravinder/Beowulf.txt"))
            {

                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {

                    Beowulf.Add(ln);

                }

                file.Close();
                counter = File.ReadLines("U:/Users/696464/ravinder/Beowulf.txt").Count();
                Console.WriteLine($"File has {counter} lines.");

            }
        }

        public int FindNumberOfBlankSpaces(string line)
        {

            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c)) { countletters++; }

                if (char.IsWhiteSpace(c)) { countletters++; }
            }
            return countSpaces;

        }

    }

}