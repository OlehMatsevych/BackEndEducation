USE HRSampleDb;

--(DIRTY READ) PART 2
SET TRANSACTION ISOLATION LEVEL
READ UNCOMMITTED

BEGIN TRANSACTION TestDR2
SELECT min_salary FROM jobs WHERE min_salary = 3200;



--(NONREPEATABLE READ) PART 2
SET TRANSACTION ISOLATION LEVEL
READ COMMITTED

BEGIN TRANSACTION TestNR2
UPDATE jobs SET job_title = 'Software Engineer' WHERE job_title = 'Programmer'
WAITFOR DELAY '00:00:10'
COMMIT TRANSACTION TestNR2;


--(PHANTOM READ) PART 2
SET TRANSACTION ISOLATION LEVEL
REPEATABLE READ
SET IDENTITY_INSERT jobs ON

BEGIN TRANSACTION TestP2
INSERT INTO jobs(job_id, job_title, min_salary, max_salary) VALUES(20,'Marketing master',2900.0,35500.0);
WAITFOR DELAY '00:00:10'
ROLLBACK TRANSACTION TestP2;