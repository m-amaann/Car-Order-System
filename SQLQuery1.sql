-- Customer table
CREATE TABLE Customer (
    CustomerID INT PRIMARY KEY IDENTITY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    PhoneNumber NVARCHAR(20),
    Address NVARCHAR(255),
    CreatedAt DATE DEFAULT GETDATE()
);
SELECT * FROM Customer


-- Admin table
CREATE TABLE Admin (
    AdminID INT PRIMARY KEY,
	Email NVARCHAR(100),
    Password NVARCHAR(100) NOT NULL, -- hash passwords 
    CreatedAt DATE DEFAULT GETDATE()
);
SELECT * FROM Admins;




CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    ProductType NVARCHAR(20), -- 'Car' or 'Car_Parts'
    ProductID INT,
    OrderDate DATETIME,
    Order_Status NVARCHAR(50),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);


-- Product table (common details for Car and Car_Parts)
CREATE TABLE Product (
    ProductID INT PRIMARY KEY,
    Model NVARCHAR(100) NOT NULL,
    Manufacturer NVARCHAR(100) NOT NULL,
    Year INT,
    StockQuantity INT
);

-- Car table
CREATE TABLE Car (
    CarID INT PRIMARY KEY,
    ProductID INT,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);


-- Car_Parts table
CREATE TABLE Car_Parts (
    PartID INT PRIMARY KEY,
    ProductID INT,
    Price DECIMAL(10, 2),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);