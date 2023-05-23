// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCensResponseBody : TeaModel {
        /// <summary>
        /// The value of the tag.
        /// </summary>
        [NameInMap("Cens")]
        [Validation(Required=false)]
        public DescribeCensResponseBodyCens Cens { get; set; }
        public class DescribeCensResponseBodyCens : TeaModel {
            [NameInMap("Cen")]
            [Validation(Required=false)]
            public List<DescribeCensResponseBodyCensCen> Cen { get; set; }
            public class DescribeCensResponseBodyCensCen : TeaModel {
                [NameInMap("CenBandwidthPackageIds")]
                [Validation(Required=false)]
                public DescribeCensResponseBodyCensCenCenBandwidthPackageIds CenBandwidthPackageIds { get; set; }
                public class DescribeCensResponseBodyCensCenCenBandwidthPackageIds : TeaModel {
                    [NameInMap("CenBandwidthPackageId")]
                    [Validation(Required=false)]
                    public List<string> CenBandwidthPackageId { get; set; }

                }

                /// <summary>
                /// The filter condition. Valid values:
                /// 
                /// *   **CenId**: the ID of a CEN instance.
                /// *   **Name**: the name of a CEN instance.
                /// 
                /// By default, the logical operator among filter conditions is **AND**. Information about a CEN instance is returned only if the CEN instance matches all filter conditions.
                /// 
                /// You can specify at most five filter conditions in each call.
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The number of entries returned per page.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The number of the page returned.
                /// </summary>
                [NameInMap("Ipv6Level")]
                [Validation(Required=false)]
                public string Ipv6Level { get; set; }

                /// <summary>
                /// The ID of the CEN instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("ProtectionLevel")]
                [Validation(Required=false)]
                public string ProtectionLevel { get; set; }

                /// <summary>
                /// The values of the filter condition.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Indicates whether IPv6 is enabled for the CEN instance.
                /// 
                /// *   **ENABLE**: enabled
                /// *   **DISABLED**: disabled
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tag keys of the resources.
                /// 
                /// The tag keys cannot be an empty string. The tag keys can be up to 64 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
                /// 
                /// You can specify at most 20 tag keys.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeCensResponseBodyCensCenTags Tags { get; set; }
                public class DescribeCensResponseBodyCensCenTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeCensResponseBodyCensCenTagsTag> Tag { get; set; }
                    public class DescribeCensResponseBodyCensCenTagsTag : TeaModel {
                        /// <summary>
                        /// Queries detailed information about Cloud Enterprise Network (CEN) instances within the current Alibaba Cloud account.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The level of CIDR block overlapping.
        /// 
        /// **REDUCED**: Overlapped CIDR blocks are allowed. This value specifies that CIDR blocks can overlap but CIDR blocks cannot be duplicates.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The status of the CEN instance.
        /// 
        /// *   **Creating**: The CEN instance is being created.
        /// *   **Active**: The CEN instance is running.
        /// *   **Deleting**: The instance is being deleted.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the resource group to which the CEN instance belongs.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The IDs of the bandwidth plans that are associated with the CEN instance.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
