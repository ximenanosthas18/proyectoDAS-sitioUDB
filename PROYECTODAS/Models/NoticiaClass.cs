using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROYECTODAS.Models
{
    public class NoticiaClass
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Cuerpo { get; set; }
        public DateTime Fecha { get; set; }
    }
}