// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribePhysicalConnectionsRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. ClientToken can contain only ASCII characters.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribePhysicalConnectionsRequestFilter> Filter { get; set; }
        public class DescribePhysicalConnectionsRequestFilter : TeaModel {
            /// <summary>
            /// The key of the filter. Valid values:
            /// 
            /// *   **PhysicalConnectionId**: the ID of the Express Connect circuit.
            /// 
            /// *   **AccessPointId**: the ID of the access point.
            /// 
            /// *   **Type**: the type of the Express Connect circuit. You can set Type only to **VPC**.
            /// 
            /// *   **LineOperator**: the connectivity provider of the Express Connect circuit. Valid values:
            /// 
            ///     *   **CT**: China Telecom.
            ///     *   **CU**: China Unicom.
            ///     *   **CM**: China Mobile.
            ///     *   **CO**: other connectivity providers in the Chinese mainland.
            ///     *   **Equinix**: Equinix.
            ///     *   **Other**: other connectivity providers outside the Chinese mainland.
            /// 
            /// *   **Spec**: the specification of the Express Connect circuit. Valid values:
            /// 
            ///     *   **1G and below**
            /// 
            ///     *   **10G**
            /// 
            ///     *   **40G**
            /// 
            ///     *   **100G**
            /// 
            /// > By default, you cannot set Spec to **40G** or **100G**. To query 40 Gbit/s or 100 Gbit/s Express Connect circuits, you must first submit an application to acquire the permissions.
            /// 
            /// *   **Status**: the status of the Express Connect circuit. Valid values:
            /// 
            ///     *   **Initial**: The application is under review.
            ///     *   **Approved**: The application is approved.
            ///     *   **Allocating**: The system is allocating resources.
            ///     *   **Allocated**: The Express Connect circuit is under construction.
            ///     *   **Confirmed**: The Express Connect circuit is pending user confirmation.
            ///     *   **Enabled**: The Express Connect circuit is enabled.
            ///     *   **Rejected**: The application is rejected.
            ///     *   **Canceled**: The application is canceled.
            ///     *   **Allocation Failed**: The system failed to allocate resources.
            ///     *   **Terminating**: The Express Connect circuit is being disabled.
            ///     *   **Terminated**: The Express Connect circuit is disabled.
            /// 
            /// *   **Name**: the name of the Express Connect circuit.
            /// 
            /// You can specify at most five filter conditions in each call. The logical relation among the filter conditions is **AND**. Therefore, an Express Connect circuit is returned only when all specified filter conditions are matched.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// Specifies whether to return the data about pending orders. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **10**. Valid values: **1** to **50**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the Express Connect circuit.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribePhysicalConnectionsRequestTags> Tags { get; set; }
        public class DescribePhysicalConnectionsRequestTags : TeaModel {
            /// <summary>
            /// The key of the tag that is added to the resource. You can specify at most 20 tag keys. The tag value cannot be an empty string.
            /// 
            /// The key cannot exceed 64 characters in length, and can contain digits, periods (.), underscores (\_), and hyphens (-). The key must start with a letter but cannot start with `aliyun` or `acs:`. The key cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that is added to the resource. You can specify at most 20 tag values. The tag value can be an empty string.
            /// 
            /// The value cannot exceed 128 characters in length and can contain digits, periods (.), underscores (\_), and hyphens (-). The value must start with a letter but cannot start with `aliyun` or `acs:`. The value cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
