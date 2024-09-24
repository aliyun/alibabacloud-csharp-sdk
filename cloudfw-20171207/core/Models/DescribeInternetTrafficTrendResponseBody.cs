// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetTrafficTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The average inbound network throughput, which indicates the average number of bits that are sent inbound per second. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6114152</para>
        /// </summary>
        [NameInMap("AvgInBps")]
        [Validation(Required=false)]
        public long? AvgInBps { get; set; }

        /// <summary>
        /// <para>The average outbound network throughput, which indicates the average number of bits that are sent outbound per second. Unit: bit/s.</para>
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
        /// <para>The total average inbound and outbound network throughput, which indicates the average number of bits that are sent inbound and outbound per second. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2306</para>
        /// </summary>
        [NameInMap("AvgTotalBps")]
        [Validation(Required=false)]
        public long? AvgTotalBps { get; set; }

        /// <summary>
        /// <para>The statistics on traffic.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeInternetTrafficTrendResponseBodyDataList> DataList { get; set; }
        public class DescribeInternetTrafficTrendResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The inbound network throughput, which indicates the number of bits that are sent inbound per second. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>187</para>
            /// </summary>
            [NameInMap("InBps")]
            [Validation(Required=false)]
            public long? InBps { get; set; }

            /// <summary>
            /// <para>The inbound network throughput, which indicates the total number of bytes that are sent inbound. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>235</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <para>The inbound network throughput, which indicates the number of packets that are sent inbound per second. Unit: packets per second (pps).</para>
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
            /// <para>The outbound network throughput, which indicates the number of bits that are sent outbound per second. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45</para>
            /// </summary>
            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public long? OutBps { get; set; }

            /// <summary>
            /// <para>The outbound network throughput, which indicates the total number of bytes that are sent outbound. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1123</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// <para>The outbound network throughput, which indicates the number of packets that are sent outbound per second. Unit: pps.</para>
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
            /// <para>The time when traffic is generated. The value is a UNIX timestamp. Unit: seconds.</para>
            /// <para>If processing is not complete at this point in time, -1 is returned for all other fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1659405600</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public int? Time { get; set; }

            /// <summary>
            /// <para>The total outbound and inbound network throughput, which indicates the total number of bits that are sent inbound and outbound per second. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>323</para>
            /// </summary>
            [NameInMap("TotalBps")]
            [Validation(Required=false)]
            public long? TotalBps { get; set; }

        }

        /// <summary>
        /// <para>The timestamp generated when the bandwidth reaches the peak value. The value is a UNIX timestamp. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672736400</para>
        /// </summary>
        [NameInMap("MaxBandwidthTime")]
        [Validation(Required=false)]
        public long? MaxBandwidthTime { get; set; }

        /// <summary>
        /// <para>The maximum volume of excess traffic allowed per day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>873</para>
        /// </summary>
        [NameInMap("MaxDayExceedBytes")]
        [Validation(Required=false)]
        public long? MaxDayExceedBytes { get; set; }

        /// <summary>
        /// <para>The maximum inbound network throughput, which indicates the maximum number of bits that are sent inbound per second. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10275643</para>
        /// </summary>
        [NameInMap("MaxInBps")]
        [Validation(Required=false)]
        public long? MaxInBps { get; set; }

        /// <summary>
        /// <para>The maximum outbound network throughput, which indicates the maximum number of bits that are sent outbound per second. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>395188</para>
        /// </summary>
        [NameInMap("MaxOutBps")]
        [Validation(Required=false)]
        public long? MaxOutBps { get; set; }

        /// <summary>
        /// <para>The number of requests during the peak hour of the network throughout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>931641</para>
        /// </summary>
        [NameInMap("MaxSession")]
        [Validation(Required=false)]
        public long? MaxSession { get; set; }

        /// <summary>
        /// <para>The total maximum inbound and outbound network throughput, which indicates the maximum number of bits that are sent inbound and outbound per second. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89783147</para>
        /// </summary>
        [NameInMap("MaxTotalBps")]
        [Validation(Required=false)]
        public long? MaxTotalBps { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7E837BE-0379-565E-B7B4-DE595C8D337C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total inbound and outbound network throughput, which indicates the total number of bytes that are sent inbound and outbound. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>963227674958</para>
        /// </summary>
        [NameInMap("TotalBytes")]
        [Validation(Required=false)]
        public long? TotalBytes { get; set; }

        /// <summary>
        /// <para>The total volume of excess traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4243873</para>
        /// </summary>
        [NameInMap("TotalExceedBytes")]
        [Validation(Required=false)]
        public long? TotalExceedBytes { get; set; }

        /// <summary>
        /// <para>The inbound network throughput, which indicates the total number of bytes that are sent inbound. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>41536824243873</para>
        /// </summary>
        [NameInMap("TotalInBytes")]
        [Validation(Required=false)]
        public long? TotalInBytes { get; set; }

        /// <summary>
        /// <para>The outbound network throughput, which indicates the total number of bytes that are sent outbound. Unit: bytes.</para>
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
