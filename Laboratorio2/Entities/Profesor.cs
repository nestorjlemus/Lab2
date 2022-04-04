namespace Laboratorio2.Entities
{
    public class Profesor: Persona, IOperaciones
    {
        public string CUI { get; set; }
        public string Cargo { get; set; }

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