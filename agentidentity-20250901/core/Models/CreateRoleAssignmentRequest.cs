// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateRoleAssignmentRequest : TeaModel {
        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public string PrincipalName { get; set; }

        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
