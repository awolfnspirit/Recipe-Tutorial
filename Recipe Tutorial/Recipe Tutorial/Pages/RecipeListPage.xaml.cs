using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RecipeTutorial
{
    public partial class RecipeListPage : ContentPage
    {
        public RecipeListPage()
        {
            InitializeComponent();

            recipesList.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    var detailPage = new RecipeDetailPage(e.SelectedItem as Recipe);

                    await Navigation.PushAsync(detailPage);

                    recipesList.SelectedItem = null;
                }
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            recipesList.ItemsSource = null;
            recipesList.ItemsSource = App.AllRecipes;
        }

        
    }
}
