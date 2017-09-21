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

    public interface IEShopEntities : System.IDisposable
    {
        System.Data.Entity.DbSet<Advertisement> Advertisements { get; set; } // Advertisement
        System.Data.Entity.DbSet<Category> Categories { get; set; } // Category
        System.Data.Entity.DbSet<Contact> Contacts { get; set; } // Contact
        System.Data.Entity.DbSet<Menu> Menus { get; set; } // Menu
        System.Data.Entity.DbSet<OrderDetail> OrderDetails { get; set; } // OrderDetail
        System.Data.Entity.DbSet<OrderMaster> OrderMasters { get; set; } // OrderMaster
        System.Data.Entity.DbSet<PageSetting> PageSettings { get; set; } // PageSetting
        System.Data.Entity.DbSet<Product> Products { get; set; } // Product
        System.Data.Entity.DbSet<Promotion> Promotions { get; set; } // Promotion
        System.Data.Entity.DbSet<Role> Roles { get; set; } // Roles
        System.Data.Entity.DbSet<UserProfile> UserProfiles { get; set; } // UserProfile
        System.Data.Entity.DbSet<UserRole> UserRoles { get; set; } // UserRoles

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();
    }

}
// </auto-generated>
