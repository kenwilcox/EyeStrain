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
  public partial class FormMain : Form
  {
//#if DEBUG
    enum Milliseconds { OneMinute = 60000, TwentyMinutes = 1200000, FortyMinutes = TwentyMinutes + TwentyMinutes };
//#else
//    enum Milliseconds {TwentyMinutes = 1200000, FortyMinutes = TwentyMinutes + TwentyMinutes};
//#endif
    //const int TwentyMinutes = 1200000;
    //const int FortyMinutes = TwentyMinutes + TwentyMinutes;

    private FormBlock fb;
    private TimeSpan duration;
    //private DateTime then; // What time it was when I started
    private DateTime beep; // What time it will be when I'm done

    public FormMain()
    {
      InitializeComponent();
      fb = new FormBlock();
      fb.BuildProgress();
    }

    private void button1_Click(object sender, EventArgs e)
    {
#if DEBUG
      ShowBlock();
#endif
      MessageBox.Show(@"Avoid Eye Strain. 

Every 20 minutes it will darken the screen for 20 seconds.
A 'snooze' feature will allow you to delay it for 40 minutes.

- Ken Wilcox 02/13/2009 - Happy Friday 13th!");
    }

    private void ShowBlock()
    {
      timerBlock.Enabled = false;
      timerTime.Enabled = false;
      
      Rectangle rect;
      rect = Screen.GetBounds(this);

      fb.Top = 0;
      fb.Left = 0;

      fb.Width = rect.Width;
      fb.Height = rect.Height;
      fb.Opacity = 0.60;
      //SystemSounds.Beep.Play(); -- Ding
      //SystemSounds.Asterisk.Play(); // bing-do
      SystemSounds.Exclamation.Play(); // wo-do
      fb.ShowDialog();
      if (fb.Skip == true)
      {
        label1.Text = "Skip: True";
        SetTime(Milliseconds.FortyMinutes);
      }
      else
      {
        label1.Text = "Skip: False";
#if DEBUG
        SetTime(Milliseconds.OneMinute);
        
#else
        SetTime(Milliseconds.TwentyMinutes);
#endif
      }
#if DEBUG
      Close(); // TEMP
#endif
      timerBlock.Enabled = true;
      timerTime.Enabled = true;
    }


    private void timerBlock_Tick(object sender, EventArgs e)
    {
      ShowBlock();
    }

    private void SetTime(Milliseconds Seconds)
    {
      //then = DateTime.Now;
      timerBlock.Interval = (int)Seconds;
      beep = DateTime.Now.AddMilliseconds((int)Seconds);
      progress.Maximum = (int)Seconds;
    }

    private void AddTime(Milliseconds Seconds)
    {
      timerBlock.Enabled = false;
      timerTime.Enabled = false;

      beep = beep.AddMilliseconds((int)Seconds);
      //duration = beep - DateTime.Now;
      timerBlock.Interval += (int)Seconds;
      progress.Maximum += (int)Seconds;

      timerBlock.Enabled = true;
      timerTime.Enabled = true;
    }

    private void SubtractTime(Milliseconds Seconds)
    {

    }

    private void FormMain_Shown(object sender, EventArgs e)
    {
#if DEBUG
      //timerBlock.Interval = (int)Milliseconds.OneMinute;
      SetTime(Milliseconds.OneMinute);
#else
      //timerBlock.Interval = (int)Milliseconds.TwentyMinutes;
      SetTime(Milliseconds.TwentyMinutes);
#endif
      duration = beep - DateTime.Now;
      labelTime.Text = "20:00";// String.Format("{0:00}:{1:00}", duration.Minutes, duration.Seconds);

      timerBlock.Enabled = true;
      timerTime.Enabled = true;
    }

    private void timerTime_Tick(object sender, EventArgs e)
    {
      duration = beep - DateTime.Now;
      labelTime.Text = String.Format("{0:00}:{1:00}", duration.Minutes, duration.Seconds);
      progress.Value = progress.Maximum - (int)duration.TotalMilliseconds;
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      Rectangle rect = Screen.GetWorkingArea(this);
      this.Top = rect.Height - this.Height;
      this.Left = rect.Width - this.Width;
    }

    private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
#if !DEBUG
      String msg = @"Eye strain is a bad thing and I can't help you unless you want me to run.

Are you sure you want to quit?";
      e.Cancel = MessageBox.Show(msg, "Closing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No;
#endif
    }

    private void labelTime_MouseUp(object sender, MouseEventArgs e)
    {
#if DEBUG
      // TODO - Add time on a left mouse
      // TODO - Subtract time on a right mouse
      if (e.Button == MouseButtons.Left)
      {
        this.Text = "Left";
        AddTime(Milliseconds.OneMinute);
      }
      else if (e.Button == MouseButtons.Right)
      {
        this.Text = "Right";
      }
#endif
    }
  }
}
