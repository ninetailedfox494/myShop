// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace DbContextPOCO.Entity
{

    // SysGroupRoles
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class SysGroupRoleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SysGroupRole>
    {
        public SysGroupRoleConfiguration()
            : this("dbo")
        {
        }

        public SysGroupRoleConfiguration(string schema)
        {
            ToTable("SysGroupRoles", schema);
            HasKey(x => x.GroupRolesId);

            Property(x => x.GroupRolesId).HasColumnName(@"GroupRolesId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.GroupRolesCode).HasColumnName(@"GroupRolesCode").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.GroupRolesName).HasColumnName(@"GroupRolesName").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            Property(x => x.IsActive).HasColumnName(@"Is_Active").HasColumnType("bit").IsOptional();
            Property(x => x.DisplayOrder).HasColumnName(@"Display_Order").HasColumnType("int").IsOptional();
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").HasColumnType("date").IsOptional();
            Property(x => x.CreateBy).HasColumnName(@"CreateBy").HasColumnType("int").IsOptional();
            Property(x => x.UpdateDate).HasColumnName(@"UpdateDate").HasColumnType("date").IsOptional();
            Property(x => x.UpdateBy).HasColumnName(@"UpdateBy").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>
