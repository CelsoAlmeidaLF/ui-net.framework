﻿
namespace Systekna.Framework.Forms
{
    partial class LoginForm
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
            this.LoginViews = new BUI.ViewsLogin.LoginView();
            this.SuspendLayout();
            // 
            // LoginViews
            // 
            this.LoginViews.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginViews.Location = new System.Drawing.Point(0, 0);
            this.LoginViews.Name = "LoginViews";
            this.LoginViews.Size = new System.Drawing.Size(1016, 593);
            this.LoginViews.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 593);
            this.Controls.Add(this.LoginViews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);

        }

        #endregion

        private BUI.ViewsLogin.LoginView LoginViews;
    }
}