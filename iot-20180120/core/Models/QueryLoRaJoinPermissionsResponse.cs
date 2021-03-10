// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryLoRaJoinPermissionsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("JoinPermissions")]
        [Validation(Required=true)]
        public QueryLoRaJoinPermissionsResponseJoinPermissions JoinPermissions { get; set; }
        public class QueryLoRaJoinPermissionsResponseJoinPermissions : TeaModel {
            [NameInMap("JoinPermission")]
            [Validation(Required=true)]
            public List<QueryLoRaJoinPermissionsResponseJoinPermissionsJoinPermission> JoinPermission { get; set; }
            public class QueryLoRaJoinPermissionsResponseJoinPermissionsJoinPermission : TeaModel {
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
