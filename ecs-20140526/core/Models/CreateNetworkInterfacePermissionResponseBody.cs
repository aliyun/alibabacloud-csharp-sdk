// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateNetworkInterfacePermissionResponseBody : TeaModel {
        /// <summary>
        /// The permission on the ENI.
        /// </summary>
        [NameInMap("NetworkInterfacePermission")]
        [Validation(Required=false)]
        public CreateNetworkInterfacePermissionResponseBodyNetworkInterfacePermission NetworkInterfacePermission { get; set; }
        public class CreateNetworkInterfacePermissionResponseBodyNetworkInterfacePermission : TeaModel {
            /// <summary>
            /// The ID of the permission on the ENI.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud partner (a certified ISV).
            /// </summary>
            [NameInMap("NetworkInterfaceId")]
            [Validation(Required=false)]
            public string NetworkInterfaceId { get; set; }

            /// <summary>
            /// The name of the Alibaba Cloud service.
            /// </summary>
            [NameInMap("NetworkInterfacePermissionId")]
            [Validation(Required=false)]
            public string NetworkInterfacePermissionId { get; set; }

            /// <summary>
            /// The ID of the ENI.
            /// </summary>
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

            [NameInMap("PermissionState")]
            [Validation(Required=false)]
            public string PermissionState { get; set; }

            /// <summary>
            /// The state of the permission on the ENI. Valid values:
            /// 
            /// *   Pending: The permission is being granted.
            /// *   Granted: The permission is granted.
            /// *   Revoking: The permission is being revoked.
            /// *   Revoked: The permission is revoked.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        /// <summary>
        /// Details about permissions on ENIs.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
