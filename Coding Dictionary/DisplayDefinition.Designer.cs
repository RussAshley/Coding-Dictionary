
namespace Coding_Dictionary
{
    partial class DisplayDefinition
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
            this.label1DefinitionTitle = new System.Windows.Forms.Label();
            this.textBoxDefinitionDisplay = new System.Windows.Forms.TextBox();
            this.button1Modify = new System.Windows.Forms.Button();
            this.richTextBoxImage = new System.Windows.Forms.RichTextBox();
            this.linkLabelURL = new System.Windows.Forms.LinkLabel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1DefinitionTitle
            // 
            this.label1DefinitionTitle.AutoSize = true;
            this.label1DefinitionTitle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1DefinitionTitle.Location = new System.Drawing.Point(346, 31);
            this.label1DefinitionTitle.Name = "label1DefinitionTitle";
            this.label1DefinitionTitle.Size = new System.Drawing.Size(54, 19);
            this.label1DefinitionTitle.TabIndex = 0;
            this.label1DefinitionTitle.Text = "label1";
            // 
            // textBoxDefinitionDisplay
            // 
            this.textBoxDefinitionDisplay.BackColor = System.Drawing.Color.Goldenrod;
            this.textBoxDefinitionDisplay.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDefinitionDisplay.Location = new System.Drawing.Point(72, 88);
            this.textBoxDefinitionDisplay.Multiline = true;
            this.textBoxDefinitionDisplay.Name = "textBoxDefinitionDisplay";
            this.textBoxDefinitionDisplay.Size = new System.Drawing.Size(489, 297);
            this.textBoxDefinitionDisplay.TabIndex = 1;
            // 
            // button1Modify
            // 
            this.button1Modify.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1Modify.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1Modify.ForeColor = System.Drawing.Color.Red;
            this.button1Modify.Location = new System.Drawing.Point(88, 406);
            this.button1Modify.Name = "button1Modify";
            this.button1Modify.Size = new System.Drawing.Size(75, 23);
            this.button1Modify.TabIndex = 2;
            this.button1Modify.Text = "Modify";
            this.button1Modify.UseCompatibleTextRendering = true;
            this.button1Modify.UseVisualStyleBackColor = false;
            // 
            // richTextBoxImage
            // 
            this.richTextBoxImage.Location = new System.Drawing.Point(567, 88);
            this.richTextBoxImage.Name = "richTextBoxImage";
            this.richTextBoxImage.Size = new System.Drawing.Size(221, 297);
            this.richTextBoxImage.TabIndex = 3;
            this.richTextBoxImage.Text = "";
            // 
            // linkLabelURL
            // 
            this.linkLabelURL.AutoSize = true;
            this.linkLabelURL.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelURL.Location = new System.Drawing.Point(88, 388);
            this.linkLabelURL.Name = "linkLabelURL";
            this.linkLabelURL.Size = new System.Drawing.Size(59, 13);
            this.linkLabelURL.TabIndex = 4;
            this.linkLabelURL.TabStop = true;
            this.linkLabelURL.Text = "linkLabel1";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonBack.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.Location = new System.Drawing.Point(713, 406);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // DisplayDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.linkLabelURL);
            this.Controls.Add(this.richTextBoxImage);
            this.Controls.Add(this.button1Modify);
            this.Controls.Add(this.textBoxDefinitionDisplay);
            this.Controls.Add(this.label1DefinitionTitle);
            this.Name = "DisplayDefinition";
            this.Text = "DisplayDefinition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1DefinitionTitle;
        private System.Windows.Forms.TextBox textBoxDefinitionDisplay;
        private System.Windows.Forms.Button button1Modify;
        private System.Windows.Forms.RichTextBox richTextBoxImage;
        private System.Windows.Forms.LinkLabel linkLabelURL;
        private System.Windows.Forms.Button buttonBack;
    }
}