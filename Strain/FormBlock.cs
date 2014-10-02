using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Strain
{
  public partial class FormBlock : Form
  {
    public bool Skip;
    private bool CanClose;
    private int Ticks;
    private const int MaxTicks = 21;
    private String[] meter;

    public FormBlock()
    {
      InitializeComponent();
    }

    public void BuildProgress()
    {
      // Do this ONCE not every time I need it!
      meter = new String[21];
      for (int i = 0; i < 21; i++)
      {
        meter[i] = ". ".Repeat(i);
      }
    }

    private void timerClose_Tick(object sender, EventArgs e)
    {
      //This will close in 20 seconds.
      if (!CanClose)
      {
        Ticks++;
        int diff = MaxTicks - Ticks;
        string sec = "seconds";
        if (diff == 1) sec = "second";
        if (diff != 0)
        {
          label2.Text = String.Format("You will be able to close this in {0:00} {1}.", diff, sec);
        }
        else
        {
          label2.Visible = false;
          label2.Text = "You can now close this dialog.";
          label2.Left = (Width / 2) - (label2.Width / 2);
          label2.Visible = true;
        }

        //label3.Text = ". ".Repeat(diff);
        label3.Text = meter[diff];
        //buttonClose.Text = label3.Text.Length.ToString();
        CanClose = (Ticks == MaxTicks);
      }
      else
      {
        //Close();
        SystemSounds.Asterisk.Play(); // bing-do
        timerClose.Enabled = false;
        buttonClose.Enabled = true;
      }
    }

    private void FormBlock_Shown(object sender, EventArgs e)
    {
      //timerClose.Interval = 1;
      //timerClose.Enabled = true;
      buttonClose.Enabled = false;
      cbSkip.Checked = false;
      Skip = false;
      CanClose = false;
      timerDraw.Enabled = true;
      Ticks = 0;
      label1.Top = (Height / 2) - label1.Height - 20;
      label1.Left = (Width / 2) - (label1.Width / 2);
      
      label2.Top = label1.Top + label1.Height + 20;
      label2.Left = (Width / 2) - (label2.Width / 2);
      label2.Text = "You will be able to close this in 20 seconds."; // The second time showing would state 00 seconds

      label3.Text = ". . . . . . . . . . . . . . . . . . . ."; // Progress meter was creaping to the left since the text was ""
      label3.Top = label2.Top + label2.Height + 20;
      label3.Left = (Width / 2) - (label3.Width / 2);

      label1.Visible = true;
      label2.Visible = true;
      label3.Visible = true;
    }

    private void FormBlock_FormClosing(object sender, FormClosingEventArgs e)
    {
      timerClose.Enabled = false;
      Skip = cbSkip.Checked;
      e.Cancel = Ticks <= (MaxTicks-1);
    }

    private void timerDraw_Tick(object sender, EventArgs e)
    {
      //*
      float delta = 0.05f;
      this.Opacity += delta;
      //label1.Text = this.Opacity.ToString();
      if (this.Opacity + delta >= 1.0)
      {
        //label1.Text = "Crap";
        timerDraw.Enabled = false;
        timerClose.Enabled = true;
      }
      //*/
      timerClose.Enabled = true;
    }

    private void cbSkip_CheckedChanged(object sender, EventArgs e)
    {
      buttonClose.Enabled = cbSkip.Checked;
    }

    private void buttonClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void FormBlock_MouseClick(object sender, MouseEventArgs e)
    {
      Close();
    }

  }
}
