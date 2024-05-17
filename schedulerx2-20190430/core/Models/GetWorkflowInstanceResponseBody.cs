// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetWorkflowInstanceResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The details of the workflow instance.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkflowInstanceResponseBodyData Data { get; set; }
        public class GetWorkflowInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The directed acyclic graph (DAG) of the workflow instance, including job instances and dependencies.
            /// </summary>
            [NameInMap("WfInstanceDag")]
            [Validation(Required=false)]
            public GetWorkflowInstanceResponseBodyDataWfInstanceDag WfInstanceDag { get; set; }
            public class GetWorkflowInstanceResponseBodyDataWfInstanceDag : TeaModel {
                /// <summary>
                /// The dependencies between job instances.
                /// </summary>
                [NameInMap("Edges")]
                [Validation(Required=false)]
                public List<GetWorkflowInstanceResponseBodyDataWfInstanceDagEdges> Edges { get; set; }
                public class GetWorkflowInstanceResponseBodyDataWfInstanceDagEdges : TeaModel {
                    /// <summary>
                    /// The upstream job instance of the current job instance. The value 0 indicates that the upstream job instance is the root node.
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public long? Source { get; set; }

                    /// <summary>
                    /// The downstream job instance of the current job instance.
                    /// </summary>
                    [NameInMap("Target")]
                    [Validation(Required=false)]
                    public long? Target { get; set; }

                }

                /// <summary>
                /// The job instances.
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<GetWorkflowInstanceResponseBodyDataWfInstanceDagNodes> Nodes { get; set; }
                public class GetWorkflowInstanceResponseBodyDataWfInstanceDagNodes : TeaModel {
                    /// <summary>
                    /// The number of retries when the job instance failed.
                    /// </summary>
                    [NameInMap("Attempt")]
                    [Validation(Required=false)]
                    public int? Attempt { get; set; }

                    /// <summary>
                    /// The data timestamp of the job instance.
                    /// </summary>
                    [NameInMap("DataTime")]
                    [Validation(Required=false)]
                    public string DataTime { get; set; }

                    /// <summary>
                    /// The time when the job instance stopped running.
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// The job ID.
                    /// </summary>
                    [NameInMap("JobId")]
                    [Validation(Required=false)]
                    public long? JobId { get; set; }

                    /// <summary>
                    /// The job instance ID.
                    /// </summary>
                    [NameInMap("JobInstanceId")]
                    [Validation(Required=false)]
                    public long? JobInstanceId { get; set; }

                    [NameInMap("JobName")]
                    [Validation(Required=false)]
                    public string JobName { get; set; }

                    /// <summary>
                    /// The state of the job instance.
                    /// </summary>
                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    /// <summary>
                    /// The time when the job instance was scheduled to run.
                    /// </summary>
                    [NameInMap("ScheduleTime")]
                    [Validation(Required=false)]
                    public string ScheduleTime { get; set; }

                    /// <summary>
                    /// The time when the job instance started to run.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// The server on which the job instance was run.
                    /// </summary>
                    [NameInMap("WorkAddr")]
                    [Validation(Required=false)]
                    public string WorkAddr { get; set; }

                }

            }

            /// <summary>
            /// The details of the workflow instance, including the state of the workflow instance, the time when the workflow instance started to run, the time when the workflow instance stopped running, the state of each job instance, and the dependencies between job instances.
            /// </summary>
            [NameInMap("WfInstanceInfo")]
            [Validation(Required=false)]
            public GetWorkflowInstanceResponseBodyDataWfInstanceInfo WfInstanceInfo { get; set; }
            public class GetWorkflowInstanceResponseBodyDataWfInstanceInfo : TeaModel {
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
