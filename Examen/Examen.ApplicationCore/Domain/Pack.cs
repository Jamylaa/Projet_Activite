using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examen.ApplicationCore.Domain
{
    public class Pack
    {
        public int PackId { get; set; }
        public int nbPlaces { get; set }
        public DateTime dateDebut { get; set; }
        public int duree { get; set; }
        
        public string intitulePack { get; set; }

        public ICollection<Activite> activites { get; set; }
        public virtual IList<Reservation> Reservations { get; set; }

    }
}