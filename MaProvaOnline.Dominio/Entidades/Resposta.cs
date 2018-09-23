using System;

namespace MaProvaOnline.Dominio.Entidades
{
    public class Resposta : EntityBase
    {
        public string Descricao { get; private set; }

        public Resposta()
        { }

        public Resposta(string descricao)
        {
            Descricao = descricao ?? throw new ArgumentNullException("O campo descrição não pode ser nulo.");
        }
    }
}
