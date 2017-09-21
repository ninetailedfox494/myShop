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

    // PageSetting
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public class PageSetting
    {
        public int PageSettingId { get; set; } // PageSetting_ID (Primary key)
        public string PageSettingNameVn { get; set; } // PageSetting_NameVN (length: 50)
        public string PageSettingNameEn { get; set; } // PageSetting_NameEN (length: 50)
        public string PageSettingUrlOut { get; set; } // PageSetting_UrlOut (length: 255)
        public string PageSettingRewrite { get; set; } // PageSetting_Rewrite (length: 255)
        public string PageSettingSearchVn { get; set; } // PageSetting_SearchVN (length: 50)
        public string PageSettingSearchEn { get; set; } // PageSetting_SearchEN (length: 50)
        public string PageSettingImg { get; set; } // PageSetting_Img (length: 255)
        public int? ImgWidth { get; set; } // Img_Width
        public string ImgUnitWidth { get; set; } // Img_Unit_Width (length: 10)
        public int? ImgHeight { get; set; } // Img_Height
        public string ImgUnitHeight { get; set; } // Img_Unit_Height (length: 10)
        public string KeywordTitile { get; set; } // Keyword_Titile (length: 50)
        public string KeywordContent { get; set; } // Keyword_Content
        public string KeywordDescription { get; set; } // Keyword_Description
        public System.DateTime? CreateDate { get; set; } // CreateDate
        public int? CreateBy { get; set; } // CreateBy
        public System.DateTime? UpdateDate { get; set; } // UpdateDate
        public int? UpdateBy { get; set; } // UpdateBy
        public int? Lock { get; set; } // Lock
        public bool? IsActive { get; set; } // Is_Active
        public bool? IsTopPage { get; set; } // Is_TopPage
        public bool? IsLeftPage { get; set; } // Is_LeftPage
        public bool? IsRightPage { get; set; } // Is_RightPage
        public bool? IsBottomPage { get; set; } // Is_BottomPage
        public int? DisplayOrder { get; set; } // Display_Order

        public PageSetting()
        {
            CreateDate = System.DateTime.Now;
            UpdateDate = System.DateTime.Now;
            Lock = 0;
            IsActive = true;
            IsTopPage = true;
            IsLeftPage = false;
            IsRightPage = false;
            IsBottomPage = true;
            DisplayOrder = 1;
        }
    }

}
// </auto-generated>