// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventCountResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("SystemEventCounts")]
        [Validation(Required=false)]
        public DescribeSystemEventCountResponseBodySystemEventCounts SystemEventCounts { get; set; }
        public class DescribeSystemEventCountResponseBodySystemEventCounts : TeaModel {
            [NameInMap("SystemEventCount")]
            [Validation(Required=false)]
            public List<DescribeSystemEventCountResponseBodySystemEventCountsSystemEventCount> SystemEventCount { get; set; }
            public class DescribeSystemEventCountResponseBodySystemEventCountsSystemEventCount : TeaModel {
                public string Status { get; set; }
                public long? Time { get; set; }
                public string GroupId { get; set; }
                public string Product { get; set; }
                public string InstanceName { get; set; }
                public long? Num { get; set; }
                public string ResourceId { get; set; }
                public string Name { get; set; }
                public string Content { get; set; }
                public string Level { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
