using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CounterOfObjects
{
    class Person
    {
        public Person()
        {

            
        }
        string Name = "Персона";


        public  static long counter = 1;
        
        public decimal SetStartCounter()
        {
            string s = Convert.ToString(DateTimeOffset.Now.ToUnixTimeMilliseconds());
            decimal z = Convert.ToDecimal(s);
            System.Threading.Thread.Sleep(1);
           
            return z;
        }
        public string name
        {
            get { return Name; }

        }
        public long count
        {
            get { return counter++; }

        }
        
    }
    public class Write
    {
       public void rogaet(string n)
        {
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = path + @"\Key.txt";

            Person one = new Person();
            Person two = new Person();
            Person three = new Person();
            Person[] person = { one, two, three };

            try
            {
                var sw = new StreamWriter(path, true);
                for (int i = 0; i < person.Length; i++)
                {
                    sw.WriteLine(person[i].name + " номер " + person[i].count + " имеет ключ " + person[i].SetStartCounter());
                }
                sw.Close();
                Console.WriteLine("Записано в файл!");
            }
            catch
            {
                Console.WriteLine("НЕ удалось записать в файл...");
            }
        }   
            



           
           
           
              

            
    }
}

