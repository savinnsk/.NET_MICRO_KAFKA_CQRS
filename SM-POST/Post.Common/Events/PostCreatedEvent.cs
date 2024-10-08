﻿using CQRS.Core.Events;

namespace Post.Common.Events
{
    public class PostCreatedEvent : BaseEvent
    {
        public string Author { get; set; }
        public string Message { get; set; }
        public DateTime DatePosted { get; set; }

        //nameof to pass the name of the event to base
        public PostCreatedEvent() : base(nameof(PostCreatedEvent))
        {
        }
    }
}
