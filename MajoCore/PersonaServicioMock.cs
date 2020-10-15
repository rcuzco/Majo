using MajoCore.Model;
using MajoTransversal;

namespace MajoCore
{
    public class PersonaServicioMock : IPersonaServicio
    {
        public ResultadoEjecucion<Persona> InsertarPersona(Persona persona)
        {
            ResultadoEjecucion<Persona> resultadoEjecucion = new ResultadoEjecucion<Persona>();
            resultadoEjecucion.Objeto = new Persona() { Id = 1 };
            resultadoEjecucion.ResultadoCorrecto = true;
            return resultadoEjecucion;
        }
    }
}