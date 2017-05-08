using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Common.Services;
using Cadastro.Common.Services.Util;

namespace Cadastro.Dal.Services.Dal
{
    public class PessoaDal
    {
        private static void Commit()
        {
            Sessao.Instance.Estudos.SaveChanges();
        }

        public static List<Pessoa> ListarPessoas()
        {
            try
            {
                return Sessao.Instance.Estudos.Pessoa.ToList();
            }
            catch
            {
                throw;
            }
        }

        public static Pessoa FindById(long id)
        {
            try
            {
                return Sessao.Instance.Estudos.Pessoa.Find(id);
            }
            catch
            {
                throw;
            }
        }

        public static void DeleteById(long id)
        {
            Sessao.Instance.Estudos.Pessoa.Remove(FindById(id));
            Sessao.Instance.Estudos.SaveChanges();
        }

        public static void Add(Pessoa p)
        {
            Sessao.Instance.Estudos.Pessoa.Add(p);
            Commit();
        }

        public static void Update(Pessoa p)
        {
            Sessao.Instance.Estudos.Pessoa.Attach(p);
            Commit();
        }

    }
}
