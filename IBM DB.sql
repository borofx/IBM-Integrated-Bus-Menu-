CREATE DATABASE razpisanie;
USE razpisanie;


CREATE TABLE firmi (
  id_firma int NOT NULL IDENTITY(1,1),
  ime varchar(40) NOT NULL,
  PRIMARY KEY (id_firma)
);


INSERT INTO firmi (ime) 
VALUES ('Arsenal'),
('Metro Transit'),
('Urban Express'),
('City Cruiser'),
('Metro Movers'),
('Alex Transit'),
('Ivan Transit');


CREATE TABLE razpisaniq (
  id_marshrut int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  zaminava_ot varchar(40) NOT NULL,
  pristiga_v varchar(40) NOT NULL,
  chas_pristigane time NOT NULL,
  chas_zaminavane time NOT NULL
);

CREATE TABLE razpisaniq_firmi (
  id_marshrut int NOT NULL,
  id_firma int NOT NULL,
  CONSTRAINT FK_firmi FOREIGN KEY (id_firma) REFERENCES firmi (id_firma),
  CONSTRAINT FK_razpisaniq FOREIGN KEY (id_marshrut) REFERENCES razpisaniq (id_marshrut)
);
INSERT INTO razpisaniq (zaminava_ot, pristiga_v, chas_pristigane, chas_zaminavane)
VALUES 
    ('Sofia', 'Varna', '12:45:00', '20:45:00'),
    ('Plovdiv ', 'Burgas ', '10:30:00', '17:30:00'),
    ('Veliko Tarnovo ', 'Blagoevgrad  ', '11:15:00', '18:15:00'),
    ('Ruse', 'Stara Zagora', '09:55:00', '16:55:00'),
    ('Pleven ', 'Gabrovo ', '08:40:00', '15:40:00'),
    ('Haskovo  ', 'Dobrich  ', '14:20:00', '21:20:00'),
    ('Shumen   ', 'Sliven   ', '13:10:00', '20:10:00'),
    ('Pazardzhik', 'Vidin', '10:05:00', '17:05:00'),
    ('Montana ', 'Yambol ', '12:25:00', '19:26:00'),
    ('Kyustendil', 'Silistra', '11:50:00', '18:50:00');

INSERT INTO razpisaniq_firmi (id_marshrut, id_firma)
VALUES 
    (4,1),(5,2),(6,3),(7,4),(8,5),
    (9,1),(10,2),(11,3),(12,4),(13,5);