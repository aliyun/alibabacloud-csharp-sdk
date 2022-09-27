// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfacePermissionsResponseBody : TeaModel {
        [NameInMap("NetworkInterfacePermissions")]
        [Validation(Required=false)]
        public DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissions NetworkInterfacePermissions { get; set; }
        public class DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissions : TeaModel {
            [NameInMap("NetworkInterfacePermission")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissionsNetworkInterfacePermission> NetworkInterfacePermission { get; set; }
            public class DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissionsNetworkInterfacePermission : TeaModel {
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

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
