
namespace Webview_Drag_and_Drop
{
    partial class Main
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
            this.Form1Button = new System.Windows.Forms.Button();
            this.Form2Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Form1Button
            // 
            this.Form1Button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Form1Button.FlatAppearance.BorderSize = 0;
            this.Form1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Form1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form1Button.ForeColor = System.Drawing.SystemColors.Control;
            this.Form1Button.Location = new System.Drawing.Point(44, 116);
            this.Form1Button.Name = "Form1Button";
            this.Form1Button.Size = new System.Drawing.Size(136, 41);
            this.Form1Button.TabIndex = 0;
            this.Form1Button.Text = "Form 1";
            this.Form1Button.UseVisualStyleBackColor = false;
            this.Form1Button.Click += new System.EventHandler(this.Form1Button_Click);
            // 
            // Form2Button
            // 
            this.Form2Button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Form2Button.FlatAppearance.BorderSize = 0;
            this.Form2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Form2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form2Button.ForeColor = System.Drawing.SystemColors.Control;
            this.Form2Button.Location = new System.Drawing.Point(44, 275);
            this.Form2Button.Name = "Form2Button";
            this.Form2Button.Size = new System.Drawing.Size(136, 41);
            this.Form2Button.TabIndex = 1;
            this.Form2Button.Text = "Form 2";
            this.Form2Button.UseVisualStyleBackColor = false;
            this.Form2Button.Click += new System.EventHandler(this.Form2Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "WebView2 Drag and Drop Dataobject Example";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 81);
            this.label2.TabIndex = 3;
            this.label2.Text = "The normal drap and drop to webview2 with the typical browser handling. Drag and " +
    "drop from webview returns the dataobject file path.";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 81);
            this.label3.TabIndex = 4;
            this.label3.Text = "When drag and drop to a Webview the new window request is handled blocking the no" +
    "rmal browser behavior of opening a new window and instead returns the file path " +
    "of the dropped path.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Form2Button);
            this.Controls.Add(this.Form1Button);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Form1Button;
        private System.Windows.Forms.Button Form2Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}