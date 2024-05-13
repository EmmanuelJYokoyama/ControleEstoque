
namespace ControleEstoque
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.nomeProd_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codProd_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qtdProd_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.marca_text = new System.Windows.Forms.TextBox();
            this.dado_label = new System.Windows.Forms.Label();
            this.dado1_text = new System.Windows.Forms.TextBox();
            this.dado2_label = new System.Windows.Forms.Label();
            this.dado2_text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.preco_text = new System.Windows.Forms.TextBox();
            this.cadastrar_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.forn_prod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(782, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(50, 696);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomeProd_text
            // 
            this.nomeProd_text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeProd_text.Location = new System.Drawing.Point(42, 162);
            this.nomeProd_text.Multiline = true;
            this.nomeProd_text.Name = "nomeProd_text";
            this.nomeProd_text.Size = new System.Drawing.Size(312, 35);
            this.nomeProd_text.TabIndex = 2;
            this.nomeProd_text.TextChanged += new System.EventHandler(this.nomeProd_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(42, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Produto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(415, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cód. Produto:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // codProd_text
            // 
            this.codProd_text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codProd_text.Location = new System.Drawing.Point(415, 162);
            this.codProd_text.Multiline = true;
            this.codProd_text.Name = "codProd_text";
            this.codProd_text.Size = new System.Drawing.Size(312, 35);
            this.codProd_text.TabIndex = 4;
            this.codProd_text.TextChanged += new System.EventHandler(this.codProd_text_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(42, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Qtd. Produto:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // qtdProd_text
            // 
            this.qtdProd_text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qtdProd_text.Location = new System.Drawing.Point(44, 238);
            this.qtdProd_text.Multiline = true;
            this.qtdProd_text.Name = "qtdProd_text";
            this.qtdProd_text.Size = new System.Drawing.Size(86, 35);
            this.qtdProd_text.TabIndex = 6;
            this.qtdProd_text.TextChanged += new System.EventHandler(this.qtdProd_text_TextChanged);
            this.qtdProd_text.Enter += new System.EventHandler(this.qtdProd_text_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(44, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Família:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(377, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(421, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "CADASTRO DE PRODUTO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(415, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Marca/Fabricante:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // marca_text
            // 
            this.marca_text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marca_text.Location = new System.Drawing.Point(415, 238);
            this.marca_text.Multiline = true;
            this.marca_text.Name = "marca_text";
            this.marca_text.Size = new System.Drawing.Size(312, 35);
            this.marca_text.TabIndex = 11;
            this.marca_text.TextChanged += new System.EventHandler(this.marca_text_TextChanged);
            // 
            // dado_label
            // 
            this.dado_label.AutoSize = true;
            this.dado_label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dado_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dado_label.Location = new System.Drawing.Point(44, 443);
            this.dado_label.Name = "dado_label";
            this.dado_label.Size = new System.Drawing.Size(37, 23);
            this.dado_label.TabIndex = 15;
            this.dado_label.Text = "d1";
            this.dado_label.Visible = false;
            this.dado_label.Click += new System.EventHandler(this.label8_Click);
            // 
            // dado1_text
            // 
            this.dado1_text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dado1_text.Location = new System.Drawing.Point(42, 469);
            this.dado1_text.Multiline = true;
            this.dado1_text.Name = "dado1_text";
            this.dado1_text.Size = new System.Drawing.Size(312, 35);
            this.dado1_text.TabIndex = 14;
            this.dado1_text.Visible = false;
            this.dado1_text.TextChanged += new System.EventHandler(this.dado1_text_TextChanged);
            // 
            // dado2_label
            // 
            this.dado2_label.AutoSize = true;
            this.dado2_label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dado2_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dado2_label.Location = new System.Drawing.Point(417, 443);
            this.dado2_label.Name = "dado2_label";
            this.dado2_label.Size = new System.Drawing.Size(177, 23);
            this.dado2_label.TabIndex = 17;
            this.dado2_label.Text = "Info. Adicional:";
            this.dado2_label.Visible = false;
            this.dado2_label.Click += new System.EventHandler(this.dado2_label_Click);
            // 
            // dado2_text
            // 
            this.dado2_text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dado2_text.Location = new System.Drawing.Point(417, 469);
            this.dado2_text.Multiline = true;
            this.dado2_text.Name = "dado2_text";
            this.dado2_text.Size = new System.Drawing.Size(312, 35);
            this.dado2_text.TabIndex = 16;
            this.dado2_text.Visible = false;
            this.dado2_text.TextChanged += new System.EventHandler(this.dado2_text_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(415, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Preço:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // preco_text
            // 
            this.preco_text.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.preco_text.Location = new System.Drawing.Point(415, 309);
            this.preco_text.Multiline = true;
            this.preco_text.Name = "preco_text";
            this.preco_text.Size = new System.Drawing.Size(312, 35);
            this.preco_text.TabIndex = 20;
            this.preco_text.Click += new System.EventHandler(this.preco_text_Click);
            this.preco_text.TextChanged += new System.EventHandler(this.preco_text_TextChanged);
            this.preco_text.Enter += new System.EventHandler(this.preco_text_Enter);
            this.preco_text.Leave += new System.EventHandler(this.preco_text_Leave);
            // 
            // cadastrar_btn
            // 
            this.cadastrar_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.cadastrar_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cadastrar_btn.Location = new System.Drawing.Point(446, 677);
            this.cadastrar_btn.Name = "cadastrar_btn";
            this.cadastrar_btn.Size = new System.Drawing.Size(236, 64);
            this.cadastrar_btn.TabIndex = 22;
            this.cadastrar_btn.Text = "Cadastrar";
            this.cadastrar_btn.UseVisualStyleBackColor = true;
            this.cadastrar_btn.Click += new System.EventHandler(this.cadastrar_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ALTO FALANTES",
            "ARMAZENAMENTO",
            "CABO",
            "FANS",
            "FONES",
            "FONTES",
            "GABINETES",
            "MEMORIA RAM",
            "MONITOR",
            "MOUSE",
            "MOUSEPADS",
            "NOTEBOOKS",
            "PLACA DE VIDEO",
            "PLACA MAE",
            "PROCESSADOR",
            "SMARTPHONES",
            "TECLADO",
            "VIDEOGAMES",
            "WEBCAM",
            "OUTROS"});
            this.comboBox1.Location = new System.Drawing.Point(44, 311);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 33);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(42, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Data Recebimento:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(44, 391);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 33);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // forn_prod
            // 
            this.forn_prod.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forn_prod.Location = new System.Drawing.Point(417, 389);
            this.forn_prod.Multiline = true;
            this.forn_prod.Name = "forn_prod";
            this.forn_prod.Size = new System.Drawing.Size(312, 35);
            this.forn_prod.TabIndex = 28;
            this.forn_prod.TextChanged += new System.EventHandler(this.forn_prod_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(417, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "Fornecedor:";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1220, 775);
            this.Controls.Add(this.forn_prod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cadastrar_btn);
            this.Controls.Add(this.preco_text);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dado2_label);
            this.Controls.Add(this.dado2_text);
            this.Controls.Add(this.dado_label);
            this.Controls.Add(this.dado1_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.marca_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qtdProd_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codProd_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeProd_text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nomeProd_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codProd_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qtdProd_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox marca_text;
        private System.Windows.Forms.Label dado_label;
        private System.Windows.Forms.TextBox dado1_text;
        private System.Windows.Forms.Label dado2_label;
        private System.Windows.Forms.TextBox dado2_text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox preco_text;
        private System.Windows.Forms.Button cadastrar_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox forn_prod;
        private System.Windows.Forms.Label label8;
    }
}