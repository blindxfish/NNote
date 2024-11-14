using System.Windows;

namespace NNote
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AlwaysOnTopButton_Checked(object sender, RoutedEventArgs e)
        {
            this.Topmost = true;
        }

        private void AlwaysOnTopButton_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Topmost = false;
        }

        // Close button click event
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Enable dragging the window when the top area is clicked
        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        // Event handler for creating a new sticky note
        private void NewNoteButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newNote = new MainWindow();
            newNote.Show();
        }
    }
}
