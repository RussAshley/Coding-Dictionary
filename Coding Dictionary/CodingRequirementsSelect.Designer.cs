
namespace Coding_Dictionary
{
    partial class CodingRequirementsSelect
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(205, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Scrum";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(205, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kanban";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(543, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Waterfall";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Goldenrod;
            this.button4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(543, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 66);
            this.button4.TabIndex = 3;
            this.button4.Text = "Agile";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(222, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Coding Requirements and Planning";
            // 
            // button5Back
            // 
            this.button5Back.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button5Back.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5Back.ForeColor = System.Drawing.Color.Red;
            this.button5Back.Location = new System.Drawing.Point(90, 398);
            this.button5Back.Name = "button5Back";
            this.button5Back.Size = new System.Drawing.Size(75, 23);
            this.button5Back.TabIndex = 5;
            this.button5Back.Text = "Back";
            this.button5Back.UseVisualStyleBackColor = false;
            // 
            // CodingRequirementsSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CodingRequirementsSelect";
            this.Text = "CodingRequirementsSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5Back;
    }
}