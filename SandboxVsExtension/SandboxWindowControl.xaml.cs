using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;

namespace SandboxVsExtension
{
    /// <summary>
    /// Interaction logic for SandboxWindowControl.
    /// </summary>
    public partial class SandboxWindowControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxWindowControl"/> class.
        /// </summary>
        public SandboxWindowControl()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles click on the button by displaying a message box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event args.</param>
        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Invoked SandboxWindowControl.Refresh_Click");
        }
    }
}