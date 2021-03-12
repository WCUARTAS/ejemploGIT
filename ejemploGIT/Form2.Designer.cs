
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormulario1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormulario1;
    }
}