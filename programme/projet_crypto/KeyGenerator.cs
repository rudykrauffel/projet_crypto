using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_crypto
{
    class KeyGenerator
    {
        Util util = new Util();
        public List<bool[]> CurrentKey { get; set; } = new List<bool[]>();
        public int[] LetterIndexes { get; set; }
        
        public KeyGenerator(int keyLength)
        {
            //AllKeys = GenerateKeys(keyLength);
            LetterIndexes = new int[keyLength];
        }

        public List<bool[]> GetKey()
        {
            CurrentKey = GenerateKey();
            //UpdateLetterIndexes3();
            UpdateLetterIndexes6();

            return CurrentKey;
        }

        private List<bool[]> GenerateKey()
        {
            List<bool[]> key = new List<bool[]>();
            foreach (var index in LetterIndexes)
            {
                key.Add(util.IntToBoolArray(index + 97));
            }
            return key;
        }

        private void UpdateLetterIndexes3()
        {
            // Throw error quand LetterIndexes est à 25 partout (tous les caractères == 'z')
            // throw new Exception("Fin des clés, la dernière ('zzzzzz') à été atteinte.");

            // Logique pour créer toutes les clés possibles
            if (LetterIndexes[0] < 25)
            {
                LetterIndexes[0] += 1;
            }
            else
            {
                LetterIndexes[0] = 0;
                if (LetterIndexes[1] < 25)
                {
                    LetterIndexes[1] += 1;
                }
                else
                {
                    LetterIndexes[1] = 0;
                    if (LetterIndexes[2] < 25)
                    {
                        LetterIndexes[2] += 1;
                    }
                    else
                    {
                        //Throw error quand LetterIndexes est à 25 partout(tous les caractères == 'z')
                        throw new Exception("Fin des clés, la dernière ('zzz') à été atteinte.");
                    }
                }
            }
        }

        private void UpdateLetterIndexes6()
        {
            // Throw error quand LetterIndexes est à 25 partout (tous les caractères == 'z')
            // throw new Exception("Fin des clés, la dernière ('zzzzzz') à été atteinte.");

            // Logique pour créer toutes les clés possibles
            if (LetterIndexes[0] < 25)
            {
                LetterIndexes[0] += 1;
            }
            else
            {
                LetterIndexes[0] = 0;
                if (LetterIndexes[1] < 25)
                {
                    LetterIndexes[1] += 1;
                }
                else
                {
                    LetterIndexes[1] = 0;
                    if (LetterIndexes[2] < 25)
                    {
                        LetterIndexes[2] += 1;
                    }
                    else
                    {
                        LetterIndexes[2] = 0;
                        if (LetterIndexes[3] < 25)
                        {
                            LetterIndexes[3] += 1;
                        }
                        else
                        {
                            LetterIndexes[3] = 0;
                            if (LetterIndexes[4] < 25)
                            {
                                LetterIndexes[4] += 1;
                            }
                            else
                            {
                                LetterIndexes[4] = 0;
                                if (LetterIndexes[5] < 25)
                                {
                                    LetterIndexes[5] += 1;
                                }
                                else
                                {
                                    //Throw error quand LetterIndexes est à 25 partout(tous les caractères == 'z')
                                    throw new Exception("Fin des clés, la dernière ('zzzzzz') à été atteinte.");
                                }
                            }
                        }
                    }
                }
            }
        }

        public List<List<bool[]>> GenerateKey6()
        {
            int baseLetter = 97;
            int maxLetter = 122;
            List<List<bool[]>> allKeys = new List<List<bool[]>>();

            //for (int i = 0; i < 6; i++)  // 
                // iterate(keyLength) { if(keyLength >= 0) iterate(keyLength -1) } 

            for (int l1 = baseLetter; l1 <= maxLetter; l1++)
            {
                for (int l2 = baseLetter; l2 <= maxLetter; l2++)
                {
                    for (int l3 = baseLetter; l3 <= maxLetter; l3++)
                    {
                        for (int l4 = baseLetter; l4 <= maxLetter; l4++)
                        {
                            for (int l5 = baseLetter; l5 <= maxLetter; l5++)
                            {
                                for (int l6 = baseLetter; l6 <= maxLetter; l6++)
                                {
                                    List<bool[]> currentKey = new List<bool[]>();
                                    currentKey.Add(util.CharToBoolArray(Convert.ToChar(l1)));
                                    currentKey.Add(util.CharToBoolArray(Convert.ToChar(l2)));
                                    currentKey.Add(util.CharToBoolArray(Convert.ToChar(l3)));
                                    currentKey.Add(util.CharToBoolArray(Convert.ToChar(l4)));
                                    currentKey.Add(util.CharToBoolArray(Convert.ToChar(l5)));
                                    currentKey.Add(util.CharToBoolArray(Convert.ToChar(l6)));
                                    allKeys.Add(currentKey);
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(l1);
            }


            return allKeys;

        }
        public List<List<bool[]>> GenerateKey2()
        {
            List<List<bool[]>> allKeys = new List<List<bool[]>>();
            int baseLetter = 97;
            int maxLetter = 122;


            for (int l2 = baseLetter; l2 <= maxLetter; l2++)
            {
                for (int l1 = baseLetter; l1 <= maxLetter; l1++)
                {
                    List<bool[]> currentKey = new List<bool[]>();
                    currentKey.Add(util.CharToBoolArray(Convert.ToChar(l1)));
                    currentKey.Add(util.CharToBoolArray(Convert.ToChar(l2)));
                    allKeys.Add(currentKey);
                }
            }
            return allKeys;
        }

    }
}
