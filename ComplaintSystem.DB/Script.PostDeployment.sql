if not exists (select 1 from dbo.[User])
Begin
	insert dbo.[User] ([UserName],[Email],[Password],[Role])
	values ('Hossein3274' ,'hossein@gmail.com','hossein123','admin'),
	('ali3274','ali@gmail.com','ali123','seller'),
	('hadi3274','hadi@gmail.com','hadi123','customre'),
	('mohsen3274','mohsen@gmail.com','mohsen123','customer')
End