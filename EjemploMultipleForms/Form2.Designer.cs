
namespace EjemploMultipleForms
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
            this.but_f2_main = new System.Windows.Forms.Button();
            this.but_f2_f1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_f2_main
            // 
            this.but_f2_main.Location = new System.Drawing.Point(214, 87);
            this.but_f2_main.Name = "but_f2_main";
            this.but_f2_main.Size = new System.Drawing.Size(293, 51);
            this.but_f2_main.TabIndex = 0;
            this.but_f2_main.Text = "Volver al Main Form";
            this.but_f2_main.UseVisualStyleBackColor = true;
            this.but_f2_main.Click += new System.EventHandler(this.but_f2_main_Click);
            // 
            // but_f2_f1
            // 
            this.but_f2_f1.Location = new System.Drawing.Point(253, 213);
            this.but_f2_f1.Name = "but_f2_f1";
            this.but_f2_f1.Size = new System.Drawing.Size(225, 50);
            this.but_f2_f1.TabIndex = 1;
            this.but_f2_f1.Text = "Abrir Form1";
            this.but_f2_f1.UseVisualStyleBackColor = true;
            this.but_f2_f1.Click += new System.EventHandler(this.but_f2_f1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_f2_f1);
            this.Controls.Add(this.but_f2_main);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_f2_main;
        private System.Windows.Forms.Button but_f2_f1;
    }
}