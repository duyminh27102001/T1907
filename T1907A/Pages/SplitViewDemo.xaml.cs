using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using T1907A.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1907A.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SplitViewDemo : Page
    {
        public static Frame contentFrame;
        public SplitViewDemo()
        {
            this.InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SV.IsPaneOpen = !SV.IsPaneOpen;
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("E80F", 16)), "Home", "lsc"));
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("E77B", 16)), "List Contact","lst"));
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("EA4A", 16)), "Add Contact","add"));
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("E715", 16)), "CustomerList", "lscus"));
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("E716", 16)), "Add Customer", "addC"));
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("E715", 16)), "Mail", "lsc"));
            

        }

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            contentFrame = FrContent;
            FrContent.Navigate(typeof(ContactList));
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)LV.SelectedItem;
            if (selected.Dest.Equals("lst"))
            {
                FrContent.Navigate(typeof(ContactList));
            } else if (selected.Dest.Equals("add"))
            {
                FrContent.Navigate(typeof(AddContact));
            }
            else if (selected.Dest.Equals("lscus"))
            {
                FrContent.Navigate(typeof(AddCustomer));
            }
            else if (selected.Dest.Equals("addC"))
            {
                FrContent.Navigate(typeof(CustomerList));
            }
        }
    }
}
