using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SelectfromCollectionview
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
            UpdateSelectionData(Enumerable.Empty<Monkey>(), Enumerable.Empty<Monkey>());
        }

        void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateSelectionData(e.PreviousSelection, e.CurrentSelection);
        }

        void UpdateSelectionData(IEnumerable<object> previousSelectedItems, IEnumerable<object> currentSelectedItems)
        {
            string previous = (previousSelectedItems.FirstOrDefault() as Monkey)?.Name;
            string current = (currentSelectedItems.FirstOrDefault() as Monkey)?.Name;
            currentSelectedItemLabel.Text = (currentSelectedItems.FirstOrDefault() as Monkey)?.Name;
        }
    }
}
