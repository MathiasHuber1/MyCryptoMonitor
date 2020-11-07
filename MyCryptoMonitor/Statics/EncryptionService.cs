using MyCryptoMonitor.Forms;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MyCryptoMonitor.Statics
{
    public class EncryptionService
    {
        #region Private Variables

        private const string CHECKVALUE = "Success";
        private static string _password = string.Empty;

        #endregion Private Variables

        #region Methods

        public static void DecryptFiles()
        {
            PortfolioService.PortfolioServiceInstance.ToggleEncryption();
            UserConfigService.EncryptionCheck = string.Empty;
            UserConfigService.Encrypted = false;
            AlertService.Save();
        }

        public static void EncryptFiles(string password)
        {
            _password = password;

            PortfolioService.PortfolioServiceInstance.ToggleEncryption();
            UserConfigService.EncryptionCheck = AesEncryptString(CHECKVALUE);
            UserConfigService.Encrypted = true;
            AlertService.Save();
        }

        public static void Unlock()
        {
            using (var form = new Unlock())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (!ValidatePassword(form.PasswordInput))
                    {
                        Unlock();
                        return;
                    }

                    _password = form.PasswordInput;
                }
                else if (result == DialogResult.Abort)
                {
                    if (MainService.ConfirmReset())
                        MainService.Reset();
                    else
                        Unlock();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        public static bool ValidatePassword(string password)
        {
            return AesDecryptString(UserConfigService.EncryptionCheck, password).ExtEquals(CHECKVALUE);
        }

        #endregion Methods

        #region Encrypt

        public static byte[] AESEncryptBytes(byte[] clearBytes, byte[] passBytes, byte[] saltBytes)
        {
            byte[] encryptedBytes = null;
            var key = new Rfc2898DeriveBytes(passBytes, saltBytes, 32768);

            using (Aes aes = new AesManaged())
            {
                aes.KeySize = 256;
                aes.Key = key.GetBytes(aes.KeySize / 8);
                aes.IV = key.GetBytes(aes.BlockSize / 8);

                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }
            return encryptedBytes;
        }

        public static string AesEncryptString(string clearText)
        {
            return AesEncryptString(clearText, _password, UserConfigService.SaltKey);
        }

        public static string AesEncryptString(string clearText, string passText)
        {
            return AesEncryptString(clearText, passText, UserConfigService.SaltKey);
        }

        public static string AesEncryptString(string clearText, string passText, string saltText)
        {
            try
            {
                var clearBytes = Encoding.UTF8.GetBytes(clearText);
                var passBytes = Encoding.UTF8.GetBytes(passText);
                var saltBytes = Encoding.UTF8.GetBytes(saltText);

                return Convert.ToBase64String(AESEncryptBytes(clearBytes, passBytes, saltBytes));
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        #endregion Encrypt

        #region Decrypt

        public static byte[] AESDecryptBytes(byte[] cryptBytes, byte[] passBytes, byte[] saltBytes)
        {
            byte[] clearBytes = null;
            var key = new Rfc2898DeriveBytes(passBytes, saltBytes, 32768);

            using (Aes aes = new AesManaged())
            {
                aes.KeySize = 256;
                aes.Key = key.GetBytes(aes.KeySize / 8);
                aes.IV = key.GetBytes(aes.BlockSize / 8);

                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cryptBytes, 0, cryptBytes.Length);
                        cs.Close();
                    }
                    clearBytes = ms.ToArray();
                }
            }
            return clearBytes;
        }

        public static string AesDecryptString(string cryptText)
        {
            return AesDecryptString(cryptText, _password, UserConfigService.SaltKey);
        }

        public static string AesDecryptString(string cryptText, string passText)
        {
            return AesDecryptString(cryptText, passText, UserConfigService.SaltKey);
        }

        public static string AesDecryptString(string cryptText, string passText, string saltText)
        {
            try
            {
                var cryptBytes = Convert.FromBase64String(cryptText);
                var passBytes = Encoding.UTF8.GetBytes(passText);
                var saltBytes = Encoding.UTF8.GetBytes(saltText);

                return Encoding.UTF8.GetString(AESDecryptBytes(cryptBytes, passBytes, saltBytes));
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        #endregion Decrypt
    }
}