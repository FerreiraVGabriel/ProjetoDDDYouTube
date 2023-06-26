using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Entidades.Notificacoes;

namespace Entidades.Entidades
{
    public class Base : Notifica
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}