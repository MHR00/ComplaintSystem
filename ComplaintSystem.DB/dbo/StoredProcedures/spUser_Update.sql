CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int ,
	@UserName nvarchar(50),
	@Email nvarchar(50),
	@Password nvarchar(50),
	@Role nvarchar(50)
AS
Begin
		Update dbo.[User]
		set UserName=@UserName,Email=@Email,[Password]=@Password,[Role]=@Role
		where Id=@Id;
End
