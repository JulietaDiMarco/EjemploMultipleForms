
namespace EjemploMultipleForms
{
    partial class MainForm
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
            this.but_form1 = new System.Windows.Forms.Button();
            this.but_form2 = new System.Windows.Forms.Button();
            this.btn_Mensaje = new System.Windows.Forms.Button();
            this.btn_dialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_form1
            // 
            this.but_form1.Location = new System.Drawing.Point(224, 102);
            this.but_form1.Name = "but_form1";
            this.but_form1.Size = new System.Drawing.Size(284, 63);
            this.but_form1.TabIndex = 0;
            this.but_form1.Text = "Abrir Form1";
            this.but_form1.UseVisualStyleBackColor = true;
            this.but_form1.Click += new System.EventHandler(this.but_form1_Click);
            // 
            // but_form2
            // 
            this.but_form2.Location = new System.Drawing.Point(224, 240);
            this.but_form2.Name = "but_form2";
            this.but_form2.Size = new System.Drawing.Size(287, 66);
            this.but_form2.TabIndex = 1;
            this.but_form2.Text = "Abrir Form2";
            this.but_form2.UseVisualStyleBackColor = true;
            this.but_form2.Click += new System.EventHandler(this.but_form2_Click);
            // 
            // btn_Mensaje
            // 
            this.btn_Mensaje.Location = new System.Drawing.Point(286, 368);
            this.btn_Mensaje.Name = "btn_Mensaje";
            this.btn_Mensaje.Size = new System.Drawing.Size(164, 63);
            this.btn_Mensaje.TabIndex = 2;
            this.btn_Mensaje.Text = "Mensaje";
            this.btn_Mensaje.UseVisualStyleBackColor = true;
            this.btn_Mensaje.Click += new System.EventHandler(this.btn_Mensaje_Click);
            // 
            // btn_dialog
            // 
            this.btn_dialog.Location = new System.Drawing.Point(223, 478);
            this.btn_dialog.Name = "btn_dialog";
            this.btn_dialog.Size = new System.Drawing.Size(285, 72);
            this.btn_dialog.TabIndex = 3;
            this.btn_dialog.Text = "Abrir Dialog";
            this.btn_dialog.UseVisualStyleBackColor = true;
            this.btn_dialog.Click += new System.EventHandler(this.btn_dialog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.btn_dialog);
            this.Controls.Add(this.btn_Mensaje);
            this.Controls.Add(this.but_form2);
            this.Controls.Add(this.but_form1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_form1;
        private System.Windows.Forms.Button but_form2;
        private System.Windows.Forms.Button btn_Mensaje;
        private System.Windows.Forms.Button btn_dialog;
    }
}

