using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Diagnostics;

namespace RobotControllerTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        Task m_backgroundWorkTask;

        //Properties for binding to the UI
        private double _posXaxis= 15;//temporarily assigning a default value
        public double PosXaxis
        {
            get
            {
                return _posXaxis;
            }
            set
            {
                _posXaxis = value;
                NotifyPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            m_backgroundWorkTask = Task.Run(() => PollGamepad());
        } 

        private void PollGamepad()
        {
            IRobotInputDevice robotInputDevice = new XboxOneController();
            bool test = true;
            while (test)
            {
                PosXaxis = robotInputDevice.leftX();
                Debug.WriteLine(PosXaxis);
            
                
            }
        
        }
    }
}
