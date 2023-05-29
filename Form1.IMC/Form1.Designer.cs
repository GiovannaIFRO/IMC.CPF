namespace Form1.IMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nm_altura = new System.Windows.Forms.NumericUpDown();
            this.nm_idade = new System.Windows.Forms.NumericUpDown();
            this.nm_peso = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.lb_resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nm_altura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_idade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_peso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(722, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "idade.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "nome.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "altura.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(346, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "peso.:";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(158, 190);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(297, 22);
            this.tx_nome.TabIndex = 5;
            this.tx_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mask_cpf
            // 
            this.mask_cpf.Location = new System.Drawing.Point(546, 193);
            this.mask_cpf.Mask = "000.000.000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(141, 22);
            this.mask_cpf.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "SEU IMC";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(91, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(281, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nm_altura
            // 
            this.nm_altura.DecimalPlaces = 2;
            this.nm_altura.Location = new System.Drawing.Point(241, 261);
            this.nm_altura.Name = "nm_altura";
            this.nm_altura.Size = new System.Drawing.Size(72, 22);
            this.nm_altura.TabIndex = 13;
            // 
            // nm_idade
            // 
            this.nm_idade.Location = new System.Drawing.Point(785, 191);
            this.nm_idade.Name = "nm_idade";
            this.nm_idade.Size = new System.Drawing.Size(68, 22);
            this.nm_idade.TabIndex = 15;
            this.nm_idade.ValueChanged += new System.EventHandler(this.nm_idade_ValueChanged);
            // 
            // nm_peso
            // 
            this.nm_peso.DecimalPlaces = 2;
            this.nm_peso.Location = new System.Drawing.Point(412, 260);
            this.nm_peso.Name = "nm_peso";
            this.nm_peso.Size = new System.Drawing.Size(137, 22);
            this.nm_peso.TabIndex = 18;
            this.nm_peso.ValueChanged += new System.EventHandler(this.nm_peso_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(559, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "sexo.:";
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Feminino ",
            "Masculino"});
            this.cb_sexo.Location = new System.Drawing.Point(629, 264);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(121, 24);
            this.cb_sexo.TabIndex = 21;
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resultado.ForeColor = System.Drawing.Color.SeaGreen;
            this.lb_resultado.Location = new System.Drawing.Point(87, 422);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(59, 20);
            this.lb_resultado.TabIndex = 22;
            this.lb_resultado.Text = "label8";
            this.lb_resultado.Click += new System.EventHandler(this.lb_resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 505);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nm_peso);
            this.Controls.Add(this.nm_idade);
            this.Controls.Add(this.nm_altura);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mask_cpf);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcular seu IMC";
            ((System.ComponentModel.ISupportInitialize)(this.nm_altura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_idade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_peso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nm_altura;
        private System.Windows.Forms.NumericUpDown nm_idade;
        private System.Windows.Forms.NumericUpDown nm_peso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.Label lb_resultado;
    }
}

