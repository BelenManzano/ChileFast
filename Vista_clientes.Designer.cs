namespace ChileFast
{
    partial class Vista_clientes
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
            this.dtaTable = new System.Windows.Forms.DataGridView();
            this.txtMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaTable
            // 
            this.dtaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaTable.Location = new System.Drawing.Point(58, 58);
            this.dtaTable.Name = "dtaTable";
            this.dtaTable.Size = new System.Drawing.Size(695, 291);
            this.dtaTable.TabIndex = 0;
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(346, 371);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(116, 23);
            this.txtMostrar.TabIndex = 1;
            this.txtMostrar.Text = "Mostrar clientes";
            this.txtMostrar.UseVisualStyleBackColor = true;
            this.txtMostrar.Click += new System.EventHandler(this.TxtMostrar_Click);
            // 
            // Vista_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.dtaTable);
            this.Name = "Vista_clientes";
            this.Text = "Vista_clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtaTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaTable;
        private System.Windows.Forms.Button txtMostrar;
    }
}