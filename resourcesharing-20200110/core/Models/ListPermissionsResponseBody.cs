// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class ListPermissionsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<ListPermissionsResponseBodyPermissions> Permissions { get; set; }
        public class ListPermissionsResponseBodyPermissions : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DefaultPermission")]
            [Validation(Required=false)]
            public bool? DefaultPermission { get; set; }

            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public bool? DefaultVersion { get; set; }

            [NameInMap("PermissionName")]
            [Validation(Required=false)]
            public string PermissionName { get; set; }

            [NameInMap("PermissionVersion")]
            [Validation(Required=false)]
            public string PermissionVersion { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
