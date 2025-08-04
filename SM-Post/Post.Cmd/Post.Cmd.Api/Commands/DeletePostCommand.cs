using CQRS.Core.Commands;

namespace Post.Cmd.Api;

public class DeletePostCommand : BaseCommand
{
    public string Username { get; set; }
}
