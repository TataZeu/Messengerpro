namespace WindowsFormsApplication1
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
            this.RichBoxText1 = new System.Windows.Forms.RichTextBox();
            this.Maria = new System.Windows.Forms.Button();
            this.Ionel = new System.Windows.Forms.Button();
            this.RichBoxText2 = new System.Windows.Forms.RichTextBox();
            this.Salvare = new System.Windows.Forms.Button();
            this.Sterge = new System.Windows.Forms.Button();
            this.Incarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RichBoxText1
            // 
            this.RichBoxText1.Location = new System.Drawing.Point(36, 25);
            this.RichBoxText1.Name = "RichBoxText1";
            this.RichBoxText1.ReadOnly = true;
            this.RichBoxText1.Size = new System.Drawing.Size(573, 172);
            this.RichBoxText1.TabIndex = 0;
            this.RichBoxText1.Text = "";
            // 
            // Maria
            // 
            this.Maria.Location = new System.Drawing.Point(36, 252);
            this.Maria.Name = "Maria";
            this.Maria.Size = new System.Drawing.Size(75, 30);
            this.Maria.TabIndex = 1;
            this.Maria.Text = "Maria";
            this.Maria.UseVisualStyleBackColor = true;
            this.Maria.Click += new System.EventHandler(this.Maria_Click);
            // 
            // Ionel
            // 
            this.Ionel.Location = new System.Drawing.Point(534, 252);
            this.Ionel.Name = "Ionel";
            this.Ionel.Size = new System.Drawing.Size(75, 26);
            this.Ionel.TabIndex = 2;
            this.Ionel.Text = "Ionel";
            this.Ionel.UseVisualStyleBackColor = true;
            this.Ionel.Click += new System.EventHandler(this.Ionel_Click);
            // 
            // RichBoxText2
            // 
            this.RichBoxText2.Location = new System.Drawing.Point(141, 252);
            this.RichBoxText2.Name = "RichBoxText2";
            this.RichBoxText2.Size = new System.Drawing.Size(355, 26);
            this.RichBoxText2.TabIndex = 3;
            this.RichBoxText2.Text = "";
            // 
            // Salvare
            // 
            this.Salvare.Location = new System.Drawing.Point(36, 325);
            this.Salvare.Name = "Salvare";
            this.Salvare.Size = new System.Drawing.Size(154, 23);
            this.Salvare.TabIndex = 4;
            this.Salvare.Text = "Salvare";
            this.Salvare.UseVisualStyleBackColor = true;
            this.Salvare.Click += new System.EventHandler(this.Salvare_Click);
            // 
            // Sterge
            // 
            this.Sterge.Location = new System.Drawing.Point(225, 325);
            this.Sterge.Name = "Sterge";
            this.Sterge.Size = new System.Drawing.Size(188, 23);
            this.Sterge.TabIndex = 5;
            this.Sterge.Text = "Sterge fereastra";
            this.Sterge.UseVisualStyleBackColor = true;
            this.Sterge.Click += new System.EventHandler(this.Sterge_Click);
            // 
            // Incarca
            // 
            this.Incarca.Location = new System.Drawing.Point(455, 325);
            this.Incarca.Name = "Incarca";
            this.Incarca.Size = new System.Drawing.Size(154, 23);
            this.Incarca.TabIndex = 6;
            this.Incarca.Text = "Incarcare mesaje";
            this.Incarca.UseVisualStyleBackColor = true;
            this.Incarca.Click += new System.EventHandler(this.Incarca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 360);
            this.Controls.Add(this.Incarca);
            this.Controls.Add(this.Sterge);
            this.Controls.Add(this.Salvare);
            this.Controls.Add(this.RichBoxText2);
            this.Controls.Add(this.Ionel);
            this.Controls.Add(this.Maria);
            this.Controls.Add(this.RichBoxText1);
            this.Name = "Form1";
            this.Text = "M E S S E N G E R";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichBoxText1;
        private System.Windows.Forms.Button Maria;
        private System.Windows.Forms.Button Ionel;
        private System.Windows.Forms.RichTextBox RichBoxText2;
        private System.Windows.Forms.Button Salvare;
        private System.Windows.Forms.Button Sterge;
        private System.Windows.Forms.Button Incarca;
    }
}

