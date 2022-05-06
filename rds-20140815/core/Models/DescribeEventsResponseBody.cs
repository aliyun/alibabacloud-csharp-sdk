// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        [NameInMap("EventItems")]
        [Validation(Required=false)]
        public DescribeEventsResponseBodyEventItems EventItems { get; set; }
        public class DescribeEventsResponseBodyEventItems : TeaModel {
            [NameInMap("EventItems")]
            [Validation(Required=false)]
            public List<DescribeEventsResponseBodyEventItemsEventItems> EventItems { get; set; }
            public class DescribeEventsResponseBodyEventItemsEventItems : TeaModel {
                public long? CallerUid { get; set; }
                public int? EventId { get; set; }
                public string EventName { get; set; }
                public string EventPayload { get; set; }
                public string EventReason { get; set; }
                public string EventRecordTime { get; set; }
                public string EventTime { get; set; }
                public string EventType { get; set; }
                public string EventUserType { get; set; }
                public string RegionId { get; set; }
                public string ResourceName { get; set; }
                public string ResourceType { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
