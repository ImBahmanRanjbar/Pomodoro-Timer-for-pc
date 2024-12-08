namespace PomodoroTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.richsec = new System.Windows.Forms.RichTextBox();
            this.richmin = new System.Windows.Forms.RichTextBox();
            this.richours = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richsec
            // 
            this.richsec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richsec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richsec.Enabled = false;
            this.richsec.Font = new System.Drawing.Font("NSimSun", 60F);
            this.richsec.Location = new System.Drawing.Point(477, 146);
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
            this.richmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richmin.Enabled = false;
            this.richmin.Font = new System.Drawing.Font("NSimSun", 60F);
            this.richmin.Location = new System.Drawing.Point(139, 146);
            this.richmin.Margin = new System.Windows.Forms.Padding(0);
            this.richmin.MaxLength = 2;
            this.richmin.Name = "richmin";
            this.richmin.ReadOnly = true;
            this.richmin.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richmin.Size = new System.Drawing.Size(115, 100);
            this.richmin.TabIndex = 8;
            this.richmin.Text = "00";
            // 
            // richours
            // 
            this.richours.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richours.Font = new System.Drawing.Font("NSimSun", 60F);
            this.richours.Location = new System.Drawing.Point(-14, 161);
            this.richours.Margin = new System.Windows.Forms.Padding(0);
            this.richours.MaxLength = 2;
            this.richours.Name = "richours";
            this.richours.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richours.Size = new System.Drawing.Size(115, 100);
            this.richours.TabIndex = 9;
            this.richours.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkCyan;
            this.label11.Location = new System.Drawing.Point(489, 77);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "SECONDS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.DarkCyan;
            this.label10.Location = new System.Drawing.Point(155, 77);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "MINIUTES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkCyan;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.Plum;
            this.label5.Location = new System.Drawing.Point(13, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "HOURS";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(333, 421);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 10;
            this.BtnStart.Text = "Pause";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(330, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "BreakTime";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 528);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.richsec);
            this.Controls.Add(this.richmin);
            this.Controls.Add(this.richours);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richsec;
        private System.Windows.Forms.RichTextBox richmin;
        private System.Windows.Forms.RichTextBox richours;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}