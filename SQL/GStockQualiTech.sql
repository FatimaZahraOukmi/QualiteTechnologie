  
  Select * From Utilisateurs;
  Select * From Vente;
  Select * From DetailVente;
  Select * From Articles;
  Select * From DetailAchat;
    Select * From Achat;
	  

  


CREATE DATABASE GStockQualiTech;
USE GStockQualiTech;

CREATE TABLE Utilisateurs (
    UtilisateurId INT PRIMARY KEY IDENTITY,
    Nom VARCHAR(50),
    Prenom VARCHAR(50),
    Login VARCHAR(50),
    Password VARCHAR(50),
    Telephone VARCHAR(20),
    Email VARCHAR(50),
    Role VARCHAR(50)
);

CREATE TABLE Clients (
    ClientId INT PRIMARY KEY IDENTITY,
    Entreprise VARCHAR(100) UNIQUE,
    Email VARCHAR(50) UNIQUE,
    TelephoneFax VARCHAR(20),
    Ville VARCHAR(255),
    TypeArticleId INT,
    FOREIGN KEY (TypeArticleId) REFERENCES TypeArticle(TypeArticleId)
);

CREATE TABLE Fournisseurs (
    FournisseurId INT PRIMARY KEY IDENTITY,
    Entreprise VARCHAR(100) UNIQUE,
    Ville VARCHAR(255),
    Email VARCHAR(255) UNIQUE,
    Telephone VARCHAR(20),
    TypeArticleId INT,
    FOREIGN KEY (TypeArticleId) REFERENCES TypeArticle(TypeArticleId)
);

CREATE TABLE Vente (
       VenteId INT PRIMARY KEY IDENTITY,
       UtilisateurId INT NOT NULL,
       ClientID INT,
       Date_Vente DATETIME NOT NULL DEFAULT GETDATE(),
       Montant_Total DECIMAL(10, 2) NOT NULL,
       FOREIGN KEY (ClientId) REFERENCES Clients(ClientId),
       FOREIGN KEY (UtilisateurId) REFERENCES Utilisateurs(UtilisateurId)
);

CREATE TABLE DetailVente (
		ID_DetailVente INT PRIMARY KEY IDENTITY,
		VenteId INT NOT NULL,
		ArticleId INT NOT NULL,
		Reference VARCHAR(50),
		Designation VARCHAR(255),
		PrixUnitaire DECIMAL,
		Quantite INT,
		Montant_Produit DECIMAL(10, 2) NOT NULL,
		FOREIGN KEY (VenteId) REFERENCES Vente(VenteId),
		FOREIGN KEY (ArticleId) REFERENCES Articles(ArticleId)
);

CREATE TABLE Achat (
		AchatId INT PRIMARY KEY IDENTITY,
		UtilisateurId INT NOT NULL,
		FournisseurId INT,
		Date_Achat DATETIME NOT NULL DEFAULT GETDATE(),
		Montant_Total DECIMAL(10, 2) NOT NULL,
		FOREIGN KEY (FournisseurId) REFERENCES Fournisseurs(FournisseurId),
		FOREIGN KEY (UtilisateurId) REFERENCES Utilisateurs(UtilisateurId)
);

CREATE TABLE DetailAchat (
		ID_DetailAchat INT PRIMARY KEY IDENTITY,
		AchatId INT,
		ArticleId INT NOT NULL,
		Reference VARCHAR(50),
		Designation VARCHAR(255),
		PrixUnitaire DECIMAL,
		Quantite INT,		
		Montant_Produit DECIMAL(10, 2) NOT NULL,
		FOREIGN KEY (AchatId) REFERENCES Achat(AchatId),
		FOREIGN KEY (ArticleId) REFERENCES Articles(ArticleId)
);

CREATE TABLE TypeArticle (
    TypeArticleId INT PRIMARY KEY IDENTITY,
    Libelle VARCHAR(50)
);

CREATE TABLE Articles (
    ArticleId INT PRIMARY KEY IDENTITY,
    Designation VARCHAR(255),
    TypeArticleId INT,
    PrixUnitaire DECIMAL,
    QuantiteStock INT,
    FournisseurId INT,
    Reference VARCHAR(50),
    DateReception DATETIME,
    FOREIGN KEY (TypeArticleId) REFERENCES TypeArticle(TypeArticleId),
    FOREIGN KEY (FournisseurId) REFERENCES Fournisseurs(FournisseurId)
);

-- Assurez-vous d'utiliser la bonne base de données
USE GStockQualiTech;

-- Insertion de données dans la table Utilisateurs
INSERT INTO Utilisateurs (Nom, Prenom, Login, Password, Telephone, Email, Role) 
VALUES 
('Oukmi', 'FatimaZahra', 'Faty5', '123', '0123456789', 'FatyOuk@example.com', 'Gerante'),
('OuiDir', 'Sara', 'Sara7', '777', '08966498', 'Saraoui@example.com', 'Commercial'),
('Hedraty', 'Manel', 'Manel1', '111', '1234567890', 'ManelK@example.com', 'RH');

-- Insertion de données dans la table TypeArticle
INSERT INTO TypeArticle (Libelle) VALUES ('Tablettes');
INSERT INTO TypeArticle (Libelle) VALUES ('SmartPhone');
INSERT INTO TypeArticle (Libelle) VALUES ('PC');
INSERT INTO TypeArticle (Libelle) VALUES ('Accessoires');

-- Insertion de données dans la table Articles
INSERT INTO Articles (Designation, TypeArticleId, PrixUnitaire, QuantiteStock, FournisseurId, Reference, DateReception) 
VALUES 
('iPad', 1, 300, 50, 1, 'REF123', '2024-04-03'),
('iPhone', 2, 700, 30, 1, 'REF456', '2024-04-07'),
('Samsung Galaxy S21', 2, 800, 20, 2, 'REF789', '2024-03-03');

-- Insertion de données dans la table Clients
INSERT INTO Clients (Entreprise, Email, TelephoneFax, Ville, TypeArticleId) 
VALUES 
('Imilchil Sarl', 'Imilchil@example.com', '0123456789', 'Rabat', 2),
('Belectrotec Sarl', 'Belectrotec@example.com', '0987654321', 'Casablanca', 3),
('Sis Consultant', 'Sis@example.com', '1122334455', 'Salé', 1);

-- Insertion de données dans la table Fournisseurs
INSERT INTO Fournisseurs (Entreprise, Ville, Email, Telephone, TypeArticleId) 
VALUES 
('Ste Systeme De Telephone', 'Rabat', '0123456789', '0123456789', 4),
('Maroc Phone', 'Marakech', 'MarocPhone@example.com', '0987654321', 3),
('Technologie & Telecom T&T', 'Casablanca', 'TechnologieT&T@example.com', '1122334455', 2);

-- Ajout de la colonne TypeArticleId dans la table DetailAchat
ALTER TABLE DetailAchat
ADD TypeArticleId INT,
FOREIGN KEY (TypeArticleId) REFERENCES TypeArticle(TypeArticleId);

-- Ajout de la colonne TypeArticleId dans la table DetailVente
ALTER TABLE DetailVente
ADD TypeArticleId INT,
FOREIGN KEY (TypeArticleId) REFERENCES TypeArticle(TypeArticleId);


CREATE PROCEDURE AjouterAchat (
    @UtilisateurId INT,
    @FournisseurId INT,
    @Date_Achat DATETIME,
    @DetailAchat XML
)
AS
BEGIN
    DECLARE @AchatId INT;

    -- Ajouter l'achat
    INSERT INTO Achat (UtilisateurId, FournisseurId, Date_Achat)
    VALUES (@UtilisateurId, @FournisseurId, @Date_Achat);

    -- Récupérer l'ID de l'achat ajouté
    SET @AchatId = SCOPE_IDENTITY(); 

    -- Insérer les détails d'achat à partir de la données XML
    INSERT INTO DetailAchat (AchatId, ArticleId, Reference, Designation, PrixUnitaire, Quantite, Montant_Produit)
    SELECT 
        @AchatId,
        DetailAchat.value('(ArticleId)[1]', 'INT'),
        DetailAchat.value('(Reference)[1]', 'NVARCHAR(50)'),
        DetailAchat.value('(Designation)[1]', 'NVARCHAR(100)'),
        DetailAchat.value('(PrixUnitaire)[1]', 'DECIMAL(18, 2)'),
        DetailAchat.value('(Quantite)[1]', 'INT'),
        DetailAchat.value('(PrixUnitaire)[1]', 'DECIMAL(18, 2)') * DetailAchat.value('(Quantite)[1]', 'INT')
    FROM @DetailAchat.nodes('/DetailAchat') AS Tbl(DetailAchat);

    -- Mettre à jour le Montant_Total dans l'achat
    UPDATE A
    SET Montant_Total = (
        SELECT SUM(DA.Montant_Produit)
        FROM DetailAchat DA
        WHERE DA.AchatId = @AchatId
    )
    FROM Achat A
    WHERE A.AchatId = @AchatId;
END;


CREATE PROCEDURE RemplirTablesAchat (
    @UtilisateurId INT,
    @FournisseurId INT,
    @Date_Achat DATETIME,
    @ArticleId INT,
    @Reference NVARCHAR(50),
    @Designation NVARCHAR(100),
    @PrixUnitaire DECIMAL(18, 2),
    @Quantite INT
)
AS
BEGIN
    BEGIN TRANSACTION;

    DECLARE @AchatId INT;

    -- Insérer l'achat
    INSERT INTO Achat (UtilisateurId, FournisseurId, Date_Achat)
    VALUES (@UtilisateurId, @FournisseurId, @Date_Achat);
    SET @AchatId = SCOPE_IDENTITY();

    -- Insérer les détails d'achat
    INSERT INTO DetailAchat (AchatId, ArticleId, Reference, Designation, PrixUnitaire, Quantite, Montant_Produit)
    VALUES (@AchatId, @ArticleId, @Reference, @Designation, @PrixUnitaire, @Quantite, @PrixUnitaire * @Quantite);

    -- Insérer l'article si nécessaire
    IF NOT EXISTS (
        SELECT 1
        FROM Articles
        WHERE ArticleId = @ArticleId
    )
    BEGIN
        INSERT INTO Articles (ArticleId, Designation, TypeArticleId, PrixUnitaire, QuantiteStock, FournisseurId, Reference, DateReception)
        VALUES (@ArticleId, @Designation, (SELECT TypeArticleId FROM Articles WHERE ArticleId = @ArticleId), @PrixUnitaire, @Quantite, @FournisseurId, @Reference, @Date_Achat);
    END

    -- Commit de la transaction
    COMMIT TRANSACTION;
END;
