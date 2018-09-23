using MaProvaOnline.Dominio.Entidades;
using MaProvaOnline.Infra.Mapping;
using System.Data.Entity;

namespace MaProvaOnline.Infra.DataContext
{
    public class MaProvaOnlineContext : DbContext
    {
        public MaProvaOnlineContext() : base("MaProvaOnlineConnection")
        {
            Database.SetInitializer<MaProvaOnlineContext>(new MaProvaOnlineContextInitializer());
        }
               

        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Resposta> Respostas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PerguntaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
