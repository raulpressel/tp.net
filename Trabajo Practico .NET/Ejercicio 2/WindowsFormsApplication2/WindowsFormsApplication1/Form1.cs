using Modelo;
using AccesoADatos;
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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ManejadorDeDatos>());

                var gerente = new Gerente
                {
                    Nombre = textBox1.Text,
                    Apellido = textBox2.Text,
                    Usuario = textBox3.Text,
                    Contraseña = textBox4.Text,
                    DNI = textBox5.Text,
                    //Id = 1,

                };
                using (var context = new ManejadorDeDatos())
                {
                    context.Gerente.Add(gerente);
                    context.SaveChanges();
                    MessageBox.Show("Agregado con exito");
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var contexto = new ManejadorDeDatos())
            {
                try
                {

                    var g = contexto.Gerente.Find(Convert.ToInt32(comboBox1.Text));//Lo menos peor que encontramos
                    //label2.Text = comboBox1.SelectedItem;
                    MessageBox.Show(g.Apellido + " " + g.Nombre + " Eliminado");
                    contexto.Gerente.Remove(g);
                    contexto.SaveChanges();


                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.ToString());
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_AccesoADatos_ManejadorDeDatosDataSet.Factors' Puede moverla o quitarla según sea necesario.
            this.factorsTableAdapter.Fill(this._AccesoADatos_ManejadorDeDatosDataSet.Factors);
            // TODO: esta línea de código carga datos en la tabla '_AccesoADatos_ManejadorDeDatosDataSet.Proyectoes' Puede moverla o quitarla según sea necesario.
            this.proyectoesTableAdapter.Fill(this._AccesoADatos_ManejadorDeDatosDataSet.Proyectoes);
            // TODO: esta línea de código carga datos en la tabla '_AccesoADatos_ManejadorDeDatosDataSet.Gerentes' Puede moverla o quitarla según sea necesario.
            this.gerentesTableAdapter.Fill(this._AccesoADatos_ManejadorDeDatosDataSet.Gerentes);
            // TODO: esta línea de código carga datos en la tabla '_AccesoADatos_ManejadorDeDatosDataSet2.Proyectos' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla '_AccesoADatos_ManejadorDeDatosDataSet1.Proyectoes' Puede moverla o quitarla según sea necesario.
            //this.proyectoesTableAdapter.Fill(this._AccesoADatos_ManejadorDeDatosDataSet1.Proyectoes);
            // TODO: esta línea de código carga datos en la tabla '_AccesoADatos_ManejadorDeDatosDataSet.Gerentes' Puede moverla o quitarla según sea necesario.


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            using (var contexto = new ManejadorDeDatos())
            {
                try
                {
                    int a = Convert.ToInt32(comboBox2.Text);
                    var g = contexto.Gerente.Find(a);//Lo menos peor que encontramos
                    textBox6.Text = g.Nombre;
                    textBox7.Text = g.Apellido;
                    textBox8.Text = g.Usuario;
                    textBox9.Text = g.Contraseña;
                    textBox10.Text = g.DNI;
                }

                catch (Exception ex)
                {
                    //MessageBox.Show(ex.InnerException.ToString());
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ManejadorDeDatos>());

                var proyecto = new Proyecto
                {
                    Nombre = textBox20.Text,
                    Descripcion = textBox19.Text,
                    Fecha = dateTimePicker1.Value.Date,
                    Gerente_Id = Convert.ToInt32(textBox16.Text),
                    //Id = 1,

                };
                using (var context = new ManejadorDeDatos())
                {
                    context.Proyecto.Add(proyecto);
                    context.SaveChanges();
                    MessageBox.Show("Agregado con exito");

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.InnerException.ToString());
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            using (var contexto = new ManejadorDeDatos())
            {
                try
                {

                    var p = contexto.Proyecto.Find(Convert.ToInt32(comboBox4.Text));//Lo menos peor que encontramos
                    contexto.Proyecto.Remove(p);
                    contexto.SaveChanges();
                    MessageBox.Show(p.Nombre + " Eliminado");

                }

                catch (Exception ex)
                {
                    //MessageBox.Show(ex.InnerException.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var contexto = new ManejadorDeDatos())
            {
                try
                {
                    int a = Convert.ToInt32(comboBox2.Text);
                    //var g = contexto.Gerente.Find(a);//Lo menos peor que encontramos
                    contexto.Gerente.Find(a).Nombre = textBox6.Text;
                    contexto.Gerente.Find(a).Apellido = textBox7.Text;
                    contexto.Gerente.Find(a).Usuario = textBox8.Text;
                    contexto.Gerente.Find(a).Contraseña = textBox9.Text;
                    contexto.Gerente.Find(a).DNI = textBox10.Text;
                    contexto.SaveChanges();

                    MessageBox.Show("Registro Actualizado");
                }

                catch (Exception ex)
                {
                    //MessageBox.Show(ex.InnerException.ToString());
                }
            }
        }

       /* private void comboBox3_TextChanged(object sender, EventArgs e)
        {

            MessageBox.Show("hola");

            using (var contexto = new ManejadorDeDatos())
            {
                try
                {
                    int a = Convert.ToInt32(comboBox3.Text);
                    var g = contexto.Proyecto.Find(a);

                    MessageBox.Show(g.Nombre);

                    textBox14.Text = g.Nombre;
                    textBox13.Text = g.Descripcion;
                    textBox12.Text = Convert.ToString(g.Gerente_Id);
                    dateTimePicker2.Value = g.Fecha;
                }

                catch (Exception ex)
                {
                    //MessageBox.Show(ex.InnerException.ToString());
                }
            }
        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            using (var contexto = new ManejadorDeDatos())
            {
                try
                {
                    int a = Convert.ToInt32(comboBox3.Text);
                    //var g = contexto.Gerente.Find(a);//Lo menos peor que encontramos
                    //contexto.Proyecto.Find(a).Id = Convert.ToInt32(textBox15.Text);
                    contexto.Proyecto.Find(a).Nombre = textBox14.Text;
                    contexto.Proyecto.Find(a).Descripcion = textBox13.Text;
                    contexto.Proyecto.Find(a).Gerente_Id = Convert.ToInt32(textBox12.Text);
                    contexto.Proyecto.Find(a).Fecha = dateTimePicker2.Value;

                    contexto.SaveChanges();

                    MessageBox.Show("Registro Actualizado");
                }

                catch (Exception ex)
                {
                    //MessageBox.Show(ex.InnerException.ToString());
                }
            }
        }

        private void comboBox3_TextChanged_1(object sender, EventArgs e)
        {
            using (var contexto = new ManejadorDeDatos())
            {
                try
                {
                    int a = Convert.ToInt32(comboBox3.Text);
                    var g = contexto.Proyecto.Find(a);

                    textBox14.Text = g.Nombre;
                    textBox13.Text = g.Descripcion;
                    textBox12.Text = Convert.ToString(g.Gerente_Id);
                    dateTimePicker2.Value = g.Fecha;
                }

                catch (Exception ex)
                {
                    //MessageBox.Show(ex.InnerException.ToString());
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ManejadorDeDatos>());

                var factor = new Factor
                {
                    Nombre = textBox11.Text,
                    Ponderacion = textBox15.Text,
                    Habilitado = checkBox1.Checked
                    //Gerente_Id = Convert.ToInt32(textBox16.Text),
                    //Id = 1,

                };

                using (var context = new ManejadorDeDatos())
                {
                    context.Factor.Add(factor);
                    context.SaveChanges();
                    MessageBox.Show("Agregado con exito");

                }
            }
            
            catch (Exception ex)
            {
                //MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void comboBox5_TextChanged(object sender, EventArgs e)
        {
            using (var contexto = new ManejadorDeDatos())
            {
                try
                {
                    int a = Convert.ToInt32(comboBox5.Text);
                    var g = contexto.Factor.Find(a);

                    textBox18.Text = g.Nombre;
                    textBox17.Text = Convert.ToString(g.Ponderacion);
                    checkBox2.Checked = g.Habilitado;
                    
                }

                catch (Exception ex)
                {
                    //MessageBox.Show(ex.InnerException.ToString());
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (var contexto = new ManejadorDeDatos())
            {
                try
                {
                    int a = Convert.ToInt32(comboBox5.Text);
                    //var g = contexto.Gerente.Find(a);//Lo menos peor que encontramos
                    //contexto.Proyecto.Find(a).Id = Convert.ToInt32(textBox15.Text);
                    contexto.Factor.Find(a).Nombre = textBox18.Text;
                    contexto.Factor.Find(a).Ponderacion = textBox17.Text;
                    contexto.Factor.Find(a).Habilitado = checkBox2.Checked;
                    contexto.SaveChanges();

                    MessageBox.Show("Registro Actualizado");
                }

                catch (Exception ex)
                {
                    //MessageBox.Show(ex.InnerException.ToString());
                }
            }
        }

    }
}
