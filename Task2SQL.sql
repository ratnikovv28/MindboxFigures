--Создание таблицы 'Категории'
CREATE TABLE Category
(
    CategoryId INT PRIMARY KEY,
    CategoryName VARCHAR(50) NOT NULL
);

INSERT INTO Category (CategoryId, CategoryName)
VALUES
    (1, 'Electronics'),
    (2, 'Clothing'),
    (3, 'Books');

--Создание таблицы 'Продукты'
CREATE TABLE Product
(
    ProductId INT PRIMARY KEY,
    ProductName VARCHAR(100) NOT NULL,
    CategoryId INT,
    FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId)
);

INSERT INTO Product (ProductId, ProductName, CategoryId)
VALUES
    (101, 'Smartphone', 1),
    (102, 'Laptop', 1),
    (103, 'T-Shirt', 2),
    (104, 'Jeans', 2),
    (105, 'Novel', 3),
    (106, 'Textbook', 3),
	(107, 'Car', null);

--Запрос, согласно требованиям
--Используется LEFT JOIN для вывода продукта, если даже у него нет категории
SELECT p.ProductName, c.CategoryName
FROM product p
LEFT JOIN category c ON p.CategoryId = c.CategoryId;