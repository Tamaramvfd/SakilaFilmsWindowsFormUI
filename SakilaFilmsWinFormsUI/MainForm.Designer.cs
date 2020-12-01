namespace SakilaFilmsWinFormsUI
{
    partial class MainForm
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
            this.filmsListView = new System.Windows.Forms.ListView();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.filmsFoundLabel = new System.Windows.Forms.Label();
            this.pagesFoundLabel = new System.Windows.Forms.Label();
            this.filmsPerPageComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // filmsListView
            // 
            this.filmsListView.HideSelection = false;
            this.filmsListView.Location = new System.Drawing.Point(12, 96);
            this.filmsListView.Name = "filmsListView";
            this.filmsListView.Size = new System.Drawing.Size(777, 268);
            this.filmsListView.TabIndex = 0;
            this.filmsListView.UseCompatibleStateImageBehavior = false;
            this.filmsListView.View = System.Windows.Forms.View.List;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(12, 36);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(202, 24);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(293, 388);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 36);
            this.prevButton.TabIndex = 2;
            this.prevButton.Text = "Prev";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(398, 388);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 36);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // filmsFoundLabel
            // 
            this.filmsFoundLabel.AutoSize = true;
            this.filmsFoundLabel.Location = new System.Drawing.Point(273, 67);
            this.filmsFoundLabel.Name = "filmsFoundLabel";
            this.filmsFoundLabel.Size = new System.Drawing.Size(76, 17);
            this.filmsFoundLabel.TabIndex = 4;
            this.filmsFoundLabel.Text = "films found";
            // 
            // pagesFoundLabel
            // 
            this.pagesFoundLabel.AutoSize = true;
            this.pagesFoundLabel.Location = new System.Drawing.Point(441, 67);
            this.pagesFoundLabel.Name = "pagesFoundLabel";
            this.pagesFoundLabel.Size = new System.Drawing.Size(46, 17);
            this.pagesFoundLabel.TabIndex = 5;
            this.pagesFoundLabel.Text = "label1";
            // 
            // filmsPerPageComboBox
            // 
            this.filmsPerPageComboBox.FormattingEnabled = true;
            this.filmsPerPageComboBox.Location = new System.Drawing.Point(658, 36);
            this.filmsPerPageComboBox.Name = "filmsPerPageComboBox";
            this.filmsPerPageComboBox.Size = new System.Drawing.Size(121, 24);
            this.filmsPerPageComboBox.TabIndex = 6;
            this.filmsPerPageComboBox.SelectedIndexChanged += new System.EventHandler(this.filmsPerPageComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filmsPerPageComboBox);
            this.Controls.Add(this.pagesFoundLabel);
            this.Controls.Add(this.filmsFoundLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.filmsListView);
            this.Name = "MainForm";
            this.Text = "Sakila Films";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView filmsListView;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label filmsFoundLabel;
        private System.Windows.Forms.Label pagesFoundLabel;
        private System.Windows.Forms.ComboBox filmsPerPageComboBox;
    }
}

