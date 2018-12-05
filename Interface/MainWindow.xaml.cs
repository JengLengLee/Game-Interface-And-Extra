//-----------------------------------------------------------------------
// <copyright file="MainWindow.xaml.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------

namespace Interface
{
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

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Click event that starts a new form
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param> 
        private void BtnSudoku_Click(object sender, RoutedEventArgs e)
        {
            // use to show the form for the sudoku game.
            SudokuGame.MainWindow sudoku = new SudokuGame.MainWindow();
            sudoku.ShowDialog();
        }

        /// <summary>
        /// Click event that starts a new form
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param> 
        private void BtnMancala_Click(object sender, RoutedEventArgs e)
        {
            // use to show the form for the sudoku game.
            Mancala.MainWindow mancala = new Mancala.MainWindow();
            mancala.ShowDialog();
        }

        /// <summary>
        /// Click event that exits program
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param> 
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
