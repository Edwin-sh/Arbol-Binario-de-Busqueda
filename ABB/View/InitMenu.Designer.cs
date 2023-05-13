namespace ABB.View
{
    partial class InitMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitMenu));
            this.btnPrimerEsc = new System.Windows.Forms.Button();
            this.btnSegundoEsc = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrimerEsc
            // 
            this.btnPrimerEsc.BackColor = System.Drawing.Color.Chartreuse;
            this.btnPrimerEsc.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerEsc.Location = new System.Drawing.Point(32, 22);
            this.btnPrimerEsc.Name = "btnPrimerEsc";
            this.btnPrimerEsc.Size = new System.Drawing.Size(115, 40);
            this.btnPrimerEsc.TabIndex = 0;
            this.btnPrimerEsc.Text = "Escenario 1";
            this.btnPrimerEsc.UseVisualStyleBackColor = false;
            this.btnPrimerEsc.Click += new System.EventHandler(this.btnPrimerEsc_Click);
            // 
            // btnSegundoEsc
            // 
            this.btnSegundoEsc.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSegundoEsc.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundoEsc.Location = new System.Drawing.Point(175, 22);
            this.btnSegundoEsc.Name = "btnSegundoEsc";
            this.btnSegundoEsc.Size = new System.Drawing.Size(115, 40);
            this.btnSegundoEsc.TabIndex = 1;
            this.btnSegundoEsc.Text = "Escenario 2";
            this.btnSegundoEsc.UseVisualStyleBackColor = false;
            this.btnSegundoEsc.Click += new System.EventHandler(this.btnSegundoEsc_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Yellow;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(315, 22);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(94, 40);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir  ";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // InitMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 84);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSegundoEsc);
            this.Controls.Add(this.btnPrimerEsc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InitMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.InitMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrimerEsc;
        private System.Windows.Forms.Button btnSegundoEsc;
        private System.Windows.Forms.Button btnSalir;
    }
}