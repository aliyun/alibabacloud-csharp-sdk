// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ListWorkflowInstanceResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about workflow instances.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWorkflowInstanceResponseBodyData Data { get; set; }
        public class ListWorkflowInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The workflow instances.
            /// </summary>
            [NameInMap("WfInstanceInfos")]
            [Validation(Required=false)]
            public List<ListWorkflowInstanceResponseBodyDataWfInstanceInfos> WfInstanceInfos { get; set; }
            public class ListWorkflowInstanceResponseBodyDataWfInstanceInfos : TeaModel {
                /// <summary>
                /// The data timestamp of the workflow instance.
                /// </summary>
                [NameInMap("DataTime")]
                [Validation(Required=false)]
                public string DataTime { get; set; }

                /// <summary>
                /// The time when the workflow instance stopped running.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The time when the workflow instance was scheduled to run.
                /// </summary>
                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public string ScheduleTime { get; set; }

                /// <summary>
                /// The time when the workflow instance started to run.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The state of the workflow instance. Valid values:
                /// 
                /// *   1: pending
                /// *   2: preparing
                /// *   3: running
                /// *   4: successful
                /// *   5: failed
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The workflow instance ID.
                /// </summary>
                [NameInMap("WfInstanceId")]
                [Validation(Required=false)]
                public long? WfInstanceId { get; set; }

                /// <summary>
                /// The workflow ID.
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public long? WorkflowId { get; set; }

            }

        }

        /// <summary>
        /// The returned error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
