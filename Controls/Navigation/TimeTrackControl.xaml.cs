﻿using System.Windows.Controls;

namespace ssi
{
    /// <summary>
    /// Interaction logic for TimeTrackControl.xaml
    /// </summary>
    public partial class TimeTrackControl : UserControl
    {
        public TimeTrackControl()
        {
            InitializeComponent();

            timeTrack.IsSelection(false);
            timeTrackSelection.IsSelection(true);
        }
    }
}