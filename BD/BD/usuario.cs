using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BD
{
    public partial class usuario : Form
    {
        public usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("Data Source=ROMAN\\SQLEXPRESS;Initial Catalog=usuarios;Integrated Security=True");
            
            string des = textBox1.Text;
            string serie = textBox2.Text;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;    
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            

            try
            {
                if (des==""){
                    MessageBox.Show("Ingresa la descripcion");
                }

                else if(serie==""){
                    MessageBox.Show("Ingresa la serie");
                }

                else
                {
                    string consulta = "insert into producto values('" + des + "','" + serie + "','" + dateTimePicker1.Text + "')";
                    SqlCommand cmd = new SqlCommand(consulta, cnx);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos insertados");
                }
                
                
            }

            catch (Exception en)
            {
                MessageBox.Show(en.ToString());
            }

            
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Actualizar.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            dateTimePicker1.Visible = true;
            comboBox1.Visible = false;
            label4.Visible = false;
            button2.Visible = false;
            button1.Visible = true;
            label5.Visible = false;
            textBox3.Visible = false;
            button3.Visible = false;

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            //1
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel2_Click_1(object sender, EventArgs e)
        {
            Actualizar.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox1.Visible = false;
            label4.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
            label5.Visible = false;
            textBox3.Visible = false;
            button3.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;

            dataGridView2.EditMode = DataGridViewEditMode.EditOnEnter;

            SqlConnection cnx = new SqlConnection("Data Source=ROMAN\\SQLEXPRESS;Initial Catalog=usuarios;Integrated Security=True");
            string datobuscado = textBox3.Text;
            string consulta = "Select *from producto";
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand(consulta, cnx);
            cnx.Open();
            SqlDataReader lectura = cmd.ExecuteReader();

      
            dt.Load(lectura);
            dataGridView2.DataSource = dt;

            

            //2
        }

        private void toolStripLabel3_Click_1(object sender, EventArgs e)
        {
            Actualizar.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox1.Visible = true;
            label4.Visible = true;
            button2.Visible = true;
            button1.Visible = false;
            label5.Visible = false;
            textBox3.Visible = false;
            button3.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;

            //////////////////////////// BORRAR COMBOBOX
            comboBox1.Items.Clear();
            SqlConnection cnx = new SqlConnection("Data Source=ROMAN\\SQLEXPRESS;Initial Catalog=usuarios;Integrated Security=True");
            try
            {

                string combo = "select descripcion from producto ";
                SqlCommand cmd = new SqlCommand(combo, cnx);
                cnx.Open();

                SqlDataReader leer = cmd.ExecuteReader();

                while (leer.Read())
                {
                    comboBox1.Items.Add(leer.GetString(0));
                }

            }

            catch (Exception en)
            {
                MessageBox.Show(en.ToString());
            }
            //3
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Actualizar.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox1.Visible = false;
            label4.Visible = false;
            button2.Visible = false;
            button1.Visible = false;

            label5.Visible = true;
            textBox3.Visible = true;
            button3.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            //4
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usuariosDataSet.producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.usuariosDataSet.producto);
            // TODO: This line of code loads data into the 'usuariosDataSet.persona' table. You can move, or remove it, as needed.
            this.personaTableAdapter.Fill(this.usuariosDataSet.persona);
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox1.Visible = false;
            label4.Visible = false;
            button2.Visible = false;
            button1.Visible = false;

            label5.Visible = false;
            textBox3.Visible = false;
            button3.Visible = false;

            dataGridView1.Visible = false;
            dataGridView2.Visible = false;

            Actualizar.Visible = false;

           
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            object dato = comboBox1.SelectedItem;

            
            SqlConnection cnx = new SqlConnection("Data Source=ROMAN\\SQLEXPRESS;Initial Catalog=usuarios;Integrated Security=True");
            try {

                string consulta = "delete from producto where descripcion='"+dato.ToString()+"'";
                SqlCommand cmd = new SqlCommand(consulta, cnx);
                cnx.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos Eliminados");
            }
            catch { 
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("Data Source=ROMAN\\SQLEXPRESS;Initial Catalog=usuarios;Integrated Security=True");
            string datobuscado = textBox3.Text;
            string consulta = "Select *from producto where descripcion like '%"+datobuscado+"%' OR serie like '%"+datobuscado+"%'";

            try {

                SqlCommand cmd = new SqlCommand(consulta,cnx);
                cnx.Open();
                SqlDataReader lectura = cmd.ExecuteReader();

                if (lectura.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(lectura);
                    dataGridView1.DataSource = dt;
                }

                else {
                    MessageBox.Show("Datos no encontrados");
                }

            }
            catch { 
            
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("Data Source=ROMAN\\SQLEXPRESS;Initial Catalog=usuarios;Integrated Security=True");
            string datobuscado = textBox3.Text;
            string consulta = "Select *from producto";
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand(consulta, cnx);
            cnx.Open();
            SqlDataReader lectura = cmd.ExecuteReader();

            dt.Load(lectura);
            dataGridView2.DataSource = dt;

            try {
                SqlDataAdapter cmd1 = new SqlDataAdapter("Select *from producto", cnx);
                SqlCommandBuilder c1 = new SqlCommandBuilder(cmd1);
                
                MessageBox.Show("Datos actualizados");
            }

            catch { 
            
            }
        }
    }
}
