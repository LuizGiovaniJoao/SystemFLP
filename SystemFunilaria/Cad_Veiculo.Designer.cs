namespace SystemFunilaria
{
    partial class Cad_Veiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Pesquisar = new System.Windows.Forms.Button();
            this.txt_Proprietario = new System.Windows.Forms.TextBox();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Gravar = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.label_OBS = new System.Windows.Forms.Label();
            this.txt_OBS = new System.Windows.Forms.TextBox();
            this.txt_Cor = new System.Windows.Forms.TextBox();
            this.label_Cor = new System.Windows.Forms.Label();
            this.cbx_Marca = new System.Windows.Forms.ComboBox();
            this.label8_Marca = new System.Windows.Forms.Label();
            this.label_Ano = new System.Windows.Forms.Label();
            this.label_Chassis = new System.Windows.Forms.Label();
            this.label_Tipo = new System.Windows.Forms.Label();
            this.label_Placa = new System.Windows.Forms.Label();
            this.txt_Ano = new System.Windows.Forms.TextBox();
            this.txt_Chassis = new System.Windows.Forms.TextBox();
            this.txt_Tipo = new System.Windows.Forms.TextBox();
            this.txt_Placa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Propriétário";
            // 
            // bt_Pesquisar
            // 
            this.bt_Pesquisar.Location = new System.Drawing.Point(430, 140);
            this.bt_Pesquisar.Name = "bt_Pesquisar";
            this.bt_Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.bt_Pesquisar.TabIndex = 8;
            this.bt_Pesquisar.Text = "Pesquisar";
            this.bt_Pesquisar.UseVisualStyleBackColor = true;
            this.bt_Pesquisar.Click += new System.EventHandler(this.bt_Pesquisar_Click);
            // 
            // txt_Proprietario
            // 
            this.txt_Proprietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Proprietario.Location = new System.Drawing.Point(15, 142);
            this.txt_Proprietario.Name = "txt_Proprietario";
            this.txt_Proprietario.Size = new System.Drawing.Size(409, 20);
            this.txt_Proprietario.TabIndex = 7;
            this.txt_Proprietario.Enter += new System.EventHandler(this.txt_Proprietario_Enter);
            this.txt_Proprietario.Leave += new System.EventHandler(this.txt_Proprietario_Leave);
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.Location = new System.Drawing.Point(430, 338);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.bt_Cadastrar.TabIndex = 12;
            this.bt_Cadastrar.Text = "Cadastrar";
            this.bt_Cadastrar.UseVisualStyleBackColor = true;
            this.bt_Cadastrar.Click += new System.EventHandler(this.bt_Cadastrar_Click);
            // 
            // bt_Gravar
            // 
            this.bt_Gravar.Location = new System.Drawing.Point(349, 338);
            this.bt_Gravar.Name = "bt_Gravar";
            this.bt_Gravar.Size = new System.Drawing.Size(75, 23);
            this.bt_Gravar.TabIndex = 11;
            this.bt_Gravar.Text = "Gravar";
            this.bt_Gravar.UseVisualStyleBackColor = true;
            this.bt_Gravar.Click += new System.EventHandler(this.bt_Gravar_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Location = new System.Drawing.Point(268, 338);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(75, 23);
            this.bt_Limpar.TabIndex = 10;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            // 
            // label_OBS
            // 
            this.label_OBS.AutoSize = true;
            this.label_OBS.Location = new System.Drawing.Point(12, 165);
            this.label_OBS.Name = "label_OBS";
            this.label_OBS.Size = new System.Drawing.Size(32, 13);
            this.label_OBS.TabIndex = 32;
            this.label_OBS.Text = "OBS:";
            // 
            // txt_OBS
            // 
            this.txt_OBS.Location = new System.Drawing.Point(15, 181);
            this.txt_OBS.Multiline = true;
            this.txt_OBS.Name = "txt_OBS";
            this.txt_OBS.Size = new System.Drawing.Size(490, 151);
            this.txt_OBS.TabIndex = 9;
            this.txt_OBS.Enter += new System.EventHandler(this.txt_Proprietario_Enter);
            this.txt_OBS.Leave += new System.EventHandler(this.txt_Proprietario_Leave);
            // 
            // txt_Cor
            // 
            this.txt_Cor.Location = new System.Drawing.Point(74, 103);
            this.txt_Cor.Name = "txt_Cor";
            this.txt_Cor.Size = new System.Drawing.Size(431, 20);
            this.txt_Cor.TabIndex = 6;
            this.txt_Cor.Enter += new System.EventHandler(this.txt_Proprietario_Enter);
            this.txt_Cor.Leave += new System.EventHandler(this.txt_Proprietario_Leave);
            // 
            // label_Cor
            // 
            this.label_Cor.AutoSize = true;
            this.label_Cor.Location = new System.Drawing.Point(72, 87);
            this.label_Cor.Name = "label_Cor";
            this.label_Cor.Size = new System.Drawing.Size(23, 13);
            this.label_Cor.TabIndex = 53;
            this.label_Cor.Text = "Cor";
            // 
            // cbx_Marca
            // 
            this.cbx_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Marca.FormattingEnabled = true;
            this.cbx_Marca.Items.AddRange(new object[] {
            "Agrale",
            "Alfa",
            "Romeo",
            "Audi",
            "BMW",
            "Cadillac",
            "CBT",
            "Chevrolet",
            "Citroën",
            "Dodge",
            "Ferrari",
            "Fiat",
            "Ford",
            "Honda",
            "Hyundai",
            "Jaguar",
            "KIA",
            "Lamborghini",
            "Mazda",
            "Mercedes Benz",
            "Mitsubishi",
            "Nissan",
            "Peugeot",
            "Renault",
            "Toyota",
            "Volkswagen"});
            this.cbx_Marca.Location = new System.Drawing.Point(252, 24);
            this.cbx_Marca.Name = "cbx_Marca";
            this.cbx_Marca.Size = new System.Drawing.Size(253, 21);
            this.cbx_Marca.TabIndex = 3;
            // 
            // label8_Marca
            // 
            this.label8_Marca.AutoSize = true;
            this.label8_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8_Marca.Location = new System.Drawing.Point(249, 8);
            this.label8_Marca.Name = "label8_Marca";
            this.label8_Marca.Size = new System.Drawing.Size(37, 13);
            this.label8_Marca.TabIndex = 51;
            this.label8_Marca.Text = "Marca";
            // 
            // label_Ano
            // 
            this.label_Ano.AutoSize = true;
            this.label_Ano.Location = new System.Drawing.Point(12, 87);
            this.label_Ano.Name = "label_Ano";
            this.label_Ano.Size = new System.Drawing.Size(26, 13);
            this.label_Ano.TabIndex = 50;
            this.label_Ano.Text = "Ano";
            // 
            // label_Chassis
            // 
            this.label_Chassis.AutoSize = true;
            this.label_Chassis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_Chassis.Location = new System.Drawing.Point(87, 8);
            this.label_Chassis.Name = "label_Chassis";
            this.label_Chassis.Size = new System.Drawing.Size(43, 13);
            this.label_Chassis.TabIndex = 49;
            this.label_Chassis.Text = "Chassis";
            // 
            // label_Tipo
            // 
            this.label_Tipo.AutoSize = true;
            this.label_Tipo.Location = new System.Drawing.Point(12, 48);
            this.label_Tipo.Name = "label_Tipo";
            this.label_Tipo.Size = new System.Drawing.Size(28, 13);
            this.label_Tipo.TabIndex = 48;
            this.label_Tipo.Text = "Tipo";
            // 
            // label_Placa
            // 
            this.label_Placa.AutoSize = true;
            this.label_Placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_Placa.Location = new System.Drawing.Point(12, 9);
            this.label_Placa.Name = "label_Placa";
            this.label_Placa.Size = new System.Drawing.Size(34, 13);
            this.label_Placa.TabIndex = 47;
            this.label_Placa.Text = "Placa";
            // 
            // txt_Ano
            // 
            this.txt_Ano.Location = new System.Drawing.Point(15, 103);
            this.txt_Ano.Name = "txt_Ano";
            this.txt_Ano.Size = new System.Drawing.Size(53, 20);
            this.txt_Ano.TabIndex = 5;
            this.txt_Ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Ano.Enter += new System.EventHandler(this.txt_Proprietario_Enter);
            this.txt_Ano.Leave += new System.EventHandler(this.txt_Proprietario_Leave);
            // 
            // txt_Chassis
            // 
            this.txt_Chassis.Location = new System.Drawing.Point(90, 25);
            this.txt_Chassis.MaxLength = 17;
            this.txt_Chassis.Name = "txt_Chassis";
            this.txt_Chassis.Size = new System.Drawing.Size(156, 20);
            this.txt_Chassis.TabIndex = 2;
            this.txt_Chassis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Chassis.Enter += new System.EventHandler(this.txt_Proprietario_Enter);
            this.txt_Chassis.Leave += new System.EventHandler(this.txt_Proprietario_Leave);
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.Location = new System.Drawing.Point(15, 64);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Size = new System.Drawing.Size(490, 20);
            this.txt_Tipo.TabIndex = 4;
            this.txt_Tipo.Enter += new System.EventHandler(this.txt_Proprietario_Enter);
            this.txt_Tipo.Leave += new System.EventHandler(this.txt_Proprietario_Leave);
            // 
            // txt_Placa
            // 
            this.txt_Placa.BackColor = System.Drawing.Color.Bisque;
            this.txt_Placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Placa.Location = new System.Drawing.Point(15, 25);
            this.txt_Placa.MaxLength = 7;
            this.txt_Placa.Name = "txt_Placa";
            this.txt_Placa.Size = new System.Drawing.Size(69, 20);
            this.txt_Placa.TabIndex = 1;
            this.txt_Placa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cad_Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 370);
            this.Controls.Add(this.txt_Cor);
            this.Controls.Add(this.label_Cor);
            this.Controls.Add(this.cbx_Marca);
            this.Controls.Add(this.label8_Marca);
            this.Controls.Add(this.label_Ano);
            this.Controls.Add(this.label_Chassis);
            this.Controls.Add(this.label_Tipo);
            this.Controls.Add(this.label_Placa);
            this.Controls.Add(this.txt_Ano);
            this.Controls.Add(this.txt_Chassis);
            this.Controls.Add(this.txt_Tipo);
            this.Controls.Add(this.txt_Placa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Pesquisar);
            this.Controls.Add(this.txt_Proprietario);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.bt_Gravar);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.label_OBS);
            this.Controls.Add(this.txt_OBS);
            this.Name = "Cad_Veiculo";
            this.Text = "Cad_Veiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Pesquisar;
        private System.Windows.Forms.TextBox txt_Proprietario;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Gravar;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.Label label_OBS;
        private System.Windows.Forms.TextBox txt_OBS;
        private System.Windows.Forms.TextBox txt_Cor;
        private System.Windows.Forms.Label label_Cor;
        private System.Windows.Forms.ComboBox cbx_Marca;
        private System.Windows.Forms.Label label8_Marca;
        private System.Windows.Forms.Label label_Ano;
        private System.Windows.Forms.Label label_Chassis;
        private System.Windows.Forms.Label label_Tipo;
        private System.Windows.Forms.Label label_Placa;
        private System.Windows.Forms.TextBox txt_Ano;
        private System.Windows.Forms.TextBox txt_Chassis;
        private System.Windows.Forms.TextBox txt_Tipo;
        private System.Windows.Forms.TextBox txt_Placa;
    }
}