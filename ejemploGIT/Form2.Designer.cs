
namespace ejemploGIT
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
            this.btnFormulario1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Edad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFormulario1
            // 
            this.btnFormulario1.Location = new System.Drawing.Point(167, 105);
            this.btnFormulario1.Name = "btnFormulario1";
            this.btnFormulario1.Size = new System.Drawing.Size(75, 23);
            this.btnFormulario1.TabIndex = 0;
            this.btnFormulario1.Text = "Formulario 1";
            this.btnFormulario1.UseVisualStyleBackColor = true;
            this.btnFormulario1.Click += new System.EventHandler(this.btnFormulario1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "EDAD";
            // 
            // label_Edad
            // 
            this.label_Edad.AutoSize = true;
            this.label_Edad.Location = new System.Drawing.Point(476, 113);
            this.label_Edad.Name = "label_Edad";
            this.label_Edad.Size = new System.Drawing.Size(35, 13);
            this.label_Edad.TabIndex = 3;
            this.label_Edad.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Edad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFormulario1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormulario1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Edad;
    }
}