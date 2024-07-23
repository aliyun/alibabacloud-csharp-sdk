// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeBandwidthLimitationResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the maximum public bandwidth.</para>
        /// </summary>
        [NameInMap("Bandwidths")]
        [Validation(Required=false)]
        public DescribeBandwidthLimitationResponseBodyBandwidths Bandwidths { get; set; }
        public class DescribeBandwidthLimitationResponseBodyBandwidths : TeaModel {
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public List<DescribeBandwidthLimitationResponseBodyBandwidthsBandwidth> Bandwidth { get; set; }
            public class DescribeBandwidthLimitationResponseBodyBandwidthsBandwidth : TeaModel {
                /// <summary>
                /// <para>The billing method for network usage. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>PayByBandwidth</description></item>
                /// <item><description>PayByTraffic</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PayByTraffic</para>
                /// </summary>
                [NameInMap("InternetChargeType")]
                [Validation(Required=false)]
                public string InternetChargeType { get; set; }

                /// <summary>
                /// <para>The maximum public bandwidth.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Max")]
                [Validation(Required=false)]
                public int? Max { get; set; }

                /// <summary>
                /// <para>The minimum public bandwidth.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Min")]
                [Validation(Required=false)]
                public int? Min { get; set; }

                /// <summary>
                /// <para>The unit of the public bandwidth.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mbps</para>
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
