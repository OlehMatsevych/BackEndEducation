USE BookingDb;

-- nonclustered
CREATE INDEX rooms_nonc_index ON 
[dbo].RoomsDetails(Price)


-- clustered
CREATE UNIQUE CLUSTERED INDEX rooms_c_index ON 
[dbo].RoomsDetails(Price)


-- nonclustered
CREATE INDEX reservations_nonc_index ON 
[dbo].Reservations(StartDate)


-- clustered
CREATE UNIQUE CLUSTERED INDEX reservations_c_index ON 
[dbo].Reservations(StartDate)
