using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_crypto
{
    class Program
    {
        static void Main(string[] args)
        {
            FileImport FI = new FileImport();
            Encryptor Enc = new Encryptor();
            KeyGenerator Kg = new KeyGenerator(2);
            Checker checker = new Checker();

            string stringGeg = FI.GetStringGeg();
            string string1 = "Les francais en ont marre des arbres.";
            //string string1 = "Ceci sert a effectuer un test sur le programme. Bonne chance.";
            string key1 = "rud";

            // encode
            Console.WriteLine(string1);
            string test1 = Enc.XOR(string1, key1);
            System.IO.File.WriteAllText(@"D:\EXIA\A4\PROJET 1 - Cybersécurité\TestXOR4.txt", test1);
            Console.WriteLine(test1);

            // decode
            test1 = Enc.XOR(test1, key1);
            Console.WriteLine(test1);


            // Brute force
            // BruteGeg(Enc, checker, stringGeg);

            // Vrai brut force
            // BruteChad(Enc, checker, FI.GetPA());
            BruteChad(Enc, checker, FI.GetPAernest());

            // Décryptage de tous les fichiers
            DecryptAll(Enc, FI);
        }

        static void BruteGeg(Encryptor enc, Checker checker, string message)
        {
            Console.WriteLine("######### BRUTE GEG #########");
            Console.WriteLine();

            Util util = new Util();
            string outputString = "";
            int cnt = 0;
            
            KeyGenerator Hagrid = new KeyGenerator(3);
            while (!checker.IsSolutionFound)
            {
                outputString = enc.XOR(message, Hagrid.GetKey());
                checker.Verify(outputString, Hagrid.CurrentKey);
                if (cnt % 1000 == 0)
                {
                    Console.WriteLine(cnt);
                }
                cnt++;
            }
            string goodKey = util.BoolArrayToStringText(Hagrid.CurrentKey);
            Console.WriteLine(goodKey);
            Console.WriteLine(outputString);
            System.IO.File.WriteAllText(@"D:\EXIA\A4\PROJET 1 - Cybersécurité\RESULTAT.txt", goodKey);
        }
        static void BruteChad(Encryptor enc, Checker checker, string message)
        {
            Console.WriteLine("######### BRUTE CHAD #########");
            Console.WriteLine();

            Util util = new Util();
            string outputString = "";
            int cnt = 0;

            KeyGenerator Hagrid = new KeyGenerator(6);
            while (!checker.IsSolutionFound)
            {
                outputString = enc.XOR(message, Hagrid.GetKey());
                checker.Verify(outputString, Hagrid.CurrentKey);

                if (cnt%1000 == 0)
                    Console.WriteLine(cnt);

                cnt++;
            }
            string goodKey = util.BoolArrayToStringText(Hagrid.CurrentKey);
            Console.WriteLine(goodKey);
            Console.WriteLine(outputString);
            System.IO.File.WriteAllText(@"D:\EXIA\A4\PROJET 1 - Cybersécurité\RESULTAT.txt", goodKey);

        }
        static void DecryptAll(Encryptor enc, FileImport fi)
        {
            string[] files = fi.getAllFiles();
            string[] destinations = new string[11] { @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\decryptedPA.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\decryptedPB.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\decryptedPC.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\decryptedPD.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\decryptedPE.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\decryptedPF.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\decryptedPG.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\decryptedPH.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\decryptedPI.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\decryptedPJ.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\decryptedPK.txt" };
            string key = "vrhpaf";

            for (int i = 0; i < files.Length; i++)
            {
                File.WriteAllText(destinations[i], enc.XOR(files[i], key));
            }
        }

        static void testKeyGenerator()
        {
            List<List<char>> allKeys = new List<List<char>>();
            int baseLetter = 97;
            int maxLetter = 122;


            for (int l2 = baseLetter; l2 <= maxLetter; l2++)
            {
                for (int l1 = baseLetter; l1 <= maxLetter; l1++)
                {
                    List<char> currentKey = new List<char>();
                    currentKey.Add(Convert.ToChar(l1));
                    currentKey.Add(Convert.ToChar(l2));
                    allKeys.Add(currentKey);
                }
            }
            foreach (var list in allKeys)
            {
                foreach (var c in list)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
