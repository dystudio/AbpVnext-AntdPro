﻿using Tudou.Abp.AuditLogging;
using Tudou.Abp.SettingManagement;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;

namespace Tudou.Grace
{
    [DependsOn(
        typeof(GraceDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(GraceApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpAuditLoggingApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpSettingManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule)
        )]
    public class GraceApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<GraceApplicationModule>();
            });
        }
    }
}
