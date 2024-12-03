using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_
{
    public class Methodes
    {
        public void DisplayList(string name, List<int> list)
        {
            Console.WriteLine(name);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Le nombre des items de la liste {name} est {list.Count}");
        }

        public void Addition(List<int> list1, List<int> list2, List<int> list3)
        {
            list3.AddRange(list1); list3.AddRange(list2);
        }

        public void SuppressionIndex (int index, List<int> list)
        {
            list.RemoveAt(index);
        }

        public void SuppressionRange (int index, List<int> list)
        {
            list.RemoveRange(index, 3);
        }
    }
}
