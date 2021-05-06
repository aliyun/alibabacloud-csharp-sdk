// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenInterRegionBandwidthLimitsResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("CenInterRegionBandwidthLimits")]
        [Validation(Required=false)]
        public DescribeCenInterRegionBandwidthLimitsResponseBodyCenInterRegionBandwidthLimits CenInterRegionBandwidthLimits { get; set; }
        public class DescribeCenInterRegionBandwidthLimitsResponseBodyCenInterRegionBandwidthLimits : TeaModel {
            [NameInMap("CenInterRegionBandwidthLimit")]
            [Validation(Required=false)]
            public List<DescribeCenInterRegionBandwidthLimitsResponseBodyCenInterRegionBandwidthLimitsCenInterRegionBandwidthLimit> CenInterRegionBandwidthLimit { get; set; }
            public class DescribeCenInterRegionBandwidthLimitsResponseBodyCenInterRegionBandwidthLimitsCenInterRegionBandwidthLimit : TeaModel {
                public string Status { get; set; }
                public string BandwidthPackageId { get; set; }
                public string OppositeRegionId { get; set; }
                public string GeographicSpanId { get; set; }
                public string CenId { get; set; }
                public string LocalRegionId { get; set; }
                public long? BandwidthLimit { get; set; }
            }
        };

    }

}
