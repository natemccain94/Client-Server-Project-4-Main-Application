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
using System.Net;
using VeryImportantCompanySecurity.DoorServiceReference;
using VeryImportantCompanySecurity.FloorServiceReference;
using VeryImportantCompanySecurity.WindowServiceReference;

namespace VeryImportantCompanySecurity
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the DfButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void DfButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DoorServiceReference.DoorService client = new DoorService();
                DfTextbox.Text = string.Concat("Front Door Reception: ", client.GetFrontDoorValue());
            }
            catch (System.Net.WebException exception)
            {
                Console.WriteLine(exception.Message);
                DfTextbox.Text = "Error: Can't connect to Door Server.";
                throw;
            }
            catch (System.Net.Sockets.SocketException exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the FfrButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void FfrButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FloorServiceReference.FloorService client = new FloorService();
                FfrTextbox.Text = string.Concat("Front Floor Reception: ", client.GetFloorPlateOneVal(),
                    " lbs");
            }
            catch (System.Net.WebException exception)
            {
                Console.WriteLine(exception.Message);
                FfrTextbox.Text = "Error: Can't connect to Floor Server.";
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the FbrButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void FbrButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FloorServiceReference.FloorService client = new FloorService();
                FbrTextbox.Text = string.Concat("Back Floor Reception: ", client.GetFloorPlateTwoVal(),
                    " lbs");
            }
            catch (System.Net.WebException exception)
            {
                Console.WriteLine(exception.Message);
                FbrTextbox.Text = "Error: Can't connect to Floor Server.";
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the DmButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void DmButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DoorServiceReference.DoorService client = new DoorService();
                DmTextbox.Text = string.Concat("Middle Door: ", client.GetMiddleDoorValue());
            }
            catch (System.Net.WebException exception)
            {
                Console.WriteLine(exception.Message);
                DmTextbox.Text = "Error: Can't connect to Door Server.";
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the FfbButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void FfbButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FloorServiceReference.FloorService client = new FloorService();
                FfbTextbox.Text = string.Concat("Front Floor Boss: ", client.GetFloorPlateThreeVal(),
                    " lbs");
            }
            catch (System.Net.WebException exception)
            {
                Console.WriteLine(exception.Message);
                FfbTextbox.Text = "Error: Can't connect to Floor Server.";
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the W1Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void W1Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WindowServiceReference.WindowService client = new WindowService();
                W1Textbox.Text = string.Concat("Window 1: ", client.GetWindowOneVal());
            }
            catch (System.Net.WebException exception)
            {
                Console.WriteLine(exception.Message);
                W1Textbox.Text = "Error: Can't connect to Window Server.";
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the W2Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void W2Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WindowServiceReference.WindowService client = new WindowService();
                W2Textbox.Text = string.Concat("Window 2: ", client.GetWindowTwoVal());
            }
            catch (System.Net.WebException exception)
            {
                Console.WriteLine(exception.Message);
                W2Textbox.Text = "Error: Can't connect to Window Server.";
                throw;
            }
        }

        /// <summary>
        /// Handles the Click event of the FbbButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void FbbButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FloorServiceReference.FloorService client = new FloorService();
                FbbTextbox.Text = string.Concat("Back Floor Boss: ", client.GetFloorPlateFourVal(),
                    " lbs");
            }
            catch (System.Net.WebException exception)
            {
                Console.WriteLine(exception.Message);
                FbbTextbox.Text = "Error: Can't connect to Floor Server.";
                throw;
            }
        }
    }
}
