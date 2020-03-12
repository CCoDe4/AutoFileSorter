namespace AutoFileSorter
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
            this.selectPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCopy = new System.Windows.Forms.RadioButton();
            this.rbtnMove = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectPath
            // 
            this.selectPath.Location = new System.Drawing.Point(123, 97);
            this.selectPath.Name = "selectPath";
            this.selectPath.Size = new System.Drawing.Size(296, 20);
            this.selectPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source directory";
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.Location = new System.Drawing.Point(425, 95);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPath.TabIndex = 2;
            this.btnOpenPath.Text = "Select";
            this.btnOpenPath.UseVisualStyleBackColor = true;
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMove);
            this.groupBox1.Controls.Add(this.rbtnCopy);
            this.groupBox1.Location = new System.Drawing.Point(123, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 42);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // rbtnCopy
            // 
            this.rbtnCopy.AutoSize = true;
            this.rbtnCopy.Checked = true;
            this.rbtnCopy.Location = new System.Drawing.Point(6, 19);
            this.rbtnCopy.Name = "rbtnCopy";
            this.rbtnCopy.Size = new System.Drawing.Size(49, 17);
            this.rbtnCopy.TabIndex = 0;
            this.rbtnCopy.TabStop = true;
            this.rbtnCopy.Text = "Copy";
            this.rbtnCopy.UseVisualStyleBackColor = true;
            // 
            // rbtnMove
            // 
            this.rbtnMove.AutoSize = true;
            this.rbtnMove.Location = new System.Drawing.Point(107, 19);
            this.rbtnMove.Name = "rbtnMove";
            this.rbtnMove.Size = new System.Drawing.Size(52, 17);
            this.rbtnMove.TabIndex = 4;
            this.rbtnMove.Text = "Move";
            this.rbtnMove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOpenPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selectPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnMove;
        private System.Windows.Forms.RadioButton rbtnCopy;
    }
}

