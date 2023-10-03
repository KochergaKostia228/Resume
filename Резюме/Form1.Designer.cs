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
            this.bt_StartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_StartGame
            // 
            this.bt_StartGame.Location = new System.Drawing.Point(307, 178);
            this.bt_StartGame.Name = "bt_StartGame";
            this.bt_StartGame.Size = new System.Drawing.Size(185, 84);
            this.bt_StartGame.TabIndex = 0;
            this.bt_StartGame.Text = "Почати гру";
            this.bt_StartGame.UseVisualStyleBackColor = true;
            this.bt_StartGame.Click += new System.EventHandler(this.bt_StartGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_StartGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt_StartGame;
    }
}