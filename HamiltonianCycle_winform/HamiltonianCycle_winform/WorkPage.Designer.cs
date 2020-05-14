namespace HamiltonianCycle_winform
{
    partial class WorkPage
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuAuthor_label = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuAlgorithm_label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuHelp_label = new System.Windows.Forms.Label();
            this.ReadFromFile_panel = new System.Windows.Forms.Panel();
            this.EnterPath_button = new System.Windows.Forms.Button();
            this.ReadFromFile_text = new System.Windows.Forms.Label();
            this.ReadFromFile_label = new System.Windows.Forms.Label();
            this.startSolution_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InputMatrix_button = new System.Windows.Forms.Button();
            this.ManualInput_text = new System.Windows.Forms.Label();
            this.ManualInput_label = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuPanel.SuspendLayout();
            this.ReadFromFile_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MenuPanel.Controls.Add(this.flowLayoutPanel4);
            this.MenuPanel.Controls.Add(this.flowLayoutPanel3);
            this.MenuPanel.Controls.Add(this.MenuAuthor_label);
            this.MenuPanel.Controls.Add(this.flowLayoutPanel2);
            this.MenuPanel.Controls.Add(this.MenuAlgorithm_label);
            this.MenuPanel.Controls.Add(this.flowLayoutPanel1);
            this.MenuPanel.Controls.Add(this.MenuHelp_label);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(247, 467);
            this.MenuPanel.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.flowLayoutPanel4.Location = new System.Drawing.Point(35, 341);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(186, 5);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.flowLayoutPanel3.Location = new System.Drawing.Point(35, 262);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(186, 5);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // MenuAuthor_label
            // 
            this.MenuAuthor_label.AutoSize = true;
            this.MenuAuthor_label.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuAuthor_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.MenuAuthor_label.Location = new System.Drawing.Point(39, 286);
            this.MenuAuthor_label.Name = "MenuAuthor_label";
            this.MenuAuthor_label.Size = new System.Drawing.Size(174, 35);
            this.MenuAuthor_label.TabIndex = 4;
            this.MenuAuthor_label.Text = "About author";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(35, 180);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(186, 5);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // MenuAlgorithm_label
            // 
            this.MenuAlgorithm_label.AutoSize = true;
            this.MenuAlgorithm_label.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuAlgorithm_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.MenuAlgorithm_label.Location = new System.Drawing.Point(39, 204);
            this.MenuAlgorithm_label.Name = "MenuAlgorithm_label";
            this.MenuAlgorithm_label.Size = new System.Drawing.Size(134, 35);
            this.MenuAlgorithm_label.TabIndex = 2;
            this.MenuAlgorithm_label.Text = "Algorithm";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(186, 5);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // MenuHelp_label
            // 
            this.MenuHelp_label.AutoSize = true;
            this.MenuHelp_label.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuHelp_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.MenuHelp_label.Location = new System.Drawing.Point(39, 119);
            this.MenuHelp_label.Name = "MenuHelp_label";
            this.MenuHelp_label.Size = new System.Drawing.Size(71, 35);
            this.MenuHelp_label.TabIndex = 0;
            this.MenuHelp_label.Text = "Help";
            // 
            // ReadFromFile_panel
            // 
            this.ReadFromFile_panel.Controls.Add(this.EnterPath_button);
            this.ReadFromFile_panel.Controls.Add(this.ReadFromFile_text);
            this.ReadFromFile_panel.Controls.Add(this.ReadFromFile_label);
            this.ReadFromFile_panel.Location = new System.Drawing.Point(322, 179);
            this.ReadFromFile_panel.Name = "ReadFromFile_panel";
            this.ReadFromFile_panel.Size = new System.Drawing.Size(228, 220);
            this.ReadFromFile_panel.TabIndex = 1;
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
            this.ReadFromFile_text.Click += new System.EventHandler(this.ReadFromFile_text_Click);
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
            this.ReadFromFile_label.Click += new System.EventHandler(this.ReadFromFile_label_Click);
            // 
            // startSolution_label
            // 
            this.startSolution_label.AutoSize = true;
            this.startSolution_label.Font = new System.Drawing.Font("Trebuchet MS", 35F, System.Drawing.FontStyle.Bold);
            this.startSolution_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(206)))), ((int)(((byte)(103)))));
            this.startSolution_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startSolution_label.Location = new System.Drawing.Point(355, 95);
            this.startSolution_label.Name = "startSolution_label";
            this.startSolution_label.Size = new System.Drawing.Size(411, 59);
            this.startSolution_label.TabIndex = 2;
            this.startSolution_label.Text = "Start the solution";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InputMatrix_button);
            this.panel1.Controls.Add(this.ManualInput_text);
            this.panel1.Controls.Add(this.ManualInput_label);
            this.panel1.Location = new System.Drawing.Point(576, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 219);
            this.panel1.TabIndex = 2;
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
            this.ManualInput_text.Click += new System.EventHandler(this.ManualInput_text_Click);
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
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.flowLayoutPanel5.Location = new System.Drawing.Point(560, 181);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(5, 218);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // WorkPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startSolution_label);
            this.Controls.Add(this.ReadFromFile_panel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "WorkPage";
            this.Size = new System.Drawing.Size(888, 467);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ReadFromFile_panel.ResumeLayout(false);
            this.ReadFromFile_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel ReadFromFile_panel;
        private System.Windows.Forms.Label startSolution_label;
        private System.Windows.Forms.Label ReadFromFile_label;
        private System.Windows.Forms.Label ReadFromFile_text;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label MenuAuthor_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label MenuAlgorithm_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label MenuHelp_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ManualInput_text;
        private System.Windows.Forms.Label ManualInput_label;
        private System.Windows.Forms.Button EnterPath_button;
        private System.Windows.Forms.Button InputMatrix_button;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
    }
}
