using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_crypto
{
    class Checker
    {
        FileImport fi = new FileImport();
        Util util = new Util();
        List<string> dico = new List<string>();

        public bool IsSolutionFound { get; private set; }
        public Checker()
        {
            dico = fi.GetDico();
            IsSolutionFound = false;
        }

        internal void Verify(string outputString, List<bool[]> currentKey)
        {
            if (outputString.Contains(' ') && outputString.Split(' ').Length > 3)
            {
                int goodWordCount = 0;
                string[] words = outputString.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    if (dico.Contains(words[i]))
                        goodWordCount++;

                    if (goodWordCount > 2)
                    {
                        System.IO.File.AppendAllText(@"D:\EXIA\A4\PROJET 1 - Cybersécurité\possibleKeys.txt",
                            util.BoolArrayToStringText(currentKey) + " " + outputString + Environment.NewLine);
                        return;
                    }
                }
            }

            return;

            //int GoodWordCount = 0;
            //string compared = outputString.ToLower();
            //foreach (var word in dico)
            //{
            //    if (compared.Contains(" " + word) || compared.Contains(word + " "))
            //    {
            //        GoodWordCount++;
            //        if (GoodWordCount > 2)
            //        {
            //            System.IO.File.AppendAllText(@"D:\EXIA\A4\PROJET 1 - Cybersécurité\possibleKeys.txt",
            //            util.BoolArrayToStringText(currentKey) + " " + outputString + Environment.NewLine);
            //            return;
            //        }
            //    }
            //}
        }
    }
}
