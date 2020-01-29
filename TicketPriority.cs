using Penguin.Cms.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Cms.IssueTracking
{
    public class TicketPriority : Entity
    {
        public string Name { get => this.ExternalId; set { this.ExternalId = value; } }
        public int Priority { get; set; }

        public override string ToString()
        {
            return ExternalId;
        }
    }
}
