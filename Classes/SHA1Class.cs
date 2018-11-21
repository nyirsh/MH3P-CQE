using System;
using System.Security.Cryptography;

namespace CQE.Classes
{
    class SHA1Class
    {
        public static byte[] ComputeHash(byte[] questBytes, string hashAlgorithm, byte[] saltBytes)
        {
            // If salt is not specified, generate it on the fly.
            if (saltBytes == null)
            {
                // Define min and max salt sizes.
                const int minSaltSize = 4;
                const int maxSaltSize = 8;

                // Generate a random number for the size of the salt.
                Random random = new Random();
                int saltSize = random.Next(minSaltSize, maxSaltSize);

                // Allocate a byte array, which will hold the salt.
                saltBytes = new byte[saltSize];

                // Initialize a random number generator.
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

                // Fill the salt with cryptographically strong byte values.
                rng.GetNonZeroBytes(saltBytes);
            }

            // Allocate array, which will hold plain text and salt.
            byte[] plainTextWithSaltBytes =
                    new byte[questBytes.Length + saltBytes.Length];

            // Copy plain text bytes into resulting array.
            for (int i = 0; i < questBytes.Length; i++)
                plainTextWithSaltBytes[i] = questBytes[i];

            // Append salt bytes to the resulting array.
            for (int i = 0; i < saltBytes.Length; i++)
                plainTextWithSaltBytes[questBytes.Length + i] = saltBytes[i];

            // Because we support multiple hashing algorithms, we must define
            // hash object as a common (abstract) base class. We will specify the
            // actual hashing algorithm class later during object creation.
            HashAlgorithm hash;

            // Make sure hashing algorithm name is specified.
            if (hashAlgorithm == null)
                hashAlgorithm = "";

            // Initialize appropriate hashing algorithm class.
            switch (hashAlgorithm.ToUpper())
            {
                case "SHA1":
                    hash = new SHA1Managed();
                    break;

                case "SHA256":
                    hash = new SHA256Managed();
                    break;

                case "SHA384":
                    hash = new SHA384Managed();
                    break;

                case "SHA512":
                    hash = new SHA512Managed();
                    break;

                default:
                    hash = new MD5CryptoServiceProvider();
                    break;
            }

            // Compute hash value of our plain text with appended salt.
            byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);

            // Return the result.
            return hashBytes;
        }

        static readonly short[] KeyVarTable = { 0, 0, 0, 0 };
        static readonly int[] Seed0 = { 0x3DF3, 0x1709, 0xB381, 0x747B };
        static readonly int[] Seed1 = { 0xFFA9, 0xFF9D, 0xFFF1, 0xFFC7 };

        private static short[] EncryptQuest(short[] pData)
        {
            CalcKey(KeyVarTable, pData);
            for (int i = 8; i < pData.Length * 2; i += 2)
            {
                int index = (i >> 1);
                int key = GetXorKey(KeyVarTable, index & 0x03);
                pData[index] ^= (short)(key & 0xFFFF);
            }

            return pData;
        }

        private static void CalcKey(short[] pTable, short[] pData)
        {
            for (int i = 0; i < 4; i++)
            {
                pTable[i] = pData[i];
                if (pTable[i] == 0)
                {
                    pTable[i] = (short)(Seed0[i] & 0xFFFF);
                }
            }
        }

        private static int GetXorKey(short[] pTable, int pos)
        {
            int key = (int)((pTable[pos] & 0xFFFF) * (long)(Seed0[pos] & 0xFFFF) % (Seed1[pos] & 0xFFFF));
            pTable[pos] = (short)(key & 0xFFFF);
            return key;
        }

        public static byte[] ProcessQuest(byte[] byteBt)
        {
            int dims = byteBt.Length;
            if (dims % 2 == 1)
                dims += 1;
            short[] shorts = new short[dims / 2];

            int x;
            int y = 0;
            for (x = 0; x + 1 < dims; x += 2)
            {
                byte[] temp = new byte[2];
                if (x < byteBt.Length)
                {
                    temp[0] = byteBt[x];
                    temp[1] = byteBt[x + 1];
                }
                else
                {
                    temp[0] = byteBt[x];
                    temp[1] = 0x00;
                }

                shorts[y] = (short)BitConverter.ToUInt16(temp, 0);
                y++;
            }

            shorts = EncryptQuest(shorts);

            int j = 0;
            foreach (short s in shorts)
            {
                if (j < byteBt.Length)
                {
                    byteBt[j] = (byte)(s & 0x00FF);
                    byteBt[j + 1] = (byte)(s >> 8);
                }
                else
                {
                    byteBt[j] = (byte)(s & 0x00FF);
                }
                j += 2;
            }

            return byteBt;
        }
    }
}
