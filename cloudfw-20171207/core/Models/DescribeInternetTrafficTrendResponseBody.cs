// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInternetTrafficTrendResponseBody : TeaModel {
        [NameInMap("AvgInBps")]
        [Validation(Required=false)]
        public long? AvgInBps { get; set; }

        [NameInMap("AvgOutBps")]
        [Validation(Required=false)]
        public long? AvgOutBps { get; set; }

        [NameInMap("AvgSession")]
        [Validation(Required=false)]
        public long? AvgSession { get; set; }

        [NameInMap("AvgTotalBps")]
        [Validation(Required=false)]
        public long? AvgTotalBps { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeInternetTrafficTrendResponseBodyDataList> DataList { get; set; }
        public class DescribeInternetTrafficTrendResponseBodyDataList : TeaModel {
            [NameInMap("InBps")]
            [Validation(Required=false)]
            public long? InBps { get; set; }

            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            [NameInMap("InPps")]
            [Validation(Required=false)]
            public long? InPps { get; set; }

            [NameInMap("NewConn")]
            [Validation(Required=false)]
            public long? NewConn { get; set; }

            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public long? OutBps { get; set; }

            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            [NameInMap("OutPps")]
            [Validation(Required=false)]
            public long? OutPps { get; set; }

            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public int? Time { get; set; }

            [NameInMap("TotalBps")]
            [Validation(Required=false)]
            public long? TotalBps { get; set; }

        }

        [NameInMap("MaxBandwidthTime")]
        [Validation(Required=false)]
        public long? MaxBandwidthTime { get; set; }

        [NameInMap("MaxInBps")]
        [Validation(Required=false)]
        public long? MaxInBps { get; set; }

        [NameInMap("MaxOutBps")]
        [Validation(Required=false)]
        public long? MaxOutBps { get; set; }

        [NameInMap("MaxSession")]
        [Validation(Required=false)]
        public long? MaxSession { get; set; }

        [NameInMap("MaxTotalBps")]
        [Validation(Required=false)]
        public long? MaxTotalBps { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalBytes")]
        [Validation(Required=false)]
        public long? TotalBytes { get; set; }

        [NameInMap("TotalInBytes")]
        [Validation(Required=false)]
        public long? TotalInBytes { get; set; }

        [NameInMap("TotalOutBytes")]
        [Validation(Required=false)]
        public long? TotalOutBytes { get; set; }

        [NameInMap("TotalSession")]
        [Validation(Required=false)]
        public long? TotalSession { get; set; }

    }

}
