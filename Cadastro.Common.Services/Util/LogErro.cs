using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Wm.BI.Common.Services.Util
{
    public static class LogErro
    {
        private static readonly string path = Application.StartupPath + "\\Log.txt";

        public static void Write(string texto, string cab = "\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*\n")
        {
            File.AppendAllText(path, cab.Replace("\n", Environment.NewLine) +
                                     DateTime.Now.ToShortDateString() + " " +
                                     DateTime.Now.ToLongTimeString() + ":\t" +
                                     texto +
                                     Environment.NewLine);
        }

        public static void Write(Exception ex)
        {
            Write(ex, true);
        }

        public static void Write(Exception ex, bool exibe)
        {
            Write(ex.ToString());
            try
            {
                if (exibe == true)
                {
                    StackTrace st = new StackTrace(ex, true);
                    StackFrame frame = st.GetFrame(st.FrameCount - 1);
                    int linha = frame.GetFileLineNumber();
                    int erro = ex.HResult;
                    string metodo = frame.GetMethod().Name;
                    string modulo = frame.GetMethod().DeclaringType.FullName;
                    string msg;

                    if (ex.InnerException == null)
                    {
                        msg = ex.Message;
                    }
                    else
                    {
                        msg = ex.InnerException.Message;
                    }
                    MessageBox.Show("Execução interrompida!\n\nMensagem: " + msg + "\n\nOrigem: " + modulo + "\nMétodo: " + metodo + "\nLinha: " + linha + "\n\nPara maiores informações consulte o log.", Constantes.Atencao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problema ao executar a mensagem de erro:\n\n" + e.ToString() + "\n\n Consulte o log.", Constantes.Atencao, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}