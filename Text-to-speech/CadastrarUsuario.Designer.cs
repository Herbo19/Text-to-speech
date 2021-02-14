namespace Text_to_speech
{
    partial class CadastrarUsuario
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
            this.TxtSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.BtCadastrar = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
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
            this.TxtNome.Location = new System.Drawing.Point(73, 35);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(256, 33);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TxtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtSenha.HintForeColor = System.Drawing.Color.Empty;
            this.TxtSenha.HintText = "Palavra Passe";
            this.TxtSenha.isPassword = false;
            this.TxtSenha.LineFocusedColor = System.Drawing.Color.Blue;
            this.TxtSenha.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtSenha.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TxtSenha.LineThickness = 3;
            this.TxtSenha.Location = new System.Drawing.Point(356, 35);
            this.TxtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(256, 33);
            this.TxtSenha.TabIndex = 1;
            this.TxtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CmbSexo
            // 
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "UsuarioComum",
            "Adm"});
            this.CmbSexo.Location = new System.Drawing.Point(160, 98);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(121, 21);
            this.CmbSexo.TabIndex = 2;
            // 
            // BtCadastrar
            // 
            this.BtCadastrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtCadastrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtCadastrar.Location = new System.Drawing.Point(369, 102);
            this.BtCadastrar.Name = "BtCadastrar";
            this.BtCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtCadastrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtCadastrar.Symbol = "57673";
            this.BtCadastrar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.BtCadastrar.TabIndex = 3;
            this.BtCadastrar.Click += new System.EventHandler(this.BtCadastrar_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(493, 102);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.TabIndex = 4;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(88, 98);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(52, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Acesso";
            // 
            // CadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 396);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.BtCadastrar);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtNome);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CadastrarUsuario";
            this.Text = "MetroForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtNome;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtSenha;
        private System.Windows.Forms.ComboBox CmbSexo;
        private DevComponents.DotNetBar.ButtonX BtCadastrar;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}