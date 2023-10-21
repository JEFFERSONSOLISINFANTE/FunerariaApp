using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace FunerariaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FAQPage : ContentPage
    {
        public FAQPage()
        {
            InitializeComponent();
        }


        private async void OpenPopupButton_Clicked(object sender, EventArgs e)
        {
            // Crear el contenido de la ventana emergente
            var popupContent = new StackLayout
            {
                BackgroundColor = Color.LightGray,
                Padding = new Thickness(20),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 250, 0, 0),
                Children = {
            new Label
            {
                Text = "Lorem Ipsum is simply dummy text of the printing and " +
                "typesetting industry. Lorem Ipsum has been the industry's.",
                FontSize = 30,
                TextColor = Color.Brown
            },
            new Label
            {
                Text = "Lorem Ipsum is simply dummy text of the printing and " +
                "typesetting industry. Lorem Ipsum has been the industry's.",
                FontSize = 30,
                TextColor = Color.Brown
            }
        }
            };

            // Crear una página emergente con el contenido que hemos definido
            var popupPage = new PopupPage
            {
                Content = popupContent
            };

            // Personalizar la animación de entrada (por ejemplo, con escalado)
            popupPage.Animation = new MoveAnimation(MoveAnimationOptions.Center, MoveAnimationOptions.Bottom);

            // Mostrar la ventana emergente con la animación personalizada
            await PopupNavigation.Instance.PushAsync(popupPage);
        }

        private async void OpenPopupButton2_Clicked(object sender, EventArgs e)
        {
            // Crear el contenido de la ventana emergente
            var popupContent = new StackLayout
            {
                BackgroundColor = Color.LightGray,
                Padding = new Thickness(20),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 250, 0, 0),
                Children = {
            new Label
            {
                Text = "Lorem Ipsum is simply dummy text of the printing and " +
                "typesetting industry. Lorem Ipsum has been the industry's.",
                FontSize = 30,
                TextColor = Color.Brown
            },
            new Label
            {
                Text = "Lorem Ipsum is simply dummy text of the printing and " +
                "typesetting industry. Lorem Ipsum has been the industry's.",
                FontSize = 30,
                TextColor = Color.Brown
            }
        }
            };

            // Crear una página emergente con el contenido que hemos definido
            var popupPage = new PopupPage
            {
                Content = popupContent
            };

            // Personalizar la animación de entrada (por ejemplo, con escalado)
            popupPage.Animation = new MoveAnimation(MoveAnimationOptions.Center, MoveAnimationOptions.Bottom);

            // Mostrar la ventana emergente con la animación personalizada
            await PopupNavigation.Instance.PushAsync(popupPage);
        }


        private async void OpenPopupButton3_Clicked(object sender, EventArgs e)
        {
            // Crear el contenido de la ventana emergente
            var popupContent = new StackLayout
            {
                BackgroundColor = Color.LightGray,
                Padding = new Thickness(20),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 250, 0, 0),
                Children = {
            new Label
            {
                Text = "Lorem Ipsum is simply dummy text of the printing and " +
                "typesetting industry. Lorem Ipsum has been the industry's.",
                FontSize = 30,
                TextColor = Color.Brown
            },
            new Label
            {
                Text = "Lorem Ipsum is simply dummy text of the printing and " +
                "typesetting industry. Lorem Ipsum has been the industry's.",
                FontSize = 30,
                TextColor = Color.Brown
            }
        }
            };

            // Crear una página emergente con el contenido que hemos definido
            var popupPage = new PopupPage
            {
                Content = popupContent
            };

            // Personalizar la animación de entrada (por ejemplo, con escalado)
            popupPage.Animation = new MoveAnimation(MoveAnimationOptions.Center, MoveAnimationOptions.Bottom);

            // Mostrar la ventana emergente con la animación personalizada
            await PopupNavigation.Instance.PushAsync(popupPage);
        }


        private async void OpenPopupButton4_Clicked(object sender, EventArgs e)
        {
            // Crear el contenido de la ventana emergente
            var popupContent = new StackLayout
            {
                BackgroundColor = Color.LightGray,
                Padding = new Thickness(20),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 250, 0, 0),
                Children = {
            new Label
            {
                Text = "Lorem Ipsum is simply dummy text of the printing and " +
                "typesetting industry. Lorem Ipsum has been the industry's.",
                FontSize = 30,
                TextColor = Color.Brown
            },
            new Label
            {
                Text = "Lorem Ipsum is simply dummy text of the printing and " +
                "typesetting industry. Lorem Ipsum has been the industry's.",
                FontSize = 30,
                TextColor = Color.Brown
            }
        }
            };

            // Crear una página emergente con el contenido que hemos definido
            var popupPage = new PopupPage
            {
                Content = popupContent
            };

            // Personalizar la animación de entrada (por ejemplo, con escalado)
            popupPage.Animation = new MoveAnimation(MoveAnimationOptions.Center, MoveAnimationOptions.Bottom);

            // Mostrar la ventana emergente con la animación personalizada
            await PopupNavigation.Instance.PushAsync(popupPage);
        }

        private async void OpenPopupButton5_Clicked(object sender, EventArgs e)
        {
            // Crear el contenido de la ventana emergente
            var popupContent = new StackLayout
            {
                BackgroundColor = Color.LightGray,
                Padding = new Thickness(20),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 250, 0, 0),
                Children = {
            new Label
            {
                Text = "Lorem Ipsum is simply dummy text of the printing and " +
                "typesetting industry. Lorem Ipsum has been the industry's.",
                FontSize = 30,
                TextColor = Color.Brown
            },
            new Label
            {
                Text = "Lorem Ipsum is simply dummy text of the printing and " +
                "typesetting industry. Lorem Ipsum has been the industry's.",
                FontSize = 30,
                TextColor = Color.Brown
            }
        }
            };

            // Crear una página emergente con el contenido que hemos definido
            var popupPage = new PopupPage
            {
                Content = popupContent
            };

            // Personalizar la animación de entrada (por ejemplo, con escalado)
            popupPage.Animation = new MoveAnimation(MoveAnimationOptions.Center, MoveAnimationOptions.Bottom);

            // Mostrar la ventana emergente con la animación personalizada
            await PopupNavigation.Instance.PushAsync(popupPage);
        }

        private async void OpenPopupButton6_Clicked(object sender, EventArgs e)
        {
            // Crear el contenido de la ventana emergente
            var popupContent = new StackLayout
            {
                BackgroundColor = Color.LightGray,
                Padding = new Thickness(20),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 250, 0, 0),
                Children = {
            new Label
            {
                Text = "Lorem Ipsum is simply dummy text of the printing and " +
                "typesetting industry. Lorem Ipsum has been the industry's.",
                FontSize = 30,
                TextColor = Color.Brown
            },
            new Label
            {
                Text = "Lorem Ipsum is simply dummy text of the printing and " +
                "typesetting industry. Lorem Ipsum has been the industry's.",
                FontSize = 30,
                TextColor = Color.Brown
            }
        }
            };

            // Crear una página emergente con el contenido que hemos definido
            var popupPage = new PopupPage
            {
                Content = popupContent
            };

            // Personalizar la animación de entrada (por ejemplo, con escalado)
            popupPage.Animation = new MoveAnimation(MoveAnimationOptions.Center, MoveAnimationOptions.Bottom);

            // Mostrar la ventana emergente con la animación personalizada
            await PopupNavigation.Instance.PushAsync(popupPage);
        }

    }
}


