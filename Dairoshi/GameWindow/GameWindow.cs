using SFML.Graphics;
using SFML.Window;
using Dairoshi.Game;

namespace Dairoshi.GameWindow;

internal class GameWindow
{
    private readonly RenderWindow _renderWindow;
    //private readonly Game _game;

    public GameWindow()
    {
        _renderWindow = new RenderWindow(VideoMode.DesktopMode, "Dairoshi", Styles.Default);
    }

    public void Run()
    {
        Initialize();
        Loop();
    }

    #region Private methods

    private void Initialize()
    {
        _renderWindow.Closed += OnWindowClose;
    }

    private void OnWindowClose(object? sender, EventArgs e)
    {
        _renderWindow.Close();
    }

    private void Loop()
    {
        while (_renderWindow.IsOpen)
        {
            Clear();
            Update();
            Draw();
        }
    }

    private void Clear()
    {
        _renderWindow.Clear();
    }

    private void Update()
    {
        _renderWindow.DispatchEvents();
    }

    private void Draw()
    {
        _renderWindow.Display();
    }

    #endregion Private methods
}
