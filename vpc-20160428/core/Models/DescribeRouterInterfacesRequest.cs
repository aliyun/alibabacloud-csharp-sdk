// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouterInterfacesRequest : TeaModel {
        /// <summary>
        /// The filter information.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeRouterInterfacesRequestFilter> Filter { get; set; }
        public class DescribeRouterInterfacesRequestFilter : TeaModel {
            /// <summary>
            /// The filter conditions. You can specify up to five filter conditions. The following filter conditions are supported:
            /// 
            /// *   **RouterInterfaceId**: the ID of the router interface.
            /// *   **RouterId**: the ID of the router.
            /// *   **RouterType**: the router type. Valid values: **VRouter** and **VBR**.
            /// *   **RouterInterfaceOwnerId**: the ID of the Alibaba Cloud account to which the router interface belongs.
            /// *   **OppositeInterfaceId**: the ID of the peer router interface.
            /// *   **OppositeRouterType**: the type of the peer router interface. Valid values: **VRouter** and **VBR**.
            /// *   **OppositeRouterId**: the ID of the peer router.
            /// *   **OppositeInterfaceOwnerId**: the ID of the Alibaba Cloud account to which the peer router interface belongs.
            /// *   **Status**: the status of the router interface.
            /// *   **Name**: the name of the router interface.
            /// 
            /// >  The logical operator among multiple values in a filter condition is OR. In this case, the filter condition is met if one of the values is matched. The logical operator among filter conditions is AND. Only routers that meet all the filter conditions are queried.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// Specifies the value in the filter condition based on the key. You can specify multiple filter values for one key. The logical operator among filter values is OR. If one filter value is matched, the filter condition is matched.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// Specifies whether renewal data is included. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

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
        /// The number of entries per page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the router interface.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Resource Group ID.
        /// 
        /// For more information about resource groups, please refer to [What is a Resource Group?](~~94475~~)
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
        /// The tags of the resource.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeRouterInterfacesRequestTags> Tags { get; set; }
        public class DescribeRouterInterfacesRequestTags : TeaModel {
            /// <summary>
            /// The key of the resource tag. At least one tag key must be entered, and a maximum of 20 tag keys are supported. If this value needs to be passed in, it cannot be an empty string.
            /// 
            /// A tag key can support up to 128 characters, cannot start with \"aliyun\" or \"acs:\", and cannot contain \"http://\" or \"https://\".
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the resource tag. A maximum of 20 tag values can be entered. If this value needs to be passed in, an empty string can be entered.
            /// 
            /// A maximum of 128 characters are supported, it cannot start with \"aliyun\" or \"acs:\", and it cannot contain \"http://\" or \"https://\".
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
