USE [EShop]
GO
/****** Object:  StoredProcedure [dbo].[sp_UserProfile_Insert]    Script Date: 26/09/2017 4:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[sp_UserProfile_Insert]
--@UserProfile_ID int IDENTITY(1,1) ,
@UserProfile_LastName nvarchar(50) ,
@UserProfile_FirstName nvarchar(50) ,
@UserProfile_FullName nvarchar(255) ,
@UserProfile_Birth_Day int ,
@UserProfile_Birth_Month int ,
@UserProfile_Birth_Year int ,
@UserProfile_Age int =NULL,
@UserProfile_Gender nvarchar(10) ,
@UserProfile_Phone varchar(20) ,
@UserProfile_Email varchar(50) ,
@UserProfile_Pass varchar(50) ,
@UserProfile_About_Me nvarchar(max) =NULL,
@UserProfile_Avatar varchar(500) =NULL,
@UserProfile_ConnectID varchar(max) =NULL,
@CreateDate datetime =NULL,
@UpdateDate datetime =NULL,
@Lock int =NULL,
@Is_Active bit =NULL
as
begin
	Insert into UserProfile(
	UserProfile_LastName,
      UserProfile_FirstName,
      UserProfile_FullName,
      UserProfile_Birth_Day,
      UserProfile_Birth_Month,
      UserProfile_Birth_Year,
      UserProfile_Age,
      UserProfile_Gender,
      UserProfile_Phone,
      UserProfile_Email,
      UserProfile_Pass,
      UserProfile_About_Me,
      UserProfile_Avatar,
      UserProfile_ConnectID,
      CreateDate,
      UpdateDate,
      Lock,
      Is_Active
	)
	Values(
	@UserProfile_LastName,
	@UserProfile_FirstName,
	@UserProfile_FullName,
	@UserProfile_Birth_Day,
	@UserProfile_Birth_Month,
	@UserProfile_Birth_Year,
	@UserProfile_Age,
	@UserProfile_Gender,
	@UserProfile_Phone,
	@UserProfile_Email,
	Convert(varchar(255),HashBytes('MD5', @UserProfile_Pass),2),
	@UserProfile_About_Me,
	@UserProfile_Avatar,
	@UserProfile_ConnectID,
	@CreateDate,
	@UpdateDate,
	@Lock,
	@Is_Active
	)
end