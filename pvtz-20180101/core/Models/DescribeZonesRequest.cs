// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// The keyword of the zone name. The search is performed in the %KeyWord % mode and is not case-sensitive.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: 100. Default value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("QueryRegionId")]
        [Validation(Required=false)]
        public string QueryRegionId { get; set; }

        /// <summary>
        /// The virtual private cloud (VPC) ID.
        /// </summary>
        [NameInMap("QueryVpcId")]
        [Validation(Required=false)]
        public string QueryVpcId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tag added to the resource.
        /// </summary>
        [NameInMap("ResourceTag")]
        [Validation(Required=false)]
        public List<DescribeZonesRequestResourceTag> ResourceTag { get; set; }
        public class DescribeZonesRequestResourceTag : TeaModel {
            /// <summary>
            /// The key of tag N added to the resource.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N added to the resource.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The search mode. Valid values:
        /// 
        /// *   **LIKE (default)**: fuzzy search
        /// *   **EXACT**: exact search
        /// </summary>
        [NameInMap("SearchMode")]
        [Validation(Required=false)]
        public string SearchMode { get; set; }

        /// <summary>
        /// The type of the cloud service.
        /// </summary>
        [NameInMap("ZoneTag")]
        [Validation(Required=false)]
        public List<string> ZoneTag { get; set; }

        /// <summary>
        /// The type of zones to query. Default value: AUTH_ZONE.
        /// 
        /// Valid values:
        /// 
        /// *   **AUTH_ZONE**: authoritative zone
        /// *   **CLOUD_PRODUCT_ZONE**: authoritative zone for cloud services
        /// </summary>
        [NameInMap("ZoneType")]
        [Validation(Required=false)]
        public string ZoneType { get; set; }

    }

}
