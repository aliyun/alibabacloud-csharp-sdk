// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeNetworkInterfacePermissionsResponseBody : TeaModel {
        /// <summary>
        /// Details about the permissions on ENIs.
        /// </summary>
        [NameInMap("NetworkInterfacePermissions")]
        [Validation(Required=false)]
        public DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissions NetworkInterfacePermissions { get; set; }
        public class DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissions : TeaModel {
            [NameInMap("NetworkInterfacePermission")]
            [Validation(Required=false)]
            public List<DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissionsNetworkInterfacePermission> NetworkInterfacePermission { get; set; }
            public class DescribeNetworkInterfacePermissionsResponseBodyNetworkInterfacePermissionsNetworkInterfacePermission : TeaModel {
                /// <summary>
                /// The ID of the Alibaba Cloud partner (a certified ISV) or individual user.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// The ID of the ENI.
                /// </summary>
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

                /// <summary>
                /// The ID of the permission on the ENI.
                /// </summary>
                [NameInMap("NetworkInterfacePermissionId")]
                [Validation(Required=false)]
                public string NetworkInterfacePermissionId { get; set; }

                /// <summary>
                /// The permission on the ENI.
                /// </summary>
                [NameInMap("Permission")]
                [Validation(Required=false)]
                public string Permission { get; set; }

                /// <summary>
                /// The status of the permission on the ENI. Valid values:
                /// 
                /// *   Pending: The permission is being granted.
                /// *   Granted: The permission has been granted.
                /// *   Revoking: The permission is being revoked.
                /// *   Revoked: The permission has been revoked.
                /// </summary>
                [NameInMap("PermissionState")]
                [Validation(Required=false)]
                public string PermissionState { get; set; }

                /// <summary>
                /// The name of the Alibaba Cloud service.
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

        }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
