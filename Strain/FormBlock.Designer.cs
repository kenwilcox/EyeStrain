namespace Strain
{
  partial class FormBlock
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
      this.buttonClose = new System.Windows.Forms.Button();
      this.cbSkip = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.timerClose = new System.Windows.Forms.Timer(this.components);
      this.timerDraw = new System.Windows.Forms.Timer(this.components);
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // buttonClose
      // 
      this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonClose.Enabled = false;
      this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonClose.ForeColor = System.Drawing.Color.White;
      this.buttonClose.Location = new System.Drawing.Point(173, 197);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(75, 23);
      this.buttonClose.TabIndex = 0;
      this.buttonClose.Text = "Close";
      this.buttonClose.UseVisualStyleBackColor = false;
      this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
      // 
      // cbSkip
      // 
      this.cbSkip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cbSkip.AutoSize = true;
      this.cbSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbSkip.ForeColor = System.Drawing.Color.White;
      this.cbSkip.Location = new System.Drawing.Point(40, 200);
      this.cbSkip.Name = "cbSkip";
      this.cbSkip.Size = new System.Drawing.Size(127, 17);
      this.cbSkip.TabIndex = 1;
      this.cbSkip.Text = "Skip the next one too!";
      this.cbSkip.UseVisualStyleBackColor = true;
      this.cbSkip.CheckedChanged += new System.EventHandler(this.cbSkip_CheckedChanged);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(56, 59);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(794, 25);
      this.label1.TabIndex = 2;
      this.label1.Text = "Look away from the computer - preferably something that\'s 20 feet away.";
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(56, 105);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(471, 25);
      this.label2.TabIndex = 3;
      this.label2.Text = "You will be able to close this in 20 seconds.";
      // 
      // timerClose
      // 
      this.timerClose.Interval = 1000;
      this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
      // 
      // timerDraw
      // 
      this.timerDraw.Interval = 150;
      this.timerDraw.Tick += new System.EventHandler(this.timerDraw_Tick);
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.AutoSize = true;
      this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(56, 144);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(305, 25);
      this.label3.TabIndex = 4;
      this.label3.Text = ". . . . . . . . . . . . . . . . . . . .";
      // 
      // FormBlock
      // 
      this.AcceptButton = this.buttonClose;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Gray;
      this.ClientSize = new System.Drawing.Size(284, 264);
      this.ControlBox = false;
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cbSkip);
      this.Controls.Add(this.buttonClose);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormBlock";
      this.Opacity = 0.9;
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.TopMost = true;
      this.Shown += new System.EventHandler(this.FormBlock_Shown);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBlock_FormClosing);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonClose;
    private System.Windows.Forms.CheckBox cbSkip;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Timer timerClose;
    private System.Windows.Forms.Timer timerDraw;
    private System.Windows.Forms.Label label3;
  }
}