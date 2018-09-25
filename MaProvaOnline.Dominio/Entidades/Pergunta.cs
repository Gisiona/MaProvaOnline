using System;

namespace MaProvaOnline.Dominio.Entidades
{
    public class Pergunta : EntityBase
    {
        public string DescricaoPergunta { get; private set; }
        
        public Pergunta(string descricaoPergunta, Guid hashGuid, int id, DateTime dataCadastro, bool isAtivo) : base(hashGuid,id,dataCadastro,isAtivo)
        {
            DescricaoPergunta = descricaoPergunta ?? throw new ArgumentNullException("O campo descrição não pode ser nulo.");
        }

       
    }
}
