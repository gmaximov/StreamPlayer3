using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;

namespace StreamPlayer3
{
    class Utility
    {
        public static byte[] ByteArrayCombine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }

        public static T Deserialize<T>(string json)
        {
            using ( var ms = new MemoryStream(GetBytes(json)) )
            {
                byte[] adwadaw = GetBytes(json);
                var serializer = new DataContractJsonSerializer(typeof(T));
                return (T) serializer.ReadObject(ms);
            }
        }
        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
        public static byte[] Combine(params byte[][] arrays)
        {
            byte[] ret = new byte[arrays.Sum(x => x.Length)];
            int offset = 0;
            foreach ( byte[] data in arrays )
            {
                Buffer.BlockCopy(data, 0, ret, offset, data.Length);
                offset += data.Length;
            }
            return ret;
        }
    }
}
