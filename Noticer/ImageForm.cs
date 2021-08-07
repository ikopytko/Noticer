using System;
using System.Windows.Forms;

namespace Noticer
{
    [Flags]
    enum WS_EX
    {
        TOPMOST = 0x00000008,
    }

    public partial class ImageForm : Form
    {
        public ImageForm(CursorProcessor cursorProcessor)
        {
            InitializeComponent();
            cursorProcessor.ProcessCompleted += CursorProcessor_ProcessCompleted;
            label1.Parent = pictureBox1;
        }

        private void CursorProcessor_ProcessCompleted(object sender, double opacity)
        {
            Show();
            
            if (opacity == 0)
            {
                Hide();
            }
            else
            {
                Show();
                Opacity = opacity;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var baseParams = base.CreateParams;
                baseParams.ExStyle |= (int)WS_EX.TOPMOST;
                return baseParams;
            }
        }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }
    }
}
