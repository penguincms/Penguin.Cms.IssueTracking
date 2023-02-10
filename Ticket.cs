using Penguin.Cms.Security;
using Penguin.Persistence.Abstractions.Attributes.Control;
using Penguin.Persistence.Abstractions.Attributes.Relations;
using System.Collections.Generic;

namespace Penguin.Cms.IssueTracking
{
    public class Ticket : TicketBase
    {
        public string ShortCode
        { get => ExternalId; set => ExternalId = value; }

        [HasMany]
        [EagerLoad(1)]
        public List<User> Reports { get; set; }

        [EagerLoad(1)]
        public User Assigned { get; set; }

        [EagerLoad(1)]
        public TicketStatus Status { get; set; }
    }
}