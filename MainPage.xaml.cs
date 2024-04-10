using System.Collections.Generic;

namespace ExampleTintColorApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        ListView.Header = "HeaderCell with image with tint:";
        ListView.ItemsSource = new string[] { "lorem", "ipsum" };
    }
    
}