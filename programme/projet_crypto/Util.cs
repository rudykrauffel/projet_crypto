using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_crypto
{
    class Util
    {
        public int BoolArrayToInt(bool[] array)
        {
            int i = 0;

            for (int power = 0; power < array.Length; power++)
                if (array[array.Length - power - 1] == true)
                    i += (int)Math.Pow(2, power);

            return i;
        }
        public bool[] XOR(bool[] first, bool[] second)
        {
            bool[] tmp = new bool[first.Length];
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                    tmp[i] = true;
                else tmp[i] = false;
            }

            return tmp;
        }

        public bool[] CharToBoolArray(char c)
        {
            // take a char and outputs the correspond byte as an array of booleans
            return BinaryStringToBoolArray(Convert.ToString(c, 2).PadLeft(8, '0'));
        }
        public bool[] IntToBoolArray(int i)
        {
            return CharToBoolArray(Convert.ToChar(i));
        }

        public bool[] BinaryStringToBoolArray(string source)
        {
            bool[] array = new bool[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                array[i] = source[i] == '1' ? true : false;
            }
            return array;
        }

        public List<bool[]> TextStringToBoolArray(string str)
        {
            List<bool[]> boolArray = new List<bool[]>();
            foreach (char c in str)
            {
                string binaryString = "";

                if ((int)c == 65533)
                    binaryString = Convert.ToString('#', 2).PadLeft(8, '0');
                else
                    binaryString = Convert.ToString(c, 2).PadLeft(8, '0');
                
                bool[] tmpArray = new bool[8];

                for (int i = 0; i < binaryString.Length; i++)
                    tmpArray[i] = binaryString[i] == '1' ? true : false;
                boolArray.Add(tmpArray);
            }
            return boolArray;
        }

        public string BoolArrayToStringText(List<bool[]> list)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var array in list)
                sb.Append(Convert.ToChar(BoolArrayToInt(array)));

            return sb.ToString();
        }

        
    }
}
