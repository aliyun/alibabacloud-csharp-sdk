// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryLoRaJoinPermissionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("JoinPermissions")]
        [Validation(Required=false)]
        public QueryLoRaJoinPermissionsResponseBodyJoinPermissions JoinPermissions { get; set; }
        public class QueryLoRaJoinPermissionsResponseBodyJoinPermissions : TeaModel {
            [NameInMap("JoinPermission")]
            [Validation(Required=false)]
            public List<QueryLoRaJoinPermissionsResponseBodyJoinPermissionsJoinPermission> JoinPermission { get; set; }
            public class QueryLoRaJoinPermissionsResponseBodyJoinPermissionsJoinPermission : TeaModel {
                public string JoinPermissionId { get; set; }
                public string JoinPermissionName { get; set; }
                public string JoinPermissionType { get; set; }
                public string OwnerAliyunPk { get; set; }
                public bool? Enabled { get; set; }
                public string ClassMode { get; set; }
            }
        };

    }

}
