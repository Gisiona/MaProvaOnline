using System;

namespace MaProvaOnline.Dominio.Entidades
{
    public class Pergunta : EntityBase
    {
        public string DescricaoPergunta { get; private set; }

        public Pergunta(string descricaoPergunta)
        {
            DescricaoPergunta = descricaoPergunta ?? throw new ArgumentNullException("O campo descrição não pode ser nulo.");
        }

        public Pergunta()
        {
        }
    }
}
