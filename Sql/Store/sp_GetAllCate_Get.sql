---Get all category---
Create PROCEDURE [dbo].[sp_GetAllCate_Get]
	--Tham số truyền vào nếu co,k có thì k bỏ vào
	--With Encryption Đoạn mã hoá Store,khuyến cáo k nên xài khi dùng Azure
AS
BEGIN
	SELECT A.*
	FROM [Category] A
END

--Get By Id category--
Create Procedure sp_GetByIdCate
	@ID int
as
Begin
	Select C.*
	From Category C
	Where Category_ID=@ID
end