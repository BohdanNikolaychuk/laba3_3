using System;
using System.IO;

namespace oopLaba3_3
{
    
    class Program
    {
        static void numsword(string str)
        {
          
            string[] text = str.Split(new char[] { ' ',',',':',';','.'}, StringSplitOptions.RemoveEmptyEntries);
           
            Console.WriteLine("Кiлькiсть слiв="+text.Length);
            using (var sw = new StreamWriter("D:\\output.txt", true))
            {
                sw.Write("Кiлькiсть слiв="+text.Length);
               

            }


        }


        static void Main(string[] args)
        {
            string path = "D:\\input.txt";

            using (var sr = new StreamReader(path))
            {

                string str = sr.ReadToEnd();
                numsword(str);

            }
            
        }
    }
}
