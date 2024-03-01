// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserAssetIPTrafficInfoResponseBody : TeaModel {
        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The network throughput, which indicates the inbound traffic rate. Unit: bit/s.
        /// </summary>
        [NameInMap("InBps")]
        [Validation(Required=false)]
        public long? InBps { get; set; }

        /// <summary>
        /// The inbound network throughput, which indicates the number of packets that are sent inbound per second. Unit: packets per second (pps).
        /// </summary>
        [NameInMap("InPps")]
        [Validation(Required=false)]
        public long? InPps { get; set; }

        /// <summary>
        /// The new connection creation rate.
        /// </summary>
        [NameInMap("NewConn")]
        [Validation(Required=false)]
        public long? NewConn { get; set; }

        /// <summary>
        /// The network throughput, which indicates the outbound traffic rate. Unit: bit/s.
        /// </summary>
        [NameInMap("OutBps")]
        [Validation(Required=false)]
        public long? OutBps { get; set; }

        /// <summary>
        /// The outbound network throughput, which indicates the number of packets that are sent outbound per second. Unit: pps.
        /// </summary>
        [NameInMap("OutPps")]
        [Validation(Required=false)]
        public long? OutPps { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of requests.
        /// </summary>
        [NameInMap("SessionCount")]
        [Validation(Required=false)]
        public long? SessionCount { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
