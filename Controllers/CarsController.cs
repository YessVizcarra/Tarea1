using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarea_practica.Modelos;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tarea_practica.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        [HttpGet(Name = "GetVehiculo")]
        public string Get()
        {
            return "Obtener información del vehículo";
        }

        [HttpPost(Name = "CrearAutomovil")]
        public string CrearAutomovil([FromBody] Automovil automovil)
        {
            // Accede a los campos de vehículo
            string marca = automovil.Marca;
            string modelo = automovil.Modelo;
            int año = automovil.Año;
            string tipoCombustible = automovil.TipoCombustible;
            string numeroChasis = automovil.NumeroChasis;

            // Accede a los campos específicos del automóvil
            int puertas = automovil.Puertas;
            string color = automovil.Color;
            string transmision = automovil.Transmision;
            string sistemaNavegacion = automovil.SistemaNavegacion;

          
            // Devuelve una respuesta formateada con la información del automóvil
            return $"Información del automóvil:\n" +
                $"Marca: {marca}\n" +
                $"Modelo: {modelo}\n" +
                $"Año: {año}\n" +
                $"Tipo de combustible: {tipoCombustible}\n" +
                $"Número de chasis: {numeroChasis}\n" +
                $"Puertas: {puertas}\n" +
                $"Color: {color}\n" +
                $"Transmisión: {transmision}\n" +
                $"Sistema de navegación: {sistemaNavegacion}";
        }

        [HttpGet("yesenia", Name = "yesenia")]
        public String GetYesenia()
        {
            return "prueba yesenia";
        }
    }
}

