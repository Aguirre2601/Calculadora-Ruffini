namespace TP_2_POO
{
    partial class RuffiniCal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuffiniCal));
            this.txtPolinomio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnAgregar = new System.Windows.Forms.Button();
            this.ProveedorDeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRaiz1 = new System.Windows.Forms.TextBox();
            this.txtRaiz3 = new System.Windows.Forms.TextBox();
            this.txtRaiz2 = new System.Windows.Forms.TextBox();
            this.txtRaiz4 = new System.Windows.Forms.TextBox();
            this.txtRaiz5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bttnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDeError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPolinomio
            // 
            this.txtPolinomio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(52)))));
            this.txtPolinomio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPolinomio.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPolinomio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPolinomio.Location = new System.Drawing.Point(216, 154);
            this.txtPolinomio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPolinomio.Name = "txtPolinomio";
            this.txtPolinomio.ShortcutsEnabled = false;
            this.txtPolinomio.Size = new System.Drawing.Size(237, 27);
            this.txtPolinomio.TabIndex = 1;
            this.txtPolinomio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPolinomio_KeyDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(136, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "f(x)= 3x^2+4x^1-7x^3-22x^1";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(168, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "f(x)=";
            // 
            // bttnAgregar
            // 
            this.bttnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(177)))), ((int)(((byte)(122)))));
            this.bttnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bttnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bttnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bttnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAgregar.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.bttnAgregar.Location = new System.Drawing.Point(476, 145);
            this.bttnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.bttnAgregar.Name = "bttnAgregar";
            this.bttnAgregar.Size = new System.Drawing.Size(96, 38);
            this.bttnAgregar.TabIndex = 2;
            this.bttnAgregar.Text = "Calcular";
            this.bttnAgregar.UseVisualStyleBackColor = false;
            this.bttnAgregar.Click += new System.EventHandler(this.bttnAgregar_Click);
            // 
            // ProveedorDeError
            // 
            this.ProveedorDeError.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(13, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(591, 109);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bienvenido a RuffiniCalcu el programa para calcular\r\nlas raíces de un polinomio. " +
    "Para utilizar la calculadora \r\nde raíces debe escribir al polinomio como esta en" +
    " el ejemplo a continuación:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(247, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "Raiz 1:";
            // 
            // txtRaiz1
            // 
            this.txtRaiz1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(52)))));
            this.txtRaiz1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRaiz1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtRaiz1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaiz1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRaiz1.Location = new System.Drawing.Point(323, 218);
            this.txtRaiz1.Margin = new System.Windows.Forms.Padding(4);
            this.txtRaiz1.Name = "txtRaiz1";
            this.txtRaiz1.ReadOnly = true;
            this.txtRaiz1.ShortcutsEnabled = false;
            this.txtRaiz1.Size = new System.Drawing.Size(120, 31);
            this.txtRaiz1.TabIndex = 7;
            // 
            // txtRaiz3
            // 
            this.txtRaiz3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txtRaiz3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRaiz3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtRaiz3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaiz3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRaiz3.Location = new System.Drawing.Point(323, 304);
            this.txtRaiz3.Margin = new System.Windows.Forms.Padding(4);
            this.txtRaiz3.Name = "txtRaiz3";
            this.txtRaiz3.ReadOnly = true;
            this.txtRaiz3.ShortcutsEnabled = false;
            this.txtRaiz3.Size = new System.Drawing.Size(120, 31);
            this.txtRaiz3.TabIndex = 8;
            // 
            // txtRaiz2
            // 
            this.txtRaiz2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(52)))));
            this.txtRaiz2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRaiz2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtRaiz2.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaiz2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRaiz2.Location = new System.Drawing.Point(323, 259);
            this.txtRaiz2.Margin = new System.Windows.Forms.Padding(4);
            this.txtRaiz2.Name = "txtRaiz2";
            this.txtRaiz2.ReadOnly = true;
            this.txtRaiz2.ShortcutsEnabled = false;
            this.txtRaiz2.Size = new System.Drawing.Size(120, 31);
            this.txtRaiz2.TabIndex = 9;
            // 
            // txtRaiz4
            // 
            this.txtRaiz4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txtRaiz4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRaiz4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtRaiz4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaiz4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRaiz4.Location = new System.Drawing.Point(323, 345);
            this.txtRaiz4.Margin = new System.Windows.Forms.Padding(4);
            this.txtRaiz4.Name = "txtRaiz4";
            this.txtRaiz4.ReadOnly = true;
            this.txtRaiz4.ShortcutsEnabled = false;
            this.txtRaiz4.Size = new System.Drawing.Size(120, 31);
            this.txtRaiz4.TabIndex = 10;
            // 
            // txtRaiz5
            // 
            this.txtRaiz5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.txtRaiz5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRaiz5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtRaiz5.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaiz5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRaiz5.Location = new System.Drawing.Point(323, 392);
            this.txtRaiz5.Margin = new System.Windows.Forms.Padding(4);
            this.txtRaiz5.Name = "txtRaiz5";
            this.txtRaiz5.ReadOnly = true;
            this.txtRaiz5.ShortcutsEnabled = false;
            this.txtRaiz5.Size = new System.Drawing.Size(120, 31);
            this.txtRaiz5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(247, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "Raiz 2:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(247, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 35);
            this.label7.TabIndex = 13;
            this.label7.Text = "Raiz 3:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(247, 347);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 35);
            this.label8.TabIndex = 14;
            this.label8.Text = "Raiz 4:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(247, 392);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 35);
            this.label9.TabIndex = 15;
            this.label9.Text = "Raiz 5:";
            // 
            // bttnRefresh
            // 
            this.bttnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(192)))), ((int)(((byte)(60)))));
            this.bttnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(192)))), ((int)(((byte)(60)))));
            this.bttnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(172)))), ((int)(((byte)(100)))));
            this.bttnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(192)))), ((int)(((byte)(100)))));
            this.bttnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRefresh.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.bttnRefresh.Location = new System.Drawing.Point(589, 146);
            this.bttnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(96, 38);
            this.bttnRefresh.TabIndex = 16;
            this.bttnRefresh.Text = "Nuevo";
            this.bttnRefresh.UseVisualStyleBackColor = false;
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click);
            // 
            // RuffiniCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(80)))));
            this.BackgroundImage = global::TP_2_POO.Properties.Resources._5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 454);
            this.Controls.Add(this.bttnRefresh);
            this.Controls.Add(this.txtRaiz5);
            this.Controls.Add(this.txtRaiz4);
            this.Controls.Add(this.txtRaiz3);
            this.Controls.Add(this.txtRaiz2);
            this.Controls.Add(this.txtRaiz1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPolinomio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttnAgregar);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "RuffiniCal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RuffiniCalcu";
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPolinomio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnAgregar;
        private System.Windows.Forms.ErrorProvider ProveedorDeError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRaiz5;
        private System.Windows.Forms.TextBox txtRaiz4;
        private System.Windows.Forms.TextBox txtRaiz2;
        private System.Windows.Forms.TextBox txtRaiz3;
        private System.Windows.Forms.TextBox txtRaiz1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnRefresh;
    }
}

