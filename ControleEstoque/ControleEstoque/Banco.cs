using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque
{
    class Banco
    {
        private static SQLiteConnection sqliteConnection;
        
        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source= D:\\Programação\\C#\\ControleEstoque\\ControleEstoque\\Database.db;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public static void comandoSql(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            SQLiteConnection con = new SQLiteConnection("Data Source= D:\\Programação\\C#\\ControleEstoque\\ControleEstoque\\Database.db;");
            SQLiteCommand comandosql = con.CreateCommand();
            con.Open();

            comandosql.CommandText = sql;
            comandosql.ExecuteNonQuery();
            comandosql.Connection.Close();
            MessageBox.Show("Inserido com sucesso!");

            con.Close();


        }



    }
    

}
