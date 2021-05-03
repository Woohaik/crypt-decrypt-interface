using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

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
    }
}
