// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeIpTrafficResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("MaxInBps")]
        [Validation(Required=true)]
        public long MaxInBps { get; set; }

        [NameInMap("AvgInBps")]
        [Validation(Required=true)]
        public long AvgInBps { get; set; }

        [NameInMap("MaxOutBps")]
        [Validation(Required=true)]
        public long MaxOutBps { get; set; }

        [NameInMap("AvgOutBps")]
        [Validation(Required=true)]
        public long AvgOutBps { get; set; }

        [NameInMap("IpTrafficPoints")]
        [Validation(Required=true)]
        public List<DescribeIpTrafficResponseIpTrafficPoints> IpTrafficPoints { get; set; }
        public class DescribeIpTrafficResponseIpTrafficPoints : TeaModel {
            [NameInMap("Time")]
            [Validation(Required=true)]
            public long Time { get; set; }

            [NameInMap("MaxInbps")]
            [Validation(Required=true)]
            public long MaxInbps { get; set; }

            [NameInMap("MaxOutbps")]
            [Validation(Required=true)]
            public long MaxOutbps { get; set; }

            [NameInMap("Cps")]
            [Validation(Required=true)]
            public int? Cps { get; set; }

            [NameInMap("ActConns")]
            [Validation(Required=true)]
            public int? ActConns { get; set; }

            [NameInMap("InactConns")]
            [Validation(Required=true)]
            public int? InactConns { get; set; }

        }

    }

}
