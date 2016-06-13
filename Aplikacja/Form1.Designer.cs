namespace Aplikacja
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
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.dataLabel = new System.Windows.Forms.Label();
            this.instrLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(352, 230);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(75, 23);
            this.buttonD.TabIndex = 0;
            this.buttonD.Text = "Dalej";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonW
            // 
            this.buttonW.Location = new System.Drawing.Point(265, 230);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(75, 23);
            this.buttonW.TabIndex = 1;
            this.buttonW.Text = "Wstecz";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Visible = false;
            this.buttonW.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(15, 83);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(153, 20);
            this.textBox.TabIndex = 3;
            this.textBox.Visible = false;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataLabel.Location = new System.Drawing.Point(16, 73);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(40, 17);
            this.dataLabel.TabIndex = 4;
            this.dataLabel.Text = "dane";
            this.dataLabel.Visible = false;
            // 
            // instrLabel
            // 
            this.instrLabel.AutoSize = true;
            this.instrLabel.Location = new System.Drawing.Point(16, 42);
            this.instrLabel.Name = "instrLabel";
            this.instrLabel.Size = new System.Drawing.Size(99, 13);
            this.instrLabel.TabIndex = 5;
            this.instrLabel.Text = "Witaj, naciśnij Dalej";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonD;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 265);
            this.Controls.Add(this.instrLabel);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikacja";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label instrLabel;
    }
}

