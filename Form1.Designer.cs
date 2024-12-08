namespace PomodoroTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.richsec = new System.Windows.Forms.RichTextBox();
            this.richmin = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CountNumtext = new System.Windows.Forms.RichTextBox();
            this.Btnstart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richours = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnstart2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richsec
            // 
            this.richsec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richsec.BackColor = System.Drawing.Color.White;
            this.richsec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richsec.Enabled = false;
            this.richsec.Font = new System.Drawing.Font("NSimSun", 60F);
            this.richsec.Location = new System.Drawing.Point(616, 299);
            this.richsec.Margin = new System.Windows.Forms.Padding(0);
            this.richsec.MaxLength = 2;
            this.richsec.Name = "richsec";
            this.richsec.ReadOnly = true;
            this.richsec.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richsec.Size = new System.Drawing.Size(115, 100);
            this.richsec.TabIndex = 7;
            this.richsec.Text = "00";
            // 
            // richmin
            // 
            this.richmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richmin.BackColor = System.Drawing.Color.White;
            this.richmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richmin.Enabled = false;
            this.richmin.Font = new System.Drawing.Font("NSimSun", 60F);
            this.richmin.Location = new System.Drawing.Point(393, 300);
            this.richmin.Margin = new System.Windows.Forms.Padding(0);
            this.richmin.MaxLength = 2;
            this.richmin.Name = "richmin";
            this.richmin.ReadOnly = true;
            this.richmin.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richmin.Size = new System.Drawing.Size(115, 100);
            this.richmin.TabIndex = 8;
            this.richmin.Text = "00";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Plum;
            this.label11.Location = new System.Drawing.Point(613, 256);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "SECONDS";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.Plum;
            this.label10.Location = new System.Drawing.Point(409, 256);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "MINIUTES";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Plum;
            this.label1.Location = new System.Drawing.Point(537, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count";
            // 
            // CountNumtext
            // 
            this.CountNumtext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CountNumtext.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CountNumtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CountNumtext.Font = new System.Drawing.Font("NSimSun", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountNumtext.Location = new System.Drawing.Point(506, 123);
            this.CountNumtext.Margin = new System.Windows.Forms.Padding(0);
            this.CountNumtext.MaxLength = 2;
            this.CountNumtext.Multiline = false;
            this.CountNumtext.Name = "CountNumtext";
            this.CountNumtext.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CountNumtext.Size = new System.Drawing.Size(115, 100);
            this.CountNumtext.TabIndex = 8;
            this.CountNumtext.Text = "";
            // 
            // Btnstart
            // 
            this.Btnstart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btnstart.Location = new System.Drawing.Point(524, 508);
            this.Btnstart.Name = "Btnstart";
            this.Btnstart.Size = new System.Drawing.Size(75, 40);
            this.Btnstart.TabIndex = 10;
            this.Btnstart.Text = "Start";
            this.Btnstart.UseVisualStyleBackColor = true;
            this.Btnstart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(534, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 80);
            this.label3.TabIndex = 15;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(534, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 80);
            this.label4.TabIndex = 15;
            this.label4.Text = ".";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1057, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 25, 25, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 52);
            this.button2.TabIndex = 16;
            this.button2.Text = "!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(521, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "WorkTime";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richours
            // 
            this.richours.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richours.Font = new System.Drawing.Font("NSimSun", 60F);
            this.richours.Location = new System.Drawing.Point(158, 285);
            this.richours.Margin = new System.Windows.Forms.Padding(0);
            this.richours.MaxLength = 2;
            this.richours.Name = "richours";
            this.richours.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richours.Size = new System.Drawing.Size(115, 100);
            this.richours.TabIndex = 19;
            this.richours.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkCyan;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.Plum;
            this.label5.Location = new System.Drawing.Point(185, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "HOURS";
            // 
            // btnstart2
            // 
            this.btnstart2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnstart2.Location = new System.Drawing.Point(524, 508);
            this.btnstart2.Name = "btnstart2";
            this.btnstart2.Size = new System.Drawing.Size(75, 40);
            this.btnstart2.TabIndex = 10;
            this.btnstart2.Text = "Start";
            this.btnstart2.UseVisualStyleBackColor = true;
            this.btnstart2.Click += new System.EventHandler(this.btnstart2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1121, 619);
            this.Controls.Add(this.richours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnstart2);
            this.Controls.Add(this.Btnstart);
            this.Controls.Add(this.richsec);
            this.Controls.Add(this.CountNumtext);
            this.Controls.Add(this.richmin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PomodoroTimer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richsec;
        private System.Windows.Forms.RichTextBox richmin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox CountNumtext;
        private System.Windows.Forms.Button Btnstart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnstart2;
    }
}

