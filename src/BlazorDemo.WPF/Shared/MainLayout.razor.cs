using Microsoft.AspNetCore.Components;
using Radzen.Blazor;

namespace BlazorDemo.Web.Entry.Shared;

public class MainLayoutComponent : LayoutComponentBase
{
    protected override void OnInitialized()
    {
        base.OnInitialized();
        
    }

    protected bool sidebarExpanded = true;

    protected void SidebarToggleClick(dynamic args)
    {
        sidebarExpanded = !sidebarExpanded;
    }
}