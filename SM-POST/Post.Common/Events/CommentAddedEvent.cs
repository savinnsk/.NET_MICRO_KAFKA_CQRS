﻿using CQRS.Core.Events;

namespace Post.Common.Events
{
    public class CommentAddedEvent : BaseEvent
    {
        public required Guid CommentId { get; set; }
        public required string Comment { get; set; }
        public required string Username { get; set; }
        public required DateTime CommentDate { get; set; }

        public CommentAddedEvent() : base(nameof(PostLikedEvent))
        {
        }
    }

}
