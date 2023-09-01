// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListPermissionsResponseBody : TeaModel {
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<ListPermissionsResponseBodyPermissions> Permissions { get; set; }
        public class ListPermissionsResponseBodyPermissions : TeaModel {
            [NameInMap("PermissionCode")]
            [Validation(Required=false)]
            public string PermissionCode { get; set; }

            [NameInMap("PermissionRules")]
            [Validation(Required=false)]
            public List<ListPermissionsResponseBodyPermissionsPermissionRules> PermissionRules { get; set; }
            public class ListPermissionsResponseBodyPermissionsPermissionRules : TeaModel {
                [NameInMap("Accessibility")]
                [Validation(Required=false)]
                public string Accessibility { get; set; }

                [NameInMap("EntityAccessType")]
                [Validation(Required=false)]
                public string EntityAccessType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
