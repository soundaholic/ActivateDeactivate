using System.Drawing;
using System.Windows.Forms;

namespace ActivateDeactivate
{
    partial class Form_ActivateDeactivate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ActivateDeactivate));
            this.RadioButton_Activate = new System.Windows.Forms.RadioButton();
            this.RadioButton_Deactivate = new System.Windows.Forms.RadioButton();
            this.Button_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RadioButton_Activate
            // 
            this.RadioButton_Activate.AutoSize = true;
            this.RadioButton_Activate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.RadioButton_Activate.Location = new System.Drawing.Point(28, 18);
            this.RadioButton_Activate.Name = "RadioButton_Activate";
            this.RadioButton_Activate.Size = new System.Drawing.Size(75, 21);
            this.RadioButton_Activate.TabIndex = 0;
            this.RadioButton_Activate.Text = "Activate";
            this.RadioButton_Activate.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Deactivate
            // 
            this.RadioButton_Deactivate.AutoSize = true;
            this.RadioButton_Deactivate.Checked = true;
            this.RadioButton_Deactivate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.RadioButton_Deactivate.Location = new System.Drawing.Point(28, 40);
            this.RadioButton_Deactivate.Name = "RadioButton_Deactivate";
            this.RadioButton_Deactivate.Size = new System.Drawing.Size(182, 21);
            this.RadioButton_Deactivate.TabIndex = 0;
            this.RadioButton_Deactivate.TabStop = true;
            this.RadioButton_Deactivate.Text = "Deactivate or switch state";
            this.RadioButton_Deactivate.UseVisualStyleBackColor = true;
            // 
            // Button_Start
            // 
            this.Button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Start.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Button_Start.Location = new System.Drawing.Point(73, 73);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(75, 30);
            this.Button_Start.TabIndex = 1;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Form_ActivateDeactivate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(157)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(232, 116);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.RadioButton_Deactivate);
            this.Controls.Add(this.RadioButton_Activate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ActivateDeactivate";
            this.Text = "Activate <=> Deactivate";
            this.Load += new System.EventHandler(this.Form_ActivateDeactivate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton RadioButton_Activate;
        private RadioButton RadioButton_Deactivate;
        private Button Button_Start;
    }
}