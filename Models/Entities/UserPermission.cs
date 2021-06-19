using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MODELS.Entities
{
    public class UserPermission
    {
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public int WorkspaceId { get; set; }

        [ForeignKey("WorkspaceId")]
        public Workspace WorkSpace { get; set; }
        public PermissionLevel PermissionLevel { get; set; }

    }
}
