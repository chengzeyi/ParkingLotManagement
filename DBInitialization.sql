USE Test;
GO

CREATE TABLE Register(
	username VARCHAR(32) NOT NULL,
	password VARCHAR(32) NOT NULL,
	PRIMARY KEY(username)
	);
GO

INSERT INTO Register(username, password)
VALUES('root', '000000');
GO

CREATE TABLE ParkingLotStatus(
	parkingfloor INT NOT NULL,
	parkingno INT NOT NULL,
	parkingisused INT NOT NULL,
	parkingindatetime DATETIME,
	carplatenumber VARCHAR(32),
	PRIMARY KEY(parkingfloor, parkingno)
	);
GO

DECLARE @i INT;
SET @i = 1;
WHILE @i <= 2 BEGIN
	DECLARE @j INT;
	SET @j = 1;
	WHILE @j <= 16 BEGIN
		INSERT INTO ParkingLotStatus(parkingfloor, parkingno, parkingisused)
		VALUES(@i, @j, 0);
		SET @j = @j + 1;
	END
	SET @i = @i + 1;
END
GO

CREATE TABLE ParkingLotConfig(
	configname VARCHAR(32) NOT NULL,
	priceperhour MONEY NOT NULL,
	PRIMARY KEY(configname)
	);
GO

INSERT INTO ParkingLotConfig(configname, priceperhour)
VALUES('standard', 1.00);
GO