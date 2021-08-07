using System;
using System.Windows.Forms;

namespace Noticer
{
    public partial class DebugForm : Form
    {
        private readonly CursorProcessor _cursorProcessor;
        private readonly AppTimer _appTimer;

        public DebugForm(CursorProcessor cursorProcessor, AppTimer appTimer)
        {
            InitializeComponent();
            _cursorProcessor = cursorProcessor;
            _appTimer = appTimer;
            cbEnable.Checked = _appTimer.Enabled;
        }

        private void CursorProcessor_ProcessCompleted(object sender, double e)
        {
            pbOpacity.Value = (int)(e * 100);
            lblOpacity.Text = pbOpacity.Value.ToString();

            debugChart.Series[0].Points.Clear();
            debugChart.Series[0].Points.DataBindY(_cursorProcessor.History);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _cursorProcessor.ProcessCompleted += CursorProcessor_ProcessCompleted;
            _appTimer.TimerStarted += AppTimer_TimerStarted;
            _appTimer.TimerStopped += AppTimer_TimerStopped;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _cursorProcessor.ProcessCompleted -= CursorProcessor_ProcessCompleted;
            _appTimer.TimerStarted -= AppTimer_TimerStarted;
            _appTimer.TimerStopped -= AppTimer_TimerStopped;
        }

        private void AppTimer_TimerStopped(object sender, EventArgs e)
        {
            cbEnable.Checked = false;
        }

        private void AppTimer_TimerStarted(object sender, EventArgs e)
        {
            cbEnable.Checked = true;
        }

        private void cbEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnable.Checked)
            {
                _appTimer.Start();
            }
            else
            {
                _appTimer.Stop();
            }
        }
    }
}