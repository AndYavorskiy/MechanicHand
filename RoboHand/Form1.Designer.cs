namespace RoboHand
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trackBarValueLabel1 = new System.Windows.Forms.Label();
            this.trackBarValueLabel2 = new System.Windows.Forms.Label();
            this.trackBarValueLabel3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3_scroll = new System.Windows.Forms.Label();
            this.label2_scroll = new System.Windows.Forms.Label();
            this.label1_scroll = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(124, 12);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(361, 45);
            this.trackBar1.SmallChange = 2;
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar1_MouseUp);
            // 
            // trackBar2
            // 
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(124, 74);
            this.trackBar2.Maximum = 180;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(361, 45);
            this.trackBar2.SmallChange = 2;
            this.trackBar2.TabIndex = 1;
            this.trackBar2.TickFrequency = 5;
            this.trackBar2.Scroll += new System.EventHandler(this.TrackBar2_Scroll);
            this.trackBar2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar2_MouseUp);
            // 
            // trackBar3
            // 
            this.trackBar3.LargeChange = 1;
            this.trackBar3.Location = new System.Drawing.Point(124, 136);
            this.trackBar3.Maximum = 180;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(361, 45);
            this.trackBar3.SmallChange = 2;
            this.trackBar3.TabIndex = 2;
            this.trackBar3.TickFrequency = 5;
            this.trackBar3.Value = 90;
            this.trackBar3.Scroll += new System.EventHandler(this.TrackBar3_Scroll);
            this.trackBar3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar3_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Servo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Servo 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Servo 3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 6;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // trackBarValueLabel1
            // 
            this.trackBarValueLabel1.AutoSize = true;
            this.trackBarValueLabel1.Location = new System.Drawing.Point(71, 12);
            this.trackBarValueLabel1.Name = "trackBarValueLabel1";
            this.trackBarValueLabel1.Size = new System.Drawing.Size(13, 13);
            this.trackBarValueLabel1.TabIndex = 8;
            this.trackBarValueLabel1.Text = "0";
            // 
            // trackBarValueLabel2
            // 
            this.trackBarValueLabel2.AutoSize = true;
            this.trackBarValueLabel2.Location = new System.Drawing.Point(71, 74);
            this.trackBarValueLabel2.Name = "trackBarValueLabel2";
            this.trackBarValueLabel2.Size = new System.Drawing.Size(13, 13);
            this.trackBarValueLabel2.TabIndex = 9;
            this.trackBarValueLabel2.Text = "0";
            // 
            // trackBarValueLabel3
            // 
            this.trackBarValueLabel3.AutoSize = true;
            this.trackBarValueLabel3.Location = new System.Drawing.Point(71, 136);
            this.trackBarValueLabel3.Name = "trackBarValueLabel3";
            this.trackBarValueLabel3.Size = new System.Drawing.Size(19, 13);
            this.trackBarValueLabel3.TabIndex = 10;
            this.trackBarValueLabel3.Text = "90";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 11;
            this.button2.Text = "Scan...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(617, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(219, 237);
            this.textBox1.TabIndex = 12;
            this.textBox1.WordWrap = false;
            // 
            // label3_scroll
            // 
            this.label3_scroll.AutoSize = true;
            this.label3_scroll.Location = new System.Drawing.Point(491, 136);
            this.label3_scroll.Name = "label3_scroll";
            this.label3_scroll.Size = new System.Drawing.Size(13, 13);
            this.label3_scroll.TabIndex = 15;
            this.label3_scroll.Text = "0";
            // 
            // label2_scroll
            // 
            this.label2_scroll.AutoSize = true;
            this.label2_scroll.Location = new System.Drawing.Point(491, 74);
            this.label2_scroll.Name = "label2_scroll";
            this.label2_scroll.Size = new System.Drawing.Size(13, 13);
            this.label2_scroll.TabIndex = 14;
            this.label2_scroll.Text = "0";
            // 
            // label1_scroll
            // 
            this.label1_scroll.AutoSize = true;
            this.label1_scroll.Location = new System.Drawing.Point(491, 12);
            this.label1_scroll.Name = "label1_scroll";
            this.label1_scroll.Size = new System.Drawing.Size(13, 13);
            this.label1_scroll.TabIndex = 13;
            this.label1_scroll.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 261);
            this.Controls.Add(this.label3_scroll);
            this.Controls.Add(this.label2_scroll);
            this.Controls.Add(this.label1_scroll);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.trackBarValueLabel3);
            this.Controls.Add(this.trackBarValueLabel2);
            this.Controls.Add(this.trackBarValueLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label trackBarValueLabel1;
        private System.Windows.Forms.Label trackBarValueLabel2;
        private System.Windows.Forms.Label trackBarValueLabel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3_scroll;
        private System.Windows.Forms.Label label2_scroll;
        private System.Windows.Forms.Label label1_scroll;
    }
}

