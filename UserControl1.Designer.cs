namespace PomodoroTimer
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.richsec = new System.Windows.Forms.RichTextBox();
            this.richmin = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.label10.ForeColor = System.Drawing.Color.Plum;
            this.label10.Location = new System.Drawing.Point(391, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "BreakTime";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richsec
            // 
            this.richsec.BackColor = System.Drawing.Color.White;
            this.richsec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richsec.Font = new System.Drawing.Font("NSimSun", 60F);
            this.richsec.Location = new System.Drawing.Point(466, 140);
            this.richsec.Margin = new System.Windows.Forms.Padding(0);
            this.richsec.MaxLength = 2;
            this.richsec.Name = "richsec";
            this.richsec.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richsec.Size = new System.Drawing.Size(115, 100);
            this.richsec.TabIndex = 8;
            this.richsec.Text = "00";
            // 
            // richmin
            // 
            this.richmin.BackColor = System.Drawing.Color.White;
            this.richmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richmin.Font = new System.Drawing.Font("NSimSun", 60F);
            this.richmin.Location = new System.Drawing.Point(294, 140);
            this.richmin.Margin = new System.Windows.Forms.Padding(0);
            this.richmin.MaxLength = 2;
            this.richmin.Name = "richmin";
            this.richmin.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richmin.Size = new System.Drawing.Size(115, 100);
            this.richmin.TabIndex = 9;
            this.richmin.Text = "00";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richsec);
            this.Controls.Add(this.richmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(871, 439);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richsec;
        private System.Windows.Forms.RichTextBox richmin;
    }
}
