CREATE TABLE [dbo].[Log]
(
	[ID] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [CreateDate] DATETIME NOT NULL DEFAULT getdate(), 
    [LogLevel] INT NOT NULL, 
    [CorrelationID] UNIQUEIDENTIFIER NOT NULL DEFAULT newid(), 
    [Step] INT NOT NULL DEFAULT 1, 
    [Who] NVARCHAR(50) NOT NULL DEFAULT '', 
    [Message] NVARCHAR(100) NOT NULL , 
    [RefName] NVARCHAR(50) NOT NULL DEFAULT '', 
    [RefValue] NVARCHAR(50) NOT NULL DEFAULT '', 
    [Path] NVARCHAR(1000) NOT NULL DEFAULT '', 
    [Assembly] VARCHAR(200) NOT NULL DEFAULT '', 
    [ClassName] VARCHAR(200) NOT NULL DEFAULT '', 
    [MethodName] VARCHAR(200) NOT NULL DEFAULT '', 
    [IP] VARCHAR(50) NOT NULL DEFAULT '', 
    [URL] NVARCHAR(1000) NOT NULL DEFAULT '', 
    [Notes1] NVARCHAR(MAX) NOT NULL DEFAULT '', 
    [Notes2] NVARCHAR(MAX) NOT NULL DEFAULT ''
)

GO

CREATE INDEX [IX_Log_CreateDate] ON [dbo].[Log] ([CreateDate])

GO

CREATE INDEX [IX_Log_LogLevel] ON [dbo].[Log] ([LogLevel])

GO

CREATE INDEX [IX_Log_CorrelationID] ON [dbo].[Log] ([CorrelationID])

GO

CREATE INDEX [IX_Log_Who] ON [dbo].[Log] ([Who])

GO

CREATE INDEX [IX_Log_Message] ON [dbo].[Log] ([Message])

GO

CREATE INDEX [IX_Log_Ref] ON [dbo].[Log] ([RefName], [RefValue])

GO

CREATE INDEX [IX_Log_Assembly] ON [dbo].[Log] ([Assembly])

GO

CREATE INDEX [IX_Log_Class] ON [dbo].[Log] ([ClassName])

GO

CREATE INDEX [IX_Log_Method] ON [dbo].[Log] ([MethodName])

GO

CREATE INDEX [IX_Log_URL] ON [dbo].[Log] ([URL])
