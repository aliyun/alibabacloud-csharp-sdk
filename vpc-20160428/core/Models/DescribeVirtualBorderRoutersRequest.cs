// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVirtualBorderRoutersRequest : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeVirtualBorderRoutersRequestFilter> Filter { get; set; }
        public class DescribeVirtualBorderRoutersRequestFilter : TeaModel {
            /// <summary>
            /// The filter conditions. You can specify at most five filter conditions. The following filter conditions are supported:
            /// 
            /// *   **PhysicalConnectionId**: Filter by Express Connect circuit ID.
            /// *   **VbrId**: Filter by VBR ID.
            /// *   **Status**: Filter by VBR status.
            /// *   **Name**: Filter by VBR name.
            /// *   **AccessPointId**: Filter by access point ID.
            /// *   **eccId**: Filter by Express Cloud Connect (ECC) instance ID.
            /// *   **type**: Filter by Express Connect circuit type.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// Specifies whether cross-account VBRs are included.
        /// 
        /// *   **true**: yes
        /// *   **false**: no. This is the default value.
        /// </summary>
        [NameInMap("IncludeCrossAccountVbr")]
        [Validation(Required=false)]
        public bool? IncludeCrossAccountVbr { get; set; }

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
        /// The number of entries to return on each page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region where the VBRs are deployed. You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
