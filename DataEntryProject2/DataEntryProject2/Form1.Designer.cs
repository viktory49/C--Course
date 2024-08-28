namespace DataEntryProject2
{
    partial class frmDataEntry
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grbDataEntry = new GroupBox();
            btnClear = new Button();
            btnAccept = new Button();
            txtZip = new TextBox();
            txtState = new TextBox();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grbTimer = new GroupBox();
            btnExit = new Button();
            btnPause = new Button();
            btnStart = new Button();
            txtTimer = new TextBox();
            timTimer = new System.Windows.Forms.Timer(components);
            grbDataEntry.SuspendLayout();
            grbTimer.SuspendLayout();
            SuspendLayout();
            // 
            // grbDataEntry
            // 
            grbDataEntry.BackColor = Color.LightGray;
            grbDataEntry.Controls.Add(btnClear);
            grbDataEntry.Controls.Add(btnAccept);
            grbDataEntry.Controls.Add(txtZip);
            grbDataEntry.Controls.Add(txtState);
            grbDataEntry.Controls.Add(txtCity);
            grbDataEntry.Controls.Add(txtAddress);
            grbDataEntry.Controls.Add(txtName);
            grbDataEntry.Controls.Add(label5);
            grbDataEntry.Controls.Add(label4);
            grbDataEntry.Controls.Add(label3);
            grbDataEntry.Controls.Add(label2);
            grbDataEntry.Controls.Add(label1);
            grbDataEntry.Location = new Point(69, 45);
            grbDataEntry.Margin = new Padding(4, 3, 4, 3);
            grbDataEntry.Name = "grbDataEntry";
            grbDataEntry.Padding = new Padding(4, 3, 4, 3);
            grbDataEntry.Size = new Size(405, 396);
            grbDataEntry.TabIndex = 0;
            grbDataEntry.TabStop = false;
            grbDataEntry.Text = "DataEntry";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientActiveCaption;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Location = new Point(268, 316);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 46);
            btnClear.TabIndex = 11;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = SystemColors.GradientActiveCaption;
            btnAccept.FlatStyle = FlatStyle.Popup;
            btnAccept.Location = new Point(151, 316);
            btnAccept.Margin = new Padding(4, 3, 4, 3);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(98, 46);
            btnAccept.TabIndex = 10;
            btnAccept.Text = "&Accept";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // txtZip
            // 
            txtZip.BackColor = Color.LightYellow;
            txtZip.Location = new Point(151, 247);
            txtZip.Margin = new Padding(4, 3, 4, 3);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(216, 35);
            txtZip.TabIndex = 9;
            txtZip.KeyPress += txtInput_KeyPress;
            // 
            // txtState
            // 
            txtState.BackColor = Color.LightYellow;
            txtState.Location = new Point(151, 199);
            txtState.Margin = new Padding(4, 3, 4, 3);
            txtState.Name = "txtState";
            txtState.Size = new Size(216, 35);
            txtState.TabIndex = 8;
            txtState.KeyPress += txtInput_KeyPress;
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.LightYellow;
            txtCity.Location = new Point(151, 152);
            txtCity.Margin = new Padding(4, 3, 4, 3);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(216, 35);
            txtCity.TabIndex = 7;
            txtCity.KeyPress += txtInput_KeyPress;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.LightYellow;
            txtAddress.Location = new Point(151, 103);
            txtAddress.Margin = new Padding(4, 3, 4, 3);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(216, 35);
            txtAddress.TabIndex = 6;
            txtAddress.KeyPress += txtInput_KeyPress;
            // 
            // txtName
            // 
            txtName.BackColor = Color.LightYellow;
            txtName.Location = new Point(151, 55);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(216, 35);
            txtName.TabIndex = 5;
            txtName.TextChanged += txtName_TextChanged;
            txtName.KeyPress += txtInput_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 247);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 30);
            label5.TabIndex = 6;
            label5.Text = "Zip";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 199);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 30);
            label4.TabIndex = 5;
            label4.Text = "State";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 152);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 30);
            label3.TabIndex = 4;
            label3.Text = "City";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 103);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 30);
            label2.TabIndex = 3;
            label2.Text = "Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(47, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 2;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grbTimer
            // 
            grbTimer.BackColor = Color.LightGray;
            grbTimer.Controls.Add(btnExit);
            grbTimer.Controls.Add(btnPause);
            grbTimer.Controls.Add(btnStart);
            grbTimer.Controls.Add(txtTimer);
            grbTimer.Location = new Point(516, 45);
            grbTimer.Margin = new Padding(4, 3, 4, 3);
            grbTimer.Name = "grbTimer";
            grbTimer.Padding = new Padding(4, 3, 4, 3);
            grbTimer.Size = new Size(230, 396);
            grbTimer.TabIndex = 1;
            grbTimer.TabStop = false;
            grbTimer.Text = "Timer";
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GradientActiveCaption;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(65, 316);
            btnExit.Margin = new Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(98, 46);
            btnExit.TabIndex = 14;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnPause
            // 
            btnPause.BackColor = SystemColors.GradientActiveCaption;
            btnPause.FlatStyle = FlatStyle.Popup;
            btnPause.Location = new Point(65, 189);
            btnPause.Margin = new Padding(4, 3, 4, 3);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(98, 40);
            btnPause.TabIndex = 13;
            btnPause.Text = "&Pause";
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.GradientActiveCaption;
            btnStart.FlatStyle = FlatStyle.Popup;
            btnStart.Location = new Point(65, 99);
            btnStart.Margin = new Padding(4, 3, 4, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(98, 45);
            btnStart.TabIndex = 12;
            btnStart.Text = "&Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // txtTimer
            // 
            txtTimer.BackColor = Color.LightYellow;
            txtTimer.Location = new Point(32, 34);
            txtTimer.Margin = new Padding(4, 3, 4, 3);
            txtTimer.Name = "txtTimer";
            txtTimer.ReadOnly = true;
            txtTimer.Size = new Size(166, 35);
            txtTimer.TabIndex = 0;
            txtTimer.Text = "00:00:00";
            txtTimer.TextAlign = HorizontalAlignment.Center;
            txtTimer.TextChanged += txtTimer_TextChanged;
            // 
            // timTimer
            // 
            timTimer.Interval = 1000;
            timTimer.Tick += timTimer_Tick;
            // 
            // frmDataEntry
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(813, 465);
            Controls.Add(grbTimer);
            Controls.Add(grbDataEntry);
            Font = new Font("Segoe UI", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDataEntry";
            Text = "Data Entry Form";
            grbDataEntry.ResumeLayout(false);
            grbDataEntry.PerformLayout();
            grbTimer.ResumeLayout(false);
            grbTimer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDataEntry;
        private GroupBox grbTimer;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtZip;
        private TextBox txtState;
        private TextBox txtCity;
        private TextBox txtAddress;
        private TextBox txtName;
        private Button btnClear;
        private Button btnAccept;
        private Button btnStart;
        private TextBox txtTimer;
        private Button btnExit;
        private Button btnPause;
        private System.Windows.Forms.Timer timTimer;
    }
}
