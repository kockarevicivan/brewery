USE [BreweryDB]
GO
SET IDENTITY_INSERT [dbo].[Brewery] ON 

INSERT [dbo].[Brewery] ([Id], [Name], [PIN], [State]) VALUES (1, N'Apatinska pivara', N'462745-67856398-4564576', N'Srbija')
INSERT [dbo].[Brewery] ([Id], [Name], [PIN], [State]) VALUES (2, N'Heineken brewery', N'9557-474347-45892-2245', N'Netherlands')
INSERT [dbo].[Brewery] ([Id], [Name], [PIN], [State]) VALUES (3, N'Pivara Čelarevo', N'6748-4774-3554758-4253', N'Srbija')
SET IDENTITY_INSERT [dbo].[Brewery] OFF
SET IDENTITY_INSERT [dbo].[BeerType] ON 

INSERT [dbo].[BeerType] ([Id], [Name]) VALUES (1, N'Lager')
INSERT [dbo].[BeerType] ([Id], [Name]) VALUES (2, N'Tamno pivo')
INSERT [dbo].[BeerType] ([Id], [Name]) VALUES (3, N'Ale')
INSERT [dbo].[BeerType] ([Id], [Name]) VALUES (4, N'Crveno pivo')
SET IDENTITY_INSERT [dbo].[BeerType] OFF
SET IDENTITY_INSERT [dbo].[Beer] ON 

INSERT [dbo].[Beer] ([Id], [Name], [AlcoholPercentage], [IBU], [Quantity], [BeerTypeId], [BreweryId]) VALUES (1, N'Jelen', CAST(6.500 AS Decimal(6, 3)), CAST(22.000 AS Decimal(6, 3)), 128, 1, 1)
INSERT [dbo].[Beer] ([Id], [Name], [AlcoholPercentage], [IBU], [Quantity], [BeerTypeId], [BreweryId]) VALUES (2, N'Heineken', CAST(5.800 AS Decimal(6, 3)), CAST(23.000 AS Decimal(6, 3)), 50, 1, 2)
INSERT [dbo].[Beer] ([Id], [Name], [AlcoholPercentage], [IBU], [Quantity], [BeerTypeId], [BreweryId]) VALUES (3, N'Lav', CAST(5.700 AS Decimal(6, 3)), CAST(21.000 AS Decimal(6, 3)), 236, 1, 3)
SET IDENTITY_INSERT [dbo].[Beer] OFF
