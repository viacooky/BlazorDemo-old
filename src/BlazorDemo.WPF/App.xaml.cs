using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.AspNetCore.Builder;

namespace BlazorDemo.WPF;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : System.Windows.Application
{
    public App()
    {
        Serve.RunNative(RunOptions.Default.ConfigureOptions(new WebApplicationOptions()
        {
            EnvironmentName = "Development"
        }), Serve.IdleHost.Urls);
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        Native.CreateInstance<MainWindow>().Show();
        base.OnStartup(e);
    }
}