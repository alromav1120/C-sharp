using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BD
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

            SqlConnection cnx = new SqlConnection("Data Source=ROMAN\\SQLEXPRESS;Initial Catalog=usuarios;Integrated Security=True");

            string name = textBox1.Text;
            string pass = textBox2.Text;
            
            try
            {
                
                string consulta = "select *from persona where nombre='"+name+"' and pass='"+pass+"'";     
                SqlCommand cmd = new SqlCommand(consulta,cnx);

                cnx.Open();
              
                SqlDataReader lectura = cmd.ExecuteReader();

                if(lectura.Read()){
                    MessageBox.Show("Bienvenido");
                    usuario for2 = new usuario();
                    this.Hide();
                    for2.Show();
                }
                
                else{
                    MessageBox.Show("Intentalo nuevamente");
                } 
                cnx.Close();

               
            }

            catch (Exception en) {
                MessageBox.Show(en.ToString());
            }
           
            

        }
    }
}
