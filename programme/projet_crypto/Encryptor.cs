using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_crypto
{
    class Encryptor
    {
        // caractère par caractère
        // clé = 6 lettres minuscules
        // caractères possibles : 97 à 122 inclu
        // 26^6 possibilité = 308 915 776

        Util util = new Util();
        public string XOR(string message, string key)
        {
            List<bool[]> cryptedBinaryList = new List<bool[]>();

            List<bool[]> messageBinaryList = util.TextStringToBoolArray(message);
            List<bool[]> keyBinaryList = util.TextStringToBoolArray(key);
            
            // XOR
            for (int i = 0; i < messageLetterList.Count; i++)
            {
                decryptedLetterList.Add(util.XOR(messageLetterList[i], keyLetterList[i % keyLetterList.Count]));
            }

            return util.BoolArrayToStringText(cryptedBinaryList);
        }
        public string XOR(string message, List<bool[]> key)
        {
            List<bool[]> cryptedBinaryList = new List<bool[]>();

            List<bool[]> messageBinaryList = util.TextStringToBoolArray(message);
            List<bool[]> keyBinaryList = key;

            // XOR
            for (int i = 0; i < messageBinaryList.Count; i++)
            {
                cryptedBinaryList.Add(util.XOR(messageBinaryList[i], keyBinaryList[i % keyBinaryList.Count]));
            }

            return util.BoolArrayToStringText(cryptedBinaryList);
        }
    }
}
