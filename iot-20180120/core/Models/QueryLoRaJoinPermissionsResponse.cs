// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryLoRaJoinPermissionsResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("JoinPermissions")]
        [Validation(Required=true)]
        public QueryLoRaJoinPermissionsResponseJoinPermissions JoinPermissions { get; set; }
        public class QueryLoRaJoinPermissionsResponseJoinPermissions : TeaModel {
            [NameInMap("JoinPermission")]
            [Validation(Required=true)]
            public List<QueryLoRaJoinPermissionsResponseJoinPermissionsJoinPermission> JoinPermission { get; set; }
            public class QueryLoRaJoinPermissionsResponseJoinPermissionsJoinPermission : TeaModel {
                [NameInMap("ClassMode")]
                [Validation(Required=true)]
                public string ClassMode { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=true)]
                public bool? Enabled { get; set; }

                [NameInMap("JoinPermissionId")]
                [Validation(Required=true)]
                public string JoinPermissionId { get; set; }

                [NameInMap("JoinPermissionName")]
                [Validation(Required=true)]
                public string JoinPermissionName { get; set; }

                [NameInMap("JoinPermissionType")]
                [Validation(Required=true)]
                public string JoinPermissionType { get; set; }

                [NameInMap("OwnerAliyunPk")]
                [Validation(Required=true)]
                public string OwnerAliyunPk { get; set; }

            }

        }

    }

}
