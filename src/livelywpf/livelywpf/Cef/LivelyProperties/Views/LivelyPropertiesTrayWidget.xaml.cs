﻿using ModernWpf.Media.Animation;
using System;
using System.Windows;
using System.Windows.Interop;
using livelywpf.Core;

namespace livelywpf.Cef 
{
    /// <summary>
    /// Interaction logic for LivelyPropertiesTrayWidget.xaml
    /// </summary>
    public partial class LivelyPropertiesTrayWidget : Window
    {
        //readonly int xPos = 0, yPos = 0, width = 250, height = 250;
        public LivelyPropertiesTrayWidget(LibraryModel data, string livelyPropertyPath, LivelyScreen screen)
        {
            InitializeComponent();

            //top-right location.
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Height = (int)(SystemParameters.WorkArea.Height / 1.1f);
            this.Top = SystemParameters.WorkArea.Bottom - this.Height - 10;
            this.Left = SystemParameters.WorkArea.Right - this.Width - 5;
            this.Title = data.Title;

            //top-right location
            //this.width = (int)this.Width;
            //this.height = (int)(screen.Bounds.Height / 1.1f);
            //xPos = screen.Bounds.Right - this.width - 100;
            //yPos = screen.Bounds.Bottom - this.height - 10;

            ContentFrame.Navigate(new Cef.LivelyPropertiesView(data, livelyPropertyPath, screen), new SuppressNavigationTransitionInfo());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //ignores dpi, this.Left, this.Right is affected by system dpi.
            //NativeMethods.SetWindowPos(new WindowInteropHelper(this).Handle, 1, xPos, yPos, width, height, 0 | 0x0010);
        }
    }
}