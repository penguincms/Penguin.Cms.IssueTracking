using Penguin.Cms.Entities;
using Penguin.Persistence.Abstractions.Attributes.Control;
using Penguin.Persistence.Abstractions.Attributes.Relations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Cms.IssueTracking
{
    public class TicketStatus : Entity
    {
        public string Name { get => this.ExternalId; set { this.ExternalId = value; } }

        [HasMany]
        [EagerLoad(1)]
        public virtual List<TicketStatus> Next { get; set; }

        public override string ToString()
        {
            return ExternalId;
        }
    }
}
