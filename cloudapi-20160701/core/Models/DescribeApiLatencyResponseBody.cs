// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160701.Models
{
    public class DescribeApiLatencyResponseBody : TeaModel {
        [NameInMap("Latencys")]
        [Validation(Required=false)]
        public DescribeApiLatencyResponseBodyLatencys Latencys { get; set; }
        public class DescribeApiLatencyResponseBodyLatencys : TeaModel {
            [NameInMap("Latency")]
            [Validation(Required=false)]
            public List<DescribeApiLatencyResponseBodyLatencysLatency> Latency { get; set; }
            public class DescribeApiLatencyResponseBodyLatencysLatency : TeaModel {
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
