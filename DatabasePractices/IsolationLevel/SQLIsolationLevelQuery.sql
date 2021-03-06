USE HRSampleDb;

--(DIRTY READ) PART 1
SET TRANSACTION ISOLATION LEVEL
READ UNCOMMITTED

BEGIN TRANSACTION TestDR
UPDATE [HRSampleDb].[dbo].[jobs] SET min_salary = 3200 WHERE min_salary < 2600
WAITFOR DELAY '00:00:10'
ROLLBACK TRANSACTION TestDR;


--(NONREPEATABLE READ) PART 1
SET TRANSACTION ISOLATION LEVEL
READ COMMITTED

BEGIN TRANSACTION TestNR
SELECT job_title FROM  [HRSampleDb].[dbo].[jobs]  WHERE job_title = 'Programmer'
WAITFOR DELAY '00:00:10'
SELECT job_title FROM  [HRSampleDb].[dbo].[jobs]  WHERE job_title = 'Programmer'
COMMIT TRANSACTION TestNR;

--(PHANTOM READ) PART 1
SET TRANSACTION ISOLATION LEVEL
REPEATABLE READ

BEGIN TRANSACTION TestP
SELECT job_title, min_salary, max_salary FROM jobs WHERE min_salary < 3000 
WAITFOR DELAY '00:00:10'
SELECT job_title, min_salary, max_salary FROM jobs WHERE min_salary < 3000 



