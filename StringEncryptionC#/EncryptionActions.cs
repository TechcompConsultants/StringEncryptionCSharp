using EncryptionDecryptionUsingSymmetricKey;

namespace EncryptStringActions
{
    public static class StringCipher
    {
        private static String key = "b14ca5898a4e4133bbce2ea2315a1916";

        internal static String EncryptThisString(String txtString)
        {
            var MyStringEncrypted = AesOperation.EncryptString(key, txtString);
            return MyStringEncrypted;
        }

        internal static String DecryptThisString(String encryptedString)
        {
            var MyStringDecrypted = AesOperation.DecryptString(key, encryptedString);
            return MyStringDecrypted;
        }
    }
}