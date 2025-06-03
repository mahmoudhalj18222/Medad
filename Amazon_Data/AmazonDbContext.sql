IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250517113043_inital'
)
BEGIN
    CREATE TABLE [Employees] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Employees] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250517113043_inital'
)
BEGIN
    CREATE TABLE [amazonTasks] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [CreateDate] datetime2 NOT NULL,
        [CloseDate] datetime2 NOT NULL,
        [EmployeeId] int NOT NULL,
        CONSTRAINT [PK_amazonTasks] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_amazonTasks_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees] ([Id]) ON DELETE CASCADE
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250517113043_inital'
)
BEGIN
    CREATE INDEX [IX_amazonTasks_EmployeeId] ON [amazonTasks] ([EmployeeId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250517113043_inital'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20250517113043_inital', N'9.0.5');
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250517123209_getAgeToEmmployee'
)
BEGIN
    ALTER TABLE [Employees] ADD [Phone] nvarchar(max) NOT NULL DEFAULT N'';
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250517123209_getAgeToEmmployee'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20250517123209_getAgeToEmmployee', N'9.0.5');
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250517163934_AddCategory'
)
BEGIN
    CREATE TABLE [categorie] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_categorie] PRIMARY KEY ([Id])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250517163934_AddCategory'
)
BEGIN
    CREATE TABLE [AmazonTaskCategory] (
        [categoriesId] int NOT NULL,
        [tasksId] int NOT NULL,
        CONSTRAINT [PK_AmazonTaskCategory] PRIMARY KEY ([categoriesId], [tasksId]),
        CONSTRAINT [FK_AmazonTaskCategory_amazonTasks_tasksId] FOREIGN KEY ([tasksId]) REFERENCES [amazonTasks] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AmazonTaskCategory_categorie_categoriesId] FOREIGN KEY ([categoriesId]) REFERENCES [categorie] ([Id]) ON DELETE CASCADE
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250517163934_AddCategory'
)
BEGIN
    CREATE INDEX [IX_AmazonTaskCategory_tasksId] ON [AmazonTaskCategory] ([tasksId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250517163934_AddCategory'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20250517163934_AddCategory', N'9.0.5');
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250518171939_Add_Custome_category'
)
BEGIN
    DROP TABLE [AmazonTaskCategory];
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250518171939_Add_Custome_category'
)
BEGIN
    CREATE TABLE [CategoryTesk] (
        [categoriesId] int NOT NULL,
        [tasksId] int NOT NULL,
        [getDateAdd] datetime2 NOT NULL DEFAULT (getDate()),
        CONSTRAINT [PK_CategoryTesk] PRIMARY KEY ([categoriesId], [tasksId]),
        CONSTRAINT [FK_CategoryTesk_amazonTasks_tasksId] FOREIGN KEY ([tasksId]) REFERENCES [amazonTasks] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_CategoryTesk_categorie_categoriesId] FOREIGN KEY ([categoriesId]) REFERENCES [categorie] ([Id]) ON DELETE CASCADE
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250518171939_Add_Custome_category'
)
BEGIN
    CREATE INDEX [IX_CategoryTesk_tasksId] ON [CategoryTesk] ([tasksId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250518171939_Add_Custome_category'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20250518171939_Add_Custome_category', N'9.0.5');
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250518173113_Add_Employee_Address'
)
BEGIN
    CREATE TABLE [Address] (
        [id] int NOT NULL IDENTITY,
        [country] nvarchar(max) NOT NULL,
        [city] nvarchar(max) NOT NULL,
        [EmployeeId] int NOT NULL,
        CONSTRAINT [PK_Address] PRIMARY KEY ([id]),
        CONSTRAINT [FK_Address_Employees_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employees] ([Id]) ON DELETE CASCADE
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250518173113_Add_Employee_Address'
)
BEGIN
    CREATE UNIQUE INDEX [IX_Address_EmployeeId] ON [Address] ([EmployeeId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250518173113_Add_Employee_Address'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20250518173113_Add_Employee_Address', N'9.0.5');
END;

COMMIT;
GO