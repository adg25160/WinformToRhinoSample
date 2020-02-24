using System;

namespace SampleCsWinForms.Forms
{
  partial class SampleCsModalForm
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
            this.HelloBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.PickBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelloBtn
            // 
            this.HelloBtn.Location = new System.Drawing.Point(42, 28);
            this.HelloBtn.Name = "HelloBtn";
            this.HelloBtn.Size = new System.Drawing.Size(75, 21);
            this.HelloBtn.TabIndex = 0;
            this.HelloBtn.Text = "Hello!";
            this.HelloBtn.UseVisualStyleBackColor = true;
            this.HelloBtn.Click += new System.EventHandler(this.HelloButton_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(42, 73);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 21);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(159, 73);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 21);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // PickBtn
            // 
            this.PickBtn.Location = new System.Drawing.Point(159, 28);
            this.PickBtn.Name = "PickBtn";
            this.PickBtn.Size = new System.Drawing.Size(75, 21);
            this.PickBtn.TabIndex = 3;
            this.PickBtn.Text = "Pick";
            this.PickBtn.UseVisualStyleBackColor = true;
            this.PickBtn.Click += new System.EventHandler(this.PickButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "txt";
            // 
            // SampleCsModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(537, 309);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PickBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.HelloBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SampleCsModalForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SampleCsModalWinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        

        #endregion

        private System.Windows.Forms.Button HelloBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button PickBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}