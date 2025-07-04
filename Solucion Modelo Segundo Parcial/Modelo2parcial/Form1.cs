using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo2parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Gerente gerente = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos");
                return;
            }
            try
            {
                switch (comboBox1.Text)
                {
                    case "Gerente":
                        gerente = new Gerente(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDouble(textBox4.Text));
                        break;
                    case "Administrativo":
                        if (textBox5.Text == "")
                        {
                            MessageBox.Show("Por favor complete todos los campos");
                            return;
                        }
                        Administrativo miAdministrativo = new Administrativo(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDouble(textBox4.Text), Convert.ToInt32(textBox5.Text));
                        gerente.AsignarEmpleadoACargo(miAdministrativo);
                        break;
                    case "Pasante - Full Time":
                        Pasante miPasanteFullTime = new Pasante(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDouble(textBox4.Text), "FullTime");
                        gerente.AsignarEmpleadoACargo(miPasanteFullTime);
                        break;
                    case "Pasante - Part Time":
                        Pasante miPasantePartTime = new Pasante(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToDouble(textBox4.Text), "PartTime");
                        gerente.AsignarEmpleadoACargo(miPasantePartTime);
                        break;
                    default:
                        MessageBox.Show("Ocurrio un error al seleccionar el tipo de empleado");
                        break;
                }
            }
            catch (EmpleadoACargoRepetidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Limpiamos todos los textbox y actualizamos la grilla
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gerente.EmpleadosACargo;

            ActualizarDatosLabels();
        }

        private void ActualizarDatosLabels()
        {
            label7.Text = gerente.Nombre;
            label9.Text = gerente.Apellido;
            label11.Text = gerente.DNI;
            label13.Text = gerente.CantidadEmpleadosACargo.ToString();
            if (gerente.CantidadEmpleadosACargo > 0)
            {
                label20.Text = gerente.Sueldo_Bruto.ToString();
                label15.Text = gerente.Sueldo_Neto.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gerente.EliminarEmpleadoACargo(textBox6.Text);
        }
    }
}
