namespace MunaPortfolio.UI.Shared
{
    public partial class MainLayout
    {
        private bool collapseNavMenu = true;
        private bool black = false;
        private bool color = false;

        private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;
        private string? background => black ? "bg-black" : null;
        private string? TextColour => color ? "text-white" : null;

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
