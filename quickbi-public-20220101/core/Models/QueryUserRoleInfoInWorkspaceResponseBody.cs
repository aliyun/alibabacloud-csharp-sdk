// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserRoleInfoInWorkspaceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryUserRoleInfoInWorkspaceResponseBodyResult Result { get; set; }
        public class QueryUserRoleInfoInWorkspaceResponseBodyResult : TeaModel {
            [NameInMap("RoleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }
            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
