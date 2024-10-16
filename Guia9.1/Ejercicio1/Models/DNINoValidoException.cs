using System;
namespace Ejercicio1.Models
{
    public class DNINoValidoException : ApplicationException
    {
        public DNINoValidoException() : base("DNI No Valido") { }
        public DNINoValidoException(string message):base(message) { }
        public DNINoValidoException(string message, Exception innerException) : base(message, innerException) { }
    }
}
