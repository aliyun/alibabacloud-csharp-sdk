// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeIpTrafficResponseBody : TeaModel {
        [NameInMap("MaxOutBps")]
        [Validation(Required=false)]
        public long? MaxOutBps { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AvgInBps")]
        [Validation(Required=false)]
        public long? AvgInBps { get; set; }

        [NameInMap("MaxInBps")]
        [Validation(Required=false)]
        public long? MaxInBps { get; set; }

        [NameInMap("AvgOutBps")]
        [Validation(Required=false)]
        public long? AvgOutBps { get; set; }

        [NameInMap("IpTrafficPoints")]
        [Validation(Required=false)]
        public List<DescribeIpTrafficResponseBodyIpTrafficPoints> IpTrafficPoints { get; set; }
        public class DescribeIpTrafficResponseBodyIpTrafficPoints : TeaModel {
            [NameInMap("ActConns")]
            [Validation(Required=false)]
            public int? ActConns { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("InactConns")]
            [Validation(Required=false)]
            public int? InactConns { get; set; }

            [NameInMap("MaxInbps")]
            [Validation(Required=false)]
            public long? MaxInbps { get; set; }

            [NameInMap("MaxOutbps")]
            [Validation(Required=false)]
            public long? MaxOutbps { get; set; }

            [NameInMap("Cps")]
            [Validation(Required=false)]
            public int? Cps { get; set; }

        }

    }

}
