using Penguin.Cms.Entities;

namespace Penguin.Cms.IssueTracking
{
    public class TicketPriority : Entity
    {
        public string Name
        { get => ExternalId; set => ExternalId = value; }

        public int Priority { get; set; }

        public override string ToString()
        {
            return ExternalId;
        }
    }
}