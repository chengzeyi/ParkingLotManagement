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