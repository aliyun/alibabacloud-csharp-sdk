// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenInterRegionBandwidthLimitsResponseBody : TeaModel {
        /// <summary>
        /// A list of inter-region connections.
        /// </summary>
        [NameInMap("CenInterRegionBandwidthLimits")]
        [Validation(Required=false)]
        public DescribeCenInterRegionBandwidthLimitsResponseBodyCenInterRegionBandwidthLimits CenInterRegionBandwidthLimits { get; set; }
        public class DescribeCenInterRegionBandwidthLimitsResponseBodyCenInterRegionBandwidthLimits : TeaModel {
            [NameInMap("CenInterRegionBandwidthLimit")]
            [Validation(Required=false)]
            public List<DescribeCenInterRegionBandwidthLimitsResponseBodyCenInterRegionBandwidthLimitsCenInterRegionBandwidthLimit> CenInterRegionBandwidthLimit { get; set; }
            public class DescribeCenInterRegionBandwidthLimitsResponseBodyCenInterRegionBandwidthLimitsCenInterRegionBandwidthLimit : TeaModel {
                /// <summary>
                /// The maximum bandwidth of the inter-region connection. Unit: Mbit/s.
                /// </summary>
                [NameInMap("BandwidthLimit")]
                [Validation(Required=false)]
                public long? BandwidthLimit { get; set; }

                /// <summary>
                /// The ID of the bandwidth plan.
                /// </summary>
                [NameInMap("BandwidthPackageId")]
                [Validation(Required=false)]
                public string BandwidthPackageId { get; set; }

                [NameInMap("BandwidthType")]
                [Validation(Required=false)]
                public string BandwidthType { get; set; }

                /// <summary>
                /// The CEN instance ID.
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// The IDs of the local and peer regions.
                /// </summary>
                [NameInMap("GeographicSpanId")]
                [Validation(Required=false)]
                public string GeographicSpanId { get; set; }

                /// <summary>
                /// The ID of the local region.
                /// 
                /// You can call the [DescribeChildInstanceRegions](https://help.aliyun.com/document_detail/132080.html) operation to query the most recent region list.
                /// </summary>
                [NameInMap("LocalRegionId")]
                [Validation(Required=false)]
                public string LocalRegionId { get; set; }

                /// <summary>
                /// The ID of the peer region.
                /// </summary>
                [NameInMap("OppositeRegionId")]
                [Validation(Required=false)]
                public string OppositeRegionId { get; set; }

                /// <summary>
                /// The bandwidth status of the inter-region connection. Valid values:
                /// 
                /// *   **Active**
                /// *   **Modifying**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
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
        /// The request ID.
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
