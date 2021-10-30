using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                //This is my connection string i have assigned the database file address path  
string MyConnection2 = "datasource=localhost;database=citas; port=3306;username=root;password=usbw";
                //This is my insert query in which i am taking input from the user through windows forms  
string Query = "insert into ctrlcitas(nombres) values('" + this.textBox1.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
MySqlDataReader MyReader2;
MyConn2.Open();
MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
MessageBox.Show("Save Data");
while (MyReader2.Read())
  {
   }
  MyConn2.Close();
       }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
 string MyConnection2 = "datasource=localhost;database=citas; port=3306;username=root;password=usbw; convert zero datetime=True";
                //Display query  
 string Query = "select * from ctrlcitas;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                //  MyConn2.Open();  
                //For offline connection we weill use  MySqlDataAdapter class.  
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                                                   // MyConn2.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                //This is my connection string i have assigned the database file address path  
                string MyConnection2 = "datasource=localhost;database=citas; port=3306;username=root;password=usbw; convert zero datetime=True";
                //This is my update query in which i am taking input from the user through windows forms and update the record.  
                string Query = "update ctrlcitas set nombres='" + this.textBox1.Text + "' where id='" + this.IdTextBox.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Updated");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
    string MyConnection2 = "datasource=localhost;database=citas; port=3306;username=root;password=usbw; convert zero datetime=True";
  string Query = "delete from ctrlcitas where id='" + this.IdTextBox.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
