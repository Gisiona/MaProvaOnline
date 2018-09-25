using System;

namespace MaProvaOnline.Dominio.Entidades
{
    public abstract class EntityBase
    {
        public Guid HashGuid { get; private set; }
        public int id { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool IsAtivo { get; private set; }


        public EntityBase()
        {
            HashGuid = Guid.NewGuid();
            DataCadastro = DateTime.Now;
            this.IsAtivo = true;
        }

        public EntityBase(Guid hashGuid, int id, DateTime dataCadastro, bool isAtivo)
        {
            this.HashGuid = hashGuid;
            this.id = id;
            this.DataCadastro = dataCadastro;
            this.IsAtivo = isAtivo;
        }
    }
}
