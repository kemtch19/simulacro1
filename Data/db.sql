-- Active: 1717287386499@@bozrbcossksszm73bvas-mysql.services.clever-cloud.com@3306@bozrbcossksszm73bvas

-- Tabla Autores
CREATE TABLE Authors(
    Id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    Name VARCHAR(125) NOT NULL,
    LastName VARCHAR(45) NOT NULL,
    Email VARCHAR(125) NOT NULL,
    Nationality VARCHAR(125) NOT NULL,
    Status ENUM("Active", "Inactive") NOT NULL
);


-- Tabla Editorials
CREATE Table Editorials(
    Id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    Name VARCHAR(125) NOT NULL,
    Adress VARCHAR(125) NOT NULL,
    Phone VARCHAR(35) NOT NULL,
    Email VARCHAR(125) NOT NULL,
    Status ENUM("Active", "Inactive") NOT NULL
);

-- Tabla Books
CREATE Table Books(
    Id INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    Title VARCHAR(225) NOT NULL,
    Pages INT(10) NOT NULL,
    Language VARCHAR(125) NOT NULL,
    PublicationDate DATE NOT NULL,
    Description TEXT NOT NULL,
    Status ENUM("Active", "Inactive") NOT NULL,
    AuthorId INT,
    EditorialId INT,
    FOREIGN KEY (AuthorId) REFERENCES Authors(Id),
    FOREIGN KEY (EditorialId) REFERENCES Editorials(Id)
);

drop  Table `Books`;

INSERT INTO `Authors`(`Name`, `LastName`, `Email`, `Nationality`, `Status`) values 
("Daniel", "Agudelo", "test@gmail.com", "Alemana", "Active");

INSERT INTO `Editorials`(`Name`, `Adress`, `Phone`, `Email`, `Status`) values
("Campeche", "Trans 36 a 27 sur", "32112345", "editorial@gmail.com", "Active"),
("Don quijote", "Diag 24 a sur 2", "41412334", "editorial2@gmail.com", "Active");

INSERT INTO Books (`Title`, `Pages`, `Language`, `PublicationDate`, `Description`, `Status`, `AuthorId`, `EditorialId`) VALUES 
("Haikyu", 45, "Japones", "2012-02-20", "Shoyo Hinata es un estudiante que se fanatiza con el vóley después de ver un partido en el que la rompía un jugador petiso como él. Esto lo inspira a seguir sus pasos y convertirse en un as aunque tenga que arrancar bien de abajo.", "Active", 1, 1);

select * from `Books`;

show TABLES;

DROP TABLE `Books`;