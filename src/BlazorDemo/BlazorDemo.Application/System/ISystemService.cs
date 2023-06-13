namespace BlazorDemo.Application;

public interface ISystemService
{
    string AppName();

    string AppVersion();

    string AppDescription();

    string CopyRight();
}