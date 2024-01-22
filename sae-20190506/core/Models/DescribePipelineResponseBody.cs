// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribePipelineResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. Valid values:
        /// 
        /// *   **2xx**: The call was successful.
        /// *   **3xx**: The call was redirected.
        /// *   **4xx**: The call failed.
        /// *   **5xx**: A server error occurred.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The batch information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribePipelineResponseBodyData Data { get; set; }
        public class DescribePipelineResponseBodyData : TeaModel {
            /// <summary>
            /// The status of the change order for the batch.
            /// </summary>
            [NameInMap("CoStatus")]
            [Validation(Required=false)]
            public string CoStatus { get; set; }

            /// <summary>
            /// The ID of the batch processing stage.
            /// </summary>
            [NameInMap("CurrentStageId")]
            [Validation(Required=false)]
            public string CurrentStageId { get; set; }

            /// <summary>
            /// The ID of the next batch.
            /// </summary>
            [NameInMap("NextPipelineId")]
            [Validation(Required=false)]
            public string NextPipelineId { get; set; }

            /// <summary>
            /// The ID of the batch.
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// The name of the batch.
            /// </summary>
            [NameInMap("PipelineName")]
            [Validation(Required=false)]
            public string PipelineName { get; set; }

            /// <summary>
            /// The batch status. Valid values:
            /// 
            /// *   **0**: The batch is prepared for processing.
            /// *   **1**: The task is being executed.
            /// *   **2**: successful
            /// *   **3**: The processing failed in this stage.
            /// *   **6**: The batch processing was terminated.
            /// *   **10**: The batch could not be processed due to a system exception.
            /// </summary>
            [NameInMap("PipelineStatus")]
            [Validation(Required=false)]
            public int? PipelineStatus { get; set; }

            /// <summary>
            /// Indicates whether to start processing the next batch. Valid values:
            /// 
            /// *   **false**: indicates that the next batch cannot be processed yet.
            /// *   **true**: indicates that the next batch can be processed now.
            /// </summary>
            [NameInMap("ShowBatch")]
            [Validation(Required=false)]
            public bool? ShowBatch { get; set; }

            /// <summary>
            /// The list of batch processing stages.
            /// </summary>
            [NameInMap("StageList")]
            [Validation(Required=false)]
            public List<DescribePipelineResponseBodyDataStageList> StageList { get; set; }
            public class DescribePipelineResponseBodyDataStageList : TeaModel {
                /// <summary>
                /// The execution type of the stage. Valid values:
                /// 
                /// *   **0**: in sequence.
                /// *   **1**: in parallel.
                /// </summary>
                [NameInMap("ExecutorType")]
                [Validation(Required=false)]
                public int? ExecutorType { get; set; }

                /// <summary>
                /// The ID of the stage.
                /// </summary>
                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

                /// <summary>
                /// The name of the stage.
                /// </summary>
                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

                /// <summary>
                /// The status of the batch processing stage. Valid values:
                /// 
                /// *   **0**: The batch is prepared for this processing stage.
                /// *   **1**: The task is being executed.
                /// *   **2**: successful
                /// *   **3**: The processing failed in this stage.
                /// *   **6**: The processing stage was terminated.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The list of task statuses.
                /// </summary>
                [NameInMap("TaskList")]
                [Validation(Required=false)]
                public List<DescribePipelineResponseBodyDataStageListTaskList> TaskList { get; set; }
                public class DescribePipelineResponseBodyDataStageListTaskList : TeaModel {
                    /// <summary>
                    /// The error code returned when the task could not be executed. If the task is successfully executed, this parameter is not returned.
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// Indicates whether to execute the subsequent tasks when the task failed. Valid values:
                    /// 
                    /// *   **0**: The subsequent tasks cannot be executed.
                    /// *   **1**: The subsequent tasks can be executed.
                    /// </summary>
                    [NameInMap("ErrorIgnore")]
                    [Validation(Required=false)]
                    public int? ErrorIgnore { get; set; }

                    /// <summary>
                    /// The error message returned when the task could not be executed. If the task is successfully executed, this parameter is not returned.
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// The returned message indicating the task execution result.
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// Indicates whether a running task can be manually skipped. Valid values:
                    /// 
                    /// *   **true**: The running task can be skipped.
                    /// *   **false**: The zone does not allow you to change the network type of an ApsaraDB for Redis instance from classic network to VPC.
                    /// </summary>
                    [NameInMap("ShowManualIgnore")]
                    [Validation(Required=false)]
                    public bool? ShowManualIgnore { get; set; }

                    /// <summary>
                    /// The ID of the stage.
                    /// </summary>
                    [NameInMap("StageId")]
                    [Validation(Required=false)]
                    public string StageId { get; set; }

                    /// <summary>
                    /// The task status. Valid values:
                    /// 
                    /// *   **0**: The task is prepared for execution.
                    /// *   **1**: The task is being executed.
                    /// *   **2**: successful
                    /// *   **3**: The task could not be executed.
                    /// *   **5**: The task is pending retry.
                    /// *   **6**: The task was terminated.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// The ID of the task.
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                    /// <summary>
                    /// The name of the task.
                    /// </summary>
                    [NameInMap("TaskName")]
                    [Validation(Required=false)]
                    public string TaskName { get; set; }

                }

            }

        }

        /// <summary>
        /// The error code returned if the request failed. Take note of the following rules:
        /// 
        /// *   The **ErrorCode** parameter is not returned if the request succeeds.
        /// *   If the call fails, the **ErrorCode** parameter is returned. For more information, see the "**Error codes**" section of this topic.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The message returned for the operation.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the batch information was obtained. Valid values:
        /// 
        /// *   **true**: The information was queried.
        /// *   **false**: The image failed to be found.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The trace ID that is used to query the details of the request.
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
