// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
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
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("IsServiceLinkedRole")]
                [Validation(Required=false)]
                public bool? IsServiceLinkedRole { get; set; }

                [NameInMap("LatestDeletionTask")]
                [Validation(Required=false)]
                public ListRolesResponseBodyRolesRoleLatestDeletionTask LatestDeletionTask { get; set; }
                public class ListRolesResponseBodyRolesRoleLatestDeletionTask : TeaModel {
                    [NameInMap("CreateDate")]
                    [Validation(Required=false)]
                    public string CreateDate { get; set; }

                    [NameInMap("DeletionTaskId")]
                    [Validation(Required=false)]
                    public string DeletionTaskId { get; set; }

                }

                [NameInMap("MaxSessionDuration")]
                [Validation(Required=false)]
                public long? MaxSessionDuration { get; set; }

                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                [NameInMap("RolePrincipalName")]
                [Validation(Required=false)]
                public string RolePrincipalName { get; set; }

                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
