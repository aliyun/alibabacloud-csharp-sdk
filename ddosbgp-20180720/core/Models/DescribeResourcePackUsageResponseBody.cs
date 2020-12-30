// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeResourcePackUsageResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PackUsages")]
        [Validation(Required=false)]
        public List<DescribeResourcePackUsageResponseBodyPackUsages> PackUsages { get; set; }
        public class DescribeResourcePackUsageResponseBodyPackUsages : TeaModel {
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("Traffic")]
            [Validation(Required=false)]
            public float? Traffic { get; set; }

        }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

    }

}
