namespace Text_to_speech
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtMensagem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.trackBarVelocidade = new System.Windows.Forms.TrackBar();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnPause = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.btnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.btnLimpar = new DevComponents.DotNetBar.ButtonX();
            this.btnContinuar = new DevComponents.DotNetBar.ButtonX();
            this.cBVozes = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnTxt = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocidade)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, -6);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(297, 44);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Por favor digite o texto abaixo:";
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtMensagem.Border.Class = "TextBoxBorder";
            this.txtMensagem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMensagem.DisabledBackColor = System.Drawing.Color.White;
            this.txtMensagem.ForeColor = System.Drawing.Color.Black;
            this.txtMensagem.Location = new System.Drawing.Point(12, 74);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.PreventEnterBeep = true;
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensagem.Size = new System.Drawing.Size(521, 236);
            this.txtMensagem.TabIndex = 1;
            this.txtMensagem.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(12, 316);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Volume:";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.BackColor = System.Drawing.Color.White;
            this.trackBarVolume.LargeChange = 10;
            this.trackBarVolume.Location = new System.Drawing.Point(28, 358);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.Size = new System.Drawing.Size(45, 178);
            this.trackBarVolume.SmallChange = 5;
            this.trackBarVolume.TabIndex = 3;
            this.trackBarVolume.Value = 5;
            // 
            // trackBarVelocidade
            // 
            this.trackBarVelocidade.BackColor = System.Drawing.Color.White;
            this.trackBarVelocidade.Location = new System.Drawing.Point(135, 365);
            this.trackBarVelocidade.Minimum = -10;
            this.trackBarVelocidade.Name = "trackBarVelocidade";
            this.trackBarVelocidade.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVelocidade.Size = new System.Drawing.Size(45, 171);
            this.trackBarVelocidade.TabIndex = 4;
            this.trackBarVelocidade.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(107, 316);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(118, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Velocidade:";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(254, 318);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 47);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "Play";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnPause
            // 
            this.btnPause.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPause.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPause.Location = new System.Drawing.Point(353, 318);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 47);
            this.btnPause.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPause.TabIndex = 7;
            this.btnPause.Text = "Pause";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGuardar.Location = new System.Drawing.Point(254, 386);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 41);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelar.Location = new System.Drawing.Point(353, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 41);
            this.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpar.Location = new System.Drawing.Point(458, 386);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 41);
            this.btnLimpar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContinuar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContinuar.Location = new System.Drawing.Point(458, 318);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 47);
            this.btnContinuar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContinuar.TabIndex = 11;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // cBVozes
            // 
            this.cBVozes.DisplayMember = "Text";
            this.cBVozes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBVozes.ForeColor = System.Drawing.Color.Black;
            this.cBVozes.FormattingEnabled = true;
            this.cBVozes.ItemHeight = 17;
            this.cBVozes.Location = new System.Drawing.Point(12, 48);
            this.cBVozes.Name = "cBVozes";
            this.cBVozes.Size = new System.Drawing.Size(521, 23);
            this.cBVozes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cBVozes.TabIndex = 12;
            this.cBVozes.SelectedIndexChanged += new System.EventHandler(this.cBVozes_SelectedIndexChanged);
            // 
            // btnTxt
            // 
            this.btnTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTxt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTxt.Location = new System.Drawing.Point(353, 447);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(75, 47);
            this.btnTxt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTxt.TabIndex = 13;
            this.btnTxt.Text = ".txt";
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 548);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.cBVozes);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.trackBarVelocidade);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.Text = "MetroForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMensagem;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.TrackBar trackBarVelocidade;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btnPause;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.ButtonX btnCancelar;
        private DevComponents.DotNetBar.ButtonX btnLimpar;
        private DevComponents.DotNetBar.ButtonX btnContinuar;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cBVozes;
        private DevComponents.DotNetBar.ButtonX btnTxt;
    }
}