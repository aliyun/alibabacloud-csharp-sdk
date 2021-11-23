// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAvailableTimeRangeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public DescribeAvailableTimeRangeResponseBodyTimeRange TimeRange { get; set; }
        public class DescribeAvailableTimeRangeResponseBodyTimeRange : TeaModel {
            [NameInMap("TimeRange")]
            [Validation(Required=false)]
            public List<DescribeAvailableTimeRangeResponseBodyTimeRangeTimeRange> TimeRange { get; set; }
            public class DescribeAvailableTimeRangeResponseBodyTimeRangeTimeRange : TeaModel {
                public string EndTime { get; set; }
                public string NodeId { get; set; }
                public string StartTime { get; set; }
                public string Status { get; set; }
                public string TaskId { get; set; }
            }
        };

    }

}
