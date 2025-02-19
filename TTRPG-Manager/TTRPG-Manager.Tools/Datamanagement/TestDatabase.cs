namespace TTRPG_Manager.Tools.Datamanagement
{
    public class TestDatabase<T> : IRepository<T>
    {
        const string path = @"C:\Workspace\TTRPGManager";
        List<T> database = [];

        public TestDatabase(string file)
        {
            File.Create(Path.Join(path, file));
        }

        public void DeleteItem(T item)
        {
            database.Remove(item);
        }

        public T? FindItem(Predicate<T> pred)
        {
            return database.Find(pred);
        }

        public void SaveItem(T item)
        {
            if (database.Contains(item))
            {
                
            }
            else
            {
                database.Add(item);
            }
        }
    }
}
