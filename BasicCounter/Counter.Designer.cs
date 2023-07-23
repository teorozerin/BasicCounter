namespace BasicCounter
{
    partial class Counter
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
            components = new System.ComponentModel.Container();
            lblSecond = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnReset = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblSecond
            // 
            lblSecond.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            lblSecond.Location = new Point(94, 54);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(173, 110);
            lblSecond.TabIndex = 0;
            lblSecond.Text = "0";
            lblSecond.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(26, 190);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(88, 59);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnStop.Location = new Point(138, 190);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(88, 59);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(246, 190);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(88, 59);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Counter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 270);
            Controls.Add(btnReset);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblSecond);
            Name = "Counter";
            Text = "Counter";
            ResumeLayout(false);
        }

        #endregion

        private Label lblSecond;
        private Button btnStart;
        private Button btnStop;
        private Button btnReset;
        private System.Windows.Forms.Timer timer1;
    }
}