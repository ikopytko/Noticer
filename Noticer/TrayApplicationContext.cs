using System;
using System.Windows.Forms;
using Noticer.Properties;

namespace Noticer
{
    public class TrayApplicationContext : ApplicationContext
    {
        private const bool _defaultState = true;

        private CursorProcessor _cursorProcessor;
        private AppTimer _appTimer;

        private NotifyIcon _trayIcon;
        private MenuItem _toggleItem;
        private ImageForm _imageForm;

        public TrayApplicationContext()
        {
            _trayIcon = new NotifyIcon()
            {
                Icon = Resources.AppIcon,
                ContextMenu = new ContextMenu(new MenuItem[] {
                _toggleItem = new MenuItem(_defaultState ? "Stop" : "Start", OnToggleTimerClick),
                    new MenuItem("Debug", OnDebugClock),
                    new MenuItem("Exit", OnExitClick)
                }),
                Visible = true
            };

            _cursorProcessor = new CursorProcessor();
            _appTimer = new AppTimer(_cursorProcessor, enabled: _defaultState);
            _appTimer.TimerStarted += AppTimer_TimerStarted;
            _appTimer.TimerStopped += AppTimer_TimerStopped;

            _imageForm = new ImageForm(_cursorProcessor);
        }

        private void AppTimer_TimerStopped(object sender, EventArgs e)
        {
            _toggleItem.Text = "Start";
        }

        private void AppTimer_TimerStarted(object sender, EventArgs e)
        {
            _toggleItem.Text = "Stop";
        }

        private void OnToggleTimerClick(object sender, EventArgs e)
        {
            if (_appTimer.Enabled)
            {
                _appTimer.Stop();
            }
            else
            {
                _appTimer.Start();
            }
        }

        private void OnDebugClock(object sender, EventArgs e)
        {
            new DebugForm(_cursorProcessor, _appTimer).Show();
        }

        void OnExitClick(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            _trayIcon.Visible = false;

            Application.Exit();
        }
    }
}
