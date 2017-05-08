using System;
using Cadastro.Dal;

namespace Cadastro.Common.Services.Util
{
    public class Sessao
    {
        private static Sessao instance;
        public EstudosEntities Estudos;

        public Sessao()
        {
            try
            {
                this.Estudos = new EstudosEntities();
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Sessao Instance
        {
            get
            {
                try
                {
                    if (instance == null)
                    {
                        instance = new Sessao();
                    }

                    return instance;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            set
            {
                instance = value;
            }
        }
    }
}
