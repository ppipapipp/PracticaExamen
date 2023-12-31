USE [GestionAlumnos]
GO
/****** Object:  User [alumno]    Script Date: 20/9/2023 08:50:09 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 20/9/2023 08:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumnos](
	[idAlumno] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Legajo] [varchar](50) NULL,
	[Curso] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notas]    Script Date: 20/9/2023 08:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notas](
	[idAlumno] [int] IDENTITY(1,1) NOT NULL,
	[Nota] [int] NOT NULL,
 CONSTRAINT [PK_Notas] PRIMARY KEY CLUSTERED 
(
	[idAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Alumnos] ([idAlumno], [Nombre], [Apellido], [Legajo], [Curso]) VALUES (NULL, N'Lautaro', N'Yukelson', N'34024P', N'4IC')
INSERT [dbo].[Alumnos] ([idAlumno], [Nombre], [Apellido], [Legajo], [Curso]) VALUES (NULL, N'Iair', N'Steinberg', N'38932S', N'4IC')
INSERT [dbo].[Alumnos] ([idAlumno], [Nombre], [Apellido], [Legajo], [Curso]) VALUES (NULL, N'Dante', N'Napoli', N'36952R', NULL)
GO
SET IDENTITY_INSERT [dbo].[Notas] ON 

INSERT [dbo].[Notas] ([idAlumno], [Nota]) VALUES (1, 4)
INSERT [dbo].[Notas] ([idAlumno], [Nota]) VALUES (2, 9)
INSERT [dbo].[Notas] ([idAlumno], [Nota]) VALUES (3, 10)
SET IDENTITY_INSERT [dbo].[Notas] OFF
GO
ALTER TABLE [dbo].[Alumnos]  WITH CHECK ADD  CONSTRAINT [FK_Alumnos_Notas] FOREIGN KEY([idAlumno])
REFERENCES [dbo].[Notas] ([idAlumno])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Alumnos] CHECK CONSTRAINT [FK_Alumnos_Notas]
GO
