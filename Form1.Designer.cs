namespace DibujoTriangulos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.borrarButton = new System.Windows.Forms.Button();
            this.girarButton = new System.Windows.Forms.Button();
            this.dibujarButton = new System.Windows.Forms.Button();
            this.rotarButton = new System.Windows.Forms.Button();
            this.rotarTextBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Y3TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.X3TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Y2TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.X2TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Y1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.X1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.borrarButton);
            this.groupBox1.Controls.Add(this.girarButton);
            this.groupBox1.Controls.Add(this.dibujarButton);
            this.groupBox1.Controls.Add(this.rotarButton);
            this.groupBox1.Controls.Add(this.rotarTextBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Y3TextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.X3TextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Y2TextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.X2TextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Y1TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.X1TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de triangulo";
            // 
            // borrarButton
            // 
            this.borrarButton.Location = new System.Drawing.Point(188, 231);
            this.borrarButton.Name = "borrarButton";
            this.borrarButton.Size = new System.Drawing.Size(75, 23);
            this.borrarButton.TabIndex = 17;
            this.borrarButton.Text = "Borrar";
            this.borrarButton.UseVisualStyleBackColor = true;
            // 
            // girarButton
            // 
            this.girarButton.Location = new System.Drawing.Point(107, 231);
            this.girarButton.Name = "girarButton";
            this.girarButton.Size = new System.Drawing.Size(75, 23);
            this.girarButton.TabIndex = 16;
            this.girarButton.Text = "Girar";
            this.girarButton.UseVisualStyleBackColor = true;
            // 
            // dibujarButton
            // 
            this.dibujarButton.Location = new System.Drawing.Point(26, 231);
            this.dibujarButton.Name = "dibujarButton";
            this.dibujarButton.Size = new System.Drawing.Size(75, 23);
            this.dibujarButton.TabIndex = 15;
            this.dibujarButton.Text = "Dibujar";
            this.dibujarButton.UseVisualStyleBackColor = true;
            this.dibujarButton.Click += new System.EventHandler(this.dibujarButton_Click);
            // 
            // rotarButton
            // 
            this.rotarButton.Location = new System.Drawing.Point(188, 179);
            this.rotarButton.Name = "rotarButton";
            this.rotarButton.Size = new System.Drawing.Size(75, 23);
            this.rotarButton.TabIndex = 14;
            this.rotarButton.Text = "Rotar";
            this.rotarButton.UseVisualStyleBackColor = true;
            // 
            // rotarTextBox1
            // 
            this.rotarTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotarTextBox1.Location = new System.Drawing.Point(61, 181);
            this.rotarTextBox1.Name = "rotarTextBox1";
            this.rotarTextBox1.Size = new System.Drawing.Size(100, 24);
            this.rotarTextBox1.TabIndex = 13;
            this.rotarTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rotarTextBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rotar:";
            // 
            // Y3TextBox
            // 
            this.Y3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y3TextBox.Location = new System.Drawing.Point(188, 95);
            this.Y3TextBox.Name = "Y3TextBox";
            this.Y3TextBox.Size = new System.Drawing.Size(100, 24);
            this.Y3TextBox.TabIndex = 11;
            this.Y3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y3TextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Y3:";
            // 
            // X3TextBox
            // 
            this.X3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X3TextBox.Location = new System.Drawing.Point(47, 95);
            this.X3TextBox.Name = "X3TextBox";
            this.X3TextBox.Size = new System.Drawing.Size(100, 24);
            this.X3TextBox.TabIndex = 9;
            this.X3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X3TextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "X3:";
            // 
            // Y2TextBox
            // 
            this.Y2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y2TextBox.Location = new System.Drawing.Point(188, 65);
            this.Y2TextBox.Name = "Y2TextBox";
            this.Y2TextBox.Size = new System.Drawing.Size(100, 24);
            this.Y2TextBox.TabIndex = 7;
            this.Y2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y2TextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y2:";
            // 
            // X2TextBox
            // 
            this.X2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X2TextBox.Location = new System.Drawing.Point(47, 65);
            this.X2TextBox.Name = "X2TextBox";
            this.X2TextBox.Size = new System.Drawing.Size(100, 24);
            this.X2TextBox.TabIndex = 5;
            this.X2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X2TextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "X2:";
            // 
            // Y1TextBox
            // 
            this.Y1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y1TextBox.Location = new System.Drawing.Point(188, 35);
            this.Y1TextBox.Name = "Y1TextBox";
            this.Y1TextBox.Size = new System.Drawing.Size(100, 24);
            this.Y1TextBox.TabIndex = 3;
            this.Y1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Y1TextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y1:";
            // 
            // X1TextBox
            // 
            this.X1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X1TextBox.Location = new System.Drawing.Point(47, 35);
            this.X1TextBox.Name = "X1TextBox";
            this.X1TextBox.Size = new System.Drawing.Size(100, 24);
            this.X1TextBox.TabIndex = 1;
            this.X1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X1TextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "X1:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(312, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 305);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(636, 329);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox X1TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Y3TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox X3TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Y2TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox X2TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Y1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button borrarButton;
        private System.Windows.Forms.Button girarButton;
        private System.Windows.Forms.Button dibujarButton;
        private System.Windows.Forms.Button rotarButton;
        private System.Windows.Forms.TextBox rotarTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

