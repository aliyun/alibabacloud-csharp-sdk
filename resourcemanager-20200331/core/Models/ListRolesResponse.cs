// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListRolesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("Roles")]
        [Validation(Required=true)]
        public ListRolesResponseRoles Roles { get; set; }
        public class ListRolesResponseRoles : TeaModel {
            [NameInMap("Role")]
            [Validation(Required=true)]
            public List<ListRolesResponseRolesRole> Role { get; set; }
            public class ListRolesResponseRolesRole : TeaModel {
                public string Arn { get; set; }
                public string RolePrincipalName { get; set; }
                public string CreateDate { get; set; }
                public string Description { get; set; }
                public string UpdateDate { get; set; }
                public string RoleId { get; set; }
                public string RoleName { get; set; }
                public bool? IsServiceLinkedRole { get; set; }
                public long MaxSessionDuration { get; set; }
                public ListRolesResponseRolesRoleLatestDeletionTask LatestDeletionTask { get; set; }
                public class ListRolesResponseRolesRoleLatestDeletionTask : TeaModel {
                    [NameInMap("CreateDate")]
                    [Validation(Required=true)]
                    public string CreateDate { get; set; }

                    [NameInMap("DeletionTaskId")]
                    [Validation(Required=true)]
                    public string DeletionTaskId { get; set; }

                }
            }
        };

    }

}
