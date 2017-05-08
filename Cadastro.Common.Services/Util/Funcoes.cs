using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Wm.BI.Common.Services.Util
{
    public static class Funcoes
    {
        public static int UltimoDiaMes(int mes, int ano)
        {
            try
            {
                switch (mes)
                {
                    case 1:
                        return 31;
                    case 2:
                        if (DateTime.IsLeapYear(ano))
                        {
                            return 29;
                        }
                        else
                        {
                            return 28;
                        }
                    case 3:
                        return 31;
                    case 4:
                        return 30;
                    case 5:
                        return 31;
                    case 6:
                        return 30;
                    case 7:
                        return 31;
                    case 8:
                        return 31;
                    case 9:
                        return 30;
                    case 10:
                        return 31;
                    case 11:
                        return 30;
                    case 12:
                        return 31;

                    default:
                        return 30;
                }
            }
            catch
            {
                throw;
            }
        }

        public static string MyRetiraAcentos(this string value)
        {
            try
            {
                value = value.Replace("Ç", "C");
                value = value.Replace("ç", "c");

                value = value.Replace("Á", "A");
                value = value.Replace("À", "A");
                value = value.Replace("Ä", "A");
                value = value.Replace("Ã", "A");
                value = value.Replace("Â", "A");
                value = value.Replace("á", "a");
                value = value.Replace("à", "a");
                value = value.Replace("ä", "a");
                value = value.Replace("ã", "a");
                value = value.Replace("â", "a");

                value = value.Replace("É", "E");
                value = value.Replace("È", "E");
                value = value.Replace("Ë", "E");
                value = value.Replace("Ê", "E");
                value = value.Replace("é", "e");
                value = value.Replace("è", "e");
                value = value.Replace("ë", "e");
                value = value.Replace("ê", "e");

                value = value.Replace("Í", "I");
                value = value.Replace("Ì", "I");
                value = value.Replace("Ï", "I");
                value = value.Replace("Î", "I");
                value = value.Replace("í", "i");
                value = value.Replace("ì", "i");
                value = value.Replace("ï", "i");
                value = value.Replace("î", "i");

                value = value.Replace("Ó", "O");
                value = value.Replace("Ò", "O");
                value = value.Replace("Ö", "O");
                value = value.Replace("Õ", "O");
                value = value.Replace("Ô", "O");
                value = value.Replace("ó", "o");
                value = value.Replace("ò", "o");
                value = value.Replace("ö", "o");
                value = value.Replace("õ", "o");
                value = value.Replace("ô", "o");

                value = value.Replace("Ú", "U");
                value = value.Replace("Ù", "U");
                value = value.Replace("Ü", "U");
                value = value.Replace("Û", "U");
                value = value.Replace("ú", "u");
                value = value.Replace("ù", "u");
                value = value.Replace("ü", "u");
                value = value.Replace("û", "u");

                value = value.Replace("Ñ", "N");
                value = value.Replace("ñ", "n");

                value = value.Replace("º", "");
                value = value.Replace("ª", "");
                value = value.Replace("°", "");

                value = value.Replace(".", "");
                value = value.Replace(".", "");
                //value = value.Replace("/", "");
                //value = value.Replace("-", "");
                value = value.Replace("|", " ");
                value = value.Replace(":", "");
                value = value.Replace("!", "");
                value = value.Replace("?", "");


                return value;
            }
            catch
            {
                throw;
            }
        }

        public static string CalculaMD5(string texto)
        {
            try
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] byteArray = Encoding.ASCII.GetBytes(texto);

                byteArray = md5.ComputeHash(byteArray);

                StringBuilder hashedValue = new StringBuilder();

                foreach (byte b in byteArray)
                {
                    hashedValue.Append(b.ToString("x2"));
                }

                return hashedValue.ToString();
            }
            catch
            {
                throw;
            }
        }

        public static int GetNumMes(String mes)
        {
            try
            {
                int numMes = 0;
                switch (mes)
                {
                    case "Janeiro":
                        numMes = 1;
                        break;
                    case "Fevereiro":
                        numMes = 2;
                        break;
                    case "Março":
                        numMes = 3;
                        break;
                    case "Abril":
                        numMes = 4;
                        break;
                    case "Maio":
                        numMes = 5;
                        break;
                    case "Junho":
                        numMes = 6;
                        break;
                    case "Julho":
                        numMes = 7;
                        break;
                    case "Agosto":
                        numMes = 8;
                        break;
                    case "Setembro":
                        numMes = 9;
                        break;
                    case "Outubro":
                        numMes = 10;
                        break;
                    case "Novembro":
                        numMes = 11;
                        break;
                    case "Dezembro":
                        numMes = 12;
                        break;
                }
                return numMes;
            }
            catch
            {
                throw;
            }
        }

        public static String GetNomeMes(int m)
        {
            try
            {
                string mes = "";
                switch (m.ToString())
                {
                    case "1":
                        mes = "Janeiro";
                        break;
                    case "2":
                        mes = "Fevereiro";
                        break;
                    case "3":
                        mes = "Março";
                        break;
                    case "4":
                        mes = "Abril";
                        break;
                    case "5":
                        mes = "Maio";
                        break;
                    case "6":
                        mes = "Junho";
                        break;
                    case "7":
                        mes = "Julho";
                        break;
                    case "8":
                        mes = "Agosto";
                        break;
                    case "9":
                        mes = "Setembro";
                        break;
                    case "10":
                        mes = "Outubro";
                        break;
                    case "11":
                        mes = "Novembro";
                        break;
                    case "12":
                        mes = "Dezembro";
                        break;
                }

                return mes;
            }
            catch
            {
                throw;
            }
        }

        public static string GDvCb(string value)
        {
            try
            {
                if (value != (new Regex("[^0-9]")).Replace(value, ""))
                {
                    // is not numeric
                    return "";
                }
                // pad with zeros to lengthen to 14 digits
                switch (value.Length)
                {
                    case 8:
                        value = "000000" + value;
                        break;
                    case 12:
                        value = "00" + value;
                        break;
                    case 13:
                        value = "0" + value;
                        break;
                    case 14:
                        break;
                    default:
                        // wrong number of digits
                        return "";
                }
                // calculate check digit
                int[] a = new int[13];
                a[0] = int.Parse(value[0].ToString()) * 3;
                a[1] = int.Parse(value[1].ToString());
                a[2] = int.Parse(value[2].ToString()) * 3;
                a[3] = int.Parse(value[3].ToString());
                a[4] = int.Parse(value[4].ToString()) * 3;
                a[5] = int.Parse(value[5].ToString());
                a[6] = int.Parse(value[6].ToString()) * 3;
                a[7] = int.Parse(value[7].ToString());
                a[8] = int.Parse(value[8].ToString()) * 3;
                a[9] = int.Parse(value[9].ToString());
                a[10] = int.Parse(value[10].ToString()) * 3;
                a[11] = int.Parse(value[11].ToString());
                a[12] = int.Parse(value[12].ToString()) * 3;
                int sum = a[0] + a[1] + a[2] + a[3] + a[4] + a[5] + a[6] + a[7] + a[8] + a[9] + a[10] + a[11] + a[12];
                int check = (10 - (sum % 10)) % 10;
                // evaluate check digit                
                return check.ToString();
            }
            catch
            {
                throw;
            }
        }
        
        public static string DirApp
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public static bool ExisteArq(string nomeArquivo)
        {
            try
            {
                return File.Exists(nomeArquivo);
            }
            catch
            {
                throw;
            }
        }

        public static bool ExisteDirDoArq(string nomeArquivo)
        {
            try
            {
                string diretorio = Path.GetDirectoryName(nomeArquivo);
                return ExisteDir(diretorio);
            }
            catch
            {
                throw;
            }
        }

        public static bool ExisteDir(string diretorio)
        {
            try
            {
                return Directory.Exists(diretorio);
            }
            catch
            {
                throw;
            }
        }

        #region MD5
        
        public static string MD5File(string file)
        {
            try
            {
                using (FileStream stream = File.OpenRead(file))
                {
                    MD5 md5 = new MD5CryptoServiceProvider();
                    byte[] checksum = md5.ComputeHash(stream);
                    return (BitConverter.ToString(checksum)).Replace("-", string.Empty);
                }
            }
            catch
            {
                throw;
            }
        }
        
        public static string MD5String(string texto)
        {
            try
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                byte[] byteArray = Encoding.ASCII.GetBytes(texto);
                
                byteArray = md5.ComputeHash(byteArray);
                
                StringBuilder hashedValue = new StringBuilder();
                
                foreach (byte b in byteArray)
                {
                    hashedValue.Append(b.ToString("x2"));
                }
                
                return hashedValue.ToString();
            }
            catch
            {
                throw;
            }
        }
        
        #endregion MD5
    }
}