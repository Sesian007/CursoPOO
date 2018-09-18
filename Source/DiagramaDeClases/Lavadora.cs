namespace DiagramaDeClases
{
    public class Lavadora
    {
        public Secadora Secadora { get; set; }
        public Dispensador Dispensador { get; set; }
        public Motor Motor { get; set; }
        public Tambor Tambor { get; set; }
        public Comando[] Comandos { get; set; }

        public Lavadora(Motor motor,
                        Tambor tambor,
                        Comando[] comandos)
        {
            this.Motor = motor;
            this.Tambor = tambor;
            this.Comandos = comandos;
        }
    }
    public class Secadora
    { }
    public class Dispensador
    { }
    public class Motor
    { }
    public class Tambor
    { }
    public class Comando
    { }
}