using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto01.Areas.Seguranca.Models
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}