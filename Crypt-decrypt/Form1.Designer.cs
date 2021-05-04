namespace Crypt_decrypt
{
    partial class Form1
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
            this.verClavesBtn = new System.Windows.Forms.Button();
            this.openFileXml = new System.Windows.Forms.OpenFileDialog();
            this.openFileTxt = new System.Windows.Forms.OpenFileDialog();
            this.saveFileXml = new System.Windows.Forms.SaveFileDialog();
            this.saveFileTxt = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // encriptarBtn
            // 
            this.encriptarBtn.Enabled = false;
            this.encriptarBtn.Location = new System.Drawing.Point(468, 309);
            this.encriptarBtn.Name = "encriptarBtn";
            this.encriptarBtn.Size = new System.Drawing.Size(85, 35);
            this.encriptarBtn.TabIndex = 0;
            this.encriptarBtn.Text = "Encriptar";
            this.encriptarBtn.UseVisualStyleBackColor = true;
            this.encriptarBtn.Click += new System.EventHandler(this.encriptarBtn_Click);
            // 
            // desencriptarBtn
            // 
            this.desencriptarBtn.Enabled = false;
            this.desencriptarBtn.Location = new System.Drawing.Point(365, 309);
            this.desencriptarBtn.Name = "desencriptarBtn";
            this.desencriptarBtn.Size = new System.Drawing.Size(81, 36);
            this.desencriptarBtn.TabIndex = 1;
            this.desencriptarBtn.Text = "Desencriptar";
            this.desencriptarBtn.UseVisualStyleBackColor = true;
            this.desencriptarBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // importarTextoBtn
            // 
            this.importarTextoBtn.Location = new System.Drawing.Point(12, 79);
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
            this.textBox1.Location = new System.Drawing.Point(12, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(541, 176);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // crearClavesBtn
            // 
            this.crearClavesBtn.Enabled = false;
            this.crearClavesBtn.Location = new System.Drawing.Point(232, 12);
            this.crearClavesBtn.Name = "crearClavesBtn";
            this.crearClavesBtn.Size = new System.Drawing.Size(90, 34);
            this.crearClavesBtn.TabIndex = 4;
            this.crearClavesBtn.Text = "Crear Claves";
            this.crearClavesBtn.UseVisualStyleBackColor = true;
            this.crearClavesBtn.Click += new System.EventHandler(this.crearClavesBtn_Click);
            // 
            // importarClavesBtn
            // 
            this.importarClavesBtn.Enabled = false;
            this.importarClavesBtn.Location = new System.Drawing.Point(328, 12);
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
            this.exportarClavesBtn.Location = new System.Drawing.Point(443, 12);
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
            this.comboBox2.Location = new System.Drawing.Point(12, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.Text = "Selecciona algoritmo";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // verClavesBtn
            // 
            this.verClavesBtn.Location = new System.Drawing.Point(449, 79);
            this.verClavesBtn.Name = "verClavesBtn";
            this.verClavesBtn.Size = new System.Drawing.Size(109, 23);
            this.verClavesBtn.TabIndex = 9;
            this.verClavesBtn.Text = "Ver Claves";
            this.verClavesBtn.UseVisualStyleBackColor = true;
            this.verClavesBtn.Click += new System.EventHandler(this.verClavesBtn_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 356);
            this.Controls.Add(this.verClavesBtn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.exportarClavesBtn);
            this.Controls.Add(this.importarClavesBtn);
            this.Controls.Add(this.crearClavesBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.importarTextoBtn);
            this.Controls.Add(this.desencriptarBtn);
            this.Controls.Add(this.encriptarBtn);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button verClavesBtn;
        private System.Windows.Forms.OpenFileDialog openFileXml;
        private System.Windows.Forms.OpenFileDialog openFileTxt;
        private System.Windows.Forms.SaveFileDialog saveFileXml;
        private System.Windows.Forms.SaveFileDialog saveFileTxt;
    }
}

