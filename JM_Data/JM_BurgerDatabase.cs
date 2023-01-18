using JM_AppBurger.JM_Models;
using SQLite;
namespace JM_AppBurger.JM_Data
{
    public class JM_BurgerDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public JM_BurgerDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<JM_Burger>();

        }
        public int AddNewBurger(JM_Burger burger)
        {
            Init();

            if (burger.Id != 0)
            {
                return conn.Update(burger);
            }
            else
            {
                return conn.Insert(burger);
            }
        }
        public List<JM_Burger> GetAllBurgers()
        {
            Init();
            List<JM_Burger> burgers = conn.Table<JM_Burger>().ToList();
            return burgers;
        }

        public int DeleteItem(JM_Burger item)
        {
            Init();
            return conn.Delete(item);
        }
    }
}
