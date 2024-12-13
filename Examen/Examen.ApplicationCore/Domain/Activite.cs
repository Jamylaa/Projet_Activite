using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examen.ApplicationCore.Domain {
    public enum TypeService {  Excursion, Muse }

    public class Activite
    {
       // [Key]
        public int ActiviteId { get; set; }
      //  public Zone Zone { get; set; }
        public string ville { get; set }
        public double prix { get; set; }
        public string pays { get; set; }
        public TypeService TypeService { get; set; }

        public ICollection<Pack> packs { get; set; }

        public override string ToString()
        {
            return
                "ActiviteId : " + ActiviteId
                + "ville : " + ville
                + "prix : " + prix
                + "pays : " + pays
                + "TypeService : " + TypeService;
        }
    }
}