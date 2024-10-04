
namespace Ejercicio1.Models
{
    public class Propietario
    {
        public int DNI { get; set; }
        public string ApellidosNombres { get; set; }
        public string Email { get; set; }


        public Propietario(int dNI, string nombre)
        {
            DNI = dNI;
            ApellidosNombres = nombre;
        }

        public override string ToString()
        {
            return $"{ApellidosNombres}({DNI})";
        }
    }
}
