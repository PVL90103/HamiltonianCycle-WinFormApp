namespace HamiltonianCycle_winform
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.formName = new System.Windows.Forms.Label();
            this.Footer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SP_back_panel = new System.Windows.Forms.Panel();
            this.WorkingPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.InputMatrix_button = new System.Windows.Forms.Button();
            this.ManualInput_text = new System.Windows.Forms.Label();
            this.ManualInput_label = new System.Windows.Forms.Label();
            this.startSolution_label = new System.Windows.Forms.Label();
            this.ReadFromFile_panel = new System.Windows.Forms.Panel();
            this.EnterPath_button = new System.Windows.Forms.Button();
            this.ReadFromFile_text = new System.Windows.Forms.Label();
            this.ReadFromFile_label = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuAuthor_label = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuAlgorithm_label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuHelp_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.Footer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SP_back_panel.SuspendLayout();
            this.WorkingPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.ReadFromFile_panel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logo.Location = new System.Drawing.Point(30, 66);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(225, 304);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.formName);
            this.panel1.Location = new System.Drawing.Point(305, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 472);
            this.panel1.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startButton.Location = new System.Drawing.Point(41, 237);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(126, 45);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start now";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // formName
            // 
            this.formName.AutoSize = true;
            this.formName.Font = new System.Drawing.Font("Trebuchet MS", 35F, System.Drawing.FontStyle.Bold);
            this.formName.ForeColor = System.Drawing.Color.White;
            this.formName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.formName.Location = new System.Drawing.Point(31, 145);
            this.formName.Name = "formName";
            this.formName.Size = new System.Drawing.Size(424, 59);
            this.formName.TabIndex = 0;
            this.formName.Text = "Hamiltonian Cycle";
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Footer.Controls.Add(this.panel3);
            this.Footer.Location = new System.Drawing.Point(0, 436);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(889, 28);
            this.Footer.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 0;
            // 
            // SP_back_panel
            // 
            this.SP_back_panel.Controls.Add(this.WorkingPanel);
            this.SP_back_panel.Controls.Add(this.Footer);
            this.SP_back_panel.Controls.Add(this.panel1);
            this.SP_back_panel.Controls.Add(this.MenuPanel);
            this.SP_back_panel.Controls.Add(this.logo);
            this.SP_back_panel.Location = new System.Drawing.Point(1, 0);
            this.SP_back_panel.Name = "SP_back_panel";
            this.SP_back_panel.Size = new System.Drawing.Size(888, 467);
            this.SP_back_panel.TabIndex = 5;
            // 
            // WorkingPanel
            // 
            this.WorkingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.WorkingPanel.Controls.Add(this.flowLayoutPanel5);
            this.WorkingPanel.Controls.Add(this.panel5);
            this.WorkingPanel.Controls.Add(this.startSolution_label);
            this.WorkingPanel.Controls.Add(this.ReadFromFile_panel);
            this.WorkingPanel.Location = new System.Drawing.Point(248, 0);
            this.WorkingPanel.Name = "WorkingPanel";
            this.WorkingPanel.Size = new System.Drawing.Size(635, 467);
            this.WorkingPanel.TabIndex = 8;
            this.WorkingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.WorkingPanel_Paint);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.flowLayoutPanel5.Location = new System.Drawing.Point(318, 172);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(5, 218);
            this.flowLayoutPanel5.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.InputMatrix_button);
            this.panel5.Controls.Add(this.ManualInput_text);
            this.panel5.Controls.Add(this.ManualInput_label);
            this.panel5.Location = new System.Drawing.Point(334, 171);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(232, 219);
            this.panel5.TabIndex = 5;
            // 
            // InputMatrix_button
            // 
            this.InputMatrix_button.BackColor = System.Drawing.Color.White;
            this.InputMatrix_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InputMatrix_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InputMatrix_button.FlatAppearance.BorderSize = 0;
            this.InputMatrix_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputMatrix_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputMatrix_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.InputMatrix_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InputMatrix_button.Location = new System.Drawing.Point(52, 174);
            this.InputMatrix_button.Name = "InputMatrix_button";
            this.InputMatrix_button.Size = new System.Drawing.Size(140, 42);
            this.InputMatrix_button.TabIndex = 3;
            this.InputMatrix_button.Text = "Input matrix";
            this.InputMatrix_button.UseVisualStyleBackColor = false;
            this.InputMatrix_button.Click += new System.EventHandler(this.InputMatrix_button_Click);
            // 
            // ManualInput_text
            // 
            this.ManualInput_text.AutoSize = true;
            this.ManualInput_text.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManualInput_text.ForeColor = System.Drawing.Color.Silver;
            this.ManualInput_text.Location = new System.Drawing.Point(26, 82);
            this.ManualInput_text.Name = "ManualInput_text";
            this.ManualInput_text.Size = new System.Drawing.Size(194, 44);
            this.ManualInput_text.TabIndex = 1;
            this.ManualInput_text.Text = "Input an adjacency matrix\r\nmanually with keyboard";
            // 
            // ManualInput_label
            // 
            this.ManualInput_label.AutoSize = true;
            this.ManualInput_label.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManualInput_label.ForeColor = System.Drawing.Color.White;
            this.ManualInput_label.Location = new System.Drawing.Point(61, 40);
            this.ManualInput_label.Name = "ManualInput_label";
            this.ManualInput_label.Size = new System.Drawing.Size(131, 27);
            this.ManualInput_label.TabIndex = 0;
            this.ManualInput_label.Text = "Manual input";
            // 
            // startSolution_label
            // 
            this.startSolution_label.AutoSize = true;
            this.startSolution_label.Font = new System.Drawing.Font("Trebuchet MS", 35F, System.Drawing.FontStyle.Bold);
            this.startSolution_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.startSolution_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startSolution_label.Location = new System.Drawing.Point(113, 86);
            this.startSolution_label.Name = "startSolution_label";
            this.startSolution_label.Size = new System.Drawing.Size(411, 59);
            this.startSolution_label.TabIndex = 6;
            this.startSolution_label.Text = "Start the solution";
            // 
            // ReadFromFile_panel
            // 
            this.ReadFromFile_panel.Controls.Add(this.EnterPath_button);
            this.ReadFromFile_panel.Controls.Add(this.ReadFromFile_text);
            this.ReadFromFile_panel.Controls.Add(this.ReadFromFile_label);
            this.ReadFromFile_panel.Location = new System.Drawing.Point(80, 170);
            this.ReadFromFile_panel.Name = "ReadFromFile_panel";
            this.ReadFromFile_panel.Size = new System.Drawing.Size(228, 220);
            this.ReadFromFile_panel.TabIndex = 4;
            // 
            // EnterPath_button
            // 
            this.EnterPath_button.BackColor = System.Drawing.Color.White;
            this.EnterPath_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnterPath_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterPath_button.FlatAppearance.BorderSize = 0;
            this.EnterPath_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterPath_button.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterPath_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.EnterPath_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EnterPath_button.Location = new System.Drawing.Point(43, 175);
            this.EnterPath_button.Name = "EnterPath_button";
            this.EnterPath_button.Size = new System.Drawing.Size(140, 42);
            this.EnterPath_button.TabIndex = 2;
            this.EnterPath_button.Text = "Enter file path";
            this.EnterPath_button.UseVisualStyleBackColor = false;
            this.EnterPath_button.Click += new System.EventHandler(this.EnterPath_button_Click);
            // 
            // ReadFromFile_text
            // 
            this.ReadFromFile_text.AutoSize = true;
            this.ReadFromFile_text.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadFromFile_text.ForeColor = System.Drawing.Color.Silver;
            this.ReadFromFile_text.Location = new System.Drawing.Point(39, 83);
            this.ReadFromFile_text.Name = "ReadFromFile_text";
            this.ReadFromFile_text.Size = new System.Drawing.Size(177, 66);
            this.ReadFromFile_text.TabIndex = 1;
            this.ReadFromFile_text.Text = "Choose *.txt file with \r\nadjacency matrix from \r\nyour computer";
            // 
            // ReadFromFile_label
            // 
            this.ReadFromFile_label.AutoSize = true;
            this.ReadFromFile_label.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadFromFile_label.ForeColor = System.Drawing.Color.White;
            this.ReadFromFile_label.Location = new System.Drawing.Point(61, 40);
            this.ReadFromFile_label.Name = "ReadFromFile_label";
            this.ReadFromFile_label.Size = new System.Drawing.Size(113, 27);
            this.ReadFromFile_label.TabIndex = 0;
            this.ReadFromFile_label.Text = "From a file";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MenuPanel.Controls.Add(this.flowLayoutPanel6);
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Controls.Add(this.flowLayoutPanel4);
            this.MenuPanel.Controls.Add(this.flowLayoutPanel3);
            this.MenuPanel.Controls.Add(this.MenuAuthor_label);
            this.MenuPanel.Controls.Add(this.flowLayoutPanel2);
            this.MenuPanel.Controls.Add(this.MenuAlgorithm_label);
            this.MenuPanel.Controls.Add(this.flowLayoutPanel1);
            this.MenuPanel.Controls.Add(this.MenuHelp_label);
            this.MenuPanel.Location = new System.Drawing.Point(-7, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(257, 464);
            this.MenuPanel.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.flowLayoutPanel6.Location = new System.Drawing.Point(29, 75);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(186, 5);
            this.flowLayoutPanel6.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.label1.Location = new System.Drawing.Point(33, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Solution";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.flowLayoutPanel4.Location = new System.Drawing.Point(29, 399);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(186, 5);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.flowLayoutPanel3.Location = new System.Drawing.Point(29, 320);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(186, 5);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // MenuAuthor_label
            // 
            this.MenuAuthor_label.AutoSize = true;
            this.MenuAuthor_label.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuAuthor_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.MenuAuthor_label.Location = new System.Drawing.Point(33, 344);
            this.MenuAuthor_label.Name = "MenuAuthor_label";
            this.MenuAuthor_label.Size = new System.Drawing.Size(174, 35);
            this.MenuAuthor_label.TabIndex = 4;
            this.MenuAuthor_label.Text = "About author";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(29, 238);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(186, 5);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // MenuAlgorithm_label
            // 
            this.MenuAlgorithm_label.AutoSize = true;
            this.MenuAlgorithm_label.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuAlgorithm_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.MenuAlgorithm_label.Location = new System.Drawing.Point(33, 262);
            this.MenuAlgorithm_label.Name = "MenuAlgorithm_label";
            this.MenuAlgorithm_label.Size = new System.Drawing.Size(134, 35);
            this.MenuAlgorithm_label.TabIndex = 2;
            this.MenuAlgorithm_label.Text = "Algorithm";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 153);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(186, 5);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // MenuHelp_label
            // 
            this.MenuHelp_label.AutoSize = true;
            this.MenuHelp_label.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuHelp_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.MenuHelp_label.Location = new System.Drawing.Point(33, 177);
            this.MenuHelp_label.Name = "MenuHelp_label";
            this.MenuHelp_label.Size = new System.Drawing.Size(71, 35);
            this.MenuHelp_label.TabIndex = 0;
            this.MenuHelp_label.Text = "Help";
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.SP_back_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hamiltonian Cycle";
            this.Load += new System.EventHandler(this.StartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Footer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.SP_back_panel.ResumeLayout(false);
            this.WorkingPanel.ResumeLayout(false);
            this.WorkingPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ReadFromFile_panel.ResumeLayout(false);
            this.ReadFromFile_panel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label formName;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel SP_back_panel;
        private System.Windows.Forms.Panel WorkingPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button InputMatrix_button;
        private System.Windows.Forms.Label ManualInput_text;
        private System.Windows.Forms.Label ManualInput_label;
        private System.Windows.Forms.Label startSolution_label;
        private System.Windows.Forms.Panel ReadFromFile_panel;
        private System.Windows.Forms.Button EnterPath_button;
        private System.Windows.Forms.Label ReadFromFile_text;
        private System.Windows.Forms.Label ReadFromFile_label;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label MenuAuthor_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label MenuAlgorithm_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label MenuHelp_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label1;
    }
}