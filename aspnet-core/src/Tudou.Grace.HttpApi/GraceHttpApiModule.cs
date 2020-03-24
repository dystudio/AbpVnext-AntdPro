﻿using Tudou.Abp.AuditLogging;
using Tudou.Abp.SettingManagement;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.TenantManagement;

namespace Tudou.Grace
{
    [DependsOn(
        typeof(GraceApplicationContractsModule),
        typeof(AbpAccountHttpApiModule),
        typeof(AbpIdentityHttpApiModule),
        typeof(AbpAuditLoggingHttpApiModule),
        typeof(AbpPermissionManagementHttpApiModule),
        typeof(AbpTenantManagementHttpApiModule),
        typeof(AbpSettingManagementHttpApiModule),
        typeof(AbpFeatureManagementHttpApiModule)
        )]
    public class GraceHttpApiModule : AbpModule
    {
        
    }
}
