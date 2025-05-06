using System.ComponentModel.DataAnnotations;

namespace TienditaMVC.Models
{
    public class Huesped
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Genero { get; set; }
        public string CiudadDomicilio { get; set; }
        public string MotivoHospedaje { get; set; }
        public bool Acompanante { get; set; }
    }

}
