// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListFlowInstanceResponseBody : TeaModel {
        [NameInMap("FlowInstances")]
        [Validation(Required=false)]
        public ListFlowInstanceResponseBodyFlowInstances FlowInstances { get; set; }
        public class ListFlowInstanceResponseBodyFlowInstances : TeaModel {
            [NameInMap("FlowInstance")]
            [Validation(Required=false)]
            public List<ListFlowInstanceResponseBodyFlowInstancesFlowInstance> FlowInstance { get; set; }
            public class ListFlowInstanceResponseBodyFlowInstancesFlowInstance : TeaModel {
                public string ClusterId { get; set; }
                public long? Duration { get; set; }
                public long? EndTime { get; set; }
                public string FlowId { get; set; }
                public string FlowName { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public bool? HasNodeFailed { get; set; }
                public string Id { get; set; }
                public string Owner { get; set; }
                public string ProjectId { get; set; }
                public long? ScheduleTime { get; set; }
                public long? StartTime { get; set; }
                public string Status { get; set; }
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

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
