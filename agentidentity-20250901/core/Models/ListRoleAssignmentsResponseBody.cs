// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListRoleAssignmentsResponseBody : TeaModel {
        [NameInMap("Assignments")]
        [Validation(Required=false)]
        public List<ListRoleAssignmentsResponseBodyAssignments> Assignments { get; set; }
        public class ListRoleAssignmentsResponseBodyAssignments : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            [NameInMap("UserPoolId")]
            [Validation(Required=false)]
            public string UserPoolId { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
