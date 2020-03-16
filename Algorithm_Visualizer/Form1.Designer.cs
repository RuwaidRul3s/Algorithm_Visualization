namespace Algorithm_Visualizer
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
            this.AlgortihmType = new System.Windows.Forms.ComboBox();
            this.ApplicationTitleBar = new System.Windows.Forms.Panel();
            this.Algo_Data_panel = new System.Windows.Forms.Panel();
            this.SortButton = new System.Windows.Forms.Button();
            this.Algo_Code_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AlgortihmType
            // 
            this.AlgortihmType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlgortihmType.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlgortihmType.FormattingEnabled = true;
            this.AlgortihmType.Items.AddRange(new object[] {
            "BubbleSort",
            "InsertionSort",
            "SelectionSort",
            "QuickSort",
            "MergeSort"});
            this.AlgortihmType.Location = new System.Drawing.Point(398, 76);
            this.AlgortihmType.Name = "AlgortihmType";
            this.AlgortihmType.Size = new System.Drawing.Size(184, 32);
            this.AlgortihmType.TabIndex = 1;
            this.AlgortihmType.Text = "BubbleSort";
            // 
            // ApplicationTitleBar
            // 
            this.ApplicationTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ApplicationTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ApplicationTitleBar.Location = new System.Drawing.Point(0, 0);
            this.ApplicationTitleBar.Name = "ApplicationTitleBar";
            this.ApplicationTitleBar.Size = new System.Drawing.Size(930, 58);
            this.ApplicationTitleBar.TabIndex = 2;
            // 
            // Algo_Data_panel
            // 
            this.Algo_Data_panel.Location = new System.Drawing.Point(12, 118);
            this.Algo_Data_panel.Name = "Algo_Data_panel";
            this.Algo_Data_panel.Size = new System.Drawing.Size(570, 344);
            this.Algo_Data_panel.TabIndex = 3;
            this.Algo_Data_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Algo_Data_panel_Paint);
            // 
            // SortButton
            // 
            this.SortButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortButton.Location = new System.Drawing.Point(398, 519);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(138, 40);
            this.SortButton.TabIndex = 4;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // Algo_Code_panel
            // 
            this.Algo_Code_panel.Location = new System.Drawing.Point(598, 118);
            this.Algo_Code_panel.Name = "Algo_Code_panel";
            this.Algo_Code_panel.Size = new System.Drawing.Size(320, 344);
            this.Algo_Code_panel.TabIndex = 5;
            this.Algo_Code_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Algo_Code_panel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(721, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "UnSorted";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Algo_Code_panel);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.Algo_Data_panel);
            this.Controls.Add(this.ApplicationTitleBar);
            this.Controls.Add(this.AlgortihmType);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox AlgortihmType;
        private System.Windows.Forms.Panel ApplicationTitleBar;
        private System.Windows.Forms.Panel Algo_Data_panel;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Panel Algo_Code_panel;
        private System.Windows.Forms.Label label1;
    }
}

