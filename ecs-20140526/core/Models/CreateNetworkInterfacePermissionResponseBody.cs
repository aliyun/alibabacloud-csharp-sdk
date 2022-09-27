// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateNetworkInterfacePermissionResponseBody : TeaModel {
        [NameInMap("NetworkInterfacePermission")]
        [Validation(Required=false)]
        public CreateNetworkInterfacePermissionResponseBodyNetworkInterfacePermission NetworkInterfacePermission { get; set; }
        public class CreateNetworkInterfacePermissionResponseBodyNetworkInterfacePermission : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            [NameInMap("NetworkInterfacePermissionId")]
            [Validation(Required=false)]
            public string NetworkInterfacePermissionId { get; set; }

            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

            [NameInMap("PermissionState")]
            [Validation(Required=false)]
            public string PermissionState { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
