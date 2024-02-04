namespace CrossPlatform;

using System.Diagnostics;
using Avalonia.Controls;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Opener.Click += (_, _) =>
        {
            Process.Start("run");
        };
    }
}