// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenInterRegionBandwidthLimitsResponseBody : TeaModel {
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

                [NameInMap("BandwidthType")]
                [Validation(Required=false)]
                public string BandwidthType { get; set; }

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

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7A30C665-8766-5AAA-9274-C97380E2D850</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
