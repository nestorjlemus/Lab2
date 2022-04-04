namespace Laboratorio2.Entities
{
    public abstract class Persona
    {
        public string UUID { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public abstract void TomarAsistencia();

    }
}