// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetTrafficTrendResponseBody : TeaModel {
        /// <summary>
        /// The average inbound network throughput, which indicates the average number of bits that are sent inbound per second. Unit: bit/s.
        /// </summary>
        [NameInMap("AvgInBps")]
        [Validation(Required=false)]
        public long? AvgInBps { get; set; }

        /// <summary>
        /// The average outbound network throughput, which indicates the average number of bits that are sent outbound per second. Unit: bit/s.
        /// </summary>
        [NameInMap("AvgOutBps")]
        [Validation(Required=false)]
        public long? AvgOutBps { get; set; }

        /// <summary>
        /// The average number of requests.
        /// </summary>
        [NameInMap("AvgSession")]
        [Validation(Required=false)]
        public long? AvgSession { get; set; }

        /// <summary>
        /// The total average inbound and outbound network throughput, which indicates the average number of bits that are sent inbound and outbound per second. Unit: bit/s.
        /// </summary>
        [NameInMap("AvgTotalBps")]
        [Validation(Required=false)]
        public long? AvgTotalBps { get; set; }

        /// <summary>
        /// The statistics on traffic.
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeInternetTrafficTrendResponseBodyDataList> DataList { get; set; }
        public class DescribeInternetTrafficTrendResponseBodyDataList : TeaModel {
            /// <summary>
            /// The inbound network throughput, which indicates the number of bits that are sent inbound per second. Unit: bit/s.
            /// </summary>
            [NameInMap("InBps")]
            [Validation(Required=false)]
            public long? InBps { get; set; }

            /// <summary>
            /// The inbound network throughput, which indicates the total number of bytes that are sent inbound. Unit: bytes.
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// The inbound network throughput, which indicates the number of packets that are sent inbound per second. Unit: packets per second (pps).
            /// </summary>
            [NameInMap("InPps")]
            [Validation(Required=false)]
            public long? InPps { get; set; }

            /// <summary>
            /// The number of new connections.
            /// </summary>
            [NameInMap("NewConn")]
            [Validation(Required=false)]
            public long? NewConn { get; set; }

            /// <summary>
            /// The outbound network throughput, which indicates the number of bits that are sent inbound per second. Unit: bit/s.
            /// </summary>
            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public long? OutBps { get; set; }

            /// <summary>
            /// The outbound network throughput, which indicates the total number of bytes that are sent outbound. Unit: bytes.
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// The outbound network throughput, which indicates the number of packets that are sent outbound per second. Unit: pps.
            /// </summary>
            [NameInMap("OutPps")]
            [Validation(Required=false)]
            public long? OutPps { get; set; }

            /// <summary>
            /// The number of requests.
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// The time when traffic is generated. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public int? Time { get; set; }

            /// <summary>
            /// The total outbound and inbound network throughput, which indicates the total number of bits that are sent inbound and outbound per second. Unit: bit/s.
            /// </summary>
            [NameInMap("TotalBps")]
            [Validation(Required=false)]
            public long? TotalBps { get; set; }

        }

        /// <summary>
        /// The timestamp generated when the bandwidth reaches the peak value. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("MaxBandwidthTime")]
        [Validation(Required=false)]
        public long? MaxBandwidthTime { get; set; }

        [NameInMap("MaxDayExceedBytes")]
        [Validation(Required=false)]
        public long? MaxDayExceedBytes { get; set; }

        /// <summary>
        /// The maximum inbound network throughput, which indicates the maximum number of bits that are sent inbound per second. Unit: bit/s.
        /// </summary>
        [NameInMap("MaxInBps")]
        [Validation(Required=false)]
        public long? MaxInBps { get; set; }

        /// <summary>
        /// The maximum outbound network throughput, which indicates the maximum number of bits that are sent outbound per second. Unit: bit/s.
        /// </summary>
        [NameInMap("MaxOutBps")]
        [Validation(Required=false)]
        public long? MaxOutBps { get; set; }

        /// <summary>
        /// The number of requests during the peak hour of the network throughout.
        /// </summary>
        [NameInMap("MaxSession")]
        [Validation(Required=false)]
        public long? MaxSession { get; set; }

        /// <summary>
        /// The total maximum inbound and outbound network throughput, which indicates the maximum number of bits that are sent inbound and outbound per second. Unit: bit/s.
        /// </summary>
        [NameInMap("MaxTotalBps")]
        [Validation(Required=false)]
        public long? MaxTotalBps { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total inbound and outbound network throughput, which indicates the total number of bytes that are sent inbound and outbound. Unit: bytes.
        /// </summary>
        [NameInMap("TotalBytes")]
        [Validation(Required=false)]
        public long? TotalBytes { get; set; }

        [NameInMap("TotalExceedBytes")]
        [Validation(Required=false)]
        public long? TotalExceedBytes { get; set; }

        /// <summary>
        /// The inbound network throughput, which indicates the total number of bytes that are sent inbound. Unit: bytes.
        /// </summary>
        [NameInMap("TotalInBytes")]
        [Validation(Required=false)]
        public long? TotalInBytes { get; set; }

        /// <summary>
        /// The outbound network throughput, which indicates the total number of bytes that are sent outbound. Unit: bytes.
        /// </summary>
        [NameInMap("TotalOutBytes")]
        [Validation(Required=false)]
        public long? TotalOutBytes { get; set; }

        /// <summary>
        /// The total number of requests.
        /// </summary>
        [NameInMap("TotalSession")]
        [Validation(Required=false)]
        public long? TotalSession { get; set; }

    }

}
