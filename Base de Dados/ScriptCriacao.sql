USE [master]
GO
/****** Object:  Database [WebChef]    Script Date: 03/06/2019 19:35:09 ******/
CREATE DATABASE [WebChef]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WebChef', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\WebChef.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WebChef_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\WebChef_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [WebChef] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WebChef].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WebChef] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WebChef] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WebChef] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WebChef] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WebChef] SET ARITHABORT OFF 
GO
ALTER DATABASE [WebChef] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WebChef] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WebChef] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WebChef] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WebChef] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WebChef] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WebChef] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WebChef] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WebChef] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WebChef] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WebChef] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WebChef] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WebChef] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WebChef] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WebChef] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WebChef] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WebChef] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WebChef] SET RECOVERY FULL 
GO
ALTER DATABASE [WebChef] SET  MULTI_USER 
GO
ALTER DATABASE [WebChef] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WebChef] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WebChef] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WebChef] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WebChef] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WebChef', N'ON'
GO
ALTER DATABASE [WebChef] SET QUERY_STORE = OFF
GO
USE [WebChef]
GO
/****** Object:  Table [dbo].[Acao]    Script Date: 03/06/2019 19:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Acao](
	[id_acao] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NULL,
	[descricao] [varchar](150) NULL,
 CONSTRAINT [PK_Acao] PRIMARY KEY CLUSTERED 
(
	[id_acao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmentaSemanal]    Script Date: 03/06/2019 19:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmentaSemanal](
	[id_receita] [int] NOT NULL,
	[id_utilizador] [int] NOT NULL,
	[dia_da_semana] [varchar](4) NOT NULL,
 CONSTRAINT [PK_EmentaSemanal] PRIMARY KEY CLUSTERED 
(
	[id_receita] ASC,
	[id_utilizador] ASC,
	[dia_da_semana] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ingrediente]    Script Date: 03/06/2019 19:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingrediente](
	[id_ingrediente] [int] IDENTITY(1,1) NOT NULL,
	[designacao] [varchar](50) NULL,
	[imagem] [varchar](100) NULL,
 CONSTRAINT [PK_Ingrediente] PRIMARY KEY CLUSTERED 
(
	[id_ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IngredientePreferidoUtilizador]    Script Date: 03/06/2019 19:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IngredientePreferidoUtilizador](
	[id_ingrediente] [int] NOT NULL,
	[id_utilizador] [int] NOT NULL,
	[favorito] [char](1) NULL,
 CONSTRAINT [PK_IngredientePreferidoUtilizador] PRIMARY KEY CLUSTERED 
(
	[id_ingrediente] ASC,
	[id_utilizador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passo]    Script Date: 03/06/2019 19:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passo](
	[id_passo] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](300) NULL,
	[timestamp] [varchar](4) NULL,
	[id_acao] [int] NULL,
	[duracao] [int] NULL,
 CONSTRAINT [PK_Passo] PRIMARY KEY CLUSTERED 
(
	[id_passo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PassoIngrediente]    Script Date: 03/06/2019 19:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PassoIngrediente](
	[id_passo] [int] NOT NULL,
	[id_ingrediente] [int] NOT NULL,
	[quantidade] [varchar](50) NULL,
 CONSTRAINT [PK_PassoIngrediente] PRIMARY KEY CLUSTERED 
(
	[id_passo] ASC,
	[id_ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receita]    Script Date: 03/06/2019 19:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receita](
	[id_receita] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](75) NULL,
	[descricao] [varchar](300) NULL,
	[informacao_nutricional] [varchar](100) NULL,
	[duracao_prevista] [int] NULL,
	[link_ajuda] [varchar](100) NULL,
	[imagem] [varchar](100) NULL,
	[nr_pessoas] [int] NULL,
	[dificuldade] [varchar](10) NULL,
	[categoria] [varchar](50) NULL,
 CONSTRAINT [PK_Receita] PRIMARY KEY CLUSTERED 
(
	[id_receita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Receita] SET (LOCK_ESCALATION = AUTO)
GO
/****** Object:  Table [dbo].[ReceitaIngrediente]    Script Date: 03/06/2019 19:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceitaIngrediente](
	[id_receita] [int] NOT NULL,
	[id_ingrediente] [int] NOT NULL,
	[quantidade] [varchar](50) NULL,
 CONSTRAINT [PK_ReceitaIngrediente] PRIMARY KEY CLUSTERED 
(
	[id_receita] ASC,
	[id_ingrediente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReceitaPasso]    Script Date: 03/06/2019 19:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceitaPasso](
	[id_passo] [int] NOT NULL,
	[id_receita] [int] NOT NULL,
	[numero] [int] NULL,
 CONSTRAINT [PK_ReceitaPasso] PRIMARY KEY CLUSTERED 
(
	[id_passo] ASC,
	[id_receita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReceitaUtilizador]    Script Date: 03/06/2019 19:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReceitaUtilizador](
	[id_receita] [int] NOT NULL,
	[id_utilizador] [int] NOT NULL,
	[duracao] [time](7) NULL,
	[favorita] [char](1) NULL,
	[avaliacao_dificuldade] [varchar](10) NULL,
	[classificacao] [int] NULL,
	[data_realizacao] [date] NULL,
	[anotacao] [varchar](200) NULL,
	[timeInicio] [time](7) NULL,
 CONSTRAINT [PK_ReceitaUtilizador] PRIMARY KEY CLUSTERED 
(
	[id_receita] ASC,
	[id_utilizador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilizador]    Script Date: 03/06/2019 19:35:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilizador](
	[id_utilizador] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NULL,
	[email] [varchar](75) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_Utilizador] PRIMARY KEY CLUSTERED 
(
	[id_utilizador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EmentaSemanal]  WITH CHECK ADD  CONSTRAINT [FK_EmentaSemanal_Receita] FOREIGN KEY([id_receita])
REFERENCES [dbo].[Receita] ([id_receita])
GO
ALTER TABLE [dbo].[EmentaSemanal] CHECK CONSTRAINT [FK_EmentaSemanal_Receita]
GO
ALTER TABLE [dbo].[EmentaSemanal]  WITH CHECK ADD  CONSTRAINT [FK_EmentaSemanal_Utilizador] FOREIGN KEY([id_utilizador])
REFERENCES [dbo].[Utilizador] ([id_utilizador])
GO
ALTER TABLE [dbo].[EmentaSemanal] CHECK CONSTRAINT [FK_EmentaSemanal_Utilizador]
GO
ALTER TABLE [dbo].[IngredientePreferidoUtilizador]  WITH CHECK ADD  CONSTRAINT [FK_IngredientePreferidoUtilizador_Ingrediente] FOREIGN KEY([id_ingrediente])
REFERENCES [dbo].[Ingrediente] ([id_ingrediente])
GO
ALTER TABLE [dbo].[IngredientePreferidoUtilizador] CHECK CONSTRAINT [FK_IngredientePreferidoUtilizador_Ingrediente]
GO
ALTER TABLE [dbo].[IngredientePreferidoUtilizador]  WITH CHECK ADD  CONSTRAINT [FK_IngredientePreferidoUtilizador_Utilizador] FOREIGN KEY([id_utilizador])
REFERENCES [dbo].[Utilizador] ([id_utilizador])
GO
ALTER TABLE [dbo].[IngredientePreferidoUtilizador] CHECK CONSTRAINT [FK_IngredientePreferidoUtilizador_Utilizador]
GO
ALTER TABLE [dbo].[Passo]  WITH CHECK ADD  CONSTRAINT [FK_Passo_Acao] FOREIGN KEY([id_acao])
REFERENCES [dbo].[Acao] ([id_acao])
GO
ALTER TABLE [dbo].[Passo] CHECK CONSTRAINT [FK_Passo_Acao]
GO
ALTER TABLE [dbo].[PassoIngrediente]  WITH CHECK ADD  CONSTRAINT [FK_PassoIngrediente_Ingrediente] FOREIGN KEY([id_ingrediente])
REFERENCES [dbo].[Ingrediente] ([id_ingrediente])
GO
ALTER TABLE [dbo].[PassoIngrediente] CHECK CONSTRAINT [FK_PassoIngrediente_Ingrediente]
GO
ALTER TABLE [dbo].[PassoIngrediente]  WITH CHECK ADD  CONSTRAINT [FK_PassoIngrediente_Passo] FOREIGN KEY([id_passo])
REFERENCES [dbo].[Passo] ([id_passo])
GO
ALTER TABLE [dbo].[PassoIngrediente] CHECK CONSTRAINT [FK_PassoIngrediente_Passo]
GO
ALTER TABLE [dbo].[ReceitaIngrediente]  WITH CHECK ADD  CONSTRAINT [FK_ReceitaIngrediente_Ingrediente] FOREIGN KEY([id_ingrediente])
REFERENCES [dbo].[Ingrediente] ([id_ingrediente])
GO
ALTER TABLE [dbo].[ReceitaIngrediente] CHECK CONSTRAINT [FK_ReceitaIngrediente_Ingrediente]
GO
ALTER TABLE [dbo].[ReceitaIngrediente]  WITH CHECK ADD  CONSTRAINT [FK_ReceitaIngrediente_Receita] FOREIGN KEY([id_receita])
REFERENCES [dbo].[Receita] ([id_receita])
GO
ALTER TABLE [dbo].[ReceitaIngrediente] CHECK CONSTRAINT [FK_ReceitaIngrediente_Receita]
GO
ALTER TABLE [dbo].[ReceitaPasso]  WITH CHECK ADD  CONSTRAINT [FK_ReceitaPasso_Passo] FOREIGN KEY([id_passo])
REFERENCES [dbo].[Passo] ([id_passo])
GO
ALTER TABLE [dbo].[ReceitaPasso] CHECK CONSTRAINT [FK_ReceitaPasso_Passo]
GO
ALTER TABLE [dbo].[ReceitaPasso]  WITH CHECK ADD  CONSTRAINT [FK_ReceitaPasso_Receita] FOREIGN KEY([id_receita])
REFERENCES [dbo].[Receita] ([id_receita])
GO
ALTER TABLE [dbo].[ReceitaPasso] CHECK CONSTRAINT [FK_ReceitaPasso_Receita]
GO
ALTER TABLE [dbo].[ReceitaUtilizador]  WITH CHECK ADD  CONSTRAINT [FK_ReceitaUtilizador_Receita] FOREIGN KEY([id_receita])
REFERENCES [dbo].[Receita] ([id_receita])
GO
ALTER TABLE [dbo].[ReceitaUtilizador] CHECK CONSTRAINT [FK_ReceitaUtilizador_Receita]
GO
ALTER TABLE [dbo].[ReceitaUtilizador]  WITH CHECK ADD  CONSTRAINT [FK_ReceitaUtilizador_Utilizador] FOREIGN KEY([id_utilizador])
REFERENCES [dbo].[Utilizador] ([id_utilizador])
GO
ALTER TABLE [dbo].[ReceitaUtilizador] CHECK CONSTRAINT [FK_ReceitaUtilizador_Utilizador]
GO
USE [master]
GO
ALTER DATABASE [WebChef] SET  READ_WRITE 
GO
