using System.Data.Entity;

namespace MaProvaOnline.Infra.DataContext
{
    public class MaProvaOnlineContextInitializer : DropCreateDatabaseIfModelChanges<MaProvaOnlineContext>
    {
        public MaProvaOnlineContextInitializer()
        {
        }        
    }
}
