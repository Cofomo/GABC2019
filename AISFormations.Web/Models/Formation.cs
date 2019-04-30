using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AISFormations.Web.Models
{
    public class Formation
    {
        public int Id { get; set; }

        public string Titre { get; set; }

        public string Presentateur { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string PublicCible { get; set; }

        public DateTime DateHeureDebut { get; set; }

        public double DureeEnHeures { get; set; }

        public int NombrePlacesDisponibles { get; set; }

        public bool EstActive { get; set; }
        
        public List<Participant> Inscriptions { get; set; }

        public Queue<Participant> ListeAttente { get; set; }
    }
}
