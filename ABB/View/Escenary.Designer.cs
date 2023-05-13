namespace ABB.View
{
    partial class Escenary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escenary));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arbolBinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxGrafica = new System.Windows.Forms.GroupBox();
            this.groupBoxEscenario = new System.Windows.Forms.GroupBox();
            this.labelEscenario = new System.Windows.Forms.Label();
            this.panelGrafica = new System.Windows.Forms.Panel();
            this.groupBoxRecorrido = new System.Windows.Forms.GroupBox();
            this.panelRecorrido = new System.Windows.Forms.Panel();
            this.labelRecorrido = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxGrafica.SuspendLayout();
            this.groupBoxEscenario.SuspendLayout();
            this.groupBoxRecorrido.SuspendLayout();
            this.panelRecorrido.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolBinarioToolStripMenuItem,
            this.recorridosToolStripMenuItem,
            this.regresarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(922, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arbolBinarioToolStripMenuItem
            // 
            this.arbolBinarioToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arbolBinarioToolStripMenuItem.Name = "arbolBinarioToolStripMenuItem";
            this.arbolBinarioToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.arbolBinarioToolStripMenuItem.Text = "Grafica";
            this.arbolBinarioToolStripMenuItem.Click += new System.EventHandler(this.ArbolBinarioToolStripMenuItem_Click);
            // 
            // recorridosToolStripMenuItem
            // 
            this.recorridosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preOrdenToolStripMenuItem,
            this.inOrdenToolStripMenuItem,
            this.postOrdenToolStripMenuItem});
            this.recorridosToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold);
            this.recorridosToolStripMenuItem.Name = "recorridosToolStripMenuItem";
            this.recorridosToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.recorridosToolStripMenuItem.Text = "Recorridos";
            // 
            // preOrdenToolStripMenuItem
            // 
            this.preOrdenToolStripMenuItem.Name = "preOrdenToolStripMenuItem";
            this.preOrdenToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.preOrdenToolStripMenuItem.Text = "PreOrden";
            this.preOrdenToolStripMenuItem.Click += new System.EventHandler(this.PreOrdenToolStripMenuItem_Click);
            // 
            // inOrdenToolStripMenuItem
            // 
            this.inOrdenToolStripMenuItem.Name = "inOrdenToolStripMenuItem";
            this.inOrdenToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.inOrdenToolStripMenuItem.Text = "InOrden";
            this.inOrdenToolStripMenuItem.Click += new System.EventHandler(this.InOrdenToolStripMenuItem_Click);
            // 
            // postOrdenToolStripMenuItem
            // 
            this.postOrdenToolStripMenuItem.Name = "postOrdenToolStripMenuItem";
            this.postOrdenToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.postOrdenToolStripMenuItem.Text = "PostOrden";
            this.postOrdenToolStripMenuItem.Click += new System.EventHandler(this.PostOrdenToolStripMenuItem_Click);
            // 
            // regresarToolStripMenuItem
            // 
            this.regresarToolStripMenuItem.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold);
            this.regresarToolStripMenuItem.Name = "regresarToolStripMenuItem";
            this.regresarToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.regresarToolStripMenuItem.Text = "Regresar";
            this.regresarToolStripMenuItem.Click += new System.EventHandler(this.RegresarToolStripMenuItem_Click);
            // 
            // groupBoxGrafica
            // 
            this.groupBoxGrafica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxGrafica.Controls.Add(this.groupBoxRecorrido);
            this.groupBoxGrafica.Controls.Add(this.panelGrafica);
            this.groupBoxGrafica.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGrafica.Location = new System.Drawing.Point(15, 100);
            this.groupBoxGrafica.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxGrafica.Name = "groupBoxGrafica";
            this.groupBoxGrafica.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.groupBoxGrafica.Size = new System.Drawing.Size(890, 528);
            this.groupBoxGrafica.TabIndex = 2;
            this.groupBoxGrafica.TabStop = false;
            // 
            // groupBoxEscenario
            // 
            this.groupBoxEscenario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxEscenario.Controls.Add(this.labelEscenario);
            this.groupBoxEscenario.Location = new System.Drawing.Point(15, 33);
            this.groupBoxEscenario.Name = "groupBoxEscenario";
            this.groupBoxEscenario.Size = new System.Drawing.Size(890, 77);
            this.groupBoxEscenario.TabIndex = 3;
            this.groupBoxEscenario.TabStop = false;
            // 
            // labelEscenario
            // 
            this.labelEscenario.AutoSize = true;
            this.labelEscenario.Font = new System.Drawing.Font("Lucida Handwriting", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEscenario.Location = new System.Drawing.Point(201, 15);
            this.labelEscenario.Name = "labelEscenario";
            this.labelEscenario.Size = new System.Drawing.Size(416, 48);
            this.labelEscenario.TabIndex = 0;
            this.labelEscenario.Text = "Escenario Numero";
            // 
            // panelGrafica
            // 
            this.panelGrafica.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelGrafica.Location = new System.Drawing.Point(9, 26);
            this.panelGrafica.Name = "panelGrafica";
            this.panelGrafica.Size = new System.Drawing.Size(872, 376);
            this.panelGrafica.TabIndex = 0;
            // 
            // groupBoxRecorrido
            // 
            this.groupBoxRecorrido.BackColor = System.Drawing.SystemColors.Info;
            this.groupBoxRecorrido.Controls.Add(this.panelRecorrido);
            this.groupBoxRecorrido.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRecorrido.Location = new System.Drawing.Point(9, 408);
            this.groupBoxRecorrido.Name = "groupBoxRecorrido";
            this.groupBoxRecorrido.Size = new System.Drawing.Size(872, 114);
            this.groupBoxRecorrido.TabIndex = 5;
            this.groupBoxRecorrido.TabStop = false;
            // 
            // panelRecorrido
            // 
            this.panelRecorrido.Controls.Add(this.labelRecorrido);
            this.panelRecorrido.Controls.Add(this.labelR);
            this.panelRecorrido.Location = new System.Drawing.Point(6, 21);
            this.panelRecorrido.Name = "panelRecorrido";
            this.panelRecorrido.Size = new System.Drawing.Size(860, 85);
            this.panelRecorrido.TabIndex = 0;
            // 
            // labelRecorrido
            // 
            this.labelRecorrido.AutoSize = true;
            this.labelRecorrido.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecorrido.ForeColor = System.Drawing.Color.Red;
            this.labelRecorrido.Location = new System.Drawing.Point(208, 7);
            this.labelRecorrido.Name = "labelRecorrido";
            this.labelRecorrido.Size = new System.Drawing.Size(184, 27);
            this.labelRecorrido.TabIndex = 3;
            this.labelRecorrido.Text = "TipoRecorrido";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR.Location = new System.Drawing.Point(16, 7);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(146, 27);
            this.labelR.TabIndex = 2;
            this.labelR.Text = "Recorrido: ";
            // 
            // Escenary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(922, 641);
            this.Controls.Add(this.groupBoxEscenario);
            this.Controls.Add(this.groupBoxGrafica);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Escenary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escenario";
            this.Load += new System.EventHandler(this.Escenary_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxGrafica.ResumeLayout(false);
            this.groupBoxEscenario.ResumeLayout(false);
            this.groupBoxEscenario.PerformLayout();
            this.groupBoxRecorrido.ResumeLayout(false);
            this.panelRecorrido.ResumeLayout(false);
            this.panelRecorrido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arbolBinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxGrafica;
        private System.Windows.Forms.GroupBox groupBoxEscenario;
        private System.Windows.Forms.Label labelEscenario;
        private System.Windows.Forms.Panel panelGrafica;
        private System.Windows.Forms.GroupBox groupBoxRecorrido;
        private System.Windows.Forms.Panel panelRecorrido;
        private System.Windows.Forms.Label labelRecorrido;
        private System.Windows.Forms.Label labelR;
    }
}