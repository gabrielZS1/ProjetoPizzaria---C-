namespace ProjetoPizzaria
{
    partial class Form1
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
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.chkTitulo = new System.Windows.Forms.CheckBox();
            this.dgvTitulo = new System.Windows.Forms.DataGridView();
            this.cnbTitulo = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblValorDaPizza = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtValorPizza = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(926, 299);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisar.TabIndex = 1;
            // 
            // chkTitulo
            // 
            this.chkTitulo.AutoSize = true;
            this.chkTitulo.Location = new System.Drawing.Point(19, 101);
            this.chkTitulo.Name = "chkTitulo";
            this.chkTitulo.Size = new System.Drawing.Size(108, 17);
            this.chkTitulo.TabIndex = 3;
            this.chkTitulo.Text = "Tempero do Chef";
            this.chkTitulo.UseVisualStyleBackColor = true;
            // 
            // dgvTitulo
            // 
            this.dgvTitulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitulo.Location = new System.Drawing.Point(179, 370);
            this.dgvTitulo.Name = "dgvTitulo";
            this.dgvTitulo.Size = new System.Drawing.Size(945, 194);
            this.dgvTitulo.TabIndex = 4;
            // 
            // cnbTitulo
            // 
            this.cnbTitulo.FormattingEnabled = true;
            this.cnbTitulo.Location = new System.Drawing.Point(214, 83);
            this.cnbTitulo.Name = "cnbTitulo";
            this.cnbTitulo.Size = new System.Drawing.Size(121, 21);
            this.cnbTitulo.TabIndex = 5;
            this.cnbTitulo.Text = "Escolha uma opção";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(322, 591);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(84, 40);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Cebola sem choro";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(19, 32);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(107, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Borda Recheada";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(19, 78);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(102, 17);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Catupiry Original";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(867, 67);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(130, 13);
            this.lblValor.TabIndex = 17;
            this.lblValor.Text = "VALOR DOS OPCIONAIS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // lblValorDaPizza
            // 
            this.lblValorDaPizza.AutoSize = true;
            this.lblValorDaPizza.Location = new System.Drawing.Point(709, 72);
            this.lblValorDaPizza.Name = "lblValorDaPizza";
            this.lblValorDaPizza.Size = new System.Drawing.Size(95, 13);
            this.lblValorDaPizza.TabIndex = 20;
            this.lblValorDaPizza.Text = "VALOR DA PIZZA";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1032, 64);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 13);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "TOTAL A PAGAR";
            // 
            // txtValorPizza
            // 
            this.txtValorPizza.Location = new System.Drawing.Point(696, 94);
            this.txtValorPizza.Name = "txtValorPizza";
            this.txtValorPizza.Size = new System.Drawing.Size(121, 20);
            this.txtValorPizza.TabIndex = 23;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(818, 302);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(69, 13);
            this.lblPesquisar.TabIndex = 25;
            this.lblPesquisar.Text = "PESQUISAR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.chkTitulo);
            this.groupBox1.Location = new System.Drawing.Point(160, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 130);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha Opcionais";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(509, 591);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 40);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(733, 591);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(84, 40);
            this.btnCalcular.TabIndex = 28;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Location = new System.Drawing.Point(926, 591);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(84, 40);
            this.btnSair.TabIndex = 29;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(870, 94);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 30;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1018, 94);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 660);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtValorPizza);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblValorDaPizza);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.cnbTitulo);
            this.Controls.Add(this.dgvTitulo);
            this.Controls.Add(this.txtPesquisar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.CheckBox chkTitulo;
        private System.Windows.Forms.DataGridView dgvTitulo;
        private System.Windows.Forms.ComboBox cnbTitulo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblValorDaPizza;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtValorPizza;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

