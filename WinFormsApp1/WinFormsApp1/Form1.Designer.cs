namespace WinFormsApp1
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
            buttonsympa = new Button();
            label = new Label();
            SuspendLayout();
            // 
            // buttonsympa
            // 
            buttonsympa.Location = new Point(204, 210);
            buttonsympa.Name = "buttonsympa";
            buttonsympa.Size = new Size(303, 186);
            buttonsympa.TabIndex = 0;
            buttonsympa.Text = "un bouton sympa";
            buttonsympa.UseVisualStyleBackColor = true;
            buttonsympa.Click += button1_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 70F);
            label.Location = new Point(353, 18);
            label.Name = "label";
            label.Size = new Size(0, 155);
            label.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label);
            Controls.Add(buttonsympa);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonsympa;
        private Label label;
    }
}
