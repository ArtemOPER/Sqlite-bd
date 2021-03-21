using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqlite.DAL
{
    class sqliteHelper
    {
        internal static object GetUsers()
        {
            try
            {

                using(var connection = new SQLiteConnection(@"Data Sourse=db.sqlite;Version=3;"))
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return null;
        }
    }
}
