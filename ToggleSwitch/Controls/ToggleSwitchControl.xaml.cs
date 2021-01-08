using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToggleSwitch.Controls
{
    /// <summary>
    /// Interaction logic for ToggleSwitchControl.xaml
    /// </summary>
    /// 
    public partial class ToggleSwitchControl : UserControl
    {
        public enum ToggleSwitchState
        {
            Off,On
        }

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Label.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(ToggleSwitchControl));




        public ToggleSwitchState State
        {
            get { return (ToggleSwitchState)GetValue(StateProperty); }
            set { SetValue(StateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for State.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty StateProperty =
            DependencyProperty.Register("State", typeof(ToggleSwitchState), typeof(ToggleSwitchControl), new PropertyMetadata(ToggleSwitchState.Off));


        public ToggleSwitchControl()
        {
            InitializeComponent();
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            State = ToggleSwitchState.On;
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            State = ToggleSwitchState.Off;
        }
    }
}
