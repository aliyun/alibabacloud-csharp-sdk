// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20161111.Models
{
    public class ListRolesForServiceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Roles")]
        [Validation(Required=false)]
        public ListRolesForServiceResponseBodyRoles Roles { get; set; }
        public class ListRolesForServiceResponseBodyRoles : TeaModel {
            [NameInMap("Role")]
            [Validation(Required=false)]
            public List<ListRolesForServiceResponseBodyRolesRole> Role { get; set; }
            public class ListRolesForServiceResponseBodyRolesRole : TeaModel {
                public string Arn { get; set; }
                public string CreateDate { get; set; }
                public string Description { get; set; }
                public bool? IsServiceLinkedRole { get; set; }
                public ListRolesForServiceResponseBodyRolesRoleLatestDeletionTask LatestDeletionTask { get; set; }
                public class ListRolesForServiceResponseBodyRolesRoleLatestDeletionTask : TeaModel {
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

    }

}
