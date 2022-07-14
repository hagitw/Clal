using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clal_HW
{
    class Operations
    {
        //Operation 1
        public int PlusTHree(int input)
        {
            return input + 3;
        }

        //Operation 2
        public int MultiplyByFive(int input)
        {
            return input * 5;
        }

        //Operation 3
        public int DivideByTwo(int input)
        {
            return input / 2;
        }
        //Operation 4
        public int Operation4(int input)
        {
            string strInput = input.ToString();
            if (strInput.Contains('7') || input % 7 == 0)
            {
                throw new Exception();
            }
            else
            {
                return input + 7;
            }
        }
    }
}
