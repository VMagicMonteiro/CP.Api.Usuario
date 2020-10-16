using CP.Api.Usuario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP.Api.Usuario.Repository
{
    public interface IUsuarioRepository
    {

        void Cadastrar(Usuarios Usuario);
        void Excluir(Usuarios usuario);
        void Alterar(Usuarios usuario);
        IList<Usuarios> Consultar();
        Usuarios ConsultarPorParametro(string cpf);

    }
}
