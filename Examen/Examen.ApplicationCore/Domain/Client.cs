using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examen.ApplicationCore.Domain
{
    public class Client
    {
        [Key ]
        public int Identifiant { get; set; }

        [Required (ErrorMessage ="Login required !")]
        public string login { get; set }

        [Required(ErrorMessage= " Pwd required !")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string photo { get; set; }

        public virtual Conseiller conseiller { get; set; }
        [ForeignKey("Conseiller")]
        public int ConseillerFk { get; set; }

        public virtual ICollection <Reservation>reservations { get; set; }
      
    }
}