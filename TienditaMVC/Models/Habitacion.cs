using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TienditaMVC.Models
{
    public class Habitacion
    {
        public int HabitacionId { get; set; }  // Clave primaria
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public decimal Precio { get; set; }
        public bool Disponible { get; set; }
    }

}