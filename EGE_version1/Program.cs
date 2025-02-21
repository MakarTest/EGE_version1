using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGE_version1
{
    internal class Program
    {
        static void print(List<string> lst)
        { 
             foreach(var item in lst)
                Console.WriteLine(item);
            Console.WriteLine();
        }

        static void print(List<string> lst, List<List<string>> someLst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i] + " " + someLst[i].Count);
                for (int j = 0; j < someLst[i].Count; j++)
                    Console.WriteLine(someLst[i][j]);
                Console.WriteLine();
            }
        }

        static void print(Dictionary<string, int> d)
        { 
            foreach(var key in d.Keys)
                Console.WriteLine(key + ": " + d[key]);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            StreamReader fileEGE = new StreamReader("request.txt");
            List <string> subjects = new List<string>();
            List<List<string>> listOfSubjects = new List<List<string>>();
            Dictionary<string, int> dictEGE = new Dictionary<string, int>();

            while(!fileEGE.EndOfStream) 
            { 
                string[] words = fileEGE.ReadLine().Split();
                string subject = words[3];
                if (dictEGE.ContainsKey(subject))
                    dictEGE[subject]++;
                else
                    dictEGE[subject] = 1;
                
                //int ind = subjects.IndexOf(words[3]);
                //if (ind == -1)
                //{
                //    subjects.Add(words[3]);
                //    ind = subjects.Count() - 1;
                //    listOfSubjects.Add(new List<string>());
                //}
                //listOfSubjects[ind].Add($"{words[0]} {words[1]} {words[2]}");
            }
            fileEGE.Close();
            //print(subjects, listOfSubjects);
            //print(dictEGE.Keys.ToList());
            print(dictEGE);

        }
    }
}
