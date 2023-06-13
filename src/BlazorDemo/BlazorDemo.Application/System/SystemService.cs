namespace BlazorDemo.Application;

public class SystemService : ISystemService, ITransient
{
    public string AppName() => "Neuz.Blazor 演示程序";

    public string AppVersion() => "v0.0.1";

    public string AppDescription() => "演示Blazor + Furion框架 + Radzen 组件";

    public string CopyRight() => "Copyright Ⓒ 2023 - Neuz";
}