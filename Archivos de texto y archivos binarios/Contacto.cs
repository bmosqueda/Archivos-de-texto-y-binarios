namespace Archivos_de_texto_y_archivos_binarios
{
    class Contacto
    {
        public int numeroCuenta { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string telefono { get; set; }
        public char genero { get; set; }

        public Contacto(int numeroCuenta, string nombre, string apellidoPaterno, string numTelefeno, char genero)
        {
            this.numeroCuenta = numeroCuenta;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.genero = genero;
            this.telefono = numTelefeno;
        }

        public override string ToString()
        {
            return numeroCuenta + ": " + nombre + " " + apellidoPaterno;
        }
    }
}
