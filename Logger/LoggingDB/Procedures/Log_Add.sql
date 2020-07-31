create procedure [dbo].[Log_Add]
	@ID bigint out, 
    @CreateDate datetime, 
    @LogLevel int,
    @CorrelationID uniqueidentifier, 
    @Step int = 1, 
    @Who nvarchar(50) = '', 
    @Message nvarchar(100), 
    @RefName nvarchar(50) = '', 
    @RefValue nvarchar(50) = '', 
    @Path nvarchar(1000) = '', 
    @Assembly varchar(200) = '', 
    @ClassName varchar(200) = '', 
    @MethodName varchar(200) = '', 
    @IP varchar(50) = '', 
    @URL nvarchar(1000) = '', 
    @Notes1 nvarchar(MAX) = '', 
    @Notes2 nvarchar(MAX) = ''
as
begin
    insert dbo.Log
    (
        CreateDate, 
        LogLevel,
        CorrelationID, 
        Step, 
        Who, 
        [Message], 
        RefName, 
        RefValue, 
        [Path], 
        [Assembly], 
        ClassName, 
        MethodName, 
        [IP], 
        [URL], 
        Notes1, 
        Notes2
    )
    values
    (
        @CreateDate, 
        @LogLevel,
        @CorrelationID, 
        @Step, 
        @Who, 
        @Message, 
        @RefName, 
        @RefValue, 
        @Path, 
        @Assembly, 
        @ClassName, 
        @MethodName, 
        @IP, 
        @URL, 
        @Notes1, 
        @Notes2
    )

    set @ID = SCOPE_IDENTITY()
end

GO
