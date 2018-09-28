USE [ProjectManager]
GO

/****** Object:  Table [dbo].[Task_Table]    Script Date: 27-09-2018 15:19:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Task_Table](
	[Task_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Parent_ID] [bigint] NULL,
	[Project_ID] [bigint] NULL,
	[Task] [varchar](max) NOT NULL,
	[Start_Date] [datetime] NOT NULL,
	[End_Date] [datetime] NOT NULL,
	[Priority] [int] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Task_Table] PRIMARY KEY CLUSTERED 
(
	[Task_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


