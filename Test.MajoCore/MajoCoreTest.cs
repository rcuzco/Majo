using MajoCore;
using MajoCore.Model;
using MajoTransversal;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.MajoCore
{
    [TestClass]
    public class MajoCoreTest
    {
        [TestMethod]
        public void CrearPersonaMock_OK()
        {
            Persona persona = new Persona();
            persona.Id = 0;
            persona.Nombres = "Rony";
            persona.PrimerApellido = "Cuzco";
            persona.SegundoApellido = "Chumbe";
            persona.TipoDocumentoIdentidad = 1;
            persona.DocumentoIdentidad = "A1234567x";
            persona.Sexo = "M";
            persona.FechaNacimiento = DateTime.Now.AddYears(-30);
            persona.CorreoElectronico = "rony@mail.com";
            persona.TelefonoFijo = "123123123";
            persona.TelefonoMovil = "123123123";


            IPersonaServicio personaServicio = new PersonaServicioMock();
            ResultadoEjecucion<Persona> resultadoEjecucion = personaServicio.InsertarPersona(persona);
            Assert.IsTrue(resultadoEjecucion.ResultadoCorrecto);
            Assert.IsNotNull(resultadoEjecucion.Objeto);
            Assert.IsTrue(resultadoEjecucion.Objeto.Id > 0);            
        }

      
    }
}
