#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------

DROP DATABASE IF EXISTS 

#------------------------------------------------------------
# Table: t_user
#------------------------------------------------------------

CREATE TABLE t_user(
        idUser       int (11) Auto_increment  NOT NULL ,
        useMail      Varchar (100) ,
        useName      Varchar (100) ,
        useFirstName Varchar (30) ,
        usePseudo    Varchar (50) ,
        useQuestion  Varchar (255) ,
        useAnswer    Varchar (255) ,
        usePassword  Varchar (255) ,
        useAvatar    Varchar (255) ,
        useTheme     Int ,
        PRIMARY KEY (idUser )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: t_animals
#------------------------------------------------------------

CREATE TABLE t_animals(
        idAnimals      int (11) Auto_increment  NOT NULL ,
        aniSpecies     Varchar (100) ,
        aniName        Varchar (100) ,
        aniAge         Int ,
        aniGender      Bool ,
        aniAlive       Bool ,
        aniAvatar      Varchar (255) ,
        aniDateOfBirth Date ,
        aniFood        Int ,
        aniComment     Varchar (500) ,
        idUser         Int ,
        PRIMARY KEY (idAnimals )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: t_visit
#------------------------------------------------------------

CREATE TABLE t_visit(
        idVisit        int (11) Auto_increment  NOT NULL ,
        visTitle       Varchar (100) ,
        visDate        Date ,
        visDoctorName  Varchar (50) ,
        visPlace       Varchar (100) ,
        visDescription Varchar (25) ,
        idAnimals      Int ,
        PRIMARY KEY (idVisit )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: t_treatment
#------------------------------------------------------------

CREATE TABLE t_treatment(
        idTreatment        int (11) Auto_increment  NOT NULL ,
        treNameMedicament  Varchar (100) ,
        treDose            Int ,
        treMedicamentStart Date ,
        treMedicamentEnd   Date ,
        treComment         Varchar (300) ,
        idAnimals          Int ,
        PRIMARY KEY (idTreatment )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: t_vaccine
#------------------------------------------------------------

CREATE TABLE t_vaccine(
        id_vaccine int (11) Auto_increment  NOT NULL ,
        vacName    Varchar (100) ,
        vacDate    Date ,
        vacComment Varchar (300) ,
        idAnimals  Int ,
        PRIMARY KEY (id_vaccine )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: t_weight
#------------------------------------------------------------

CREATE TABLE t_weight(
        idWeight   int (11) Auto_increment  NOT NULL ,
        weiCurrent Int ,
        weiDate    Date ,
        idAnimals  Int ,
        PRIMARY KEY (idWeight )
)ENGINE=InnoDB;

ALTER TABLE t_animals ADD CONSTRAINT FK_t_animals_idUser FOREIGN KEY (idUser) REFERENCES t_user(idUser);
ALTER TABLE t_visit ADD CONSTRAINT FK_t_visit_idAnimals FOREIGN KEY (idAnimals) REFERENCES t_animals(idAnimals);
ALTER TABLE t_treatment ADD CONSTRAINT FK_t_treatment_idAnimals FOREIGN KEY (idAnimals) REFERENCES t_animals(idAnimals);
ALTER TABLE t_vaccine ADD CONSTRAINT FK_t_vaccine_idAnimals FOREIGN KEY (idAnimals) REFERENCES t_animals(idAnimals);
ALTER TABLE t_weight ADD CONSTRAINT FK_t_weight_idAnimals FOREIGN KEY (idAnimals) REFERENCES t_animals(idAnimals);
