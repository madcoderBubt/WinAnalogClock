namespace DigitalClock
{
    partial class AnalogClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalogClock));
            this.AnalogDisplay = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.my_Angle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AnalogDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // AnalogDisplay
            // 
            this.AnalogDisplay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AnalogDisplay.Location = new System.Drawing.Point(12, 12);
            this.AnalogDisplay.MaximumSize = new System.Drawing.Size(360, 337);
            this.AnalogDisplay.MinimumSize = new System.Drawing.Size(360, 337);
            this.AnalogDisplay.Name = "AnalogDisplay";
            this.AnalogDisplay.Size = new System.Drawing.Size(360, 337);
            this.AnalogDisplay.TabIndex = 0;
            this.AnalogDisplay.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // my_Angle
            // 
            this.my_Angle.Location = new System.Drawing.Point(12, 355);
            this.my_Angle.Name = "my_Angle";
            this.my_Angle.ReadOnly = true;
            this.my_Angle.Size = new System.Drawing.Size(255, 20);
            this.my_Angle.TabIndex = 2;
            this.my_Angle.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Angle";
            // 
            // t
            // 
            this.t.Enabled = true;
            this.t.Interval = 1000;
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // AnalogClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.my_Angle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnalogDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnalogClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Analog Clock";
            ((System.ComponentModel.ISupportInitialize)(this.AnalogDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AnalogDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox my_Angle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer t;
    }
}