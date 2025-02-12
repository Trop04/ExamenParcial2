USE [master]
GO
/****** Object:  Database [ExamenParcial2]    Script Date: 29/01/2025 22:26:14 ******/
CREATE DATABASE [ExamenParcial2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ExamenParcial2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ExamenParcial2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ExamenParcial2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ExamenParcial2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ExamenParcial2] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ExamenParcial2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ExamenParcial2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ExamenParcial2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ExamenParcial2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ExamenParcial2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ExamenParcial2] SET ARITHABORT OFF 
GO
ALTER DATABASE [ExamenParcial2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ExamenParcial2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ExamenParcial2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ExamenParcial2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ExamenParcial2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ExamenParcial2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ExamenParcial2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ExamenParcial2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ExamenParcial2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ExamenParcial2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ExamenParcial2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ExamenParcial2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ExamenParcial2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ExamenParcial2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ExamenParcial2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ExamenParcial2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ExamenParcial2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ExamenParcial2] SET RECOVERY FULL 
GO
ALTER DATABASE [ExamenParcial2] SET  MULTI_USER 
GO
ALTER DATABASE [ExamenParcial2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ExamenParcial2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ExamenParcial2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ExamenParcial2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ExamenParcial2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ExamenParcial2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ExamenParcial2', N'ON'
GO
ALTER DATABASE [ExamenParcial2] SET QUERY_STORE = ON
GO
ALTER DATABASE [ExamenParcial2] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ExamenParcial2]
GO
/****** Object:  Table [dbo].[Entradas]    Script Date: 29/01/2025 22:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entradas](
	[IdEntrada] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[FechaEntrada] [datetime] NULL,
	[IdProveedor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdEntrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 29/01/2025 22:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Descripcion] [nvarchar](255) NULL,
	[Precio] [decimal](10, 2) NOT NULL,
	[Stock] [int] NOT NULL,
	[IdProveedor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 29/01/2025 22:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Contacto] [nvarchar](100) NULL,
	[Telefono] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[Direccion] [nvarchar](255) NULL,
	[FechaRegistro] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Entradas] ON 

INSERT [dbo].[Entradas] ([IdEntrada], [IdProducto], [Cantidad], [FechaEntrada], [IdProveedor]) VALUES (16, 19, 15, CAST(N'2025-01-29T22:04:01.713' AS DateTime), 2)
INSERT [dbo].[Entradas] ([IdEntrada], [IdProducto], [Cantidad], [FechaEntrada], [IdProveedor]) VALUES (17, 20, 25, CAST(N'2025-01-29T22:05:53.880' AS DateTime), 4)
SET IDENTITY_INSERT [dbo].[Entradas] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Descripcion], [Precio], [Stock], [IdProveedor]) VALUES (19, N'Pepsi 1L', N'Botella de Pepsi de 1L', CAST(1.00 AS Decimal(10, 2)), 15, 2)
INSERT [dbo].[Productos] ([IdProducto], [Nombre], [Descripcion], [Precio], [Stock], [IdProveedor]) VALUES (20, N'Coca-Cola 250ml Vidrio', N'Botellas de Vidrio de Coca Cola de 250ml', CAST(0.50 AS Decimal(10, 2)), 25, 4)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedores] ON 

INSERT [dbo].[Proveedores] ([IdProveedor], [Nombre], [Contacto], [Telefono], [Email], [Direccion], [FechaRegistro]) VALUES (1, N'Favorita', N'Favorita Co', N'555-1234', N'FavoritaCorp@gmail.com', N'Calle 123, Guayaquil, Ecuador', CAST(N'2025-01-29T16:45:36.560' AS DateTime))
INSERT [dbo].[Proveedores] ([IdProveedor], [Nombre], [Contacto], [Telefono], [Email], [Direccion], [FechaRegistro]) VALUES (2, N'Pepsi', N'Pepsico', N'555-1789', N'Pepsi@gmail.com', N'Street 1, Atlanta, US', CAST(N'2025-01-29T16:45:36.560' AS DateTime))
INSERT [dbo].[Proveedores] ([IdProveedor], [Nombre], [Contacto], [Telefono], [Email], [Direccion], [FechaRegistro]) VALUES (3, N'Pilsener', N'Pilsener', N'555-8765', N'PilsenerBebidas@hotmail.com', N'Calle Secundaria 789, Quito, Ecuador', CAST(N'2025-01-29T16:45:36.560' AS DateTime))
INSERT [dbo].[Proveedores] ([IdProveedor], [Nombre], [Contacto], [Telefono], [Email], [Direccion], [FechaRegistro]) VALUES (4, N'Coca-Cola', N'Coca-Cola Co', N'555-1896', N'CocaCo@hotmail.com', N'Street 2, Atlanta, US', CAST(N'2025-01-29T22:05:05.300' AS DateTime))
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
GO
ALTER TABLE [dbo].[Entradas] ADD  DEFAULT (getdate()) FOR [FechaEntrada]
GO
ALTER TABLE [dbo].[Productos] ADD  DEFAULT ((0)) FOR [Stock]
GO
ALTER TABLE [dbo].[Proveedores] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[Proveedores] ([IdProveedor])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[Proveedores] ([IdProveedor])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD CHECK  (([Cantidad]>(0)))
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD CHECK  (([Precio]>=(0)))
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD CHECK  (([Stock]>=(0)))
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarProducto]    Script Date: 29/01/2025 22:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ActualizarProducto]
    @IdProducto INT,
    @Nombre NVARCHAR(100),
    @Descripcion NVARCHAR(255),
    @Precio DECIMAL(10,2),
    @Stock INT,
    @IdProveedor INT
AS
BEGIN
    UPDATE Productos
    SET Nombre = @Nombre, Descripcion = @Descripcion, Precio = @Precio, Stock = @Stock, IdProveedor = @IdProveedor
    WHERE IdProducto = @IdProducto;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarProveedor]    Script Date: 29/01/2025 22:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarProveedor]
    @IdProveedor INT,
    @Nombre NVARCHAR(100),
    @Contacto NVARCHAR(100),
    @Telefono NVARCHAR(20),
    @Email NVARCHAR(100),
    @Direccion NVARCHAR(255)
AS
BEGIN
    UPDATE Proveedores
    SET Nombre = @Nombre, Contacto = @Contacto, Telefono = @Telefono, Email = @Email, Direccion = @Direccion
    WHERE IdProveedor = @IdProveedor;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarEntrada]    Script Date: 29/01/2025 22:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AgregarEntrada]
    @IdProducto INT,
    @Cantidad INT
AS
BEGIN
    INSERT INTO Entradas (IdProducto, Cantidad, FechaEntrada)
    VALUES (@IdProducto, @Cantidad, GETDATE());
END

GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarProducto]    Script Date: 29/01/2025 22:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AgregarProducto]
    @Nombre NVARCHAR(100),
    @Descripcion NVARCHAR(255),
    @Precio DECIMAL(10,2),
    @Stock INT,
    @IdProveedor INT
AS
BEGIN
    DECLARE @IdProducto INT;

    INSERT INTO Productos (Nombre, Descripcion, Precio, Stock, IdProveedor)
    VALUES (@Nombre, @Descripcion, @Precio, @Stock, @IdProveedor);
    SET @IdProducto = SCOPE_IDENTITY();
    IF @IdProveedor IS NOT NULL
    BEGIN
        INSERT INTO Entradas (IdProducto, FechaEntrada, Cantidad, IdProveedor)
        VALUES (@IdProducto, GETDATE(), @Stock, @IdProveedor);
    END
    ELSE
    BEGIN
        PRINT 'Error: IdProveedor es NULL';
    END
END

GO
/****** Object:  StoredProcedure [dbo].[sp_AgregarProveedor]    Script Date: 29/01/2025 22:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_AgregarProveedor]
    @Nombre NVARCHAR(100),
    @Contacto NVARCHAR(100),
    @Telefono NVARCHAR(20),
    @Email NVARCHAR(100),
    @Direccion NVARCHAR(255)
AS
BEGIN
    INSERT INTO Proveedores (Nombre, Contacto, Telefono, Email, Direccion, FechaRegistro)
    VALUES (@Nombre, @Contacto, @Telefono, @Email, @Direccion, GETDATE());
END

GO
/****** Object:  StoredProcedure [dbo].[sp_BuscarProducto]    Script Date: 29/01/2025 22:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_BuscarProducto]
    @Nombre NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Productos WHERE Nombre LIKE '%' + @Nombre + '%';
END

GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarProducto]    Script Date: 29/01/2025 22:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EliminarProducto]
    @IdProducto INT
AS
BEGIN
    DELETE FROM Productos WHERE IdProducto = @IdProducto;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_EliminarProveedor]    Script Date: 29/01/2025 22:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_EliminarProveedor]
    @IdProveedor INT
AS
BEGIN
    DELETE FROM Proveedores WHERE IdProveedor = @IdProveedor;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerEntradas]    Script Date: 29/01/2025 22:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ObtenerEntradas]
    @Busqueda NVARCHAR(100)
AS
BEGIN
    SELECT e.IdEntrada, p.Nombre AS Producto, e.Cantidad, e.FechaEntrada 
    FROM Entradas e
    INNER JOIN Productos p ON e.IdProducto = p.IdProducto
    WHERE p.Nombre LIKE '%' + @Busqueda + '%';
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerProveedores]    Script Date: 29/01/2025 22:26:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_ObtenerProveedores]
AS
BEGIN
    SELECT IdProveedor, Nombre, Contacto, Telefono, Email, Direccion FROM Proveedores;
END

GO
USE [master]
GO
ALTER DATABASE [ExamenParcial2] SET  READ_WRITE 
GO
