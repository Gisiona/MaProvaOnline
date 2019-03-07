using MaProvaOnline.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MaProvaOnline.Api.Controllers
{
    [Route(Name ="api/pergunta/")]
    public class PerguntaController : ApiController
    {
        private Infra.DataContext.MaProvaOnlineContext _context = new Infra.DataContext.MaProvaOnlineContext();

        // GET api/values
        public HttpResponseMessage GetPerguntas()
        {
            var perg = new Pergunta("Cite 3 padrões de projetos.", Guid.NewGuid(), 1, DateTime.Now, true);
            var perg1 = new Pergunta("O que é MVC?", Guid.NewGuid(), 1, DateTime.Now, true);
            var list = new List<Pergunta>();
            list.Add(perg);
            list.Add(perg1);


           return Request.CreateResponse(HttpStatusCode.OK, list);

            //return new string[] { "value1", "value2", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
