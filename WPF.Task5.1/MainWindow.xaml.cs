using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace WPF.Task5._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG (*.png)|*.png|JPEG (*.jpg,*.jpeg,*.jpe,*.jfif)|*.jpg,*.jpeg,*.jpe,*.jfif|TIFF (*.tif,*.tiff)|*.tif,*.tiff|HEIC (*.heic)|*.heic|GIF (*.gif)|*.gif|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                ImageBrush imageBrush = new ImageBrush();
                imageBrush.ImageSource = new BitmapImage(new Uri(openFileDialog.FileName));
                incCanvas.Background = imageBrush;
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG (*.png)|*.png|JPEG (*.jpg,*.jpeg,*.jpe,*.jfif)|*.jpg,*.jpeg,*.jpe,*.jfif|TIFF (*.tif,*.tiff)|*.tif,*.tiff|HEIC (*.heic)|*.heic|GIF (*.gif)|*.gif|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.Create(saveFileDialog.FileName);
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Brush_Click(object sender, RoutedEventArgs e)
        {
            incCanvas.EditingMode = InkCanvasEditingMode.Ink;
            Eraser.Background = null;
            Eraser.BorderBrush = null;
            Brush.Background = Brushes.LightCyan;
            Brush.BorderBrush = Brushes.SkyBlue;
        }


        private void Eraser_Click(object sender, RoutedEventArgs e)
        {
            incCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
            Brush.Background = null;
            Brush.BorderBrush = null;
            Eraser.Background = Brushes.LightCyan;
            Eraser.BorderBrush = Brushes.SkyBlue;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int incSize = Convert.ToInt32(((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (incCanvas != null)
            {
                incCanvas.DefaultDrawingAttributes.Height = incSize;
                incCanvas.DefaultDrawingAttributes.Width = incSize;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { Black, Red, Blue, Green, Yellow, Orange, Purple, Cyan, Magenta, Chartreuse, Gray, LightGray, DarkGray, White, Olive };
            if (incCanvas != null)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (buttons[i] != sender)
                    {
                        buttons[i].BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                        buttons[i].Margin = new Thickness(2, 2, 2, 2);
                        buttons[i].BorderThickness = new Thickness(1, 1, 1, 1);
                    }
                    else
                    {
                        buttons[i].BorderBrush = Brushes.SkyBlue;
                        buttons[i].Margin = new Thickness(1, 1, 1, 1);
                        buttons[i].BorderThickness = new Thickness(2, 2, 2, 2);
                    }
                }
                Color myColor = Brushes.Black.Color;
                incCanvas.DefaultDrawingAttributes.Color = myColor;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { Black, Red, Blue, Green, Yellow, Orange, Purple, Cyan, Magenta, Chartreuse, Gray, LightGray, DarkGray, White, Olive };
            if (incCanvas != null)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (buttons[i] != sender)
                    {
                        buttons[i].BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                        buttons[i].Margin = new Thickness(2, 2, 2, 2);
                        buttons[i].BorderThickness = new Thickness(1, 1, 1, 1);
                    }
                    else
                    {
                        buttons[i].BorderBrush = Brushes.SkyBlue;
                        buttons[i].Margin = new Thickness(1, 1, 1, 1);
                        buttons[i].BorderThickness = new Thickness(2, 2, 2, 2);
                    }
                }
                Color myColor = Brushes.Red.Color;
                incCanvas.DefaultDrawingAttributes.Color = myColor;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { Black, Red, Blue, Green, Yellow, Orange, Purple, Cyan, Magenta, Chartreuse, Gray, LightGray, DarkGray, White, Olive };
            if (incCanvas != null)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (buttons[i] != sender)
                    {
                        buttons[i].BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                        buttons[i].Margin = new Thickness(2, 2, 2, 2);
                        buttons[i].BorderThickness = new Thickness(1, 1, 1, 1);
                    }
                    else
                    {
                        buttons[i].BorderBrush = Brushes.SkyBlue;
                        buttons[i].Margin = new Thickness(1, 1, 1, 1);
                        buttons[i].BorderThickness = new Thickness(2, 2, 2, 2);
                    }
                }
                Color myColor = Brushes.Blue.Color;
                incCanvas.DefaultDrawingAttributes.Color = myColor;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { Black, Red, Blue, Green, Yellow, Orange, Purple, Cyan, Magenta, Chartreuse, Gray, LightGray, DarkGray, White, Olive };
            if (incCanvas != null)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (buttons[i] != sender)
                    {
                        buttons[i].BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                        buttons[i].Margin = new Thickness(2, 2, 2, 2);
                        buttons[i].BorderThickness = new Thickness(1, 1, 1, 1);
                    }
                    else
                    {
                        buttons[i].BorderBrush = Brushes.SkyBlue;
                        buttons[i].Margin = new Thickness(1, 1, 1, 1);
                        buttons[i].BorderThickness = new Thickness(2, 2, 2, 2);
                    }
                }
                Color myColor = Brushes.Green.Color;
                incCanvas.DefaultDrawingAttributes.Color = myColor;
            }
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { Black, Red, Blue, Green, Yellow, Orange, Purple, Cyan, Magenta, Chartreuse, Gray, LightGray, DarkGray, White, Olive };
            if (incCanvas != null)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (buttons[i] != sender)
                    {
                        buttons[i].BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                        buttons[i].Margin = new Thickness(2, 2, 2, 2);
                        buttons[i].BorderThickness = new Thickness(1, 1, 1, 1);
                    }
                    else
                    {
                        buttons[i].BorderBrush = Brushes.SkyBlue;
                        buttons[i].Margin = new Thickness(1, 1, 1, 1);
                        buttons[i].BorderThickness = new Thickness(2, 2, 2, 2);
                    }
                }
                Color myColor = Brushes.Yellow.Color;
                incCanvas.DefaultDrawingAttributes.Color = myColor;
            }
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { Black, Red, Blue, Green, Yellow, Orange, Purple, Cyan, Magenta, Chartreuse, Gray, LightGray, DarkGray, White, Olive };
            if (incCanvas != null)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (buttons[i] != sender)
                    {
                        buttons[i].BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                        buttons[i].Margin = new Thickness(2, 2, 2, 2);
                        buttons[i].BorderThickness = new Thickness(1, 1, 1, 1);
                    }
                    else
                    {
                        buttons[i].BorderBrush = Brushes.SkyBlue;
                        buttons[i].Margin = new Thickness(1, 1, 1, 1);
                        buttons[i].BorderThickness = new Thickness(2, 2, 2, 2);
                    }
                }
                Color myColor = Brushes.Orange.Color;
                incCanvas.DefaultDrawingAttributes.Color = myColor;
            }
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { Black, Red, Blue, Green, Yellow, Orange, Purple, Cyan, Magenta, Chartreuse, Gray, LightGray, DarkGray, White, Olive };
            if (incCanvas != null)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (buttons[i] != sender)
                    {
                        buttons[i].BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                        buttons[i].Margin = new Thickness(2, 2, 2, 2);
                        buttons[i].BorderThickness = new Thickness(1, 1, 1, 1);
                    }
                    else
                    {
                        buttons[i].BorderBrush = Brushes.SkyBlue;
                        buttons[i].Margin = new Thickness(1, 1, 1, 1);
                        buttons[i].BorderThickness = new Thickness(2, 2, 2, 2);
                    }
                }
                Color myColor = Brushes.Purple.Color;
                incCanvas.DefaultDrawingAttributes.Color = myColor;
            }
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { Black, Red, Blue, Green, Yellow, Orange, Purple, Cyan, Magenta, Chartreuse, Gray, LightGray, DarkGray, White, Olive };
            if (incCanvas != null)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (buttons[i] != sender)
                    {
                        buttons[i].BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                        buttons[i].Margin = new Thickness(2, 2, 2, 2);
                        buttons[i].BorderThickness = new Thickness(1, 1, 1, 1);
                    }
                    else
                    {
                        buttons[i].BorderBrush = Brushes.SkyBlue;
                        buttons[i].Margin = new Thickness(1, 1, 1, 1);
                        buttons[i].BorderThickness = new Thickness(2, 2, 2, 2);
                    }
                }
                Color myColor = Brushes.Cyan.Color;
                incCanvas.DefaultDrawingAttributes.Color = myColor;
            }
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { Black, Red, Blue, Green, Yellow, Orange, Purple, Cyan, Magenta, Chartreuse, Gray, LightGray, DarkGray, White, Olive };
            if (incCanvas != null)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (buttons[i] != sender)
                    {
                        buttons[i].BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                        buttons[i].Margin = new Thickness(2, 2, 2, 2);
                        buttons[i].BorderThickness = new Thickness(1, 1, 1, 1);
                    }
                    else
                    {
                        buttons[i].BorderBrush = Brushes.SkyBlue;
                        buttons[i].Margin = new Thickness(1, 1, 1, 1);
                        buttons[i].BorderThickness = new Thickness(2, 2, 2, 2);
                    }
                }
                Color myColor = Brushes.Magenta.Color;
                incCanvas.DefaultDrawingAttributes.Color = myColor;
            }
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { Black, Red, Blue, Green, Yellow, Orange, Purple, Cyan, Magenta, Chartreuse, Gray, LightGray, DarkGray, White, Olive };
            if (incCanvas != null)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (buttons[i] != sender)
                    {
                        buttons[i].BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                        buttons[i].Margin = new Thickness(2, 2, 2, 2);
                        buttons[i].BorderThickness = new Thickness(1, 1, 1, 1);
                    }
                    else
                    {
                        buttons[i].BorderBrush = Brushes.SkyBlue;
                        buttons[i].Margin = new Thickness(1, 1, 1, 1);
                        buttons[i].BorderThickness = new Thickness(2, 2, 2, 2);
                    }
                }
                Color myColor = Brushes.Chartreuse.Color;
                incCanvas.DefaultDrawingAttributes.Color = myColor;
            }
        }
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { Black, Red, Blue, Green, Yellow, Orange, Purple, Cyan, Magenta, Chartreuse, Gray, LightGray, DarkGray, White, Olive };
            if (incCanvas != null)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (buttons[i] != sender)
                    {
                        buttons[i].BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                        buttons[i].Margin = new Thickness(2, 2, 2, 2);
                        buttons[i].BorderThickness = new Thickness(1, 1, 1, 1);
                    }
                    else
                    {
                        buttons[i].BorderBrush = Brushes.SkyBlue;
                        buttons[i].Margin = new Thickness(1, 1, 1, 1);
                        buttons[i].BorderThickness = new Thickness(2, 2, 2, 2);
                    }
                }
                Color myColor = Brushes.Gray.Color;
                incCanvas.DefaultDrawingAttributes.Color = myColor;
            }
        }
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { Black, Red, Blue, Green, Yellow, Orange, Purple, Cyan, Magenta, Chartreuse, Gray, LightGray, DarkGray, White, Olive };
            if (incCanvas != null)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (buttons[i] != sender)
                    {
                        buttons[i].BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                        buttons[i].Margin = new Thickness(2, 2, 2, 2);
                        buttons[i].BorderThickness = new Thickness(1, 1, 1, 1);
                    }
                    else
                    {
                        buttons[i].BorderBrush = Brushes.SkyBlue;
                        buttons[i].Margin = new Thickness(1, 1, 1, 1);
                        buttons[i].BorderThickness = new Thickness(2, 2, 2, 2);
                    }
                }
                Color myColor = Brushes.LightGray.Color;
                incCanvas.DefaultDrawingAttributes.Color = myColor;
            }
        }
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { Black, Red, Blue, Green, Yellow, Orange, Purple, Cyan, Magenta, Chartreuse, Gray, LightGray, DarkGray, White, Olive };
            if (incCanvas != null)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (buttons[i] != sender)
                    {
                        buttons[i].BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                        buttons[i].Margin = new Thickness(2, 2, 2, 2);
                        buttons[i].BorderThickness = new Thickness(1, 1, 1, 1);
                    }
                    else
                    {
                        buttons[i].BorderBrush = Brushes.SkyBlue;
                        buttons[i].Margin = new Thickness(1, 1, 1, 1);
                        buttons[i].BorderThickness = new Thickness(2, 2, 2, 2);
                    }
                }
                Color myColor = Brushes.DarkGray.Color;
                incCanvas.DefaultDrawingAttributes.Color = myColor;
            }
        }
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { Black, Red, Blue, Green, Yellow, Orange, Purple, Cyan, Magenta, Chartreuse, Gray, LightGray, DarkGray, White, Olive };
            if (incCanvas != null)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (buttons[i] != sender)
                    {
                        buttons[i].BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                        buttons[i].Margin = new Thickness(2, 2, 2, 2);
                        buttons[i].BorderThickness = new Thickness(1, 1, 1, 1);
                    }
                    else
                    {
                        buttons[i].BorderBrush = Brushes.SkyBlue;
                        buttons[i].Margin = new Thickness(1, 1, 1, 1);
                        buttons[i].BorderThickness = new Thickness(2, 2, 2, 2);
                    }
                }
                Color myColor = Brushes.White.Color;
                incCanvas.DefaultDrawingAttributes.Color = myColor;
            }
        }
        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { Black, Red, Blue, Green, Yellow, Orange, Purple, Cyan, Magenta, Chartreuse, Gray, LightGray, DarkGray, White, Olive };
            if (incCanvas != null)
            {
                for (int i = 0; i < 14; i++)
                {
                    if (buttons[i] != sender)
                    {
                        buttons[i].BorderBrush = new SolidColorBrush(Color.FromRgb(70, 70, 70));
                        buttons[i].Margin = new Thickness(2, 2, 2, 2);
                        buttons[i].BorderThickness = new Thickness(1, 1, 1, 1);
                    }
                    else
                    {
                        buttons[i].BorderBrush = Brushes.SkyBlue;
                        buttons[i].Margin = new Thickness(1, 1, 1, 1);
                        buttons[i].BorderThickness = new Thickness(2, 2, 2, 2);
                    }
                }
                Color myColor = Brushes.Olive.Color;
                incCanvas.DefaultDrawingAttributes.Color = myColor;
            }
        }
    }
}
