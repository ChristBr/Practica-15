namespace Practica_15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(380, 24);
            label1.TabIndex = 0;
            label1.Text = "Dado como dato el sueldo de un trabajador,";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(381, 24);
            label2.TabIndex = 1;
            label2.Text = "el programa aplica un aumento del 15% si el";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(372, 24);
            label3.TabIndex = 2;
            label3.Text = "sueldo es inferior a 400 mil pesos y en caso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 90);
            label4.Name = "label4";
            label4.Size = new Size(271, 24);
            label4.TabIndex = 3;
            label4.Text = "contrario el aumento es del 8%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 153);
            label6.Name = "label6";
            label6.Size = new Size(138, 24);
            label6.TabIndex = 5;
            label6.Text = "Ingresar sueldo";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(26, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 32);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(69, 284);
            button1.Name = "button1";
            button1.Size = new Size(88, 35);
            button1.TabIndex = 7;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(222, 284);
            button2.Name = "button2";
            button2.Size = new Size(94, 35);
            button2.TabIndex = 8;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(239, 153);
            label7.Name = "label7";
            label7.Size = new Size(125, 24);
            label7.TabIndex = 9;
            label7.Text = "Nuevo sueldo";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(239, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 32);
            textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(402, 366);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Aumento de sueldo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label7;
        private TextBox textBox2;
    }
}