using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ContaDomain
    {
        public ContaRepository _contaRepository { get; set; }

        public ContaDomain()
        {
            _contaRepository = new ContaRepository();
        }

        public void Inserir(Conta conta)
        {
            if (string.IsNullOrWhiteSpace(conta.Titular))
            {
                throw new Exception("Informe o titular.");
            }

            if (conta.NumeroConta.Length < 4)
            {
                throw new Exception("Número da conta inválido.");
            }

            _contaRepository.Inserir(conta);
        }
    }
}
