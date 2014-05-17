using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using System.Data.Entity;
using Modelo;


namespace WindowsFormsApplication5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_AccesoDatos_AccesoADatosDataSet4.Factors' Puede moverla o quitarla según sea necesario.
            this.factorsTableAdapter.Fill(this._AccesoDatos_AccesoADatosDataSet4.Factors);
            // TODO: esta línea de código carga datos en la tabla '_AccesoDatos_AccesoADatosDataSet3.Proyectoes' Puede moverla o quitarla según sea necesario.
            this.proyectoesTableAdapter.Fill(this._AccesoDatos_AccesoADatosDataSet3.Proyectoes);
            // TODO: esta línea de código carga datos en la tabla '_AccesoDatos_AccesoADatosDataSet2.Gerentes' Puede moverla o quitarla según sea necesario.
            this.gerentesTableAdapter1.Fill(this._AccesoDatos_AccesoADatosDataSet2.Gerentes);
            // TODO: esta línea de código carga datos en la tabla '_AccesoDatos_AccesoADatosDataSet1.Gerentes' Puede moverla o quitarla según sea necesario.
            this.gerentesTableAdapter.Fill(this._AccesoDatos_AccesoADatosDataSet1.Gerentes);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
            try{
            int id = Convert.ToInt32(comboBox1.Text);

            using (var contexto = new AccesoADatos())
            {
                var g = contexto.Gerente.Find(id);

                textBox1.Text = g.Nombre;
                textBox2.Text = g.Apellido;
                textBox3.Text = g.Usuario;
                textBox4.Text = g.Contraseña;
                textBox5.Text = g.DNI;

            }
            }
            catch {/* MessageBox.Show("error2");*/ }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox1.Text);

            using (var contexto = new AccesoADatos())
            {
                var g = contexto.Gerente.Find(id);


                contexto.Gerente.Remove(g);

                contexto.SaveChanges();

            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {

            try { 
            
            int id = Convert.ToInt32(comboBox2.Text);

            using (var contexto = new AccesoADatos())
            {
                var g = contexto.Proyecto.Find(id);

                textBox10.Text = g.Nombre;
                textBox9.Text = g.Descripcion;
                dateTimePicker1.Value = g.Fecha;

            }
            }
            catch
            {
                //MessageBox.Show("error");


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { 
            
            int id = Convert.ToInt32(comboBox2.Text);

            using (var contexto = new AccesoADatos())
            {
                var g = contexto.Proyecto.Find(id);


                contexto.Proyecto.Remove(g);

                contexto.SaveChanges();

                comboBox2.SelectedItem = -1;
                textBox10.Clear();
                textBox9.Clear();

            }
            }
            catch
            {
                //MessageBox.Show("error");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Visible = true;
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox2.Text);

            using (var contexto = new AccesoADatos())
            {
                var g = contexto.Factor.Find(id);

                textBox7.Text = g.Nombre;
                textBox6.Text = g.Ponderacion;
                checkBox1.Checked = g.Habilitado;

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AccesoADatos>());


                using (var context = new AccesoADatos())
                {

                    int id = Convert.ToInt32(comboBox2.Text);

                    context.Proyecto.Find(id).Nombre = textBox10.Text;
                    context.Proyecto.Find(id).Descripcion = textBox9.Text;
                    context.Proyecto.Find(id).Fecha = dateTimePicker1.Value;

                    context.SaveChanges();
                    MessageBox.Show(";)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox3.Text);

            using (var contexto = new AccesoADatos())
            {
                var g = contexto.Factor.Find(id);


                contexto.Factor.Remove(g);

                contexto.SaveChanges();

            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AccesoADatos>());


                using (var context = new AccesoADatos())
                {
                   
                    int id = Convert.ToInt32(comboBox1.Text);

                    context.Gerente.Find(id).Nombre = textBox1.Text;
                    context.Gerente.Find(id).Apellido = textBox2.Text;
                    context.Gerente.Find(id).Usuario = textBox3.Text;
                    context.Gerente.Find(id).Contraseña = textBox4.Text;
                    context.Gerente.Find(id).DNI = textBox5.Text;



                    context.SaveChanges();
                    MessageBox.Show(";)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AccesoADatos>());


                using (var context = new AccesoADatos())
                {

                    int id = Convert.ToInt32(comboBox3.Text);

                    context.Factor.Find(id).Nombre = textBox7.Text;
                    context.Factor.Find(id).Ponderacion = textBox6.Text;
                    context.Factor.Find(id).Habilitado = checkBox1.Checked;

                    context.SaveChanges();
                    MessageBox.Show(";)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }
    }
}
