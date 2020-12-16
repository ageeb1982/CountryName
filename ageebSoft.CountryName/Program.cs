using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace ageebSoft.CountryName
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in MyCountry.getAllCountry())
            {
                Console.WriteLine("Name : "+item.Name +" , EngName : "+item.NameEn);
            } ;

            Console.ReadLine();
        }




        

    }
}
