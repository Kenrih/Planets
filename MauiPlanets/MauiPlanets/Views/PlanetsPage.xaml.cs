using MauiPlanets.Models;
using MauiPlanets.Services;
using System.Linq;

namespace MauiPlanets.Views;

public partial class PlanetsPage : ContentPage
{
    private const uint AnimationDuration = 800u;

    public PlanetsPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        
        lstPopularPlanets.ItemsSource = PlanetsService.GetFeaturedPlanets() ?? new List<Planet>();
        lstAllPlanets.ItemsSource = PlanetsService.GetAllPlanets() ?? new List<Planet>();
    }

    async void Planets_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Planet selectedPlanet)
        {
            await Navigation.PushAsync(new PlanetsDetailsPage(selectedPlanet));
        }
    }

    async void ProfilePic_Clicked(System.Object sender, System.EventArgs e)
    {
       
        await MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1, AnimationDuration, Easing.CubicIn);
        await MainContentGrid.ScaleTo(0.8, AnimationDuration);
    }

    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {
        await CloseMenu();
    }

    private async Task CloseMenu()
    {
      
        await MainContentGrid.FadeTo(1, AnimationDuration);
        await MainContentGrid.ScaleTo(1, AnimationDuration);
        await MainContentGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicIn);
    }
}
