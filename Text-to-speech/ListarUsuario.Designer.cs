namespace Text_to_speech
{
    partial class ListarUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGListarUsuario = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.BtLIstar = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.DGListarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // DGListarUsuario
            // 
            this.DGListarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGListarUsuario.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGListarUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.DGListarUsuario.Location = new System.Drawing.Point(12, 29);
            this.DGListarUsuario.Name = "DGListarUsuario";
            this.DGListarUsuario.Size = new System.Drawing.Size(453, 230);
            this.DGListarUsuario.TabIndex = 0;
            // 
            // BtLIstar
            // 
            this.BtLIstar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtLIstar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtLIstar.Location = new System.Drawing.Point(29, 276);
            this.BtLIstar.Name = "BtLIstar";
            this.BtLIstar.Size = new System.Drawing.Size(75, 23);
            this.BtLIstar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtLIstar.TabIndex = 1;
            this.BtLIstar.Text = "Listar";
            this.BtLIstar.Click += new System.EventHandler(this.BtLIstar_Click);
            // 
            // ListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 306);
            this.Controls.Add(this.BtLIstar);
            this.Controls.Add(this.DGListarUsuario);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ListarUsuario";
            this.Text = "MetroForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGListarUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DGListarUsuario;
        private DevComponents.DotNetBar.ButtonX BtLIstar;
    }
}