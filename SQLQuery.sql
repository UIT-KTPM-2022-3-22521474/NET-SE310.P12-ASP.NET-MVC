USE QuanLySanPham;

CREATE TABLE Catalog (
    Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    CatalogCode NVARCHAR(50) NULL,
    CatalogName NVARCHAR(250) NULL
);

CREATE TABLE Product (
    Id INT NOT NULL PRIMARY KEY,
    CatalogId INT NULL,
    ProductCode NVARCHAR(50) NULL,
    ProductName NVARCHAR(250) NULL,
    Picture NVARCHAR(MAX) NULL,
    UnitPrice FLOAT NULL,
    FOREIGN KEY (Id) REFERENCES Catalog(Id)
);
