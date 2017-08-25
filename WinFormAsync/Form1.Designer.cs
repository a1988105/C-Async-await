using System.Drawing;

namespace WinFormAsync
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
            this.Btn_Sync = new System.Windows.Forms.Button();
            this.Btn_Async_thread = new System.Windows.Forms.Button();
            this.lb_Result = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Sync
            // 
            this.Btn_Sync.Location = new System.Drawing.Point(12, 12);
            this.Btn_Sync.Name = "Btn_Sync";
            this.Btn_Sync.Size = new System.Drawing.Size(211, 23);
            this.Btn_Sync.TabIndex = 0;
            this.Btn_Sync.Text = "Run Sync Method";
            this.Btn_Sync.UseVisualStyleBackColor = true;
            this.Btn_Sync.Click += new System.EventHandler(this.Btn_Sync_Click);
            // 
            // Btn_Async_thread
            // 
            this.Btn_Async_thread.Location = new System.Drawing.Point(12, 41);
            this.Btn_Async_thread.Name = "Btn_Async_thread";
            this.Btn_Async_thread.Size = new System.Drawing.Size(211, 23);
            this.Btn_Async_thread.TabIndex = 1;
            this.Btn_Async_thread.Text = "Run Async Method (Task.Factory)";
            this.Btn_Async_thread.UseVisualStyleBackColor = true;
            this.Btn_Async_thread.Click += new System.EventHandler(this.Btn_Async_Click);
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.Location = new System.Drawing.Point(12, 220);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(0, 13);
            this.lb_Result.TabIndex = 2;
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.ForeColor = System.Drawing.Color.Blue;
            this.lb_Status.Location = new System.Drawing.Point(75, 220);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(0, 13);
            this.lb_Status.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Run Async Method (ThreadPool)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Run Async Method (Task.Run)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.Btn_Async_thread);
            this.Controls.Add(this.Btn_Sync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Sync;
        private System.Windows.Forms.Button Btn_Async_thread;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

