using ChatSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ChatSystem.Context
{
    public class LabChatSystemContext:DbContext
    {
        public LabChatSystemContext(DbContextOptions<LabChatSystemContext> options) : base(options) { }
        public virtual DbSet<Message> Messages { get; set; }
    }
}
