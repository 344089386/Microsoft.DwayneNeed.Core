using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsControls
{
    public partial class MediaPlayer : UserControl
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }

        public string URL
        {
            get
            {
#if MEDIA_PLAYER_ENABLED
                return axWindowsMediaPlayer1.URL;
#else
                return string.Empty;
#endif
            }

            set
            {
#if MEDIA_PLAYER_ENABLED
                axWindowsMediaPlayer1.URL = value;
#endif
            }
        }
    }
}
