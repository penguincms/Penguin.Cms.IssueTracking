using Penguin.Cms.Entities;
using Penguin.Cms.Files;
using Penguin.Persistence.Abstractions.Attributes.Control;
using Penguin.Persistence.Abstractions.Attributes.Rendering;
using System.Collections.Generic;

namespace Penguin.Cms.IssueTracking
{
    public class TicketBase : Entity
    {
        public string Summary { get; set; }

        [HtmlRender(HtmlRenderAttribute.RenderingType.textarea)]
        [DontAllow(DisplayContexts.List)]
        public string Description { get; set; }

        [EagerLoad(1)]
        public TicketPriority Priority { get; set; }

        [EagerLoad(1)]
        [DontAllow(DisplayContexts.List)]
        public List<DatabaseFile> Attachments { get; set; }

        public override string ToString()
        {
            return Summary;
        }
    }
}