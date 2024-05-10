// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVirtualBorderRoutersRequest : TeaModel {
        /// <summary>
        /// The information about the filter.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeVirtualBorderRoutersRequestFilter> Filter { get; set; }
        public class DescribeVirtualBorderRoutersRequestFilter : TeaModel {
            /// <summary>
            /// The filter conditions. You can specify up to five filter conditions. Valid values:
            /// 
            /// *   **PhysicalConnectionId**: Filter by Express Connect circuit ID.
            /// *   **VbrId**: Filter by VBR ID.
            /// *   **Status**: Filter by VBR status.
            /// *   **Name**: Filter by VBR name.
            /// *   **AccessPointId**: Filter by access point ID.
            /// *   **eccId:** Filter by Express Cloud Connect (ECC) instance ID.
            /// *   **type**: Filter by Express Connect circuit type.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The filter values for keys. You can specify multiple filter values for one key. The logical operator between filter values is OR. If one filter value is matched, the filter condition is matched.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// Specifies whether cross-account VBRs are included.
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("IncludeCrossAccountVbr")]
        [Validation(Required=false)]
        public bool? IncludeCrossAccountVbr { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: **1 to 50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the region in which the VBR is deployed. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to obtain the region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// 
        /// For more information about resource groups, see [What is a resource group?](https://help.aliyun.com/document_detail/94475.html)
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeVirtualBorderRoutersRequestTags> Tags { get; set; }
        public class DescribeVirtualBorderRoutersRequestTags : TeaModel {
            /// <summary>
            /// The tag key. You can specify at most 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// The key cannot exceed 128 characters in length, and cannot start with `aliyun` or `acs:`. The key cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. You can specify at most 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag value cannot exceed 128 characters in length, and cannot start with `aliyun` or `acs:`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
