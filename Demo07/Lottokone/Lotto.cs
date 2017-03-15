using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottokone
{
    class Lotto
    {
        private Random rand = new Random();
        private int Number;
        private List<int> Numbers = new List<int>();
        private List<string> NumbersString = new List<string>();
        private List<string> Rows = new List<string>();

        public string GetRows(int RowN)
        {
            for (int i = 0; i < RowN; i++)
            {
                while (Numbers.Count < 7) 
                {
                    Number = rand.Next(1, 39 + 1);
                    if(!Numbers.Contains(Number))
                    {
                        Numbers.Add(Number);
                    }
                }

                for (int j = 0; j < 7; j++)
                {
                    if (Numbers[j] < 10) //jos luku j on alle 10
                    {
                        NumbersString.Add("0" + Numbers[j].ToString()); //lisätään luvun eteen 0 joten luvusta 7 tulee 07
                    }
                    else
                    {
                        NumbersString.Add(Numbers[j].ToString()); //muuten lisätään luku j lukujonoon
                    }
                }
                NumbersString.Sort(); //järjestää numerot pienimmästä suurimpaan
                Rows.Add(string.Join(" ", NumbersString));
                Numbers.Clear();
                NumbersString.Clear();
            }
            return string.Join(Environment.NewLine, Rows);
        }

    }
}
