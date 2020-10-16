using CP.Api.Usuario.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP.Api.Usuario.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationContext _context;

        public UsuarioRepository(ApplicationContext context)
        {
            _context = context;
        }
        public void Alterar(Usuarios usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void Cadastrar(Usuarios usuario)
        {
            

            try
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e.InnerException;
            }
        }

        public IList<Usuarios> Consultar()
        {
            return _context.Usuarios.ToList();
        }

        public Usuarios ConsultarPorParametro(string cpf)
        {
            return _context.Usuarios.Find(cpf);
        }

        public void Excluir(Usuarios usuario)
        {
            
            
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            
            

            
        }
    }
}
