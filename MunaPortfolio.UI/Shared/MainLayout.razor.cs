namespace MunaPortfolio.UI.Shared
{
    public partial class MainLayout
    {
        private bool collapseNavMenu = true;
        private bool black = false;
        private bool color = false;

        private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;
        private string? background => black ? null: "bg-black";
        private string? TextColour => color ? null: "text-white";

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
         
        private void ToggleColour()
        {
            black = !black;
            color = !color;
        }

    }
}
