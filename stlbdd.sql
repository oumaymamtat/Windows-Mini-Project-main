/*==============================================================*/
create database stl;
use stl;client
create table Client
(
   code                 int not null  comment '',
   adresse              varchar(254)  comment '',
   nom                  varchar(254)  comment '',
   prenom               varchar(254)  comment '',
   cin                  int  comment '',
   num_passport         int  comment '',
   pays                 varchar(254)  comment '',
   code_fiscale         int  comment '',
   raison_sociale       varchar(254)  comment '',
   primary key (code)
);


create table Compte
(
   id_compte            int not null  comment '',
   type                 varchar(254)  comment '',
   nom                  varchar(254)  comment '',
   prenom               varchar(254)  comment '',
   num_tel              int  comment '',
   adresse_email        varchar(254)  comment '',
   login                varchar(254)  comment '',
   password             varchar(254)  comment '',
   primary key (id_compte)
);


create table Contrat
(
   numcontrat           int not null  comment '',
   code                 int not null  comment '',
   num_chassis          int not null  comment '',
   tarif                int  comment '',
   montant              int  comment '',
   datedeb_loc          datetime  comment '',
   val_compteur         int  comment '',
   date_retour          datetime  comment '',
   val_compteur_retour  int  comment '',
   chauffeur            int  comment '',
   primary key (numcontrat),
   key AK_Identifier_1 (numcontrat)
);


create table Facturation
(
   num_fact             int not null  comment '',
   numcontrat           int not null  comment '',
   categorie_fact       int  comment '',
   nbkm_parc            int  comment '',
   nbh_tr               int  comment '',
   tarif_km_parc        int  comment '',
   tarif_h_tr           int  comment '',
   tarif_journalier_loc int  comment '',
   tarif_chauffeur      int  comment '',
   montant_glob         int  comment '',
   montant_horstaxe     int  comment '',
   montant_tva          int  comment '',
   montant_net          int  comment '',
   date_fact            datetime  comment '',
   primary key (num_fact)
);


create table Tarification
(
   id_tarif             int not null  comment '',
   categorie_tarif      int  comment '',
   tarif_km_prc         int  comment '',
   tarif_loc_jr         int  comment '',
   tarif_h_tr           int  comment '',
   tarif_chauffeur      int  comment '',
   primary key (id_tarif)
);


create table Vahicule
(
   num_chassis          int not null  comment '',
   marque               varchar(254)  comment '',
   categorie            int  comment '',
   etat                 varchar(254)  comment '',
   nbkm                 int  comment '',
   nbh                  int  comment '',
   primary key (num_chassis)
);

alter table Contrat add constraint FK_CONTRAT_ASSOCIATI_CLIENT foreign key (code)
      references Client (code) on delete restrict on update restrict;

alter table Contrat add constraint FK_CONTRAT_ASSOCIATI_VAHICULE foreign key (num_chassis)
      references Vahicule (num_chassis) on delete restrict on update restrict;

alter table Facturation add constraint FK_FACTURAT_ASSOCIATI_CONTRAT foreign key (numcontrat)
      references Contrat (numcontrat) on delete restrict on update restrict;

