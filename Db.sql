USE csharpdb;
CREATE TABLE ProjectTable(
Number int,
Date varchar(30),
Inventory_Number int,
Object_Name varchar(30),
Count int,
Price double,
Availability varchar(6),
OrderComplete varchar(6)
);

DELIMITER //
CREATE PROCEDURE InsertProc(n int, d varchar(50), i int, o varchar(30), c int, p double, av bit, oc bit)
BEGIN
    INSERT INTO ProjectTable VALUES(n, d, i, o, c, p, av, oc);
END //
DELIMITER;


DELIMITER //
CREATE PROCEDURE updateProc(d varchar(50), i int, o varchar(30), c int, p double, av bit, oc bit, n int)
BEGIN
    UPDATE ProjectTable SET Date=d, Inventory_Number=i, Object_Name=o, Count=c, Price=p, Availability=av, OrderComplete=oc WHERE Number=n;
END //
DELIMITER;


DELIMITER //
CREATE PROCEDURE deleteProc(n int)
BEGIN
    DELETE FROM ProjectTable WHERE Number=n;
END //
