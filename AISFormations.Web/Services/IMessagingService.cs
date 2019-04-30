using System.Threading.Tasks;

namespace AISFormations.Web.Services
{
    public interface IMessagingService
    {
        Task PushMessage(FormationMessage message);
    }

    public class FormationMessage
    {
        public int IdFormation { get; set; }
    }
}