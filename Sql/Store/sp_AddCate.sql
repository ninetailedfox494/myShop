﻿--Insert category--
Alter Procedure sp_AddCate
	@Category_Parent_ID int,
	@Category_NameVN nvarchar(50) = NULL,
	@Category_NameEN nvarchar(50) = NULL,
	@Category_UrlOut nvarchar(255) = NULL,
	@Category_Rewrite nvarchar(255) = NULL,
	@Category_SearchVN varchar(50)= NULL,
	@Category_SearchEN varchar(50)= NULL,
	@Category_Icon varchar(255)= NULL,
	@Category_Img varchar(255)= NULL,
	@Keyword_Titile nvarchar(50)= NULL,
	@Keyword_Content nvarchar(max)= NULL,
	@Keyword_Description nvarchar(max)= NULL,
	@CreateDate datetime= NULL,
	@CreateBy int= NULL,
	@UpdateDate datetime= NULL,
	@UpdateBy int= NULL,
	@Lock int =NULL,
	@Is_Active bit= NULL,
	@Is_HomePage bit =NULL,
	@Is_TopMenu bit= NULL,
	@Is_BottomMenu bit= NULL,
	@Display_Order int= NULL
	--With Encryption Đoạn mã hoá Store,khuyến cáo k nên xài khi dùng Azure
as
Begin
 	--Declare  @Category_Parent_ID int
	--Declare @Category_NameVN nvarchar(50)
	--Declare @Category_NameEN nvarchar(50) 
	--Declare @Category_Rewrite nvarchar(255)

	insert into Category(
	Category_Parent_ID
	,Category_NameVN,
	Category_NameEN,
	Category_UrlOut,
	Category_Rewrite,
	Category_SearchVN,
     Category_SearchEN,
	 Category_Icon,
	 Category_Img,
	 Keyword_Titile,
	 Keyword_Content,
	 Keyword_Description,
     CreateDate,
	 CreateBy,
	 UpdateDate,
	 UpdateBy,
	 Lock,
	 Is_Active,
	 Is_HomePage,
	 Is_TopMenu,
	 Is_BottomMenu,
      Display_Order) 
	  Values(
	  @Category_Parent_ID,
		@Category_NameVN,
		@Category_NameEN,
		@Category_UrlOut,
		@Category_Rewrite,
		@Category_SearchVN,
		@Category_SearchEN,
		@Category_Icon,
		@Category_Img,
		@Keyword_Titile,
		@Keyword_Content,
		@Keyword_Description,
		@CreateDate,
		@CreateBy,
		@UpdateDate,
		@UpdateBy,
		@Lock,
		@Is_Active,
		@Is_HomePage,
		@Is_TopMenu,
		@Is_BottomMenu,
		@Display_Order)
end