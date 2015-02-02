﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lorn.ADSP.AM.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Lorn.ADSP.AM.DataModels;
    
    public partial class AMDataEntities : DbContext
    {
        public AMDataEntities()
            : base("name=AMDataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdMaterialFormInfo> AdMaterialFormInfoes { get; set; }
        public virtual DbSet<AdMaterial> AdMaterials { get; set; }
        public virtual DbSet<AdSpotPlanDetail> AdSpotPlanDetails { get; set; }
        public virtual DbSet<AdSpotPlanEdition> AdSpotPlanEditions { get; set; }
        public virtual DbSet<RedirectConditionDetail> RedirectConditionDetails { get; set; }
        public virtual DbSet<RedirectCondition> RedirectConditions { get; set; }
        public virtual DbSet<AdSpotPlanGroup> AdSpotPlanGroups { get; set; }
        public virtual DbSet<AdSpotPlan> AdSpotPlans { get; set; }
        public virtual DbSet<AdSpotPlanThirdMonitorCode> AdSpotPlanThirdMonitorCodes { get; set; }
        public virtual DbSet<AdSpotPlanType> AdSpotPlanTypes { get; set; }
        public virtual DbSet<IpLibrary> IpLibraries { get; set; }
        public virtual DbSet<MonitorType> MonitorTypes { get; set; }
        public virtual DbSet<AdMaterialAssign> AdMaterialAssigns { get; set; }
        public virtual DbSet<FrequencyControl> FrequencyControls { get; set; }
        public virtual DbSet<FrequencyControlDetail> FrequencyControlDetails { get; set; }
        public virtual DbSet<ThirdMonitorCode> ThirdMonitorCodes { get; set; }
        public virtual DbSet<ThirdMonitorMode> ThirdMonitorModes { get; set; }
        public virtual DbSet<ThirdMonitorCompany> ThirdMonitorCompanies { get; set; }
    }
}
