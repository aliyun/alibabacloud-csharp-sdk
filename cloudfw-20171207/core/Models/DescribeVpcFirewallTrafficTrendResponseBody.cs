// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallTrafficTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The average inbound network throughput. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1264110</para>
        /// </summary>
        [NameInMap("AvgInBps")]
        [Validation(Required=false)]
        public long? AvgInBps { get; set; }

        /// <summary>
        /// <para>The average outbound network throughput. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68915</para>
        /// </summary>
        [NameInMap("AvgOutBps")]
        [Validation(Required=false)]
        public long? AvgOutBps { get; set; }

        /// <summary>
        /// <para>The average number of requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1995</para>
        /// </summary>
        [NameInMap("AvgSession")]
        [Validation(Required=false)]
        public long? AvgSession { get; set; }

        /// <summary>
        /// <para>The average total network throughput in both the outbound and inbound directions. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34291</para>
        /// </summary>
        [NameInMap("AvgTotalBps")]
        [Validation(Required=false)]
        public long? AvgTotalBps { get; set; }

        /// <summary>
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallTrafficTrendResponseBodyDataList> DataList { get; set; }
        public class DescribeVpcFirewallTrafficTrendResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The inbound bandwidth. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>187</para>
            /// </summary>
            [NameInMap("InBps")]
            [Validation(Required=false)]
            public long? InBps { get; set; }

            /// <summary>
            /// <para>The inbound traffic. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <para>The inbound packet forwarding rate. Unit: pps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InPps")]
            [Validation(Required=false)]
            public long? InPps { get; set; }

            /// <summary>
            /// <para>The number of new connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("NewConn")]
            [Validation(Required=false)]
            public long? NewConn { get; set; }

            /// <summary>
            /// <para>The outbound traffic. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45</para>
            /// </summary>
            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public long? OutBps { get; set; }

            /// <summary>
            /// <para>The total outbound network throughput. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>230</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// <para>The outbound packet forwarding rate. Unit: pps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("OutPps")]
            [Validation(Required=false)]
            public long? OutPps { get; set; }

            /// <summary>
            /// <para>The number of sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <para>The time when the traffic occurred. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1758470400</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public int? Time { get; set; }

        }

        /// <summary>
        /// <para>The timestamp when the peak bandwidth occurred. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1768008060</para>
        /// </summary>
        [NameInMap("MaxBandwidthTime")]
        [Validation(Required=false)]
        public long? MaxBandwidthTime { get; set; }

        /// <summary>
        /// <para>The peak inbound network throughput. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1436</para>
        /// </summary>
        [NameInMap("MaxInBps")]
        [Validation(Required=false)]
        public long? MaxInBps { get; set; }

        /// <summary>
        /// <para>The peak outbound network throughput. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2128</para>
        /// </summary>
        [NameInMap("MaxOutBps")]
        [Validation(Required=false)]
        public long? MaxOutBps { get; set; }

        /// <summary>
        /// <para>The peak number of requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2003</para>
        /// </summary>
        [NameInMap("MaxSession")]
        [Validation(Required=false)]
        public long? MaxSession { get; set; }

        /// <summary>
        /// <para>The peak total network throughput in both the outbound and inbound directions. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61947852</para>
        /// </summary>
        [NameInMap("MaxTotalBps")]
        [Validation(Required=false)]
        public long? MaxTotalBps { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45F8B9E6-8583-56B3-A127-1B421C9E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total traffic. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>141688156232</para>
        /// </summary>
        [NameInMap("TotalBytes")]
        [Validation(Required=false)]
        public long? TotalBytes { get; set; }

        /// <summary>
        /// <para>The total inbound network throughput. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2659635037</para>
        /// </summary>
        [NameInMap("TotalInBytes")]
        [Validation(Required=false)]
        public long? TotalInBytes { get; set; }

        /// <summary>
        /// <para>The total outbound network throughput. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>399762701</para>
        /// </summary>
        [NameInMap("TotalOutBytes")]
        [Validation(Required=false)]
        public long? TotalOutBytes { get; set; }

        /// <summary>
        /// <para>The total number of requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1078757</para>
        /// </summary>
        [NameInMap("TotalSession")]
        [Validation(Required=false)]
        public long? TotalSession { get; set; }

    }

}
