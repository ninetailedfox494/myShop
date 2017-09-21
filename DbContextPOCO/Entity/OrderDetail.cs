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

    // OrderDetail
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class OrderDetail
    {
        public int OrderDetailId { get; set; } // OrderDetail_ID (Primary key)
        public int OrderMasterId { get; set; } // OrderMaster_ID
        public int ProductId { get; set; } // Product_ID
        public int Quanlity { get; set; } // Quanlity
        public double Amout { get; set; } // Amout
        public System.DateTime OrderDetailDate { get; set; } // OrderDetail_Date
        public int? OrderDetailStatus { get; set; } // OrderDetail_Status
        public int? Lock { get; set; } // Lock
        public bool? IsActive { get; set; } // Is_Active

        // Foreign keys

        /// <summary>
        /// Parent OrderMaster pointed by [OrderDetail].([OrderMasterId]) (FK_OrderDetail_OrderMaster)
        /// </summary>
        public virtual OrderMaster OrderMaster { get; set; } // FK_OrderDetail_OrderMaster

        /// <summary>
        /// Parent Product pointed by [OrderDetail].([ProductId]) (FK_OrderDetail_Product)
        /// </summary>
        public virtual Product Product { get; set; } // FK_OrderDetail_Product

        public OrderDetail()
        {
            OrderDetailDate = System.DateTime.Now;
            OrderDetailStatus = 0;
            Lock = 0;
            IsActive = true;
        }
    }

}
// </auto-generated>