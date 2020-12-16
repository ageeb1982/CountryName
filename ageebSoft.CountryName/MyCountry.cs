using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ageebSoft.CountryName
{
    public class MyCountry
    {
        public int Id { get; set; }
        public string NameEn { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Capital_En { get; set; }



        public static List<MyCountry> getAllCountry()
        {

            var folderPath = Environment.CurrentDirectory;
            var FilePath = Path.Combine(folderPath, "Country.json");
            var fileText = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<MyCountry>>(fileText);



        }
    }

    

     
}
