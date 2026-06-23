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
        /// <para>The bandwidth statistics for Internet Shared Bandwidth billed by enhanced 95th percentile.</para>
        /// </summary>
        [NameInMap("Traffic95Summary")]
        [Validation(Required=false)]
        public Describe95TrafficResponseBodyTraffic95Summary Traffic95Summary { get; set; }
        public class Describe95TrafficResponseBodyTraffic95Summary : TeaModel {
            /// <summary>
            /// <para>The peak bandwidth of the Internet Shared Bandwidth instance on the queried date. Unit: Mbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20000.0</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            /// <summary>
            /// <para>The daily peak bandwidth. Unit: Mbps.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/89729.html">Daily peak bandwidth</a>.</para>
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
            /// <para>The billing method of the Internet Shared Bandwidth instance on the queried date. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PayBy95</b>: pay-by-enhanced-95th-percentile</para>
            /// </description></item>
            /// <item><description><para><b>PayByBandwidth</b>: pay-by-bandwidth</para>
            /// </description></item>
            /// <item><description><para><b>PayByDominantTraffic</b>: pay-by-dominant-traffic</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PayBy95</para>
            /// </summary>
            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            /// <summary>
            /// <para>The minimum bandwidth commitment of the Internet Shared Bandwidth instance on the queried date. Unit: Mbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("MinimumConsumeBandwidth")]
            [Validation(Required=false)]
            public string MinimumConsumeBandwidth { get; set; }

            [NameInMap("Traffic95DetailList")]
            [Validation(Required=false)]
            public Describe95TrafficResponseBodyTraffic95SummaryTraffic95DetailList Traffic95DetailList { get; set; }
            public class Describe95TrafficResponseBodyTraffic95SummaryTraffic95DetailList : TeaModel {
                [NameInMap("Traffic95Detail")]
                [Validation(Required=false)]
                public List<Describe95TrafficResponseBodyTraffic95SummaryTraffic95DetailListTraffic95Detail> Traffic95Detail { get; set; }
                public class Describe95TrafficResponseBodyTraffic95SummaryTraffic95DetailListTraffic95Detail : TeaModel {
                    [NameInMap("BillBandwidth")]
                    [Validation(Required=false)]
                    public string BillBandwidth { get; set; }

                    [NameInMap("InBandwidth")]
                    [Validation(Required=false)]
                    public string InBandwidth { get; set; }

                    [NameInMap("OutBandwidth")]
                    [Validation(Required=false)]
                    public string OutBandwidth { get; set; }

                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                }

            }

        }

    }

}
