// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenBandwidthPackagesRequest : TeaModel {
        /// <summary>
        /// The filter configurations.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeCenBandwidthPackagesRequestFilter> Filter { get; set; }
        public class DescribeCenBandwidthPackagesRequestFilter : TeaModel {
            /// <summary>
            /// The filter conditions. You can use filter conditions to filter the bandwidth plans that you want to query. The following filter conditions are supported:
            /// 
            /// *   **CenId**: CEN instance ID
            /// 
            /// *   **Status**: bandwidth plan status. Valid values:
            /// 
            ///     *   **Idle**: not associated with a CEN instance.
            ///     *   **InUse**: associated with a CEN instance.
            /// 
            /// *   **CenBandwidthPackageId**: bandwidth plan ID
            /// 
            /// *   **Name**: bandwidth plan name You can specify one or more filter conditions. The maximum value of **N** is **5**.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// Specify a filter value based on the **Key** parameter. You can specify multiple filter values for each **Key**. The logical operator between filter values is **OR**. If one filter value is matched, the filter condition is matched.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// Specifies whether to include renewal data. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("IncludeReservationData")]
        [Validation(Required=false)]
        public bool? IncludeReservationData { get; set; }

        /// <summary>
        /// The logical operator between the filter conditions. Valid values:
        /// 
        /// *   **false** (default): **AND** Bandwidth plans that meet all filter conditions are returned.
        /// *   **true**: **OR** Bandwidth plans that meet one of the filter conditions are returned.
        /// </summary>
        [NameInMap("IsOrKey")]
        [Validation(Required=false)]
        public bool? IsOrKey { get; set; }

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
        /// The number of entries to return on each page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group.
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
        /// The information about the tags.
        /// 
        /// You can specify at most 20 tags in each call.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeCenBandwidthPackagesRequestTag> Tag { get; set; }
        public class DescribeCenBandwidthPackagesRequestTag : TeaModel {
            /// <summary>
            /// The tag keys.
            /// 
            /// The tag keys cannot be an empty string. The tag keys can be up to 64 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// 
            /// You can specify at most 20 tag keys.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag values.
            /// 
            /// The tag values can be 0 to 128 characters in length, and cannot start with `aliyun` or `acs:`. It cannot contain `http://` or `https://`.
            /// 
            /// The tag value of each tag key must be unique. You can specify at most 20 tag values in each call.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
