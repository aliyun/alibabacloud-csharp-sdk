// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenInterRegionBandwidthLimitsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the peer region.
        /// </summary>
        [NameInMap("CenInterRegionBandwidthLimits")]
        [Validation(Required=false)]
        public DescribeCenInterRegionBandwidthLimitsResponseBodyCenInterRegionBandwidthLimits CenInterRegionBandwidthLimits { get; set; }
        public class DescribeCenInterRegionBandwidthLimitsResponseBodyCenInterRegionBandwidthLimits : TeaModel {
            [NameInMap("CenInterRegionBandwidthLimit")]
            [Validation(Required=false)]
            public List<DescribeCenInterRegionBandwidthLimitsResponseBodyCenInterRegionBandwidthLimitsCenInterRegionBandwidthLimit> CenInterRegionBandwidthLimit { get; set; }
            public class DescribeCenInterRegionBandwidthLimitsResponseBodyCenInterRegionBandwidthLimitsCenInterRegionBandwidthLimit : TeaModel {
                [NameInMap("BandwidthLimit")]
                [Validation(Required=false)]
                public long? BandwidthLimit { get; set; }

                [NameInMap("BandwidthPackageId")]
                [Validation(Required=false)]
                public string BandwidthPackageId { get; set; }

                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                [NameInMap("GeographicSpanId")]
                [Validation(Required=false)]
                public string GeographicSpanId { get; set; }

                [NameInMap("LocalRegionId")]
                [Validation(Required=false)]
                public string LocalRegionId { get; set; }

                [NameInMap("OppositeRegionId")]
                [Validation(Required=false)]
                public string OppositeRegionId { get; set; }

                /// <summary>
                /// Queries the bandwidth limits of cross-region connections.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The ID of the CEN instance.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The bandwidth limit of the cross-region connection. Unit: Mbit/s.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of cross-region connections.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
