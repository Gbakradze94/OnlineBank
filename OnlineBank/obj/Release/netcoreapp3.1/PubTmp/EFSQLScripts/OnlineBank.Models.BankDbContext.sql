IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201225135811_Initial')
BEGIN
    CREATE TABLE [Accounts] (
        [AccountID] bigint NOT NULL IDENTITY,
        [AccountName] nvarchar(max) NULL,
        [Currency] nvarchar(max) NULL,
        [AccountNumber] int NOT NULL,
        [Balance] decimal(8,2) NOT NULL,
        [Category] nvarchar(max) NULL,
        CONSTRAINT [PK_Accounts] PRIMARY KEY ([AccountID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201225135811_Initial')
BEGIN
    CREATE TABLE [Operations] (
        [OperationID] int NOT NULL IDENTITY,
        [AccountName] nvarchar(max) NOT NULL,
        [AccountNumber] int NOT NULL,
        [Amount] float NOT NULL,
        [Country] nvarchar(max) NULL,
        [ConfirmOnPhone] bit NOT NULL,
        [Delivered] bit NOT NULL,
        CONSTRAINT [PK_Operations] PRIMARY KEY ([OperationID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201225135811_Initial')
BEGIN
    CREATE TABLE [TransferLine] (
        [TransferLineID] int NOT NULL IDENTITY,
        [AccountID] bigint NULL,
        [Amount] int NOT NULL,
        [UsdExchangeRate] float NOT NULL,
        [OperationID] int NULL,
        CONSTRAINT [PK_TransferLine] PRIMARY KEY ([TransferLineID]),
        CONSTRAINT [FK_TransferLine_Accounts_AccountID] FOREIGN KEY ([AccountID]) REFERENCES [Accounts] ([AccountID]) ON DELETE NO ACTION,
        CONSTRAINT [FK_TransferLine_Operations_OperationID] FOREIGN KEY ([OperationID]) REFERENCES [Operations] ([OperationID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201225135811_Initial')
BEGIN
    CREATE INDEX [IX_TransferLine_AccountID] ON [TransferLine] ([AccountID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201225135811_Initial')
BEGIN
    CREATE INDEX [IX_TransferLine_OperationID] ON [TransferLine] ([OperationID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201225135811_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201225135811_Initial', N'3.1.1');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201225135840_Operations')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201225135840_Operations', N'3.1.1');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201225135907_ConfirmedOperations')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201225135907_ConfirmedOperations', N'3.1.1');
END;

GO

