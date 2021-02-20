// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcChannelMetricsResponseBody : TeaModel {
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<DescribeRtcChannelMetricsResponseBodyMetrics> Metrics { get; set; }
        public class DescribeRtcChannelMetricsResponseBodyMetrics : TeaModel {
            [NameInMap("Mid")]
            [Validation(Required=false)]
            public string Mid { get; set; }

            [NameInMap("KVs")]
            [Validation(Required=false)]
            public List<string> KVs { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
