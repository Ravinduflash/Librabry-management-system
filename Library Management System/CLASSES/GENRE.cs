using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Library_Management_System.CLASSES
{
    class GENRE
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        // CREATE FUNCTION TO ADD A GENRE
        public Boolean addGenre(string name)
        {
            string query = "INSERT INTO `genres`(`name`) VALUES (@genre_name)";

            MySqlParameter[] paramters = new MySqlParameter[1];
            paramters[0] = new MySqlParameter("@genre_name", MySqlDbType.VarChar);
            paramters[0].Value = name;

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // CREATE FUNCTION TO EDIT A GENRE
        public Boolean editGenre(int id, string name)
        {
            string query = "UPDATE `genres` SET `name`= @genre_name WHERE `id` = @id";

            MySqlParameter[] paramters = new MySqlParameter[2];
            paramters[0] = new MySqlParameter("@genre_name", MySqlDbType.VarChar);
            paramters[0].Value = name;

            paramters[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            paramters[1].Value = id;
            

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }

        // CREATE FUNCTION TO DELETE A GENRE
        public Boolean removeGenre(int id)
        {
            string query = "DELETE FROM `genres` WHERE `id` = @id";

            MySqlParameter[] paramters = new MySqlParameter[1];
            paramters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            paramters[0].Value = id;


            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // CREATE FUNCTION TO RETURN TABLE OF GENRES
        public DataTable GenresList()
        {

            DataTable table = new DataTable();
            table = db.getData("SELECT * FROM `genres`", null);
            return table;
        }
    }
}
