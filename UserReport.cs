using Penguin.Cms.Security;
using Penguin.Persistence.Abstractions.Attributes.Control;
using Penguin.Persistence.Abstractions.Attributes.Relations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Penguin.Cms.IssueTracking
{
    public class UserReport : TicketBase
    {
        [HasRequired]
        [EagerLoad]
        public virtual User User { get; set; }

        [HasRequired]
        [EagerLoad]
        public virtual Ticket Ticket { get; set; }
    }
}
