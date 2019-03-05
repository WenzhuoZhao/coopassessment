CREATE DATABASE ProductsDB;

CREATE TABLE ProductsDB.dbo.Product(
		ID int NOT NULL IDENTITY(1,1),
		Name varchar(255),
		Price float,
		Description varchar(255),
		CONSTRAINT PK_Product PRIMARY KEY(ID)
);

INSERT INTO ProductsDB.dbo.Product(Name, Price,Description)
     VALUES ('Dog Shampoo',10.57,'shampoo for long hair dogs'),
	        ('WD Red 4 TB',150.99,'NAS hard drive'),
			('2018 Nissan Mourano',37866.99,'Nissan Mourano AWD with Tech Package?');

SELECT *
  INTO ProductsDB.dbo.Product_Copy
  FROM ProductsDB.dbo.Product
;

DELETE FROM ProductsDB.dbo.Product_Copy
      WHERE ID = 2;