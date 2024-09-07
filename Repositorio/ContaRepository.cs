using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class ContaRepository
    {
        public DataContext _dataContext { get; set; }

        public ContaRepository()
        {
            _dataContext = GeradorDeServicos.CarregarContexto();
        }

        public void Inserir(Conta conta)
        {
            _dataContext.Add(conta);

            _dataContext.SaveChanges();
        }
    }
}
