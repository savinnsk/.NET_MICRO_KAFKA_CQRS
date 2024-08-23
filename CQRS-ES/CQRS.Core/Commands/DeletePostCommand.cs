namespace CQRS.Core.Commands
{
    public class DeletePostCommand : BaseCommand
    {
        public required string Username { get; set; }
        public required Guid CommentId { get; set; }

    }
}