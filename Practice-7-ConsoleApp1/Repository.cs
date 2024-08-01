using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Practice_7_ConsoleApp1
{
    struct Repository
    {
        public string path;
        public Worker[] workers;
        public Repository(string path)
        {
            this.path = path;
            workers = new Worker[2];
        }
        public void GetAllWorkers(string path) // показать весь список
        {
            string Contentfile = File.ReadAllText(path);
            Console.WriteLine(Contentfile);
        }
        public void AddWorker(string path, string text)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                Console.WriteLine("ID: ");
                string t = Console.ReadLine();
                text += $"{t}";

                string now = DateTime.Now.ToShortTimeString();
                Console.WriteLine($"Время добавления записи: {now}");
                text += $"{now}";

                Console.WriteLine("ФИО: ");
                string t1 = Console.ReadLine();
                text += $"{t1}";

                Console.WriteLine("Возраст: ");
                string t2 = Console.ReadLine();
                text += $"{t2}";

                Console.WriteLine("Рост: ");
                string t3 = Console.ReadLine();
                text += $"{t3}";

                Console.WriteLine("Дата рождения: ");
                string t4 = Console.ReadLine();
                text += $"{t4}";

                Console.WriteLine("Место рождения: ");
                string t5 = Console.ReadLine();
                text += $"{t5}";

                string[] values = new string[] { t, t1, now, t2, t3, t4, t5 };
                string t10 = string.Join("#", values);
                sw.WriteLine(t10);
            }
        }
        public void GetWorkerById()
        {
            Console.WriteLine("Напишите Id работника: ");
            int id = int.Parse(Console.ReadLine());
            Worker? worker = FindWorkerById(id);

            if (worker != null)
            {
                Console.WriteLine($"Имя: {worker.Value.FIO}");
            }
            else
            {
                Console.WriteLine("Нет такого");
            }
        }
        private Worker? FindWorkerById(int id)
        {
            if (workers != null)
            {
                foreach (Worker worker in workers)
                {
                    if (worker.Id == id)
                    {
                        return worker;
                    }
                }
            }
            return null;
        }
           
        

        public void Menu()
        {
            string path = "newFile.txt";
            string text = string.Empty;

            while(true)
            {
                
                Console.WriteLine("Нажмите 1, чтобы открыть весь список");
                Console.WriteLine("Нажмите 2, чтобы открыть Id");
                Console.WriteLine("Нажмите 3, чтобы добавить нового работника");
                Console.WriteLine("Нажмите 4, чтобы удалить весь список");
                Console.WriteLine(("Нажмите 0, чтобы выйти"));
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        return;
                    case "1":
                        GetAllWorkers(path);
                        break;
                    case "2":
                        GetWorkerById(); //!!!
                        break;
                    case "3":
                        AddWorker(path, text);
                        break;

                }

            }
        }
    }
}
