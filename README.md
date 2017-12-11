# Login-Signup-Update
#UserLogin,userSignUp,passwordUpdate from database

<-- Trigger for checking older passwords before inserting the new one -->
CREATE TRIGGER Before_Insert_Trigger ON [Password]
INSTEAD OF INSERT
AS

DECLARE @userID uniqueidentifier;
DECLARE @passwordID uniqueidentifier;
DECLARE @password nvarchar(30);
DECLARE @pwCount int;
DECLARE @lastModified datetime2(2);

SET @userID=(SELECT UserID FROM inserted);
SET @pwCount=(SELECT COUNT(*) FROM [Password] WHERE UserID=@userID);
SET @password=(SELECT [password] FROM inserted);
SET @passwordID=newid();
SET @lastModified=GetDate();

BEGIN

	IF @pwCount >= 3
		BEGIN
			DELETE FROM [Password] 
					WHERE PasswordID=(SELECT TOP 1 PasswordID FROM [Password] 
																WHERE UserID=@userID 
																ORDER BY LastModified ASC)
		END
	UPDATE [Password] SET IsActive = 'False' 
					  WHERE UserID=@userID AND IsActive='True'


	INSERT INTO [Password] VALUES (@passwordID,@userID,@password,1,@lastModified)
END
