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
        static void print(Dictionary<string, List<string>> d)
        {
            foreach (var key in d.Keys)
            {
                Console.WriteLine("Предмет " + key);
                print(d[key]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            StreamReader fileEGE = new StreamReader("request.txt");
            Dictionary<string, List<string>> dictEGE = new Dictionary<string, List<string>>();

            while(!fileEGE.EndOfStream) 
            { 
                string[] words = fileEGE.ReadLine().Split();
                string subject = words[3];
                string student = words[0] + " " + words[1];
                if (!dictEGE.ContainsKey(subject))
                    dictEGE[subject] = new List<string>();
                dictEGE[subject].Add(student);
            }
            fileEGE.Close();
            print(dictEGE);

        }
    }
}
