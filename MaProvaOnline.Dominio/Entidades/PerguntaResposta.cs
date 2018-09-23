using System;
using System.Collections.Generic;

namespace MaProvaOnline.Dominio.Entidades
{
    public class PerguntaResposta : EntityBase
    {
        public int PerguntaId { get; set; }
        public ICollection<Pergunta> Perguntas { get; set; }
        public int RespostaId { get; set; }
        public ICollection<Resposta> Respostas { get; set; }

        public PerguntaResposta()
        {
        }

        public PerguntaResposta(Guid hashGuid, int id, DateTime dataCadastro, bool isAtivo) : base(hashGuid, id, dataCadastro, isAtivo)
        {
        }

        public PerguntaResposta(int perguntaId, ICollection<Pergunta> perguntas, int respostaId, ICollection<Resposta> respostas)
        {
            PerguntaId = perguntaId;
            Perguntas = perguntas ?? throw new ArgumentNullException(nameof(perguntas));
            RespostaId = respostaId;
            Respostas = respostas ?? throw new ArgumentNullException(nameof(respostas));
        }
    }
}
