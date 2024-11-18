CREATE TABLE `Products`(
    `Music` BLOB NULL,
    `Price` DECIMAL(10, 2) NOT NULL,
    `Id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `Img` BLOB NULL,
    `Description` TEXT NULL,
    `Name` VARCHAR(100) NOT NULL
);
CREATE TABLE `Users`(
    `Name` VARCHAR(100) NOT NULL,
    `PasswordHash` VARCHAR(255) NOT NULL,
    `Email` VARCHAR(100) NOT NULL,
    `Id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY
);
ALTER TABLE
    `Users` ADD UNIQUE `users_email_unique`(`Email`);
CREATE TABLE `OrderProducts`(
    `ProductId` INT NOT NULL,
    `OrderId` INT NOT NULL,
    `Quantity` INT NULL DEFAULT '1',
    PRIMARY KEY(`ProductId`)
);
ALTER TABLE
    `OrderProducts` ADD PRIMARY KEY(`OrderId`);
CREATE TABLE `Orders`(
    `TotalAmount` DECIMAL(10, 2) NOT NULL,
    `OrderDate` DATETIME NULL DEFAULT CURRENT_TIMESTAMP(), `UserId` INT NOT NULL, `Id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY);
ALTER TABLE
    `OrderProducts` ADD CONSTRAINT `orderproducts_orderid_foreign` FOREIGN KEY(`OrderId`) REFERENCES `Orders`(`Id`);
ALTER TABLE
    `OrderProducts` ADD CONSTRAINT `orderproducts_productid_foreign` FOREIGN KEY(`ProductId`) REFERENCES `Products`(`Id`);
ALTER TABLE
    `Orders` ADD CONSTRAINT `orders_userid_foreign` FOREIGN KEY(`UserId`) REFERENCES `Users`(`Id`);