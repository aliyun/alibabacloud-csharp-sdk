// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenInterRegionBandwidthLimitsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of inter-region connections.</para>
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
                /// <para>The maximum bandwidth of the inter-region connection. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BandwidthLimit")]
                [Validation(Required=false)]
                public long? BandwidthLimit { get; set; }

                /// <summary>
                /// <para>The ID of the bandwidth plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cenbwp-uenczwb592fnvv****</para>
                /// </summary>
                [NameInMap("BandwidthPackageId")]
                [Validation(Required=false)]
                public string BandwidthPackageId { get; set; }

                /// <summary>
                /// <para>The bandwidth allocation method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>BandwidthPackage</b>: allocates bandwidth from a bandwidth plan.</description></item>
                /// <item><description><b>DataTransfer</b>: bandwidth is billed based on the pay-by-data-transfer metering method.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BandwidthPackage</para>
                /// </summary>
                [NameInMap("BandwidthType")]
                [Validation(Required=false)]
                public string BandwidthType { get; set; }

                /// <summary>
                /// <para>The CEN instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-pfa6ugf3xl0qsd****</para>
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>The IDs of the local and peer regions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>china_china</para>
                /// </summary>
                [NameInMap("GeographicSpanId")]
                [Validation(Required=false)]
                public string GeographicSpanId { get; set; }

                /// <summary>
                /// <para>The ID of the local region.</para>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query the most recent region list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccn-cn-shanghai</para>
                /// </summary>
                [NameInMap("LocalRegionId")]
                [Validation(Required=false)]
                public string LocalRegionId { get; set; }

                /// <summary>
                /// <para>The ID of the peer region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("OppositeRegionId")]
                [Validation(Required=false)]
                public string OppositeRegionId { get; set; }

                /// <summary>
                /// <para>The bandwidth status of the inter-region connection. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Active</b></description></item>
                /// <item><description><b>Modifying</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
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
