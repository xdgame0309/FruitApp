namespace FruitApp;

public partial class FruitDetailed : ContentPage
{
	public FruitDetailed(string fruitName,string fruitImage,string fruitDescription)
	{
        InitializeComponent();
		showName.Text = fruitName;
        showlmage.Source = fruitImage;
		showDescription.Text = fruitDescription;
	}
}