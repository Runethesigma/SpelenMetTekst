namespace SpelenMetTekst
{
    partial class Form1
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
            IsButton = new Button();
            VraagtekenButton = new Button();
            HeelButton = new Button();
            TofButton = new Button();
            TitelLabel = new Label();
            IsLabel = new Label();
            HeelLabel = new Label();
            TofLabel = new Label();
            SuperLabel = new Label();
            HeelDoorstreeptLabel = new Label();
            SuspendLayout();
            // 
            // IsButton
            // 
            IsButton.Location = new Point(12, 49);
            IsButton.Name = "IsButton";
            IsButton.Size = new Size(75, 31);
            IsButton.TabIndex = 0;
            IsButton.Text = "is";
            IsButton.UseVisualStyleBackColor = true;
            IsButton.Click += IsButton_Click;
            // 
            // VraagtekenButton
            // 
            VraagtekenButton.Location = new Point(93, 83);
            VraagtekenButton.Name = "VraagtekenButton";
            VraagtekenButton.Size = new Size(75, 31);
            VraagtekenButton.TabIndex = 1;
            VraagtekenButton.Text = "?";
            VraagtekenButton.UseVisualStyleBackColor = true;
            VraagtekenButton.Visible = false;
            VraagtekenButton.Click += VraagtekenButton_Click;
            // 
            // HeelButton
            // 
            HeelButton.Location = new Point(93, 49);
            HeelButton.Name = "HeelButton";
            HeelButton.Size = new Size(75, 31);
            HeelButton.TabIndex = 2;
            HeelButton.Text = "heel";
            HeelButton.UseVisualStyleBackColor = false;
            HeelButton.Visible = false;
            HeelButton.Click += HeelButton_Click;
            // 
            // TofButton
            // 
            TofButton.Location = new Point(174, 49);
            TofButton.Name = "TofButton";
            TofButton.Size = new Size(75, 31);
            TofButton.TabIndex = 3;
            TofButton.Text = "tof";
            TofButton.UseVisualStyleBackColor = true;
            TofButton.Visible = false;
            TofButton.Click += TofButton_Click;
            // 
            // TitelLabel
            // 
            TitelLabel.AutoSize = true;
            TitelLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            TitelLabel.Location = new Point(12, 9);
            TitelLabel.Name = "TitelLabel";
            TitelLabel.Size = new Size(240, 30);
            TitelLabel.TabIndex = 4;
            TitelLabel.Text = "Handelsschool Broeders";
            // 
            // IsLabel
            // 
            IsLabel.AutoSize = true;
            IsLabel.Font = new Font("Segoe UI", 13F);
            IsLabel.Location = new Point(39, 132);
            IsLabel.Name = "IsLabel";
            IsLabel.Size = new Size(24, 25);
            IsLabel.TabIndex = 5;
            IsLabel.Text = "is";
            IsLabel.Visible = false;
            // 
            // HeelLabel
            // 
            HeelLabel.AutoSize = true;
            HeelLabel.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeelLabel.Location = new Point(69, 134);
            HeelLabel.Name = "HeelLabel";
            HeelLabel.Size = new Size(42, 23);
            HeelLabel.TabIndex = 6;
            HeelLabel.Text = "heel";
            HeelLabel.Visible = false;
            // 
            // TofLabel
            // 
            TofLabel.AutoSize = true;
            TofLabel.Font = new Font("Segoe UI", 13F);
            TofLabel.Location = new Point(119, 132);
            TofLabel.Name = "TofLabel";
            TofLabel.Size = new Size(35, 25);
            TofLabel.TabIndex = 7;
            TofLabel.Text = "tof";
            TofLabel.Visible = false;
            // 
            // SuperLabel
            // 
            SuperLabel.AutoSize = true;
            SuperLabel.Font = new Font("Segoe UI", 15F);
            SuperLabel.Location = new Point(69, 153);
            SuperLabel.Name = "SuperLabel";
            SuperLabel.Size = new Size(63, 28);
            SuperLabel.TabIndex = 8;
            SuperLabel.Text = "Super";
            SuperLabel.Visible = false;
            // 
            // HeelDoorstreeptLabel
            // 
            HeelDoorstreeptLabel.AutoSize = true;
            HeelDoorstreeptLabel.Font = new Font("Segoe UI", 12.75F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
            HeelDoorstreeptLabel.Location = new Point(69, 134);
            HeelDoorstreeptLabel.Name = "HeelDoorstreeptLabel";
            HeelDoorstreeptLabel.Size = new Size(42, 23);
            HeelDoorstreeptLabel.TabIndex = 9;
            HeelDoorstreeptLabel.Text = "heel";
            HeelDoorstreeptLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 190);
            Controls.Add(HeelDoorstreeptLabel);
            Controls.Add(SuperLabel);
            Controls.Add(TofLabel);
            Controls.Add(HeelLabel);
            Controls.Add(IsLabel);
            Controls.Add(TitelLabel);
            Controls.Add(TofButton);
            Controls.Add(HeelButton);
            Controls.Add(VraagtekenButton);
            Controls.Add(IsButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button IsButton;
        private Button VraagtekenButton;
        private Button HeelButton;
        private Button TofButton;
        private Label TitelLabel;
        private Label IsLabel;
        private Label HeelLabel;
        private Label TofLabel;
        private Label SuperLabel;
        private Label HeelDoorstreeptLabel;
    }
}
