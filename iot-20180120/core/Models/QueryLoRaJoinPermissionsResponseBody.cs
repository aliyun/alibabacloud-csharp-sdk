// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryLoRaJoinPermissionsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("JoinPermissions")]
        [Validation(Required=false)]
        public QueryLoRaJoinPermissionsResponseBodyJoinPermissions JoinPermissions { get; set; }
        public class QueryLoRaJoinPermissionsResponseBodyJoinPermissions : TeaModel {
            [NameInMap("JoinPermission")]
            [Validation(Required=false)]
            public List<QueryLoRaJoinPermissionsResponseBodyJoinPermissionsJoinPermission> JoinPermission { get; set; }
            public class QueryLoRaJoinPermissionsResponseBodyJoinPermissionsJoinPermission : TeaModel {
                [NameInMap("ClassMode")]
                [Validation(Required=false)]
                public string ClassMode { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("JoinPermissionId")]
                [Validation(Required=false)]
                public string JoinPermissionId { get; set; }

                [NameInMap("JoinPermissionName")]
                [Validation(Required=false)]
                public string JoinPermissionName { get; set; }

                [NameInMap("JoinPermissionType")]
                [Validation(Required=false)]
                public string JoinPermissionType { get; set; }

                [NameInMap("OwnerAliyunPk")]
                [Validation(Required=false)]
                public string OwnerAliyunPk { get; set; }

            }

        }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
