
namespace EjemploMultipleForms
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
            this.but_f1_main = new System.Windows.Forms.Button();
            this.but_f1_f2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_f1_main
            // 
            this.but_f1_main.Location = new System.Drawing.Point(232, 118);
            this.but_f1_main.Name = "but_f1_main";
            this.but_f1_main.Size = new System.Drawing.Size(300, 55);
            this.but_f1_main.TabIndex = 0;
            this.but_f1_main.Text = "Volver al Main Form";
            this.but_f1_main.UseVisualStyleBackColor = true;
            this.but_f1_main.Click += new System.EventHandler(this.but_f1_main_Click);
            // 
            // but_f1_f2
            // 
            this.but_f1_f2.Location = new System.Drawing.Point(274, 217);
            this.but_f1_f2.Name = "but_f1_f2";
            this.but_f1_f2.Size = new System.Drawing.Size(216, 56);
            this.but_f1_f2.TabIndex = 1;
            this.but_f1_f2.Text = "Abrir Form2";
            this.but_f1_f2.UseVisualStyleBackColor = true;
            this.but_f1_f2.Click += new System.EventHandler(this.but_f1_f2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 472);
            this.Controls.Add(this.but_f1_f2);
            this.Controls.Add(this.but_f1_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_f1_main;
        private System.Windows.Forms.Button but_f1_f2;
    }
}