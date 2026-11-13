// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeFirewallTrafficTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned data.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeFirewallTrafficTrendResponseBodyDataList> DataList { get; set; }
        public class DescribeFirewallTrafficTrendResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The traffic of the Internet firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InternetBps")]
            [Validation(Required=false)]
            public long? InternetBps { get; set; }

            /// <summary>
            /// <para>The traffic of the NAT firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("NatBps")]
            [Validation(Required=false)]
            public long? NatBps { get; set; }

            /// <summary>
            /// <para>The time when the traffic is generated. The value is a UNIX timestamp in seconds.</para>
            /// <para>If the data for this time point is not processed, the values of other fields are -1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758470400</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <para>The total traffic of the firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("TotalBps")]
            [Validation(Required=false)]
            public long? TotalBps { get; set; }

            /// <summary>
            /// <para>The traffic of the VPC firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("VpcBps")]
            [Validation(Required=false)]
            public long? VpcBps { get; set; }

        }

        /// <summary>
        /// <para>The timestamp when the total traffic peaks. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1758470400</para>
        /// </summary>
        [NameInMap("MaxBandwidthTime")]
        [Validation(Required=false)]
        public long? MaxBandwidthTime { get; set; }

        /// <summary>
        /// <para>The traffic distribution at the time when the total traffic peaks.</para>
        /// </summary>
        [NameInMap("MaxBandwidthTimeBps")]
        [Validation(Required=false)]
        public DescribeFirewallTrafficTrendResponseBodyMaxBandwidthTimeBps MaxBandwidthTimeBps { get; set; }
        public class DescribeFirewallTrafficTrendResponseBodyMaxBandwidthTimeBps : TeaModel {
            /// <summary>
            /// <para>The traffic of the Internet firewall at the time when the total traffic peaks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InternetBps")]
            [Validation(Required=false)]
            public long? InternetBps { get; set; }

            /// <summary>
            /// <para>The traffic of the NAT firewall at the time when the total traffic peaks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("NatBps")]
            [Validation(Required=false)]
            public long? NatBps { get; set; }

            /// <summary>
            /// <para>The peak total traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("TotalBps")]
            [Validation(Required=false)]
            public long? TotalBps { get; set; }

            /// <summary>
            /// <para>The traffic of the VPC firewall at the time when the total traffic peaks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("VpcBps")]
            [Validation(Required=false)]
            public long? VpcBps { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E7F94C7-781F-5192-86CF-DB085****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
