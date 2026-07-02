// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeFirewallTrafficTrendResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeFirewallTrafficTrendResponseBodyDataList> DataList { get; set; }
        public class DescribeFirewallTrafficTrendResponseBodyDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InternetBps")]
            [Validation(Required=false)]
            public long? InternetBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("NatBps")]
            [Validation(Required=false)]
            public long? NatBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1758470400</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("TotalBps")]
            [Validation(Required=false)]
            public long? TotalBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("VpcBps")]
            [Validation(Required=false)]
            public long? VpcBps { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1758470400</para>
        /// </summary>
        [NameInMap("MaxBandwidthTime")]
        [Validation(Required=false)]
        public long? MaxBandwidthTime { get; set; }

        [NameInMap("MaxBandwidthTimeBps")]
        [Validation(Required=false)]
        public DescribeFirewallTrafficTrendResponseBodyMaxBandwidthTimeBps MaxBandwidthTimeBps { get; set; }
        public class DescribeFirewallTrafficTrendResponseBodyMaxBandwidthTimeBps : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InternetBps")]
            [Validation(Required=false)]
            public long? InternetBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("NatBps")]
            [Validation(Required=false)]
            public long? NatBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("TotalBps")]
            [Validation(Required=false)]
            public long? TotalBps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("VpcBps")]
            [Validation(Required=false)]
            public long? VpcBps { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4E7F94C7-781F-5192-86CF-DB085****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
