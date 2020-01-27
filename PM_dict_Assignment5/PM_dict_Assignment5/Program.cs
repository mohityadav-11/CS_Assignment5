using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_dict_Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<int, string>
            {
                { 1998, "Atal Bihari Vajpayee" },
                { 2014, "Narendra Modi" },
                { 2004, "Manmohan Singh" }
            };

            Console.WriteLine(primeMinisters[2004]);
            Console.WriteLine();

            primeMinisters.Add(2019, "Narendra Modi");

            var pm = new SortedDictionary<int, string>(primeMinisters);

            foreach (var mt in pm)
                Console.WriteLine(mt.Key+"      "+mt.Value);
        }
    }
}
