using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EmployeeManagement.Localization;
using EmployeeManagement.MultiTenancy;
using Volo.Abp.Account.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.UI.Navigation;
using Volo.Abp.Users;

namespace EmployeeManagement.Blazor.Menus;

public class EmployeeManagementMenuContributor : IMenuContributor
{
    private readonly IConfiguration _configuration;

    public EmployeeManagementMenuContributor(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
        else if (context.Menu.Name == StandardMenus.User)
        {
            await ConfigureUserMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<EmployeeManagementResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                EmployeeManagementMenus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home"
            ).AddItem(new ApplicationMenuItem(
                       name: "EmployeeList",
                       displayName: l["Employee List"],
                       url: "/employeeList")
                   ).AddItem(new ApplicationMenuItem(
                       name: "AddEmployee",
                       displayName: l["Add Employee"],
                       url: "/addEmployee")
                    )
        );
        //context.Menu.AddItem(
        //       new ApplicationMenuItem(EmployeeManagementMenus.Home,
        //       l["Menu:Home"],
        //       icon: "fas fa-home").RequireAuthenticated()
        //           .AddItem(new ApplicationMenuItem(
        //               name: "EmployeeList",
        //               displayName: l["Employee List"],
        //               url: "/employeeList")
        //           ).AddItem(new ApplicationMenuItem(
        //               name: "AddEmployee",
        //               displayName: l["Add Employee"],
        //               url: "/addEmployee")
        //            )
        //   );
        var administration = context.Menu.GetAdministration();

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

        return Task.CompletedTask;
    }

    private Task ConfigureUserMenuAsync(MenuConfigurationContext context)
    {
        var accountStringLocalizer = context.GetLocalizer<AccountResource>();

        var authServerUrl = _configuration["AuthServer:Authority"] ?? "";

        context.Menu.AddItem(new ApplicationMenuItem(
            "Account.Manage",
            accountStringLocalizer["MyAccount"],
            $"{authServerUrl.EnsureEndsWith('/')}Account/Manage?returnUrl={_configuration["App:SelfUrl"]}",
            icon: "fa fa-cog",
            order: 1000,
            null).RequireAuthenticated());


        return Task.CompletedTask;
    }
}
