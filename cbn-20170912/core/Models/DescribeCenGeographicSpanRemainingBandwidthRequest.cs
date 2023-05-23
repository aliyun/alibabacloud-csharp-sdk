// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenGeographicSpanRemainingBandwidthRequest : TeaModel {
        /// <summary>
        /// The ID of the Cloud Enterprise Network (CEN) instance to which the bandwidth plan is associated.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The ID of one of the connected areas of the bandwidth plan. Valid values:
        /// 
        /// *   **China**: Chinese mainland
        /// *   **North-America**: North America
        /// *   **Asia-Pacific**: Asia Pacific
        /// *   **Europe**: Europe
        /// *   **Australia**: Australia
        /// </summary>
        [NameInMap("GeographicRegionAId")]
        [Validation(Required=false)]
        public string GeographicRegionAId { get; set; }

        /// <summary>
        /// The ID of the other area connected by the bandwidth plan. Valid values:
        /// 
        /// *   **China**: Chinese mainland
        /// *   **North-America**: North America
        /// *   **Asia-Pacific**: Asia Pacific
        /// *   **Europe**: Europe
        /// *   **Australia**: Australia
        /// </summary>
        [NameInMap("GeographicRegionBId")]
        [Validation(Required=false)]
        public string GeographicRegionBId { get; set; }

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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
