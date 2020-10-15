using MajoCore.Model;
using MajoTransversal;

namespace MajoCore
{
    public interface IPersonaServicio 
    {
        public ResultadoEjecucion<Persona> InsertarPersona(Persona persona);
    }
}