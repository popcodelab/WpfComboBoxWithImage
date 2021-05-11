using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfComboBoxWithImage.Controls
{
    /// <summary>
    /// Interaction logic for ComboBoxWithImage.xaml
    /// </summary>
    public partial class ComboBoxWithImage : UserControl
    {


        public ComboBoxWithImage()
        {
            InitializeComponent();
            
        }

        public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register("ItemsSource", typeof(IEnumerable), typeof(ComboBoxWithImage), new UIPropertyMetadata(null));

        public IEnumerable ItemsSource
        {
            get => (Dictionary<string,string>)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public static readonly DependencyProperty SelectedItemProperty = DependencyProperty.Register("SelectedItem", typeof(object), typeof(ComboBoxWithImage), new UIPropertyMetadata(null));

        public object SelectedItem
        {
            get => GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        public static DependencyProperty DefaultTextProperty =DependencyProperty.Register("DefaultText", typeof(string), typeof(ComboBoxWithImage));
        public string DefaultText
        {
            get => (string)GetValue(DefaultTextProperty);
            set => SetValue(DefaultTextProperty, value);
        }
    }
}
