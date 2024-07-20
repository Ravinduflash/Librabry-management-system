using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;



namespace Library_Management_System.CLASSES
{
    class MEMBER
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        //create a function to add member.
        // CREATE FUNCTION TO ADD A new member
        public Boolean addMember(string fname, string lname, string gender, string phone, string email, byte[] picture )
        {
            string query = "INSERT INTO `members`(`first_name`, `last_name`, `gender`, `phone`, `email`, `picture`) VALUES (@fn, @ln, @gender, @phone, @email, @pic)";

            MySqlParameter[] paramters = new MySqlParameter[6];

            paramters[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            paramters[0].Value = fname;

            paramters[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            paramters[1].Value = lname;

            paramters[2] = new MySqlParameter("@gender", MySqlDbType.VarChar);
            paramters[2].Value = gender;

            paramters[3] = new MySqlParameter("@phone", MySqlDbType.VarChar);
            paramters[3].Value = phone;

            paramters[4] = new MySqlParameter("@email", MySqlDbType.VarChar);
            paramters[4].Value = email;

            paramters[5] = new MySqlParameter("@pic", MySqlDbType.Blob);
            paramters[5].Value = picture;

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // CREATE FUNCTION TO edit member
        public Boolean editMember(int id, string fname, string lname, string gender, string phone, string email, byte[] picture)
        {
            string query = "UPDATE `members` SET `first_name`=@fn, `last_name`=@ln, `gender`=@gender, `phone`=@phone, `email`=@email, `picture`=@pic WHERE `id` =@id";

            MySqlParameter[] paramters = new MySqlParameter[7];

            paramters[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            paramters[0].Value = fname;

            paramters[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            paramters[1].Value = lname;

            paramters[2] = new MySqlParameter("@gender", MySqlDbType.VarChar);
            paramters[2].Value = gender;

            paramters[3] = new MySqlParameter("@phone", MySqlDbType.VarChar);
            paramters[3].Value = phone;

            paramters[4] = new MySqlParameter("@email", MySqlDbType.VarChar);
            paramters[4].Value = email;

            paramters[5] = new MySqlParameter("@pic", MySqlDbType.Blob);
            paramters[5].Value = picture;

            paramters[6] = new MySqlParameter("@id", MySqlDbType.Int32);
            paramters[6].Value = id;

            if (db.setData(query, paramters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // CREATE FUNCTION TO remove the selected member
        public Boolean removeMember(int id)
        {
            string query = "DELETE FROM `members` WHERE `id` = @id";

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

        // CREATE FUNCTION TO RETURN TABLE OF members
        public DataTable MembersList(Boolean display_fullname )
        {
            string query = "SELECT * FROM `members`";


            if (display_fullname)
            {
                query = "SELECT `id`, concat( `first_name`,'-', `last_name`) as fullName, `gender` , `phone` , `email` , `picture`  FROM `members`";

            }

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }
    }


}
