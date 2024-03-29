// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        [NameInMap("EventItems")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyEventItems> EventItems { get; set; }
        public class DescribeEventsResponseBodyEventItems : TeaModel {
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            [NameInMap("EventPayload")]
            [Validation(Required=false)]
            public string EventPayload { get; set; }

            [NameInMap("EventReason")]
            [Validation(Required=false)]
            public string EventReason { get; set; }

            [NameInMap("EventRecordTime")]
            [Validation(Required=false)]
            public string EventRecordTime { get; set; }

            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("EventUserType")]
            [Validation(Required=false)]
            public string EventUserType { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
