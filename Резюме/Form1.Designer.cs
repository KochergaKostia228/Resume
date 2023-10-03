namespace Резюме
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Yes = new System.Windows.Forms.Button();
            this.bt_No = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ви задоволені своєю заробітною платою?";
            // 
            // bt_Yes
            // 
            this.bt_Yes.Location = new System.Drawing.Point(133, 196);
            this.bt_Yes.Name = "bt_Yes";
            this.bt_Yes.Size = new System.Drawing.Size(132, 69);
            this.bt_Yes.TabIndex = 1;
            this.bt_Yes.Text = "Yes";
            this.bt_Yes.UseVisualStyleBackColor = true;
            this.bt_Yes.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_No
            // 
            this.bt_No.Location = new System.Drawing.Point(531, 196);
            this.bt_No.Name = "bt_No";
            this.bt_No.Size = new System.Drawing.Size(117, 69);
            this.bt_No.TabIndex = 2;
            this.bt_No.Text = "No";
            this.bt_No.UseVisualStyleBackColor = true;
            this.bt_No.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_No);
            this.Controls.Add(this.bt_Yes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button bt_Yes;
        private Button bt_No;
    }
}