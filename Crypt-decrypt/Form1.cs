using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Crypt_decrypt
{
    public partial class Form1dfgdfg : Form
    {
        private string aesIV = "Pb84K9+ID2k0M15pdQesMA==";

        public Form1dfgdfg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] cyfradoDesdeBase64 = ByteConvert.Base64ToByteArray(textoEncriptado.Text);
                string desifrado = null;
                if (comboBox2.Text.Equals("TDES"))
                {

                    desifrado = TDES.decrypt_TDES(cyfradoDesdeBase64, ByteConvert.Base64ToByteArray(inputPrivada1.Text));
                }
                else if (comboBox2.Text.Equals("RSA"))
                {


                    using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                    {
                        rsa.FromXmlString(inputPrivada1.Text);



                        desifrado = RSA.decrypt_RSA(cyfradoDesdeBase64, rsa.ExportParameters(true));
                    }

                }
                else
                {



                    desifrado = AES.decrypt_AES(cyfradoDesdeBase64, ByteConvert.Base64ToByteArray(inputPrivada1.Text), ByteConvert.Base64ToByteArray(aesIV));
                }





                textplano.Text = desifrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (saveFileXml.ShowDialog() == DialogResult.OK)
            {
                FileReadWriteHandler.exportarXml(comboBox2.Text, inputPrivada1.Text, saveFileXml.FileName);
            }

        }

        private void importarClavesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileXml.ShowDialog() == DialogResult.OK)
                {
                    string key = FileReadWriteHandler.leerXml(openFileXml.FileName);
                    inputPrivada1.Text = key;
                    if (!textoEncriptado.Text.Equals("") && !inputPrivada1.Text.Equals(""))
                    {
                        desencriptarBtn.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void openFileXml_FileOk(object sender, CancelEventArgs e)
        {

        }



        private void importarTextoBtn_Click(object sender, EventArgs e)
        {
            if (openFileTxt.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // LLenar el texto obtenido a el text area
                    string text = System.IO.File.ReadAllText(openFileTxt.FileName);
  
                    textoEncriptado.Text = text;
                    if (textoEncriptado.Text.Length > 0)
                    {
                        exportarEn.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            crearClavesBtn.Enabled = false;
            importarClavesBtn.Enabled = false;
            exportarClavesBtn.Enabled = false;
            encriptarBtn.Enabled = false;
            desencriptarBtn.Enabled = false;







            if (!(comboBox2.Text.Equals("TDES") || comboBox2.Text.Equals("AES") || comboBox2.Text.Equals("RSA")))
            {
                comboBox2.Text = "";

            }
            else
            {

                inputPrivada1.Visible = true;





                inputPrivada1.Text = "";


                crearClavesBtn.Enabled = true;
                importarClavesBtn.Enabled = true;

                encriptarBtn.Enabled = false;
            }
        }

        private void crearClavesBtn_Click(object sender, EventArgs e)
        {

            if (comboBox2.Text.Equals("TDES"))
            {
                inputPrivada1.Text = ByteConvert.ByteArrayToBase64(TDES.generateKey());
            }
            else if (comboBox2.Text.Equals("RSA"))
            {
                inputPrivada1.Text = RSA.generateKeys();
            }
            else
            {
                inputPrivada1.Text = ByteConvert.ByteArrayToBase64(AES.generateKey());
            }

            if (!textoEncriptado.Text.Equals(""))
            {
                desencriptarBtn.Enabled = true;
            }

            exportarClavesBtn.Enabled = true;
            if (!textplano.Text.Equals(""))
            {
                encriptarBtn.Enabled = true;
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
            try
            {

                byte[] cyfrado = null;
                if (comboBox2.Text.Equals("TDES"))
                {
                    cyfrado = TDES.encrypt_TDES(textplano.Text, ByteConvert.Base64ToByteArray(inputPrivada1.Text));
                }
                else if (comboBox2.Text.Equals("RSA"))
                {


                    using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                    {
                        rsa.FromXmlString(inputPrivada1.Text);

                        cyfrado = RSA.encrypt_RSA(textplano.Text, rsa.ExportParameters(true));


                    }

                }
                else
                {
                    cyfrado = AES.encrypt_AES(textplano.Text, ByteConvert.Base64ToByteArray(inputPrivada1.Text), ByteConvert.Base64ToByteArray(aesIV));
                }

                textoEncriptado.Text = ByteConvert.ByteArrayToBase64(cyfrado);


                exportarEn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textoEncriptado.Text.Equals("") && !inputPrivada1.Text.Equals(""))
            {
                desencriptarBtn.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textplano.Text.Equals(""))
            {
                encriptarBtn.Enabled = false;

            }
            else
            {

                if ((comboBox2.Text.Equals("TDES") || comboBox2.Text.Equals("AES")) || comboBox2.Text.Equals("RSA") && !inputPrivada1.Text.Equals(""))
                {
                    encriptarBtn.Enabled = true;
                    desencriptarBtn.Enabled = true;
                }

            }
        }

        private void exportarEn_Click(object sender, EventArgs e)
        {
            if (!textoEncriptado.Text.Equals(""))
            {
                if (saveFileTxt.ShowDialog() == DialogResult.OK)
                {
                    FileReadWriteHandler.guardarTxt(textoEncriptado.Text, saveFileTxt.FileName);
                }
            }
        }
    }
}
