using Penguin.Cms.Entities;
using Penguin.Persistence.Abstractions.Attributes.Control;
using Penguin.Persistence.Abstractions.Attributes.Relations;
using System.Collections.Generic;

namespace Penguin.Cms.IssueTracking
{
    public class TicketStatus : Entity
    {
        public string Name
        { get => ExternalId; set => ExternalId = value; }

        [HasMany]
        [EagerLoad(1)]
        public virtual List<TicketStatus> Next { get; set; }

        public override string ToString()
        {
            return ExternalId;
        }
    }
}