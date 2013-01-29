namespace SystemFunilaria
{
    partial class Lista_Veiculos
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
            this.bt_Adicionar = new System.Windows.Forms.Button();
            this.bt_Alterar = new System.Windows.Forms.Button();
            this.bt_Remover = new System.Windows.Forms.Button();
            this.groupBox_filtroVeiculo = new System.Windows.Forms.GroupBox();
            this.checkBox_Ano = new System.Windows.Forms.CheckBox();
            this.checkBox_Tipo = new System.Windows.Forms.CheckBox();
            this.chekbox_Marca = new System.Windows.Forms.CheckBox();
            this.txt_Ano = new System.Windows.Forms.TextBox();
            this.cbx_Marca = new System.Windows.Forms.ComboBox();
            this.txt_Tipo = new System.Windows.Forms.TextBox();
            this.listView_Veiculos = new System.Windows.Forms.ListView();
            this.groupBox_pesquisaPlaca = new System.Windows.Forms.GroupBox();
            this.txt_Placa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox_filtroVeiculo.SuspendLayout();
            this.groupBox_pesquisaPlaca.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Adicionar
            // 
            this.bt_Adicionar.Location = new System.Drawing.Point(716, 483);
            this.bt_Adicionar.Name = "bt_Adicionar";
            this.bt_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.bt_Adicionar.TabIndex = 17;
            this.bt_Adicionar.Text = "Adicionar";
            this.bt_Adicionar.UseVisualStyleBackColor = true;
            this.bt_Adicionar.Click += new System.EventHandler(this.bt_Adicionar_Click);
            // 
            // bt_Alterar
            // 
            this.bt_Alterar.Location = new System.Drawing.Point(635, 483);
            this.bt_Alterar.Name = "bt_Alterar";
            this.bt_Alterar.Size = new System.Drawing.Size(75, 23);
            this.bt_Alterar.TabIndex = 16;
            this.bt_Alterar.Text = "Alterar";
            this.bt_Alterar.UseVisualStyleBackColor = true;
            // 
            // bt_Remover
            // 
            this.bt_Remover.Location = new System.Drawing.Point(554, 483);
            this.bt_Remover.Name = "bt_Remover";
            this.bt_Remover.Size = new System.Drawing.Size(75, 23);
            this.bt_Remover.TabIndex = 15;
            this.bt_Remover.Text = "Remover";
            this.bt_Remover.UseVisualStyleBackColor = true;
            this.bt_Remover.Click += new System.EventHandler(this.bt_Remover_Click);
            // 
            // groupBox_filtroVeiculo
            // 
            this.groupBox_filtroVeiculo.Controls.Add(this.checkBox_Ano);
            this.groupBox_filtroVeiculo.Controls.Add(this.checkBox_Tipo);
            this.groupBox_filtroVeiculo.Controls.Add(this.chekbox_Marca);
            this.groupBox_filtroVeiculo.Controls.Add(this.txt_Ano);
            this.groupBox_filtroVeiculo.Controls.Add(this.cbx_Marca);
            this.groupBox_filtroVeiculo.Controls.Add(this.txt_Tipo);
            this.groupBox_filtroVeiculo.Location = new System.Drawing.Point(163, 12);
            this.groupBox_filtroVeiculo.Name = "groupBox_filtroVeiculo";
            this.groupBox_filtroVeiculo.Size = new System.Drawing.Size(626, 65);
            this.groupBox_filtroVeiculo.TabIndex = 13;
            this.groupBox_filtroVeiculo.TabStop = false;
            this.groupBox_filtroVeiculo.Text = "FILTRO";
            // 
            // checkBox_Ano
            // 
            this.checkBox_Ano.AutoSize = true;
            this.checkBox_Ano.Location = new System.Drawing.Point(576, 13);
            this.checkBox_Ano.Name = "checkBox_Ano";
            this.checkBox_Ano.Size = new System.Drawing.Size(45, 17);
            this.checkBox_Ano.TabIndex = 10;
            this.checkBox_Ano.Text = "Ano";
            this.checkBox_Ano.UseVisualStyleBackColor = true;
            // 
            // checkBox_Tipo
            // 
            this.checkBox_Tipo.AutoSize = true;
            this.checkBox_Tipo.Location = new System.Drawing.Point(217, 13);
            this.checkBox_Tipo.Name = "checkBox_Tipo";
            this.checkBox_Tipo.Size = new System.Drawing.Size(47, 17);
            this.checkBox_Tipo.TabIndex = 9;
            this.checkBox_Tipo.Text = "Tipo";
            this.checkBox_Tipo.UseVisualStyleBackColor = true;
            // 
            // chekbox_Marca
            // 
            this.chekbox_Marca.AutoSize = true;
            this.chekbox_Marca.Location = new System.Drawing.Point(9, 13);
            this.chekbox_Marca.Name = "chekbox_Marca";
            this.chekbox_Marca.Size = new System.Drawing.Size(56, 17);
            this.chekbox_Marca.TabIndex = 8;
            this.chekbox_Marca.Text = "Marca";
            this.chekbox_Marca.UseVisualStyleBackColor = true;
            // 
            // txt_Ano
            // 
            this.txt_Ano.Location = new System.Drawing.Point(576, 32);
            this.txt_Ano.Name = "txt_Ano";
            this.txt_Ano.Size = new System.Drawing.Size(44, 20);
            this.txt_Ano.TabIndex = 4;
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
            this.cbx_Marca.Location = new System.Drawing.Point(9, 32);
            this.cbx_Marca.Name = "cbx_Marca";
            this.cbx_Marca.Size = new System.Drawing.Size(202, 21);
            this.cbx_Marca.TabIndex = 2;
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.Location = new System.Drawing.Point(217, 33);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Size = new System.Drawing.Size(353, 20);
            this.txt_Tipo.TabIndex = 1;
            // 
            // listView_Veiculos
            // 
            this.listView_Veiculos.Location = new System.Drawing.Point(12, 83);
            this.listView_Veiculos.Name = "listView_Veiculos";
            this.listView_Veiculos.Size = new System.Drawing.Size(777, 394);
            this.listView_Veiculos.TabIndex = 12;
            this.listView_Veiculos.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox_pesquisaPlaca
            // 
            this.groupBox_pesquisaPlaca.Controls.Add(this.txt_Placa);
            this.groupBox_pesquisaPlaca.Controls.Add(this.label1);
            this.groupBox_pesquisaPlaca.Controls.Add(this.textBox5);
            this.groupBox_pesquisaPlaca.Controls.Add(this.label6);
            this.groupBox_pesquisaPlaca.Controls.Add(this.textBox6);
            this.groupBox_pesquisaPlaca.Location = new System.Drawing.Point(12, 12);
            this.groupBox_pesquisaPlaca.Name = "groupBox_pesquisaPlaca";
            this.groupBox_pesquisaPlaca.Size = new System.Drawing.Size(145, 65);
            this.groupBox_pesquisaPlaca.TabIndex = 14;
            this.groupBox_pesquisaPlaca.TabStop = false;
            this.groupBox_pesquisaPlaca.Text = "PLACA";
            // 
            // txt_Placa
            // 
            this.txt_Placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Placa.Location = new System.Drawing.Point(6, 16);
            this.txt_Placa.Name = "txt_Placa";
            this.txt_Placa.Size = new System.Drawing.Size(130, 40);
            this.txt_Placa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(594, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cor";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(597, 33);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(213, 20);
            this.textBox5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(544, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ano";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(547, 33);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(44, 20);
            this.textBox6.TabIndex = 4;
            // 
            // Lista_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 513);
            this.Controls.Add(this.bt_Adicionar);
            this.Controls.Add(this.bt_Alterar);
            this.Controls.Add(this.bt_Remover);
            this.Controls.Add(this.groupBox_filtroVeiculo);
            this.Controls.Add(this.listView_Veiculos);
            this.Controls.Add(this.groupBox_pesquisaPlaca);
            this.Name = "Lista_Veiculos";
            this.Text = "Lista_Veiculos";
            this.Load += new System.EventHandler(this.Lista_Veiculos_Load);
            this.groupBox_filtroVeiculo.ResumeLayout(false);
            this.groupBox_filtroVeiculo.PerformLayout();
            this.groupBox_pesquisaPlaca.ResumeLayout(false);
            this.groupBox_pesquisaPlaca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Adicionar;
        private System.Windows.Forms.Button bt_Alterar;
        private System.Windows.Forms.Button bt_Remover;
        private System.Windows.Forms.GroupBox groupBox_filtroVeiculo;
        private System.Windows.Forms.CheckBox checkBox_Ano;
        private System.Windows.Forms.CheckBox checkBox_Tipo;
        private System.Windows.Forms.CheckBox chekbox_Marca;
        private System.Windows.Forms.TextBox txt_Ano;
        private System.Windows.Forms.ComboBox cbx_Marca;
        private System.Windows.Forms.TextBox txt_Tipo;
        private System.Windows.Forms.ListView listView_Veiculos;
        private System.Windows.Forms.GroupBox groupBox_pesquisaPlaca;
        private System.Windows.Forms.TextBox txt_Placa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
    }
}