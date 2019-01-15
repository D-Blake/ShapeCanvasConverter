using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ValueConvertersProject.Converter;

namespace ValueConvertersProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Shape> shapes = new List<Shape>();
        public MainWindow()
        {
            InitializeComponent();

            ARGB color = new ARGB();
            PICKERTHING.ColorStack.DataContext = color;

            MultiBinding Multi1 = new MultiBinding();
            Multi1.Converter = new ByteToColorConverter();

            Binding A = new Binding("Text");
            A.ElementName = "decimal1";

            Binding R = new Binding("Text");
            R.ElementName = "decimal2";

            Binding G = new Binding("Text");
            G.ElementName = "decimal3";

            Binding B = new Binding("Text");
            B.ElementName = "decimal4";

            Multi1.Bindings.Add(A);
            Multi1.Bindings.Add(R);
            Multi1.Bindings.Add(G);
            Multi1.Bindings.Add(B);

            Multi1.Mode = BindingMode.OneWay;
            PICKERTHING.ColorLabel.SetBinding(BackgroundProperty, Multi1);

        }

        private void Rect_RightMouseDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle rect = sender as Rectangle;
            canvas.Children.Remove(rect);
        }
        private void Ellipse_RightMouseDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse ell = sender as Ellipse;
            canvas.Children.Remove(ell);
        }
        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Random rand = new Random();
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Color.FromArgb(255, (byte)rand.Next(256), (byte)rand.Next(256), (byte)rand.Next(256));
            int width = rand.Next(100);
            int height = rand.Next(100);
            Point p = e.GetPosition(this);
            double x = p.X;
            double y = p.Y;
            int randomShape = rand.Next(2);
            switch (randomShape)
            {
                case 0:
                    Rectangle rect = new Rectangle();
                    Thickness rectMargin = rect.Margin;
                    rect.Width = width;
                    rect.Height = height;
                    rectMargin.Left = x - (width / 2);
                    rect.Margin = rectMargin;
                    rectMargin.Top = y - (height / 2);
                    rect.Margin = rectMargin;
                    rect.Fill = mySolidColorBrush;
                    rect.StrokeThickness = .5;
                    rect.Stroke = Brushes.Black;
                    rect.MouseRightButtonDown += new MouseButtonEventHandler(Rect_RightMouseDown);
                    shapes.Add(rect);
                    canvas.Children.Add(rect);
                    break;
                case 1:
                    Ellipse ellipse = new Ellipse();
                    Thickness ellMargin = ellipse.Margin;
                    ellipse.Width = width;
                    ellipse.Height = height;
                    ellipse.Margin = ellMargin;
                    ellMargin.Left = x - (width / 2);
                    ellMargin.Top = y - (height / 2);
                    ellipse.StrokeThickness = .5;
                    ellipse.Stroke = Brushes.Black;
                    ellipse.Margin = ellMargin;
                    ellipse.Fill = mySolidColorBrush;
                    ellipse.MouseRightButtonDown += new MouseButtonEventHandler(Ellipse_RightMouseDown);
                    shapes.Add(ellipse);
                    canvas.Children.Add(ellipse);

                    break;
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            for (int x = 0; x < shapes.Count(); x++)
            {
                canvas.Children.Remove(shapes[x]);
            }
        }

        #region Sliders
        //private bool dragStarted = false;

        //private void Slider_DragCompleted(object sender, DragCompletedEventArgs e)
        //{
        //    ColorLabel.Content = Math.Round((((Slider)sender).Value));

        //    this.dragStarted = false;
        //}

        //private void Slider_DragStarted(object sender, DragStartedEventArgs e)
        //{
        //    this.dragStarted = true;
        //}

        //private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    if (!dragStarted)
        //        ColorLabel.Content = Math.Round((e.NewValue));
        //}
        #endregion

        #region TextBoxes


        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            canvas.Background = PICKERTHING.ColorLabel.Background;
        }
    }
}
