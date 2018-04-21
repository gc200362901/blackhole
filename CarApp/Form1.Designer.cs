namespace CarApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navPanel = new System.Windows.Forms.Panel();
            this.financialButton = new System.Windows.Forms.Button();
            this.soldButton = new System.Windows.Forms.Button();
            this.availableButton = new System.Windows.Forms.Button();
            this.allCarsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.allCarsPanel = new System.Windows.Forms.Panel();
            this.allCarsDataGridView = new System.Windows.Forms.DataGridView();
            this.availablePanel = new System.Windows.Forms.Panel();
            this.availableCarsDataGridView = new System.Windows.Forms.DataGridView();
            this.soldPanel = new System.Windows.Forms.Panel();
            this.soldDataGridView = new System.Windows.Forms.DataGridView();
            this.financialPanel = new System.Windows.Forms.Panel();
            this.financialDataGridView = new System.Windows.Forms.DataGridView();
            this.navPanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.allCarsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allCarsDataGridView)).BeginInit();
            this.availablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableCarsDataGridView)).BeginInit();
            this.soldPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soldDataGridView)).BeginInit();
            this.financialPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.navPanel.Controls.Add(this.financialButton);
            this.navPanel.Controls.Add(this.soldButton);
            this.navPanel.Controls.Add(this.availableButton);
            this.navPanel.Controls.Add(this.allCarsButton);
            this.navPanel.Controls.Add(this.homeButton);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(724, 100);
            this.navPanel.TabIndex = 0;
            // 
            // financialButton
            // 
            this.financialButton.FlatAppearance.BorderSize = 0;
            this.financialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financialButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialButton.Image = ((System.Drawing.Image)(resources.GetObject("financialButton.Image")));
            this.financialButton.Location = new System.Drawing.Point(580, 0);
            this.financialButton.Name = "financialButton";
            this.financialButton.Size = new System.Drawing.Size(139, 100);
            this.financialButton.TabIndex = 1;
            this.financialButton.Text = "Financial";
            this.financialButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.financialButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.financialButton.UseVisualStyleBackColor = true;
            this.financialButton.Click += new System.EventHandler(this.financialButton_Click);
            // 
            // soldButton
            // 
            this.soldButton.FlatAppearance.BorderSize = 0;
            this.soldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soldButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldButton.Image = ((System.Drawing.Image)(resources.GetObject("soldButton.Image")));
            this.soldButton.Location = new System.Drawing.Point(435, 0);
            this.soldButton.Name = "soldButton";
            this.soldButton.Size = new System.Drawing.Size(139, 100);
            this.soldButton.TabIndex = 1;
            this.soldButton.Text = "Sold";
            this.soldButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.soldButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.soldButton.UseVisualStyleBackColor = true;
            this.soldButton.Click += new System.EventHandler(this.soldButton_Click);
            // 
            // availableButton
            // 
            this.availableButton.FlatAppearance.BorderSize = 0;
            this.availableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableButton.Image = ((System.Drawing.Image)(resources.GetObject("availableButton.Image")));
            this.availableButton.Location = new System.Drawing.Point(290, 0);
            this.availableButton.Name = "availableButton";
            this.availableButton.Size = new System.Drawing.Size(139, 100);
            this.availableButton.TabIndex = 1;
            this.availableButton.Text = "Available";
            this.availableButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.availableButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.availableButton.UseVisualStyleBackColor = true;
            this.availableButton.Click += new System.EventHandler(this.availableButton_Click);
            // 
            // allCarsButton
            // 
            this.allCarsButton.FlatAppearance.BorderSize = 0;
            this.allCarsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allCarsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCarsButton.Image = ((System.Drawing.Image)(resources.GetObject("allCarsButton.Image")));
            this.allCarsButton.Location = new System.Drawing.Point(145, 0);
            this.allCarsButton.Name = "allCarsButton";
            this.allCarsButton.Size = new System.Drawing.Size(139, 100);
            this.allCarsButton.TabIndex = 1;
            this.allCarsButton.Text = "All Cars";
            this.allCarsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.allCarsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.allCarsButton.UseVisualStyleBackColor = true;
            this.allCarsButton.Click += new System.EventHandler(this.allCarsButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(0, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(139, 100);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.pictureBox1);
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(0, 100);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(724, 428);
            this.homePanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 272);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAR DIRECTORY";
            // 
            // allCarsPanel
            // 
            this.allCarsPanel.Controls.Add(this.allCarsDataGridView);
            this.allCarsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allCarsPanel.Location = new System.Drawing.Point(0, 100);
            this.allCarsPanel.Name = "allCarsPanel";
            this.allCarsPanel.Size = new System.Drawing.Size(724, 428);
            this.allCarsPanel.TabIndex = 1;
            // 
            // allCarsDataGridView
            // 
            this.allCarsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allCarsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.allCarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allCarsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allCarsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.allCarsDataGridView.Name = "allCarsDataGridView";
            this.allCarsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allCarsDataGridView.Size = new System.Drawing.Size(724, 428);
            this.allCarsDataGridView.TabIndex = 0;
            // 
            // availablePanel
            // 
            this.availablePanel.Controls.Add(this.availableCarsDataGridView);
            this.availablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availablePanel.Location = new System.Drawing.Point(0, 100);
            this.availablePanel.Name = "availablePanel";
            this.availablePanel.Size = new System.Drawing.Size(724, 428);
            this.availablePanel.TabIndex = 0;
            // 
            // availableCarsDataGridView
            // 
            this.availableCarsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.availableCarsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.availableCarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableCarsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availableCarsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.availableCarsDataGridView.Name = "availableCarsDataGridView";
            this.availableCarsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availableCarsDataGridView.Size = new System.Drawing.Size(724, 428);
            this.availableCarsDataGridView.TabIndex = 0;
            // 
            // soldPanel
            // 
            this.soldPanel.Controls.Add(this.soldDataGridView);
            this.soldPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soldPanel.Location = new System.Drawing.Point(0, 100);
            this.soldPanel.Name = "soldPanel";
            this.soldPanel.Size = new System.Drawing.Size(724, 428);
            this.soldPanel.TabIndex = 0;
            // 
            // soldDataGridView
            // 
            this.soldDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.soldDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.soldDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soldDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soldDataGridView.Location = new System.Drawing.Point(0, 0);
            this.soldDataGridView.Name = "soldDataGridView";
            this.soldDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.soldDataGridView.Size = new System.Drawing.Size(724, 428);
            this.soldDataGridView.TabIndex = 0;
            // 
            // financialPanel
            // 
            this.financialPanel.Controls.Add(this.financialDataGridView);
            this.financialPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialPanel.Location = new System.Drawing.Point(0, 100);
            this.financialPanel.Name = "financialPanel";
            this.financialPanel.Size = new System.Drawing.Size(724, 428);
            this.financialPanel.TabIndex = 0;
            // 
            // financialDataGridView
            // 
            this.financialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.financialDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialDataGridView.Location = new System.Drawing.Point(0, 0);
            this.financialDataGridView.Name = "financialDataGridView";
            this.financialDataGridView.Size = new System.Drawing.Size(724, 428);
            this.financialDataGridView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 528);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.financialPanel);
            this.Controls.Add(this.soldPanel);
            this.Controls.Add(this.availablePanel);
            this.Controls.Add(this.allCarsPanel);
            this.Controls.Add(this.navPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.navPanel.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.allCarsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allCarsDataGridView)).EndInit();
            this.availablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.availableCarsDataGridView)).EndInit();
            this.soldPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soldDataGridView)).EndInit();
            this.financialPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.financialDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Button financialButton;
        private System.Windows.Forms.Button soldButton;
        private System.Windows.Forms.Button availableButton;
        private System.Windows.Forms.Button allCarsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel allCarsPanel;
        private System.Windows.Forms.Panel availablePanel;
        private System.Windows.Forms.Panel soldPanel;
        private System.Windows.Forms.Panel financialPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView allCarsDataGridView;
        private System.Windows.Forms.DataGridView availableCarsDataGridView;
        private System.Windows.Forms.DataGridView soldDataGridView;
        private System.Windows.Forms.DataGridView financialDataGridView;
    }
}

