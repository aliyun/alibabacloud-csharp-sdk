// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetTrafficTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The average network throughput in the inbound direction. Unit: bps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6114152</para>
        /// </summary>
        [NameInMap("AvgInBps")]
        [Validation(Required=false)]
        public long? AvgInBps { get; set; }

        /// <summary>
        /// <para>The average network throughput in the outbound direction. Unit: bps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70148993</para>
        /// </summary>
        [NameInMap("AvgOutBps")]
        [Validation(Required=false)]
        public long? AvgOutBps { get; set; }

        /// <summary>
        /// <para>The average number of requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79013</para>
        /// </summary>
        [NameInMap("AvgSession")]
        [Validation(Required=false)]
        public long? AvgSession { get; set; }

        /// <summary>
        /// <para>The average network throughput in both outbound and inbound directions. Unit: bps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2306</para>
        /// </summary>
        [NameInMap("AvgTotalBps")]
        [Validation(Required=false)]
        public long? AvgTotalBps { get; set; }

        /// <summary>
        /// <para>The list of traffic statistics information.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeInternetTrafficTrendResponseBodyDataList> DataList { get; set; }
        public class DescribeInternetTrafficTrendResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The network throughput in the inbound direction. Unit: bps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>187</para>
            /// </summary>
            [NameInMap("InBps")]
            [Validation(Required=false)]
            public long? InBps { get; set; }

            /// <summary>
            /// <para>The total network traffic in the inbound direction. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>235</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <para>The packet rate in the inbound direction. Unit: pps.</para>
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
            /// <para>The network throughput in the outbound direction. Unit: bps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45</para>
            /// </summary>
            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public long? OutBps { get; set; }

            /// <summary>
            /// <para>The total network traffic in the outbound direction. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1123</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// <para>The packet rate in the outbound direction. Unit: pps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("OutPps")]
            [Validation(Required=false)]
            public long? OutPps { get; set; }

            /// <summary>
            /// <para>The number of requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <para>The time when the traffic occurred. The value is a UNIX timestamp in seconds.</para>
            /// <para>If the data for this time point is not fully processed, the values of other fields are -1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1659405600</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public int? Time { get; set; }

            /// <summary>
            /// <para>The total network throughput in both outbound and inbound directions. Unit: bps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>232</para>
            /// </summary>
            [NameInMap("TotalBps")]
            [Validation(Required=false)]
            public long? TotalBps { get; set; }

        }

        /// <summary>
        /// <para>The timestamp when the peak bandwidth occurred. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672736400</para>
        /// </summary>
        [NameInMap("MaxBandwidthTime")]
        [Validation(Required=false)]
        public long? MaxBandwidthTime { get; set; }

        /// <summary>
        /// <para>The maximum daily excess traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>873</para>
        /// </summary>
        [NameInMap("MaxDayExceedBytes")]
        [Validation(Required=false)]
        public long? MaxDayExceedBytes { get; set; }

        /// <summary>
        /// <para>The peak network throughput in the inbound direction. Unit: bps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10275643</para>
        /// </summary>
        [NameInMap("MaxInBps")]
        [Validation(Required=false)]
        public long? MaxInBps { get; set; }

        /// <summary>
        /// <para>The peak network throughput in the outbound direction. Unit: bps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>395188</para>
        /// </summary>
        [NameInMap("MaxOutBps")]
        [Validation(Required=false)]
        public long? MaxOutBps { get; set; }

        /// <summary>
        /// <para>The peak number of requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>931641</para>
        /// </summary>
        [NameInMap("MaxSession")]
        [Validation(Required=false)]
        public long? MaxSession { get; set; }

        /// <summary>
        /// <para>The peak network throughput in both outbound and inbound directions. Unit: bps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89783147</para>
        /// </summary>
        [NameInMap("MaxTotalBps")]
        [Validation(Required=false)]
        public long? MaxTotalBps { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7E837BE-0379-565E-B7B4-DE595C8D337C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total network traffic in both outbound and inbound directions. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>963227674958</para>
        /// </summary>
        [NameInMap("TotalBytes")]
        [Validation(Required=false)]
        public long? TotalBytes { get; set; }

        /// <summary>
        /// <para>The total excess traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4243873</para>
        /// </summary>
        [NameInMap("TotalExceedBytes")]
        [Validation(Required=false)]
        public long? TotalExceedBytes { get; set; }

        /// <summary>
        /// <para>The total network traffic in the inbound direction. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>41536824243873</para>
        /// </summary>
        [NameInMap("TotalInBytes")]
        [Validation(Required=false)]
        public long? TotalInBytes { get; set; }

        /// <summary>
        /// <para>The total network traffic in the outbound direction. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2660894567178</para>
        /// </summary>
        [NameInMap("TotalOutBytes")]
        [Validation(Required=false)]
        public long? TotalOutBytes { get; set; }

        /// <summary>
        /// <para>The total number of requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1061449</para>
        /// </summary>
        [NameInMap("TotalSession")]
        [Validation(Required=false)]
        public long? TotalSession { get; set; }

    }

}
