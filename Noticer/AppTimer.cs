using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Noticer
{
    public class AppTimer
    {
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        private readonly CursorProcessor _cursorProcessor;
        private Timer _mainTimer;
        private Point _mousePoint = new Point();

        public bool Enabled => _mainTimer.Enabled;
        public event EventHandler TimerStopped;
        public event EventHandler TimerStarted;

        public AppTimer(CursorProcessor cursorProcessor, int timerInterval = 50, bool enabled = false)
        {
            _cursorProcessor = cursorProcessor;

            _mainTimer = new Timer();
            _mainTimer.Interval = timerInterval;
            _mainTimer.Tick += Timer_Tick;
            _mainTimer.Enabled = enabled;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GetCursorPos(ref _mousePoint);
            _cursorProcessor.Process(_mousePoint);
        }

        internal void Start()
        {
            _mainTimer.Start();
            TimerStarted?.Invoke(this, EventArgs.Empty);
        }

        internal void Stop()
        {
            _mainTimer.Stop();
            _cursorProcessor.Reset();
            TimerStopped?.Invoke(this, EventArgs.Empty);
        }
    }
}
