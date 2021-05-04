using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypt_decrypt
{
    public partial class Form1 : Form
    {

        private string clavePublica = "";
        private string clavePrivada = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                if (saveFileTxt.ShowDialog() == DialogResult.OK)
                {
                    LeectorArchivos.guardarTxt(textBox1.Text, saveFileTxt.FileName);
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (saveFileXml.ShowDialog() == DialogResult.OK)
            {
                LeectorArchivos.exportarXml(comboBox2.Text, clavePrivada, clavePublica, saveFileXml.FileName);
            }

        }

        private void importarClavesBtn_Click(object sender, EventArgs e)
        {
            if (openFileXml.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void openFileXml_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void verClavesBtn_Click(object sender, EventArgs e)
        {
            if (!clavePrivada.Equals(""))
            {
                string clavesAMostrar = "Clave: " + clavePrivada;

                if (!clavePublica.Equals("")) clavesAMostrar += "\nClave Publica: " + clavePublica;

                MessageBox.Show(clavesAMostrar);
            }
            else
            {
                MessageBox.Show("No hay claves para mostrar");
            }

        }

        private void importarTextoBtn_Click(object sender, EventArgs e)
        {
            if (openFileTxt.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // LLenar el texto obtenido a el text area
                    string text = System.IO.File.ReadAllText(openFileTxt.FileName);
                    text = Base64.Base64Decode(text);
                    textBox1.Text = text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("No se ha podido decodificar el texto de base 64");
                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            crearClavesBtn.Enabled = false;
            importarClavesBtn.Enabled = false;
            exportarClavesBtn.Enabled = false;
            encriptarBtn.Enabled = false;
            verClavesBtn.Enabled = false;
            desencriptarBtn.Enabled = false;


            if (!(comboBox2.Text.Equals("TDES") || comboBox2.Text.Equals("AES")))
            {
                comboBox2.Text = "";
            }
            else
            {
                crearClavesBtn.Enabled = true;
                importarClavesBtn.Enabled = true;



                encriptarBtn.Enabled = false;
                desencriptarBtn.Enabled = false;


            }

            MessageBox.Show(comboBox2.Text);

        }

        private void crearClavesBtn_Click(object sender, EventArgs e)
        {
            clavePublica = "Soy la publica";
            clavePrivada = "Soy la privadeichon";
            exportarClavesBtn.Enabled = true;


            if (!textBox1.Text.Equals(""))
            {
                encriptarBtn.Enabled = true;
                desencriptarBtn.Enabled = true;
            }
        }

        private void saveFileXml_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void encriptarBtn_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                if (saveFileTxt.ShowDialog() == DialogResult.OK)
                {
                    LeectorArchivos.guardarTxt(textBox1.Text, saveFileTxt.FileName);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                encriptarBtn.Enabled = false;
                desencriptarBtn.Enabled = false;
            }
            else
            {

                if ((comboBox2.Text.Equals("TDES") || comboBox2.Text.Equals("AES")) && !clavePrivada.Equals(""))
                {
                    encriptarBtn.Enabled = true;
                    desencriptarBtn.Enabled = true;
                }

            }
        }
    }
}
