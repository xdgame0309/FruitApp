namespace FruitApp
{
    public partial class MainPage : ContentPage
    {
        List<Fruit> list = new List<Fruit>()
        {
            new Fruit(){Name="Apple",Image="apple.png",Description="This is an apple"},
            new Fruit(){Name="Orange",Image="orange.png",Description="This is an orange"},
            new Fruit(){Name="Banana",Image="banana.png",Description="This is a banana"},
            new Fruit(){Name="Kiwi",Image="kiwi.png",Description="This is a kiwi"},
            new Fruit(){Name="Strawberry",Image="strawberry.png",Description="This is a strawberry"},
            new Fruit(){Name="Pineapple",Image="pineapple.png",Description="This is a pineapple"},
            new Fruit(){Name="Watermelon",Image="watermelon.png",Description="This is a watermelon"},
            new Fruit(){Name="Grapes",Image="grape.png",Description="This is a grapes"},
        };


        public MainPage()
        {
            InitializeComponent();
            FruitListView.ItemsSource = list;

        }
        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            var selectedFruit = e.SelectedItem as Fruit;
            Navigation.PushAsync(new FruitDetailed(selectedFruit.Name, selectedFruit.Image, selectedFruit.Description));
        }


    }
}