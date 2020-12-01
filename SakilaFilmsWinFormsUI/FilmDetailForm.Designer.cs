namespace SakilaFilmsWinFormsUI
{
    partial class FilmDetailForm
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
            this.idText = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.lengthText = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(12, 53);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(200, 22);
            this.idText.TabIndex = 0;
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(12, 125);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(549, 22);
            this.titleText.TabIndex = 1;
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(12, 193);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(549, 117);
            this.descriptionText.TabIndex = 2;
            // 
            // lengthText
            // 
            this.lengthText.Location = new System.Drawing.Point(12, 349);
            this.lengthText.Name = "lengthText";
            this.lengthText.Size = new System.Drawing.Size(200, 22);
            this.lengthText.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 33);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 17);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "Id";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(9, 105);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 17);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Title";
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(12, 173);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(82, 17);
            this.descripcionLabel.TabIndex = 6;
            this.descripcionLabel.Text = "Descripcion";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(12, 329);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(52, 17);
            this.lengthLabel.TabIndex = 7;
            this.lengthLabel.Text = "Length";
            // 
            // FilmDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.lengthText);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.idText);
            this.Name = "FilmDetailForm";
            this.Text = "FilmDetailForm";
            this.Load += new System.EventHandler(this.FilmDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox lengthText;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Label lengthLabel;
    }
}