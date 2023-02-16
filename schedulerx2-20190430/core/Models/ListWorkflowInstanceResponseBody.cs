// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ListWorkflowInstanceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWorkflowInstanceResponseBodyData Data { get; set; }
        public class ListWorkflowInstanceResponseBodyData : TeaModel {
            [NameInMap("WfInstanceInfos")]
            [Validation(Required=false)]
            public List<ListWorkflowInstanceResponseBodyDataWfInstanceInfos> WfInstanceInfos { get; set; }
            public class ListWorkflowInstanceResponseBodyDataWfInstanceInfos : TeaModel {
                [NameInMap("DataTime")]
                [Validation(Required=false)]
                public string DataTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public string ScheduleTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("WfInstanceId")]
                [Validation(Required=false)]
                public long? WfInstanceId { get; set; }

                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public long? WorkflowId { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
