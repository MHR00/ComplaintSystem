CREATE PROCEDURE [dbo].[spUser_Insert]
	@UserName nvarchar(50),
	@Email nvarchar(50),
	@Password nvarchar(50),
	@Role nvarchar(50)
AS
Begin
		insert into dbo.[User] (UserName,Email,[Password],[Role])
		values(@UserName,@Email,@Password,@Role);

End

