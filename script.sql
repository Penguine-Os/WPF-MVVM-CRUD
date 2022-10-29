SET IDENTITY_INSERT [dbo].[Niveaus] ON 

INSERT [dbo].[Niveaus] ([Id], [Omschrijving]) VALUES (1, N'Federaal Parlement')
INSERT [dbo].[Niveaus] ([Id], [Omschrijving]) VALUES (2, N'Senaat')
INSERT [dbo].[Niveaus] ([Id], [Omschrijving]) VALUES (3, N'Europees Parlement')
INSERT [dbo].[Niveaus] ([Id], [Omschrijving]) VALUES (4, N'Vlaams Parlement')
INSERT [dbo].[Niveaus] ([Id], [Omschrijving]) VALUES (5, N'Federale Regering')
INSERT [dbo].[Niveaus] ([Id], [Omschrijving]) VALUES (6, N'Vlaamse Regering')
SET IDENTITY_INSERT [dbo].[Niveaus] OFF
GO

SET IDENTITY_INSERT [dbo].[PolitiekePartijen] ON 

INSERT [dbo].[PolitiekePartijen] ([Id], [Partijnaam], [AantalLeden]) VALUES (1, N'PVDA', 13591)
INSERT [dbo].[PolitiekePartijen] ([Id], [Partijnaam], [AantalLeden]) VALUES (2, N'GROEN', 9484)
INSERT [dbo].[PolitiekePartijen] ([Id], [Partijnaam], [AantalLeden]) VALUES (3, N'SPA', 42703)
INSERT [dbo].[PolitiekePartijen] ([Id], [Partijnaam], [AantalLeden]) VALUES (4, N'CDV', 48746)
INSERT [dbo].[PolitiekePartijen] ([Id], [Partijnaam], [AantalLeden]) VALUES (5, N'Open VLD', 58596)
INSERT [dbo].[PolitiekePartijen] ([Id], [Partijnaam], [AantalLeden]) VALUES (6, N'NVA', 40316)
SET IDENTITY_INSERT [dbo].[PolitiekePartijen] OFF
GO

SET IDENTITY_INSERT [dbo].[PolitiekePartijenNiveau] ON 

INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (1, 1, 1)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (2, 2, 1)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (3, 3, 1)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (4, 1, 2)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (5, 4, 2)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (6, 2, 2)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (7, 3, 2)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (8, 1, 3)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (9, 4, 3)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (10, 2, 3)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (11, 3, 3)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (12, 1, 4)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (13, 4, 4)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (14, 2, 4)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (15, 3, 4)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (16, 5, 4)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (17, 6, 4)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (18, 1, 5)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (19, 5, 5)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (20, 6, 5)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (21, 4, 5)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (22, 2, 5)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (23, 3, 5)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (24, 1, 6)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (25, 4, 6)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (26, 2, 6)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (27, 3, 6)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (28, 5, 6)
INSERT [dbo].[PolitiekePartijenNiveau] ([Id], [NiveauID], [PolitiekePartijID]) VALUES (29, 6, 6)
SET IDENTITY_INSERT [dbo].[PolitiekePartijenNiveau] OFF
GO 

SET IDENTITY_INSERT [dbo].[Politici] ON 

INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (1, N'Peter Mertens', 10, 1)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (2, N'Raoul Hedebouwbe', 1, 1)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (3, N'Marco Van Hees', 1, 1)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (4, N'Meyrem Almaci', 18, 4)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (5, N'Wouter De Vriendt', 11, 4)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (6, N'Wouter Van Besien', 20, 5)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (7, N'Peter Vanvelthoven', 20, 8)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (8, N'Caroline Gennez', 1, 9)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (9, N'Bruno Tobback', 10, 9)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (10, N'Wouter Beke', 17, 12)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (11, N'Cindy Franssen', 5, 13)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (12, N'Koen Geens', 1, 16)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (13, N'Hilde Crevits', 1, 17)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (14, N'Maggie de Block', 1, 19)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (15, N'Alexander de Croo', 1, 19)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (16, N'Bart Tommelein', 21, 20)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (17, N'Guy Verhofstadt', 35, 23)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (18, N'Bart De Wever', 22, 24)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (19, N'Jan Jambon', 1, 28)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (20, N'Theo Francken', 1, 28)
INSERT [dbo].[Politici] ([Id], [Naam], [JarenDienst], [PolitiekePartijNiveauID]) VALUES (21, N'Geert Boergeois', 1, 29)
SET IDENTITY_INSERT [dbo].[Politici] OFF
GO



