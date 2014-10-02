namespace Strain
{
  partial class FormMain
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.timerBlock = new System.Windows.Forms.Timer(this.components);
      this.labelTime = new System.Windows.Forms.Label();
      this.progress = new System.Windows.Forms.ProgressBar();
      this.timerTime = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(116, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(32, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = " ? ";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(0, 13);
      this.label1.TabIndex = 1;
      // 
      // timerBlock
      // 
      this.timerBlock.Interval = 10000;
      this.timerBlock.Tick += new System.EventHandler(this.timerBlock_Tick);
      // 
      // labelTime
      // 
      this.labelTime.AutoSize = true;
      this.labelTime.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTime.Location = new System.Drawing.Point(12, -2);
      this.labelTime.Name = "labelTime";
      this.labelTime.Size = new System.Drawing.Size(95, 33);
      this.labelTime.TabIndex = 2;
      this.labelTime.Text = "label2";
      this.labelTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelTime_MouseUp);
      // 
      // progress
      // 
      this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.progress.Location = new System.Drawing.Point(18, 30);
      this.progress.Name = "progress";
      this.progress.Size = new System.Drawing.Size(130, 10);
      this.progress.TabIndex = 3;
      // 
      // timerTime
      // 
      this.timerTime.Interval = 1000;
      this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(164, 45);
      this.Controls.Add(this.progress);
      this.Controls.Add(this.labelTime);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(180, 81);
      this.MinimumSize = new System.Drawing.Size(180, 81);
      this.Name = "FormMain";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "Strain";
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.Shown += new System.EventHandler(this.FormMain_Shown);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Timer timerBlock;
    private System.Windows.Forms.Label labelTime;
    private System.Windows.Forms.ProgressBar progress;
    private System.Windows.Forms.Timer timerTime;
  }
}

