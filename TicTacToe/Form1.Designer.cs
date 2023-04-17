namespace TicTacToe
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
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnNG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnA1
            // 
            this.btnA1.Location = new System.Drawing.Point(12, 607);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(181, 173);
            this.btnA1.TabIndex = 0;
            this.btnA1.UseVisualStyleBackColor = true;
            this.btnA1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnA2
            // 
            this.btnA2.Location = new System.Drawing.Point(221, 607);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(181, 173);
            this.btnA2.TabIndex = 1;
            this.btnA2.UseVisualStyleBackColor = true;
            this.btnA2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnA3
            // 
            this.btnA3.Location = new System.Drawing.Point(433, 607);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(181, 173);
            this.btnA3.TabIndex = 2;
            this.btnA3.UseVisualStyleBackColor = true;
            this.btnA3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnB3
            // 
            this.btnB3.Location = new System.Drawing.Point(433, 405);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(181, 173);
            this.btnB3.TabIndex = 5;
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnB2
            // 
            this.btnB2.Location = new System.Drawing.Point(221, 405);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(181, 173);
            this.btnB2.TabIndex = 4;
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnB1
            // 
            this.btnB1.Location = new System.Drawing.Point(12, 405);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(181, 173);
            this.btnB1.TabIndex = 3;
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnC3
            // 
            this.btnC3.Location = new System.Drawing.Point(433, 204);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(181, 173);
            this.btnC3.TabIndex = 8;
            this.btnC3.UseVisualStyleBackColor = true;
            this.btnC3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnC2
            // 
            this.btnC2.Location = new System.Drawing.Point(221, 204);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(181, 173);
            this.btnC2.TabIndex = 7;
            this.btnC2.UseVisualStyleBackColor = true;
            this.btnC2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnC1
            // 
            this.btnC1.Location = new System.Drawing.Point(12, 204);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(181, 173);
            this.btnC1.TabIndex = 6;
            this.btnC1.UseVisualStyleBackColor = true;
            this.btnC1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnNG
            // 
            this.btnNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNG.Location = new System.Drawing.Point(12, 12);
            this.btnNG.Name = "btnNG";
            this.btnNG.Size = new System.Drawing.Size(602, 173);
            this.btnNG.TabIndex = 9;
            this.btnNG.Text = "Start New Game";
            this.btnNG.UseVisualStyleBackColor = true;
            this.btnNG.Click += new System.EventHandler(this.btnNG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 817);
            this.Controls.Add(this.btnNG);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnB1);
            this.Controls.Add(this.btnA3);
            this.Controls.Add(this.btnA2);
            this.Controls.Add(this.btnA1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnNG;
    }
}

