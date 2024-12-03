using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_
{
    public class ListeBasique
    {
        public void ExerciceBasique() 
        {
            Methodes meto = new Methodes();

            List<int> myList1 = new List<int>() { 10, 20, 30, 40 };
            List<int> myList2 = new List<int>() { 98, 55, 12 };
            List<int> myList3 = new List<int>() { 0 };
            myList2.InsertRange(1, new List<int>() { 95, 64, 20 });

            //meto.DisplayList("Liste 1 :", myList1);
            //meto.DisplayList("Liste 2 :", myList2);

            meto.Addition(myList1, myList2, myList3);
            meto.DisplayList("Liste 3 :", myList3);

            //meto.SuppressionIndex(5, myList3);
            meto.SuppressionRange(5, myList3);

            meto.DisplayList("Liste 3 :", myList3);

        }
    }
}
