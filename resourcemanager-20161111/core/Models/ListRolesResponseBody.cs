// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20161111.Models
{
    public class ListRolesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Roles")]
        [Validation(Required=false)]
        public ListRolesResponseBodyRoles Roles { get; set; }
        public class ListRolesResponseBodyRoles : TeaModel {
            [NameInMap("Role")]
            [Validation(Required=false)]
            public List<ListRolesResponseBodyRolesRole> Role { get; set; }
            public class ListRolesResponseBodyRolesRole : TeaModel {
                public string Arn { get; set; }
                public string CreateDate { get; set; }
                public string Description { get; set; }
                public bool? IsServiceLinkedRole { get; set; }
                public ListRolesResponseBodyRolesRoleLatestDeletionTask LatestDeletionTask { get; set; }
                public class ListRolesResponseBodyRolesRoleLatestDeletionTask : TeaModel {
                    [NameInMap("CreateDate")]
                    [Validation(Required=false)]
                    public string CreateDate { get; set; }

                    [NameInMap("DeletionTaskId")]
                    [Validation(Required=false)]
                    public string DeletionTaskId { get; set; }

                }
                public long? MaxSessionDuration { get; set; }
                public string RoleId { get; set; }
                public string RoleName { get; set; }
                public string RolePrincipalName { get; set; }
                public string UpdateDate { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
