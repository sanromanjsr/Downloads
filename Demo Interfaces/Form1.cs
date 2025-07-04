using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_13_06
{
    public partial class Form1 : Form
    {

        Dispositivo dispositivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSmartTv_Click(object sender, EventArgs e)
        {
            dispositivo = new SmartTv();
        }

        private void btnTablet_Click(object sender, EventArgs e)
        {
            dispositivo = new Tablet();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                dispositivo.Apagar();
                lblEstado.Text = dispositivo.Estado;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            try
            {
                dispositivo.Encender();
                lblEstado.Text = dispositivo.Estado;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInformacion.Text == "")
                {
                    throw new Exception("Debe ingresar información para reproducir el video");
                }
                else
                {
                    (dispositivo as IReproducible).ReproducirVideo(txtInformacion.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lblEstado.Text = dispositivo.Estado;
                lblReproduciendo.Text = txtInformacion.Text;
            }
        }

        private void btnSonido_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInformacion.Text == "")
                {
                    throw new Exception("Debe ingresar información para reproducir el sonido");
                }
                else
                {
                    (dispositivo as IReproducible).ReproducirSonido(txtInformacion.Text);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lblEstado.Text = dispositivo.Estado;
                lblReproduciendo.Text = txtInformacion.Text;
            }
        }
    }
}
