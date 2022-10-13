using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L9_OAHB_1088321
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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string marca, disponible;
            int modelo=0, precio = 0, descuento = 0;
            double cambio = 0;

            try
            {

                if (!int.TryParse(txt_modelo.Text, out int num))
                {
                    MessageBox.Show("Debe ingresar un modelo");
                }
                else
                {
                    if (!int.TryParse(txt_precio.Text, out int num2))
                    {
                        MessageBox.Show("Debe ingresar un precio");
                    }
                    else
                    {
                        if (!double.TryParse(txt_cambio.Text, out double num3))
                        {
                            MessageBox.Show("Debe ingresar un cambio");
                        }
                        else
                        {
                            if (!int.TryParse(txt_desc.Text, out int num4))
                            {
                                MessageBox.Show("Debe ingresar un descuento");
                            }
                            else
                            {
                                modelo = Convert.ToInt32(txt_modelo.Text);
                                precio = Convert.ToInt32(txt_precio.Text);
                                cambio = Convert.ToDouble(txt_cambio.Text);
                                descuento = Convert.ToInt32(txt_desc.Text);

                                if (int.TryParse(txt_marca.Text, out int num5))
                                {
                                    MessageBox.Show("Debe ingresar un dato en letras");
                                }
                                else
                                {
                                    if (int.TryParse(txt_dispo.Text, out int num6))
                                    {
                                        MessageBox.Show("Debe ingresar un dato en letras");

                                    }
                                    else
                                    {
                                        marca = Convert.ToString(txt_marca.Text);
                                        disponible = Convert.ToString(txt_dispo.Text);

                                        lbl_resmodelo.Text = modelo.ToString();
                                        lbl_resprecio.Text = precio.ToString();
                                        lbl_resmarca.Text = marca.ToString();
                                        lbl_resdisponible.Text = disponible.ToString();
                                        lbl_rescambio.Text = cambio.ToString();
                                        lbl_resdescuento.Text = descuento.ToString();

                                    }
                                }
                            }

                            
                            
                        }
                    }
                }

            }
            catch (Exception)
            {
                
                MessageBox.Show("Debe ingresar un dato válido");
                throw;
            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_modelo.Clear();
            txt_precio.Clear();
            txt_marca.Clear();
            txt_cambio.Clear();
            txt_dispo.Clear();
            txt_desc.Clear();

        }
    }
}
