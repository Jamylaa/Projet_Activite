using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examen.ApplicationCore.Domain
{

    public class Etudiant: Client
    {
        public string CarteEtudiant { get; set }
    }
}