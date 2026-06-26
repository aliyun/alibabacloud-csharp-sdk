// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateRoleRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
