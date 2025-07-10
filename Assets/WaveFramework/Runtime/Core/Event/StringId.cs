using System.Collections.Generic;

namespace WaveFramework
{
    public class StringId
    {
        private static readonly Dictionary<int, string> _hashToStrDict = new Dictionary<int, string>();
        private static readonly Dictionary<string, int> _strToHashDict = new Dictionary<string, int>();

        public const int FNVInitial = 5381;
        public const int FNVMultiplier = 33;

        public static int StringToHash(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Log.Fatal("StringToHash get a null or empty string");
                return 0;
            }


            if (_strToHashDict.TryGetValue(str, out var hash))
                return hash;

            hash = FNVInitial;
            for (int i = 0; i < str.Length; i++)
            {
                hash = (hash ^ str[i]) * FNVMultiplier;
            }

            _hashToStrDict.Add(hash, str);
            _strToHashDict.Add(str, hash);

            return hash;
        }


        public static string HashToString(int hash)
        {
            return _hashToStrDict.TryGetValue(hash, out var str) ? str : string.Empty;
        }
    }
}