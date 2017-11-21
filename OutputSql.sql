IF db_id(N'Blogs') IS NOT NULL SELECT 1 ELSE SELECT Count(*) FROM sys.databases WHERE [name]=N'Blogs'
-- Enter a name for a new Blog: WHY
select cast(serverproperty('EngineEdition') as int)
INSERT [dbo].[Blogs]([Name])
VALUES (@0)
SELECT [BlogId]
FROM [dbo].[Blogs]
WHERE @@ROWCOUNT > 0 AND [BlogId] = scope_identity()

-- ===========================================================================================================
SELECT TOP (1)
    [Extent1].[BlogId] AS [BlogId],
    [Extent1].[Name] AS [Name]
    FROM [dbo].[Blogs] AS [Extent1]
    WHERE ([Extent1].[Name] = @p__linq__0) OR (([Extent1].[Name] IS NULL) AND (@p__linq__0 IS NULL))
-- ===========================================================================================================
INSERT [dbo].[Posts]([Title], [Content], [BlogId])
VALUES (@0, @1, @2)
SELECT [PostId]
FROM [dbo].[Posts]
WHERE @@ROWCOUNT > 0 AND [PostId] = scope_identity()

INSERT [dbo].[Posts]([Title], [Content], [BlogId])
VALUES (@0, @1, @2)
SELECT [PostId]
FROM [dbo].[Posts]
WHERE @@ROWCOUNT > 0 AND [PostId] = scope_identity()

INSERT [dbo].[Posts]([Title], [Content], [BlogId])
VALUES (@0, @1, @2)
SELECT [PostId]
FROM [dbo].[Posts]
WHERE @@ROWCOUNT > 0 AND [PostId] = scope_identity()
-- ===========================================================================================================

-- Press Enter to continue.

-- Opened connection at 21/11/2017 11:08:52 a.m. +08:00

SELECT
    [GroupBy1].[A1] AS [C1]
    FROM ( SELECT
        SUM([Extent1].[BlogId]) AS [A1]
        FROM [dbo].[Blogs] AS [Extent1]
        WHERE 1 = [Extent1].[BlogId]
    )  AS [GroupBy1]
SELECT
    [GroupBy1].[A1] AS [C1]
    FROM ( SELECT
        SUM([Extent1].[BlogId]) AS [A1]
        FROM [dbo].[Blogs] AS [Extent1]
        WHERE 1 = [Extent1].[BlogId]
    )  AS [GroupBy1]


-- Executing at 21/11/2017 11:08:52 a.m. +08:00

-- Completed in 1 ms with result: SqlDataReader

-- Closed connection at 21/11/2017 11:08:52 a.m. +08:00

-- ===========================================================================================================

-- blog query: 1
-- Opened connection at 21/11/2017 11:08:52 a.m. +08:00

SELECT
    [GroupBy1].[A1] AS [C1]
    FROM ( SELECT
        SUM([Extent1].[PostId]) AS [A1]
        FROM [dbo].[Posts] AS [Extent1]
        WHERE 1 = [Extent1].[BlogId]
    )  AS [GroupBy1]
SELECT
    [GroupBy1].[A1] AS [C1]
    FROM ( SELECT
        SUM([Extent1].[PostId]) AS [A1]
        FROM [dbo].[Posts] AS [Extent1]
        WHERE 1 = [Extent1].[BlogId]
    )  AS [GroupBy1]


-- Executing at 21/11/2017 11:08:52 a.m. +08:00

-- Completed in 8 ms with result: SqlDataReader



-- Closed connection at 21/11/2017 11:08:52 a.m. +08:00
===========================================================================================================
-- post query: 6
-- Opened connection at 21/11/2017 11:08:52 a.m. +08:00

SELECT
    [Extent1].[BlogId] AS [BlogId],
    [Extent1].[Name] AS [Name],
    [Extent2].[Content] AS [Content]
    FROM  [dbo].[Blogs] AS [Extent1]
    INNER JOIN [dbo].[Posts] AS [Extent2] ON [Extent1].[BlogId] = [Extent2].[BlogId]
SELECT
    [Extent1].[BlogId] AS [BlogId],
    [Extent1].[Name] AS [Name],
    [Extent2].[Content] AS [Content]
    FROM  [dbo].[Blogs] AS [Extent1]
    INNER JOIN [dbo].[Posts] AS [Extent2] ON [Extent1].[BlogId] = [Extent2].[BlogId]


-- Executing at 21/11/2017 11:08:52 a.m. +08:00

-- Completed in 8 ms with result: SqlDataReader
===========================================================================================================


-- WHY, Test 1
-- WHY, Test 2
-- WHY, Test 3
-- Closed connection at 21/11/2017 11:08:52 a.m. +08:00

-- Press any key to exit...