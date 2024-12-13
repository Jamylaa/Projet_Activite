using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examen.ApplicationCore.Domain
{
    public class Reservation
    {
        [DataType (DataType.DateTime)]
        public DateTime dateReservation { get; set; }
        public int nbPersonnes { get; set }

        private virtual Client Client {  get; set; }
        [ForeignKey("Client")]
        public int ClientFk { get; set; }

        public virtual Pack Pack { get; set; }
        [ForeignKey("Pack")]
        public int PackFk { get; set; }


    }
}