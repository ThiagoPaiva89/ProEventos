using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

         public IEnumerable<Evento> _evento = new Evento[]{
               new Evento(){
                  EventoId = 1,
                  Tema = "Angulas 11 e .NET 5",
                  Local = "Piauí",
                  Lote = "1º Lote",
                  QtdPessoas = 250,
                  DataEvento = "30/07/2022",
                  ImagemURL = "foto.png"
               },
                new Evento(){
                  EventoId = 2,
                  Tema = "Angulas e suas Novidades",
                  Local = "Brasília",
                  Lote = "3º Lote",
                  QtdPessoas = 169,
                  DataEvento = "06/08/2022",
                  ImagemURL = "foto.png"
               },
         };

        public EventoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return _evento;
        }

         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
           return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
           return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Exemplo de Put com id = {id}";
        }

         [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return $"Exemplo de Delete com id = {id}";
        }
    }
}
