using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROYECTODAS.Models
{
    public class CarreraClass
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Campus { get; set; }
        public string Tipo { get; set; }
        public int Duracion { get; set; }
    }
}