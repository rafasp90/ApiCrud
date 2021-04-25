IF NOT EXISTS(select 1 from sys.databases where name = 'UsandoCrud')
	CREATE DATABASE UsandoCrud;
GO

USE [UsandoCrud]
GO
/****** Object:  Table [dbo].[Pessoa]    Script Date: 24/04/2021 00:06:51 ******/
DROP TABLE IF EXISTS [dbo].[Pessoa]
GO
/****** Object:  Table [dbo].[Pessoa]    Script Date: 24/04/2021 00:06:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pessoa](
	[CodPessoa] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](300) NOT NULL,
	[CpfCnpj] [varchar](14) NOT NULL,
	[Rg] [varchar](10) NULL,
	[DataNascimento] [date] NULL,
	[Cep] [varchar](10) NULL,
	[Endereco] [varchar](500) NULL,
	[Numero] [varchar](10) NULL,
	[Complemento] [varchar](30) NULL,
	[DataCadastro] [datetime] NULL,
 CONSTRAINT [PK_Pessoa] PRIMARY KEY CLUSTERED 
(
	[CodPessoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
