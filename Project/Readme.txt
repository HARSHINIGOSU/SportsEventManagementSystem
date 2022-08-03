----- SQL SERVER & MICROSERVICES SETUP -----

1) Open SQL Server and Connect.

2) Open .sln extension files (Microservices solution files) in microservices from Visual Studio 2019.

3) If you open .sln files from a different system, do change the following things in your system. else GOTO 4).

	-> After opening .sln files, delete Migrations folder.
	
	-> In appsettings.json, change Data source to SQL Server Name as in your system.

	-> Open Tools->NuGet Packet Manager->Packet Mangager Console. It opens at the left bottom with command like interface.

	-> Enter following two commands one by one.
		
		add-migration initial
		update-database

4) Open Build->Build Solution and solutions are built.

5) Now press Ctrl+f5 to open Swagger UI of microservice from browser.

6) Do the same with all 4 microservices.

----- ANGULAR SETUP -----

1) Open Angular Folder from VS Code 2022.

2) Open Command prompt from the same location of angular files and enter "ng serve" and press Enter.

3)Now Angular works from localhost:4200.

---- SQL SETUP ----
1) In PlayerSerivceDb  and SportEventServiceDb insert values for Sports and Events Table

Events Table

insert into events values(1,'IPL', 30, '2022-07-18'),
(2,'FIFA', 30, '2022-07-18'),
(3,'Worldcup', 100, '2022-07-18'),
(4,'Championship', 20, '2022-07-18');

Sports Table

insert into sports values('Cricket',30,'Outdoor'),
('FootBall',20,'Outdoor'),
('Hockey',22,'Outdoor'),
('Chess',2,'Indoor'),
('Carroms',4,'Indoor'),
('Badminton',22,'Outdoor');

2)In Participation Db inserts values for Sports and Events Table

Sports Table

insert into sports values('Cricket',30,'Outdoor'),
('FootBall',20,'Outdoor'),
('Hockey',22,'Outdoor'),
('Chess',2,'Indoor'),
('Carroms',4,'Indoor'),
('Badminton',22,'Outdoor');

Event Table

insert into events values(1,'IPL', '2022-07-18',30),
(2,'FIFA', '2022-07-18',40),
(3,'Worldcup', '2022-07-18',100),
(4,'Championship', '2022-07-18',20);

