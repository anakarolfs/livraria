namespace livrariaSJP
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.jMaterialTextbox1 = new JMaterialTextbox.JMaterialTextbox();
            this.jMaterialTextbox2 = new JMaterialTextbox.JMaterialTextbox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.HotPink;
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 135);
            this.panel2.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = true;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFechar.Location = new System.Drawing.Point(465, 8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(26, 27);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "X";
            this.btnFechar.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(187, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panel2;
            // 
            // jMaterialTextbox1
            // 
            this.jMaterialTextbox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.jMaterialTextbox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jMaterialTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.jMaterialTextbox1.Font_Size = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.jMaterialTextbox1.ForeColors = System.Drawing.Color.Black;
            this.jMaterialTextbox1.HintText = "";
            this.jMaterialTextbox1.IsPassword = false;
            this.jMaterialTextbox1.LineBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.jMaterialTextbox1.LineThickness = 4;
            this.jMaterialTextbox1.Location = new System.Drawing.Point(88, 193);
            this.jMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.jMaterialTextbox1.MaxLength = 32767;
            this.jMaterialTextbox1.Name = "jMaterialTextbox1";
            this.jMaterialTextbox1.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox1.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox1.ReadOnly = false;
            this.jMaterialTextbox1.Size = new System.Drawing.Size(312, 44);
            this.jMaterialTextbox1.TabIndex = 1;
            this.jMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jMaterialTextbox1.TextName = "";
            this.jMaterialTextbox1.Load += new System.EventHandler(this.jMaterialTextbox1_Load);
            // 
            // jMaterialTextbox2
            // 
            this.jMaterialTextbox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.jMaterialTextbox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jMaterialTextbox2.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.jMaterialTextbox2.Font_Size = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.jMaterialTextbox2.ForeColors = System.Drawing.Color.Black;
            this.jMaterialTextbox2.HintText = "";
            this.jMaterialTextbox2.IsPassword = true;
            this.jMaterialTextbox2.LineBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.jMaterialTextbox2.LineThickness = 4;
            this.jMaterialTextbox2.Location = new System.Drawing.Point(88, 297);
            this.jMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.jMaterialTextbox2.MaxLength = 32767;
            this.jMaterialTextbox2.Name = "jMaterialTextbox2";
            this.jMaterialTextbox2.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox2.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox2.ReadOnly = false;
            this.jMaterialTextbox2.Size = new System.Drawing.Size(312, 44);
            this.jMaterialTextbox2.TabIndex = 2;
            this.jMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jMaterialTextbox2.TextName = "";
            // 
            // btnEnviar
            // 
            this.btnEnviar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnEnviar.BackColor = System.Drawing.Color.HotPink;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.btnEnviar.FlatAppearance.BorderSize = 4;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnEnviar.Location = new System.Drawing.Point(194, 396);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(108, 44);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(84, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(84, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(174, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "esqueceu a senha ?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(504, 516);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.jMaterialTextbox2);
            this.Controls.Add(this.jMaterialTextbox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private JDragControl.JDragControl jDragControl1;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox1;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox2;
        internal System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnFechar;
    }
}

