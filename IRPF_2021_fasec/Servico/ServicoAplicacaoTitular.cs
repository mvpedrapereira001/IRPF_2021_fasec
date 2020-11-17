using System;
using IRPF_2021_fasec.Helpers;
using IRPF_2021_fasec.Models;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using IRPF_2021_fasec.DAL;

namespace IRPF_2021_fasec.Servico
{
    public class ServicoAplicacaoTitular
    {
        private EFContext db = new EFContext();
        protected DbSet<Titular> DbSetContext;

        public Titular ValidaCPFTitular(string cpf_Titular, DateTime dataNascimento)
        {

            HelpersIRPF p_obj = new  HelpersIRPF();
            if (p_obj.IsCpf(cpf_Titular) == true)
            {
                return db.Titular.Where(x => x.Cpf_Titular == cpf_Titular && x.DataNascimento == dataNascimento).FirstOrDefault();
            }
            else
            {
                throw new Exception("CPF não válido");
            }
            
        }

        public Titular RetornaTitular(string cpf_Titular)
        {
            return db.Titular.Where(x => x.Cpf_Titular == cpf_Titular).FirstOrDefault();
        }

        internal void VincularUsuário(Titular titular, string email)
        {
            Titular item = new Titular()
            {
                Cpf_Titular = titular.Cpf_Titular,
                DataNascimento = titular.DataNascimento,
                Nome_titular = titular.Nome_titular,
                ID_USUARIO = email
            };

            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();

        }
    }
}