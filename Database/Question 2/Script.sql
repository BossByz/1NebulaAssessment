-- Create Movies table
create table Movies (
MovieID INT PRIMARY KEY NOT NULL,
MovieName VARCHAR(MAX) NOT NULL,
Genre VARCHAR(MAX) NOT NULL
)

-- Create Tickets table
create table Tickets (
TicketID INT PRIMARY KEY NOT NULL,
SeatNumber VARCHAR(MAX) NOT NULL,
MovieID INT NOT NULL FOREIGN KEY(MovieID) REFERENCES Movies(MovieID)
)

-- Vanilla data for movies table
INSERT INTO Movies VALUES(1, 'Citizen Kane', 'Drama')
INSERT INTO Movies VALUES(2, 'Shutter Island', 'Mystery')
INSERT INTO Movies VALUES(3, 'Scarecrow', 'Comedy')

-- Vanilla data for tickets table
INSERT INTO Tickets VALUES(11, 'A14', 1)
INSERT INTO Tickets VALUES(20, '2B', 2)
INSERT INTO Tickets VALUES(30, '4C', 3)

-- Expected vanilla output will be 1 ticket for each genre based on provided data

-- Dummy data for Movies Table (Made up in order to validate output)
INSERT INTO Movies VALUES(4, 'Test Movie', 'Comedy')

-- Dummy data for Movies Table (No Tickets sold for the horror genre output test)
INSERT INTO Movies VALUES(5, 'Test Movie', 'Horror')

-- Dummy data for Tickets Table (Made up in order to validate output)
INSERT INTO Tickets VALUES(10, '1A', 1)
INSERT INTO Tickets VALUES(50, 'E17', 4)

-- Expected output with Dummy data INCLUDED (when adding multiple movies with the same genre, or having multiple tickets for the same movie) will be:
--     Comedy: 2 Tickets (1 Ticket for each comedy movie)
--     Drama: 2 Tickets (2 Tickets booked for Citizen Cane) 
--     Mystery: 1 Ticket (1 Ticket booked for Shutter Island)
--	   Horror: 0 Tickets (If included in table)

-- Query to fetch ticket count
SELECT Movies.Genre, COUNT(Tickets.MovieID) AS 'Ticket Count' FROM Movies LEFT JOIN Tickets ON Movies.MovieID = Tickets.MovieID GROUP BY Movies.Genre
