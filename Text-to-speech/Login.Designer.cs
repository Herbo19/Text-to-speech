namespace Text_to_speech
{
    partial class Login
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
            this.TxtNome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.BtAutenticar = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.LbUsuario = new DevComponents.DotNetBar.LabelX();
            this.metroStatusBar4 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.metroStatusBar5 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem5 = new DevComponents.DotNetBar.LabelItem();
            this.metroStatusBar2 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNome.HintForeColor = System.Drawing.Color.Empty;
            this.TxtNome.HintText = "Nome do Usuario";
            this.TxtNome.isPassword = false;
            this.TxtNome.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtNome.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtNome.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtNome.LineThickness = 3;
            this.TxtNome.Location = new System.Drawing.Point(144, 80);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(241, 33);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha:";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(144, 147);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '#';
            this.TxtSenha.Size = new System.Drawing.Size(240, 22);
            this.TxtSenha.TabIndex = 2;
            // 
            // BtAutenticar
            // 
            this.BtAutenticar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtAutenticar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtAutenticar.Location = new System.Drawing.Point(144, 302);
            this.BtAutenticar.Name = "BtAutenticar";
            this.BtAutenticar.Size = new System.Drawing.Size(75, 23);
            this.BtAutenticar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtAutenticar.Symbol = "";
            this.BtAutenticar.TabIndex = 3;
            this.BtAutenticar.Click += new System.EventHandler(this.BtAutenticar_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(310, 302);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.TabIndex = 4;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // LbUsuario
            // 
            this.LbUsuario.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.LbUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LbUsuario.ForeColor = System.Drawing.Color.Black;
            this.LbUsuario.Location = new System.Drawing.Point(12, 331);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(236, 23);
            this.LbUsuario.TabIndex = 5;
            // 
            // metroStatusBar4
            // 
            this.metroStatusBar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroStatusBar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar4.ContainerControlProcessDialogKey = true;
            this.metroStatusBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroStatusBar4.DragDropSupport = true;
            this.metroStatusBar4.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar4.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem4});
            this.metroStatusBar4.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.metroStatusBar4.Location = new System.Drawing.Point(0, 0);
            this.metroStatusBar4.Name = "metroStatusBar4";
            this.metroStatusBar4.Size = new System.Drawing.Size(15, 392);
            this.metroStatusBar4.TabIndex = 18;
            this.metroStatusBar4.Text = "                                    Tela de Autenticação do Usuarios da Aplicação" +
    "";
            // 
            // labelItem4
            // 
            this.labelItem4.Name = "labelItem4";
            this.labelItem4.Text = "                                          Tela de Autenticação para Usuarios do S" +
    "istema SVVJJ";
            // 
            // metroStatusBar1
            // 
            this.metroStatusBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1});
            this.metroStatusBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.metroStatusBar1.Location = new System.Drawing.Point(492, 0);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(15, 392);
            this.metroStatusBar1.TabIndex = 19;
            this.metroStatusBar1.Text = "                                    Tela de Autenticação do Usuarios da Aplicação" +
    "";
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "                                          Tela de Autenticação para Usuarios do S" +
    "istema SVVJJ";
            // 
            // metroStatusBar5
            // 
            this.metroStatusBar5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroStatusBar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar5.ContainerControlProcessDialogKey = true;
            this.metroStatusBar5.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroStatusBar5.DragDropSupport = true;
            this.metroStatusBar5.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar5.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar5.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem5});
            this.metroStatusBar5.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.metroStatusBar5.Location = new System.Drawing.Point(15, 0);
            this.metroStatusBar5.Name = "metroStatusBar5";
            this.metroStatusBar5.Size = new System.Drawing.Size(477, 22);
            this.metroStatusBar5.TabIndex = 20;
            // 
            // labelItem5
            // 
            this.labelItem5.Name = "labelItem5";
            // 
            // metroStatusBar2
            // 
            this.metroStatusBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroStatusBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar2.ContainerControlProcessDialogKey = true;
            this.metroStatusBar2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar2.DragDropSupport = true;
            this.metroStatusBar2.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar2.ForeColor = System.Drawing.Color.Black;
            this.metroStatusBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem2});
            this.metroStatusBar2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.metroStatusBar2.Location = new System.Drawing.Point(15, 370);
            this.metroStatusBar2.Name = "metroStatusBar2";
            this.metroStatusBar2.Size = new System.Drawing.Size(477, 22);
            this.metroStatusBar2.TabIndex = 21;
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 392);
            this.Controls.Add(this.metroStatusBar2);
            this.Controls.Add(this.metroStatusBar5);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.metroStatusBar4);
            this.Controls.Add(this.LbUsuario);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.BtAutenticar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNome);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Autenticação";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSenha;
        private DevComponents.DotNetBar.ButtonX BtAutenticar;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX LbUsuario;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar4;
        private DevComponents.DotNetBar.LabelItem labelItem4;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar5;
        private DevComponents.DotNetBar.LabelItem labelItem5;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar2;
        private DevComponents.DotNetBar.LabelItem labelItem2;
    }
}