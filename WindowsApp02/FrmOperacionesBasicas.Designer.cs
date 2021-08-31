
namespace WindowsApp02
{
    partial class FrmOperacionesBasicas
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
            this.label1 = new System.Windows.Forms.Label();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.SumarButton = new System.Windows.Forms.Button();
            this.RestarButton = new System.Windows.Forms.Button();
            this.MultiplicarButton = new System.Windows.Forms.Button();
            this.DividirButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.ResultadosListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(107, 52);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(100, 20);
            this.Numero1TextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero 2:";
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(107, 88);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Numero2TextBox.TabIndex = 1;
            // 
            // SumarButton
            // 
            this.SumarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumarButton.Location = new System.Drawing.Point(26, 138);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(53, 39);
            this.SumarButton.TabIndex = 2;
            this.SumarButton.Text = "+";
            this.SumarButton.UseVisualStyleBackColor = true;
            this.SumarButton.Click += new System.EventHandler(this.SumarButton_Click);
            // 
            // RestarButton
            // 
            this.RestarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestarButton.Location = new System.Drawing.Point(85, 138);
            this.RestarButton.Name = "RestarButton";
            this.RestarButton.Size = new System.Drawing.Size(53, 39);
            this.RestarButton.TabIndex = 3;
            this.RestarButton.Text = "-";
            this.RestarButton.UseVisualStyleBackColor = true;
            this.RestarButton.Click += new System.EventHandler(this.RestarButton_Click);
            // 
            // MultiplicarButton
            // 
            this.MultiplicarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicarButton.Location = new System.Drawing.Point(144, 138);
            this.MultiplicarButton.Name = "MultiplicarButton";
            this.MultiplicarButton.Size = new System.Drawing.Size(53, 39);
            this.MultiplicarButton.TabIndex = 4;
            this.MultiplicarButton.Text = "*";
            this.MultiplicarButton.UseVisualStyleBackColor = true;
            this.MultiplicarButton.Click += new System.EventHandler(this.MultiplicarButton_Click);
            // 
            // DividirButton
            // 
            this.DividirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DividirButton.Location = new System.Drawing.Point(203, 138);
            this.DividirButton.Name = "DividirButton";
            this.DividirButton.Size = new System.Drawing.Size(53, 39);
            this.DividirButton.TabIndex = 5;
            this.DividirButton.Text = "/";
            this.DividirButton.UseVisualStyleBackColor = true;
            this.DividirButton.Click += new System.EventHandler(this.DividirButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SalirButton.Image = global::WindowsApp02.Properties.Resources.shutdown_36px;
            this.SalirButton.Location = new System.Drawing.Point(205, 405);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(51, 44);
            this.SalirButton.TabIndex = 7;
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Image = global::WindowsApp02.Properties.Resources.cancel_24px;
            this.CancelarButton.Location = new System.Drawing.Point(26, 183);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(230, 54);
            this.CancelarButton.TabIndex = 6;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // ResultadosListBox
            // 
            this.ResultadosListBox.FormattingEnabled = true;
            this.ResultadosListBox.Location = new System.Drawing.Point(26, 259);
            this.ResultadosListBox.Name = "ResultadosListBox";
            this.ResultadosListBox.Size = new System.Drawing.Size(230, 121);
            this.ResultadosListBox.TabIndex = 5;
            // 
            // FrmOperacionesBasicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.ResultadosListBox);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.DividirButton);
            this.Controls.Add(this.MultiplicarButton);
            this.Controls.Add(this.RestarButton);
            this.Controls.Add(this.SumarButton);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "FrmOperacionesBasicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones Básicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero2TextBox;
        private System.Windows.Forms.Button SumarButton;
        private System.Windows.Forms.Button RestarButton;
        private System.Windows.Forms.Button MultiplicarButton;
        private System.Windows.Forms.Button DividirButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.ListBox ResultadosListBox;
    }
}

