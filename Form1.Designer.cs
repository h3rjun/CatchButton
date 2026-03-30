namespace CatchButton
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
            btnTarget = new Button();
            SuspendLayout();
            // 
            // btnTarget
            // 
            btnTarget.BackColor = SystemColors.ButtonHighlight;
            btnTarget.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnTarget.ForeColor = Color.Blue;
            btnTarget.Location = new Point(285, 153);
            btnTarget.Name = "btnTarget";
            btnTarget.Size = new Size(206, 85);
            btnTarget.TabIndex = 0;
            btnTarget.Text = "나를 잡아봐";
            btnTarget.UseVisualStyleBackColor = false;
            btnTarget.Click += button1_Click;
            btnTarget.MouseEnter += button1_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTarget);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTarget;
    }
}
