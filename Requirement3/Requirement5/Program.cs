using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();
            Console.WriteLine("Enter no of songs:");
            int n=int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                string[] str = Console.ReadLine().Split(',');
                double r = double.Parse(str[3]);
                int nd = int.Parse(str[4]);
                DateTime dt = DateTime.ParseExact(str[5],"dd-MM-yyyy",null);
                Song s1 = new Song(str[0], str[1], str[2],r,nd,dt);
                    list.Add(s1);
            }
            SortedDictionary<string,int>sd = new SortedDictionary<string,int>();
            sd=Song.CalculateTypeCount(list);
            Console.WriteLine("songtype\tcount");
            foreach(var item in sd)
            {
                Console.WriteLine(item.Key+"\t\t"+item.Value);
            }
        }
    }
}
