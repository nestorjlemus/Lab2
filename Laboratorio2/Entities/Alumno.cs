namespace Laboratorio2.Entities
{
    public class Alumno: Persona, IOperaciones
    {
        public string Carne { get; set; }
        public int NumeroCreditos { get; set; }

        public void EliminarAsignatura(string asignatura)
        {
            throw new NotImplementedException();
        }

        public void ListarMisDatos(string identificador)
        {
            throw new NotImplementedException();
        }

        public override void TomarAsistencia()
        {
            throw new NotImplementedException();
        }
    }
}