// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventAttributeResponseBody : TeaModel {
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

        [NameInMap("SystemEvents")]
        [Validation(Required=false)]
        public DescribeSystemEventAttributeResponseBodySystemEvents SystemEvents { get; set; }
        public class DescribeSystemEventAttributeResponseBodySystemEvents : TeaModel {
            [NameInMap("SystemEvent")]
            [Validation(Required=false)]
            public List<DescribeSystemEventAttributeResponseBodySystemEventsSystemEvent> SystemEvent { get; set; }
            public class DescribeSystemEventAttributeResponseBodySystemEventsSystemEvent : TeaModel {
                public string Content { get; set; }
                public string GroupId { get; set; }
                public string InstanceName { get; set; }
                public string Level { get; set; }
                public string Name { get; set; }
                public string Product { get; set; }
                public string RegionId { get; set; }
                public string ResourceId { get; set; }
                public string Status { get; set; }
                public long? Time { get; set; }
            }
        };

    }

}
