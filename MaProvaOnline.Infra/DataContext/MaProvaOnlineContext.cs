using MaProvaOnline.Dominio.Entidades;
using MaProvaOnline.Infra.Mapping;
using System;
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
            modelBuilder.Configurations.Add(new RespostaMap());

            base.OnModelCreating(modelBuilder);

            /*
            //Adicionando o relacionamento no OnModelCreating
            modelBuilder.Entity<Revista>().HasMany(r => r.Edicoes);
            //Adicionando uma edição   
            Edicao edicao = new Edicao();
            edicao.Descricao = "edição 28 - entendendo ORM";
            revista.Edicoes.Add(edicao);
            */

        }
    }



    public class MaProvaOnlineContextInitializer : DropCreateDatabaseIfModelChanges<MaProvaOnlineContext>
    {
        protected override void Seed(MaProvaOnlineContext context)
        {
            var pergunta = new Pergunta("Cite 3 pradrões de projetos.", Guid.NewGuid(), 1, DateTime.Now,true);
            context.Perguntas.Add(pergunta);
            context.SaveChanges();
            base.Seed(context);

        }
    }
}
