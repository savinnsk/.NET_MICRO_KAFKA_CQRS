using CQRS.Core.Command;

namespace Post.Cmd.Api.Commands 
{
    public class EditPostCommentCommand : BaseCommand
    {
        public required Guid CommentId { get; set; }
        public required string Comment { get; set; }
        public required string Username { get; set; }
        public required string Message { get; set; }
    }

}
