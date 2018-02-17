using Xamarin.Forms;

namespace CarouselPageDemo
{
	public partial class MainPage : CarouselPage
	{
		public MainPage()
		{
			InitializeComponent();

            /* -------------------------------------------------------------------------------
                        //First Content Page
                        var firstPage = new ContentPage
                        {
                            Content = new StackLayout
                            {
                                Children =
                                {
                                    new Label
                                    {
                                        Text = "First Page",
                                        VerticalOptions = LayoutOptions.CenterAndExpand,
                                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                                        TextColor = Color.FromHex("184757"),
                                        FontAttributes = FontAttributes.Bold
                                    },

                                    new Image
                                    {
                                        Source= "swipe-right.png",
                                         VerticalOptions = LayoutOptions.CenterAndExpand,
                                        HorizontalOptions = LayoutOptions.CenterAndExpand
                                    }
                                }
                            }
                        };


                        //Second Content Page
                        var SecondPage = new ContentPage
                        {
                            Content = new StackLayout
                            {
                                Children =
                                {
                                    new Label
                                    {
                                        Text = "Second Page",
                                        VerticalOptions = LayoutOptions.CenterAndExpand,
                                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                                        TextColor = Color.FromHex("184757"),
                                        FontAttributes = FontAttributes.Bold
                                    },

                                    new Image
                                    {
                                        Source= "swipe.png",
                                         VerticalOptions = LayoutOptions.CenterAndExpand,
                                        HorizontalOptions = LayoutOptions.CenterAndExpand
                                    }
                                }
                            }
                        };


                        //Third Content Page
                        var thirdPage = new ContentPage
                        {
                            Content = new StackLayout
                            {
                                Children =
                                {
                                    new Label
                                    {
                                        Text = "Third Page",
                                        VerticalOptions = LayoutOptions.CenterAndExpand,
                                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                                        TextColor = Color.FromHex("184757"),
                                        FontAttributes = FontAttributes.Bold
                                    },

                                    new Image
                                    {
                                        Source= "swipe-left.png",
                                         VerticalOptions = LayoutOptions.CenterAndExpand,
                                        HorizontalOptions = LayoutOptions.CenterAndExpand
                                    }
                                }
                            }
                        };

                        Children.Add(firstPage);
                        Children.Add(SecondPage);
                        Children.Add(thirdPage); 
                        ---------------------------------------------------------------------------------- */
        }
    }
}
