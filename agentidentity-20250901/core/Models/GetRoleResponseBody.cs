// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetRoleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public GetRoleResponseBodyRole Role { get; set; }
        public class GetRoleResponseBodyRole : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
