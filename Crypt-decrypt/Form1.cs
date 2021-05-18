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
    public partial class Form1dfgdfg : Form
    {


        public Form1dfgdfg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] cyfradoDesdeBase64 = ByteConverter.Base64ToByteArray(textoEncriptado.Text);
                string desifrado = TDES.decrypt_TDES(cyfradoDesdeBase64, ByteConverter.StringToByteArray(inputPrivada1.Text), ByteConverter.StringToByteArray(inputPrivada1.Text));
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
                FileReadWriteHandler.exportarXml(comboBox2.Text, inputPrivada1.Text, inputPublica1.Text, saveFileXml.FileName);
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



        private void importarTextoBtn_Click(object sender, EventArgs e)
        {
            if (openFileTxt.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // LLenar el texto obtenido a el text area
                    string text = System.IO.File.ReadAllText(openFileTxt.FileName);
                    text = ByteConverter.Base64Decode(text);
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




            inputPublica1.Visible = false;


            if (!(comboBox2.Text.Equals("TDES") || comboBox2.Text.Equals("AES")))
            {
                comboBox2.Text = "";

            }
            else
            {
                if (!comboBox2.Text.Equals("TDES"))
                {

                    inputPublica1.Visible = true;
                    inputPrivada1.Visible = true;
                }


                inputPublica1.Text = "";
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
                inputPrivada1.Text = ByteConverter.ByteArrayToHexString(TDES.generateKey());
            }
            else
            {
                inputPrivada1.Text = ByteConverter.ByteArrayToHexString(TDES.generateKey());
                inputPublica1.Text = RandomGenerator.RandomHex(new Random(Environment.TickCount + 15));
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
                byte[] cyfrado = TDES.encrypt_TDES(textplano.Text, ByteConverter.StringToByteArray(inputPrivada1.Text), ByteConverter.StringToByteArray(inputPrivada1.Text));

                textoEncriptado.Text = ByteConverter.ByteArrayToBase64(cyfrado);

          



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

                if ((comboBox2.Text.Equals("TDES") || comboBox2.Text.Equals("AES")) && !inputPrivada1.Text.Equals(""))
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
                    FileReadWriteHandler.guardarTxt(ByteConverter.Base64Encode(textoEncriptado.Text), saveFileTxt.FileName);
                }
            }
        }
    }
}
