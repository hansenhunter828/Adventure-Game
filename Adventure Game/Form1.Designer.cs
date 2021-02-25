
namespace Adventure_Game
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
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.brownLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(593, 200);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(46, 17);
            this.redLabel.TabIndex = 0;
            this.redLabel.Text = "label1";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(593, 317);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(46, 17);
            this.greenLabel.TabIndex = 1;
            this.greenLabel.Text = "label2";
            // 
            // yellowLabel
            // 
            this.yellowLabel.AutoSize = true;
            this.yellowLabel.Location = new System.Drawing.Point(593, 269);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(46, 17);
            this.yellowLabel.TabIndex = 2;
            this.yellowLabel.Text = "label3";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(593, 240);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(46, 17);
            this.blueLabel.TabIndex = 3;
            this.blueLabel.Text = "label4";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(46, 40);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(372, 17);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "Welcome to my game. Please press the M key to continue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 254);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // brownLabel
            // 
            this.brownLabel.AutoSize = true;
            this.brownLabel.Location = new System.Drawing.Point(593, 360);
            this.brownLabel.Name = "brownLabel";
            this.brownLabel.Size = new System.Drawing.Size(46, 17);
            this.brownLabel.TabIndex = 6;
            this.brownLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.brownLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label brownLabel;
    }
}

