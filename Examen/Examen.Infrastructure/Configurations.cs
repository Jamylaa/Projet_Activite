namespace Examen.Infrastructure
{
    public class ExamenContext : DbContext {

        //DBSET

        public DbSet <Client> Clients{ get; set; }
        public DbSet<Conseiller> Conseiller { get; set; }
        public DbSet <Activite> Activites { get; set; }
        public DbSet <Etudiant> Etudiants { get; set; }
        public DbSet <Fonctionnaire> Fonctionnaire { get; set; }
        public Dbset <Reservation> Reservations { get; set; }
        public DbSet <Pack> Packs {  get; set; }

        //OnCOnfiguring
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source "
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        //ONModelCOnfiguring 
        //ConfigureCOnventions 

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder){
            base.ConfigureConventions(configurationBuilder);

    }
}