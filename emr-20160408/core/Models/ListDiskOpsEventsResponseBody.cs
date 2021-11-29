// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListDiskOpsEventsResponseBody : TeaModel {
        [NameInMap("EventList")]
        [Validation(Required=false)]
        public ListDiskOpsEventsResponseBodyEventList EventList { get; set; }
        public class ListDiskOpsEventsResponseBodyEventList : TeaModel {
            [NameInMap("DiskOpsEventInfo")]
            [Validation(Required=false)]
            public List<ListDiskOpsEventsResponseBodyEventListDiskOpsEventInfo> DiskOpsEventInfo { get; set; }
            public class ListDiskOpsEventsResponseBodyEventListDiskOpsEventInfo : TeaModel {
                public string ClusterBizId { get; set; }
                public string ClusterName { get; set; }
                public string CurrentActivity { get; set; }
                public string CurrentActivityState { get; set; }
                public string DiskDevice { get; set; }
                public string DiskId { get; set; }
                public string DiskMountPoint { get; set; }
                public string EventId { get; set; }
                public long? EventTriggerTime { get; set; }
                public string EventType { get; set; }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public string InstanceStatus { get; set; }
                public string PrivateIp { get; set; }
                public string RegionId { get; set; }
                public string UserId { get; set; }
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

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
