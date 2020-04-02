using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_crypto
{
    class FileImport
    {
        string[] filePaths = new string[11] { @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\PA.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\PB.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\PC.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\PD.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\PE.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\PF.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\PG.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\PH.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\PI.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\PJ.txt",
                                            @"D:\EXIA\A4\PROJET 1 - Cybersécurité\Ressources  de projet -20200328\FICHIERS CRYTES\PK.txt" };

        public string[] getAllFiles()
        {
            string[] files = new string[11];
            for (int i = 0; i < filePaths.Length; i++)
            {
                files[i] = File.ReadAllText(filePaths[i]);
            }

            //StringBuilder beginning = new StringBuilder();
            //for (int i = 0; i < 50; i++) // file is 3000 char long so 100 is fine
            //    beginning.Append(file[i]);

            return files;
        }

        // Récuperer premier fichier à décrypter
        public string GetPA()
        {
            string file = File.ReadAllText("PA.txt");
            StringBuilder beginning = new StringBuilder();
            for (int i = 0; i < 50; i++) // file is 3000 char long so 50 is fine
            {
                beginning.Append(file[i]);
            }
            return beginning.ToString();
        }
        public string GetPAernest()
        {
            string file = File.ReadAllText("PAernest.txt");
            StringBuilder beginning = new StringBuilder();
            for (int i = 0; i < 50; i++) // file is 3000 char long so 100 is fine
            {
                beginning.Append(file[i]);
            }
            return beginning.ToString();
        }
        // Récupérer dictionnaire
        public List<string> GetDico()
        {
            List<string> dico = new List<string>();
            String text = File.ReadAllText("liste_francais.txt");
            var result = text.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries); ;

            foreach (string s in result)
            {
                dico.Add(s.ToLower());
            }

            return dico;
        }

        public string GetStringGeg()
        {
            return File.ReadAllText("PourRudySansCle.txt");
        }
        public string GetStringRud()
        {
            return File.ReadAllText("TestXOR4.txt");
        }
    }
}
