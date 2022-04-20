using Facec.Dominio.nsEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Dominio.nsInterfaces
{
    public interface IClienteServico
    {
        void Gravar(Cliente cliente);
        void Excluir(Cliente excluir);
        IEnumerable<Cliente> obter();


    }
}
