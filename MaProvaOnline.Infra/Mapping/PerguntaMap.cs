using MaProvaOnline.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace MaProvaOnline.Infra.Mapping
{
    public class PerguntaMap : EntityTypeConfiguration<Pergunta>
    {
        public PerguntaMap()
        {
            ToTable("Pergunta");
            HasKey(p => p.id);
            Property(p => p.DescricaoPergunta)
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.DataCadastro).IsRequired();
        }
    }
}
