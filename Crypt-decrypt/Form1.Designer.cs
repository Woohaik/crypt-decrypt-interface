﻿namespace Crypt_decrypt
{
    partial class Form1dfgdfg
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.encriptarBtn = new System.Windows.Forms.Button();
            this.desencriptarBtn = new System.Windows.Forms.Button();
            this.importarTextoBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.crearClavesBtn = new System.Windows.Forms.Button();
            this.importarClavesBtn = new System.Windows.Forms.Button();
            this.exportarClavesBtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.openFileXml = new System.Windows.Forms.OpenFileDialog();
            this.openFileTxt = new System.Windows.Forms.OpenFileDialog();
            this.saveFileXml = new System.Windows.Forms.SaveFileDialog();
            this.saveFileTxt = new System.Windows.Forms.SaveFileDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encriptarBtn
            // 
            this.encriptarBtn.Enabled = false;
            this.encriptarBtn.Location = new System.Drawing.Point(355, 197);
            this.encriptarBtn.Name = "encriptarBtn";
            this.encriptarBtn.Size = new System.Drawing.Size(85, 28);
            this.encriptarBtn.TabIndex = 0;
            this.encriptarBtn.Text = "Encriptar";
            this.encriptarBtn.UseVisualStyleBackColor = true;
            this.encriptarBtn.Click += new System.EventHandler(this.encriptarBtn_Click);
            // 
            // desencriptarBtn
            // 
            this.desencriptarBtn.Enabled = false;
            this.desencriptarBtn.Location = new System.Drawing.Point(834, 197);
            this.desencriptarBtn.Name = "desencriptarBtn";
            this.desencriptarBtn.Size = new System.Drawing.Size(81, 29);
            this.desencriptarBtn.TabIndex = 1;
            this.desencriptarBtn.Text = "Desencriptar";
            this.desencriptarBtn.UseVisualStyleBackColor = true;
            this.desencriptarBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // importarTextoBtn
            // 
            this.importarTextoBtn.Location = new System.Drawing.Point(472, 186);
            this.importarTextoBtn.Name = "importarTextoBtn";
            this.importarTextoBtn.Size = new System.Drawing.Size(157, 23);
            this.importarTextoBtn.TabIndex = 2;
            this.importarTextoBtn.Text = "Importar Texto";
            this.importarTextoBtn.UseVisualStyleBackColor = true;
            this.importarTextoBtn.Click += new System.EventHandler(this.importarTextoBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(472, 231);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(443, 210);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // crearClavesBtn
            // 
            this.crearClavesBtn.Enabled = false;
            this.crearClavesBtn.Location = new System.Drawing.Point(355, 61);
            this.crearClavesBtn.Name = "crearClavesBtn";
            this.crearClavesBtn.Size = new System.Drawing.Size(102, 47);
            this.crearClavesBtn.TabIndex = 4;
            this.crearClavesBtn.Text = "Generar Claves";
            this.crearClavesBtn.UseVisualStyleBackColor = true;
            this.crearClavesBtn.Click += new System.EventHandler(this.crearClavesBtn_Click);
            // 
            // importarClavesBtn
            // 
            this.importarClavesBtn.Enabled = false;
            this.importarClavesBtn.Location = new System.Drawing.Point(676, 12);
            this.importarClavesBtn.Name = "importarClavesBtn";
            this.importarClavesBtn.Size = new System.Drawing.Size(109, 34);
            this.importarClavesBtn.TabIndex = 5;
            this.importarClavesBtn.Text = "Importar Claves";
            this.importarClavesBtn.UseVisualStyleBackColor = true;
            this.importarClavesBtn.Click += new System.EventHandler(this.importarClavesBtn_Click);
            // 
            // exportarClavesBtn
            // 
            this.exportarClavesBtn.Enabled = false;
            this.exportarClavesBtn.Location = new System.Drawing.Point(800, 12);
            this.exportarClavesBtn.Name = "exportarClavesBtn";
            this.exportarClavesBtn.Size = new System.Drawing.Size(115, 34);
            this.exportarClavesBtn.TabIndex = 6;
            this.exportarClavesBtn.Text = "Exportar Claves";
            this.exportarClavesBtn.UseVisualStyleBackColor = true;
            this.exportarClavesBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "TDES",
            "AES"});
            this.comboBox2.Location = new System.Drawing.Point(97, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "Selecciona algoritmo";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // openFileXml
            // 
            this.openFileXml.FileName = "openFileXml";
            this.openFileXml.Filter = " (*.xml)|*.xml";
            this.openFileXml.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileXml_FileOk);
            // 
            // openFileTxt
            // 
            this.openFileTxt.FileName = "openFileTxt";
            this.openFileTxt.Filter = " (*.txt)|*.txt";
            // 
            // saveFileXml
            // 
            this.saveFileXml.Filter = " (*.xml)|*.xml";
            this.saveFileXml.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileXml_FileOk);
            // 
            // saveFileTxt
            // 
            this.saveFileTxt.Filter = " (*.txt)|*.txt";
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.Location = new System.Drawing.Point(12, 231);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(428, 210);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Texto Plano:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Texto Encriptado:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 88);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(237, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(97, 114);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(237, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(97, 61);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(237, 20);
            this.textBox6.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Clave Publica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Clave Privada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Clave Privada 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Clave Privada 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-12, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1015, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_______";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "ALGORITMO:";
            // 
            // Form1dfgdfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 456);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.exportarClavesBtn);
            this.Controls.Add(this.importarClavesBtn);
            this.Controls.Add(this.crearClavesBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.importarTextoBtn);
            this.Controls.Add(this.desencriptarBtn);
            this.Controls.Add(this.encriptarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1dfgdfg";
            this.Text = " INTERFAZ DE ENCRIPTACIÓN-DESENCRITACIÓN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encriptarBtn;
        private System.Windows.Forms.Button desencriptarBtn;
        private System.Windows.Forms.Button importarTextoBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button crearClavesBtn;
        private System.Windows.Forms.Button importarClavesBtn;
        private System.Windows.Forms.Button exportarClavesBtn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.OpenFileDialog openFileXml;
        private System.Windows.Forms.OpenFileDialog openFileTxt;
        private System.Windows.Forms.SaveFileDialog saveFileXml;
        private System.Windows.Forms.SaveFileDialog saveFileTxt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

