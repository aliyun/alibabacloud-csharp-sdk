// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateRoleAssignmentResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RoleAssignment")]
        [Validation(Required=false)]
        public CreateRoleAssignmentResponseBodyRoleAssignment RoleAssignment { get; set; }
        public class CreateRoleAssignmentResponseBodyRoleAssignment : TeaModel {
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

    }

}
