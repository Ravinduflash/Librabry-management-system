using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Library_Management_System.CLASSES
{
    class BOOKS
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        //create a function to add a new book 
        public Boolean addBook(string isbn, string title, int author_id, int genre_id, int quantity, double price, string publisher, DateTime date_recieved, string description, byte[] cover)
        {
            string query = "INSERT INTO `books`( `isbn`, `title`, `author_id`, `genre_id`, `quantity`, `price`, `publisher`, `date_recieved`, `description`, `cover`) VALUES (@isbn, @title, @author, @genre, @qty, @price, @publisher, @d_recv, @descrp, @img)";

            MySqlParameter[] paramters = new MySqlParameter[10];

            

            paramters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            paramters[0].Value = isbn;

            paramters[1] = new MySqlParameter("@title", MySqlDbType.VarChar);
            paramters[1].Value = title;

            paramters[2] = new MySqlParameter("@author", MySqlDbType.Int32);
            paramters[2].Value = author_id;

            paramters[3] = new MySqlParameter("@genre", MySqlDbType.Int32);
            paramters[3].Value = genre_id;

            paramters[4] = new MySqlParameter("@qty", MySqlDbType.Int32);
            paramters[4].Value = quantity;

            paramters[5] = new MySqlParameter("@price", MySqlDbType.Double);
            paramters[5].Value = price;

            paramters[6] = new MySqlParameter("@publisher", MySqlDbType.VarChar);
            paramters[6].Value = publisher;

            paramters[7] = new MySqlParameter("@d_recv", MySqlDbType.Date);
            paramters[7].Value = date_recieved;

            paramters[8] = new MySqlParameter("@descrp", MySqlDbType.VarChar);
            paramters[8].Value = description;

            paramters[9] = new MySqlParameter("@img", MySqlDbType.Blob);
            paramters[9].Value = cover;
            
            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

            

        }

        //create a function to edit the selected book
        public Boolean editBook(int id, string isbn, string title, int author_id, int genre_id, int quantity, double price, string publisher, DateTime date_recieved, string description, byte[] cover)
        {
            string query = "UPDATE `books` SET `isbn`=@isbn,`title`=@title,`author_id`=@author,`genre_id`=@genre,`quantity`=@qty,`price`=@price,`publisher`=@publisher,`date_recieved`=@d_recv,`description`=@descrp,`cover`=@img WHERE `id` =@id";

            MySqlParameter[] paramters = new MySqlParameter[11];

            paramters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            paramters[0].Value = isbn;

            paramters[1] = new MySqlParameter("@title", MySqlDbType.VarChar);
            paramters[1].Value = title;

            paramters[2] = new MySqlParameter("@author", MySqlDbType.Int32);
            paramters[2].Value = author_id;

            paramters[3] = new MySqlParameter("@genre", MySqlDbType.Int32);
            paramters[3].Value = genre_id;

            paramters[4] = new MySqlParameter("@qty", MySqlDbType.Int32);
            paramters[4].Value = quantity;

            paramters[5] = new MySqlParameter("@price", MySqlDbType.Double);
            paramters[5].Value = price;

            paramters[6] = new MySqlParameter("@publisher", MySqlDbType.VarChar);
            paramters[6].Value = publisher;

            paramters[7] = new MySqlParameter("@d_recv", MySqlDbType.Date);
            paramters[7].Value = date_recieved;

            paramters[8] = new MySqlParameter("@descrp", MySqlDbType.VarChar);
            paramters[8].Value = description;

            paramters[9] = new MySqlParameter("@img", MySqlDbType.Blob);
            paramters[9].Value = cover;

            paramters[10] = new MySqlParameter("@id", MySqlDbType.Int32);
            paramters[10].Value = id;

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


        //create a function to remove the selected book
        public Boolean removeBook( int id)
        {

            string query = "DELETE FROM `books` WHERE `id` = @id";

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

        // CREATE FUNCTION TO RETURN TABLE OF books
        public DataTable BooksList()
        {
            string query = "SELECT * FROM `books` ORDER BY id DESC";

           

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        // CREATE FUNCTION TO RETURN TABLE OF the  selected author books
        public DataTable authorBooks(int authorId)
        {
            string query = "SELECT * FROM `books` WHERE `author_id` =@author_id ";

            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@author_id", MySqlDbType.Int32);
            parameters[0].Value = authorId;


            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            return table;
        }

        // check if the book isbn already exists
        public Boolean isIsbnExists(string isbn, int id)
        {
            string query = "SELECT * FROM `books` WHERE `isbn` = @isbn AND id <> @id";

            MySqlParameter[] parameters = new MySqlParameter[2];
            parameters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            parameters[0].Value = isbn;

            parameters[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[1].Value = id;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }

        // check if the book title already exists
        public Boolean isTitleExists(string title, int id)
        {
            string query = "SELECT * FROM `books` WHERE `title` = @title AND id <> @id";

            MySqlParameter[] parameters = new MySqlParameter[2];
            parameters[0] = new MySqlParameter("@title", MySqlDbType.VarChar);
            parameters[0].Value = title;

            parameters[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[1].Value = id;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        // search book by id or isbn
        public DataTable searchBookBy_IDorISBN(string id_or_isbn, int id, string isbn)
        {
            string query;
            MySqlParameter[] parameters = new MySqlParameter[1];
            

            if (id_or_isbn.Equals("id"))
            {

               
                query = "SELECT * FROM `books` WHERE `id` = @id";
                parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
                parameters[0].Value = id;
            }
            else
            {
                query = "SELECT * FROM `books` WHERE `isbn` = @isbn";
                parameters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
                parameters[0].Value = isbn;
            }
 

            DataTable table = new DataTable();
            table = db.getData(query, parameters);

            return table;


        }

    }
}
