using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Modelo;
using AccesoDatos;



namespace WindowsFormsApplication5
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // this.factorSetTableAdapter.FillBy(this._TP_2DataSet.FactorSet);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContraseñaG_Click(object sender, EventArgs e)
        {

        }

        private void DNIG_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AccesoADatos>());

                var gerente = new Gerente
                {
                    Apellido = textBox2.Text,
                    Contraseña = textBox4.Text,
                    Nombre = textBox1.Text,
                    Usuario = textBox3.Text,
                    DNI = textBox5.Text,
                    //Id = 1,

                };
                using (var context = new AccesoADatos())
                {
                    context.Gerente.Add(gerente);

                    context.SaveChanges();
                    MessageBox.Show(";)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
         }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Show();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_AccesoDatos_AccesoADatosDataSet.Gerentes' Puede moverla o quitarla según sea necesario.
            this.gerentesTableAdapter.Fill(this._AccesoDatos_AccesoADatosDataSet.Gerentes);

           



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chuchis");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            button1.Hide();

            textBox1.Text = label3.Text;
            textBox2.Text = label4.Text;
            textBox3.Text = label5.Text;
            textBox4.Text = label6.Text;
            textBox5.Text = label7.Text;
            

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
          /* // int id = Convert.ToInt32(label2.Text);

            using (var contexto = new AccesoADatos())
            {
             //   var g = contexto.Gerente.Find(id);
                MessageBox.Show(g.Apellido + " " + g.Nombre);


                contexto.Gerente.Remove(g);
                contexto.SaveChanges();
            }*/
        }

        private void button10_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox1.Visible = true;


        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = false;
            groupBox3.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AccesoADatos>());

                var factor = new Factor
                {
                    Nombre = textBox7.Text,
                    Ponderacion = textBox6.Text,
                    Habilitado = checkBox1.Checked,
                    //Id = 1,

                };
                using (var context = new AccesoADatos())
                {
                    context.Factor.Add(factor);

                    context.SaveChanges();
                    MessageBox.Show(";)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AccesoADatos>());

                var proyecto = new Proyecto
                {
                    Nombre = textBox10.Text,
                    Descripcion = textBox9.Text,
                    Fecha = dateTimePicker1.Value,
                    //Id = 1,

                };
                using (var context = new AccesoADatos())
                {
                    context.Proyecto.Add(proyecto);

                    context.SaveChanges();
                    MessageBox.Show(";)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            Form2 frm = new Form2();
            frm.Show();
            
        }
        

 
      
    }
}
