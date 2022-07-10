CREATE TABLE [Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Product] NVARCHAR(50) NULL
)

INSERT INTO Products
VALUES
	('Cucumber'),
	('Tomato'),
	('Apple'),
	('Pepsi'),
	('Coca-cola'),
	('Shampoo'),
	('Soap');

CREATE TABLE [Categories]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Category] NVARCHAR(50) NULL
)

INSERT INTO Categories
VALUES
	('Vegetables'),
	('Fruit'),
	('Food');

CREATE TABLE ProductCategories (
	Product_Id INT FOREIGN KEY REFERENCES Products(Id),
	Category_Id INT FOREIGN KEY REFERENCES Categories(Id),
);

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(1, 3),
	(2, 1),
	(2, 3),
	(3, 2),
	(3, 3),
	(4, 3),
	(5, 3);

SELECT Products.Product, Categories.Category
FROM Products LEFT JOIN ProductCategories 
ON Products.Id = ProductCategories.Product_Id
LEFT JOIN Categories 
ON ProductCategories.Category_Id = Categories.Id;