namespace Text_to_speech
{
    partial class Form1
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
            this.textentrada = new System.Windows.Forms.TextBox();
            this.Reta = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.volumeTrackbar = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.play = new DevComponents.DotNetBar.ButtonX();
            this.btnsave = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.BtLimpar = new DevComponents.DotNetBar.ButtonX();
            this.btnPause = new DevComponents.DotNetBar.ButtonX();
            this.btnStop = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.Reta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // textentrada
            // 
            this.textentrada.BackColor = System.Drawing.Color.White;
            this.textentrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textentrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textentrada.Location = new System.Drawing.Point(12, 49);
            this.textentrada.Multiline = true;
            this.textentrada.Name = "textentrada";
            this.textentrada.Size = new System.Drawing.Size(693, 260);
            this.textentrada.TabIndex = 0;
            this.textentrada.TextChanged += new System.EventHandler(this.textentrada_TextChanged);
            // 
            // Reta
            // 
            this.Reta.Location = new System.Drawing.Point(91, 315);
            this.Reta.Name = "Reta";
            this.Reta.Size = new System.Drawing.Size(320, 45);
            this.Reta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Velocidade :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Volume:";
            // 
            // volumeTrackbar
            // 
            this.volumeTrackbar.Location = new System.Drawing.Point(91, 352);
            this.volumeTrackbar.Name = "volumeTrackbar";
            this.volumeTrackbar.Size = new System.Drawing.Size(320, 45);
            this.volumeTrackbar.TabIndex = 6;
            this.volumeTrackbar.Value = 5;
            this.volumeTrackbar.Scroll += new System.EventHandler(this.volumeTrackbar_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(690, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.TabIndex = 0;
            this.metroButton1.UseSelectable = true;
            // 
            // play
            // 
            this.play.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.play.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.play.Location = new System.Drawing.Point(459, 315);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(54, 45);
            this.play.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.play.Symbol = "57399";
            this.play.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.play.TabIndex = 10;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // btnsave
            // 
            this.btnsave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsave.Location = new System.Drawing.Point(519, 365);
            this.btnsave.Name = "btnsave";
            this.btnsave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
            this.btnsave.Size = new System.Drawing.Size(54, 45);
            this.btnsave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsave.Symbol = "";
            this.btnsave.TabIndex = 11;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(459, 366);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(54, 45);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "";
            this.buttonX3.TabIndex = 12;
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // BtLimpar
            // 
            this.BtLimpar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtLimpar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BtLimpar.Location = new System.Drawing.Point(639, 315);
            this.BtLimpar.Name = "BtLimpar";
            this.BtLimpar.Size = new System.Drawing.Size(57, 45);
            this.BtLimpar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BtLimpar.Symbol = "";
            this.BtLimpar.TabIndex = 13;
            this.BtLimpar.Click += new System.EventHandler(this.BtLimpar_Click);
            // 
            // btnPause
            // 
            this.btnPause.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPause.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPause.Location = new System.Drawing.Point(519, 315);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(54, 44);
            this.btnPause.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPause.Symbol = "";
            this.btnPause.TabIndex = 14;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStop.Location = new System.Drawing.Point(579, 315);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(54, 44);
            this.btnStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStop.Symbol = "";
            this.btnStop.TabIndex = 15;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 445);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.BtLimpar);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.play);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.volumeTrackbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reta);
            this.Controls.Add(this.textentrada);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textentrada;
        private System.Windows.Forms.TrackBar Reta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar volumeTrackbar;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private DevComponents.DotNetBar.ButtonX play;
        private DevComponents.DotNetBar.ButtonX btnsave;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX BtLimpar;
        private DevComponents.DotNetBar.ButtonX btnPause;
        private DevComponents.DotNetBar.ButtonX btnStop;
    }
}

