// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class Describe95TrafficResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information returned.</para>
        /// </summary>
        [NameInMap("Traffic95Summary")]
        [Validation(Required=false)]
        public Describe95TrafficResponseBodyTraffic95Summary Traffic95Summary { get; set; }
        public class Describe95TrafficResponseBodyTraffic95Summary : TeaModel {
            /// <summary>
            /// <para>The peak bandwidth of the Internet Shared Bandwidth instance. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20000.0</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para>The daily peak bandwidth. Unit: Mbit/s.
            /// &lt;props=&quot;china&quot;&gt; For more information, see <a href="https://help.aliyun.com/document_detail/89729.html">Daily peak bandwidth</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1064.244837773641</para>
            /// </summary>
            [NameInMap("FifthPeakBandwidth")]
            [Validation(Required=false)]
            public string FifthPeakBandwidth { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbwp-wz9j19xrwf78fvz7*****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The metering method of the Internet Shared Bandwidth instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PayBy95: pay-by-enhanced-95th-percentile</description></item>
            /// <item><description>PayByBandwidth: pay-by-bandwidth</description></item>
            /// <item><description>PayByDominantTraffic: pay-by-dominant-traffic</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayBy95</para>
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The guaranteed bandwidth of the Internet Shared Bandwidth instance. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("MinimumConsumeBandwidth")]
            [Validation(Required=false)]
            public string MinimumConsumeBandwidth { get; set; }

            /// <summary>
            /// <para>The average bandwidth every 5 minutes in the inbound and outbound directions.</para>
            /// </summary>
            [NameInMap("Traffic95DetailList")]
            [Validation(Required=false)]
            public Describe95TrafficResponseBodyTraffic95SummaryTraffic95DetailList Traffic95DetailList { get; set; }
            public class Describe95TrafficResponseBodyTraffic95SummaryTraffic95DetailList : TeaModel {
                [NameInMap("Traffic95Detail")]
                [Validation(Required=false)]
                public List<Describe95TrafficResponseBodyTraffic95SummaryTraffic95DetailListTraffic95Detail> Traffic95Detail { get; set; }
                public class Describe95TrafficResponseBodyTraffic95SummaryTraffic95DetailListTraffic95Detail : TeaModel {
                    /// <summary>
                    /// <para>The sampled bandwidth value, which is the larger bandwidth value in the inbound and outbound directions within a sampling interval. Unit: Mbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>118.5090322113037</para>
                    /// </summary>
                    [NameInMap("BillBandwidth")]
                    [Validation(Required=false)]
                    public string BillBandwidth { get; set; }

                    /// <summary>
                    /// <para>The inbound bandwidth. Unit: Mbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>118.5090322113037</para>
                    /// </summary>
                    [NameInMap("InBandwidth")]
                    [Validation(Required=false)]
                    public string InBandwidth { get; set; }

                    /// <summary>
                    /// <para>The outbound bandwidth. Unit: Mbit/s.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>96.41217480977376</para>
                    /// </summary>
                    [NameInMap("OutBandwidth")]
                    [Validation(Required=false)]
                    public string OutBandwidth { get; set; }

                    /// <summary>
                    /// <para>The statistical time. The value is a string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-01-01T00:00:00Z</para>
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                }

            }

        }

    }

}
