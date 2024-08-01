using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7_ConsoleApp1
{
    struct Worker
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public int Age { get; set; }
        public string Height { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }

        public Worker(int id, string fio, int age, string height, DateTime dateofbirth, string placeofbirth)
        {
            Id = id;
            FIO = fio;
            Age = age;
            Height = height;
            DateOfBirth = dateofbirth;
            PlaceOfBirth = placeofbirth;
        }
    }
    
}
