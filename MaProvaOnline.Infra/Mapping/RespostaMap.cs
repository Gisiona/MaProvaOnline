using MaProvaOnline.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace MaProvaOnline.Infra.Mapping
{
    public class RespostaMap : EntityTypeConfiguration<Resposta>
    {
        public RespostaMap()
        {
            ToTable("Resposta");
            HasKey(p => p.id);
            Property(p => p.Descricao)
                .HasMaxLength(200)
                .IsRequired();

            Property(p => p.DataCadastro).IsRequired();
            Property(p => p.IsAtivo).IsRequired();
        }
    }
}
