// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20171120.Models
{
    public class DescribeResourcePackUsageResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Interval")]
        [Validation(Required=true)]
        public long? Interval { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public long? StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=true)]
        public long? EndTime { get; set; }

        [NameInMap("PackUsages")]
        [Validation(Required=true)]
        public List<DescribeResourcePackUsageResponsePackUsages> PackUsages { get; set; }
        public class DescribeResourcePackUsageResponsePackUsages : TeaModel {
            [NameInMap("Traffic")]
            [Validation(Required=true)]
            public float? Traffic { get; set; }

            [NameInMap("Time")]
            [Validation(Required=true)]
            public long? Time { get; set; }

        }

    }

}
