
﻿using Kili.Models.General;
using Kili.Models.GestionAdhesion;
﻿using Kili.Models.Dons;
using Kili.Models.Services;
using Microsoft.EntityFrameworkCore;

namespace Kili.Models
{
    public class BddContext : DbContext
    {
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Association> Associations { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Abonnement> Abonnements { get; set; }
        public DbSet<Adhesion> Adhesions { get; set; }
        public DbSet<Adherent> Adherents { get; set; }
        public DbSet<Cotisation> Cotisations { get; set; }
        public DbSet<ServiceAdhesion> ServicesAdhesion { get; set; }
        public DbSet<ServiceDon> ServicesDon { get; set; }
        public DbSet<ServiceBoutique> ServicesBoutique { get; set; }
        public DbSet<Don> Dons { get; set; }
        public DbSet<Donateur> Donateurs { get; set; }
        public DbSet<Collecte> Collectes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<PanierService> PaniersServices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=rrrrr;database=Kili");
        }

        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            UserAccount_Services userAccountServices = new UserAccount_Services();
            Association_Services associationServices = new Association_Services();
            Abonnement_Services abonnement_Services = new Abonnement_Services();
            DonServices donServices = new DonServices();

            userAccountServices.CreerAdmin("M.","Admin", "Admin", "Kili@mail.com");
            userAccountServices.CreerUserAccount("Fara", "Raza", "P@ssFara1", "Fara@gmail.com", TypeRole.Utilisateur);
            userAccountServices.CreerUserAccount("Romy","Kombet", "P@ssRomy1", "Romy@gmail.com", TypeRole.Utilisateur);
            userAccountServices.CreerUserAccount("Othman","Krid", "P@ssOthman1", "Othman@gmail.com", TypeRole.Utilisateur);

            //donServices.CreerDon(1000, TypeRecurrence.Unique, 1);
            //donServices.CreerDon(2000, TypeRecurrence.Unique, 1);
            //donServices.CreerDon(200, TypeRecurrence.Mensuel, 2);
            donServices.CreerCollecte("Collecte pour moi", 300000, "Une collecte intéressée");
            donServices.CreerCollecte("Collecte pour les millionnaires en détresse", 6000, "Une collecte généreuse");

            userAccountServices.DésactiverUserAccount(1);

            associationServices.CreerAssociation("Première Asso", new Adresse() { Numero = 1, Voie = "rue du sport", CodePostal = 34000, Ville = "Montpellier" }, ThemeAssociation.Sport, userAccountServices.ObtenirUserAccount(1) );
            associationServices.CreerAssociation("Deuxième Asso", new Adresse() { Numero = 20, Voie = "rue de la mer", CodePostal = 13000, Ville = "Marseille" }, ThemeAssociation.Arts_et_culture, userAccountServices.ObtenirUserAccount(2));
            associationServices.CreerAssociation("Troisième Asso", new Adresse() { Numero = 30, Voie = "champs elysés", CodePostal = 75000, Ville = "Paris" }, ThemeAssociation.Environnement, userAccountServices.ObtenirUserAccount(3));
            associationServices.CreerAssociation("4eme Asso", new Adresse() { Numero = 1, Voie = "rue du sport", CodePostal = 34000, Ville = "Montpellier" }, ThemeAssociation.Environnement, userAccountServices.ObtenirUserAccount(4));

            //abonnement_Services.AjouterServiceDansOffre(19.99, 1, TypeService.Adhesion);
            abonnement_Services.AjouterServiceDansOffre(149.99, 12, TypeService.Adhesion);
            //abonnement_Services.AjouterServiceDansOffre(19.99, 1, TypeService.Don);
            abonnement_Services.AjouterServiceDansOffre(149.99, 12, TypeService.Don);
            //abonnement_Services.AjouterServiceDansOffre(19.99, 1, TypeService.Boutique);
            abonnement_Services.AjouterServiceDansOffre(149.99, 12, TypeService.Boutique);

            abonnement_Services.AjouterService(1, abonnement_Services.ObtenirServiceDansOffre(1));
            abonnement_Services.AjouterService(1, abonnement_Services.ObtenirServiceDansOffre(2));
            abonnement_Services.AjouterService(1, abonnement_Services.ObtenirServiceDansOffre(3));
            abonnement_Services.AjouterService(2, abonnement_Services.ObtenirServiceDansOffre(1));
            abonnement_Services.AjouterService(2, abonnement_Services.ObtenirServiceDansOffre(2));
            abonnement_Services.AjouterService(3, abonnement_Services.ObtenirServiceDansOffre(2));
            abonnement_Services.AjouterService(3, abonnement_Services.ObtenirServiceDansOffre(3));

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<UserAccount>()
            //  .HasIndex(p => p.PersonneID)
            //.IsUnique();

            /*modelBuilder.Entity<Association>()
                .HasIndex(p => p.UserAccountId)
                .IsUnique();*/

            /*modelBuilder.Entity<Abonnement>()
                            .HasIndex(p => p.AssociationId)
                            .IsUnique();*/

            modelBuilder.Entity<UserAccount>()
                .HasIndex(p => p.DonateurId)
                .IsUnique();

            modelBuilder.Entity<Don>()
                .HasIndex(p => p.PaiementId)
                .IsUnique();
        }

        public void DeleteCreateDatabase()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

    }

}

