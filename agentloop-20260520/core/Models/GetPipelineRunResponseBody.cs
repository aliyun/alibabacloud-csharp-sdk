// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetPipelineRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the AgentSpace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-space</para>
        /// </summary>
        [NameInMap("agentSpaceName")]
        [Validation(Required=false)]
        public string AgentSpaceName { get; set; }

        /// <summary>
        /// <para>The list of asynchronous node execution statuses.</para>
        /// </summary>
        [NameInMap("asyncNodes")]
        [Validation(Required=false)]
        public List<GetPipelineRunResponseBodyAsyncNodes> AsyncNodes { get; set; }
        public class GetPipelineRunResponseBodyAsyncNodes : TeaModel {
            /// <summary>
            /// <para>The number of execution attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("attempt")]
            [Validation(Required=false)]
            public int? Attempt { get; set; }

            /// <summary>
            /// <para>The external task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hs-001</para>
            /// </summary>
            [NameInMap("externalTaskId")]
            [Validation(Required=false)]
            public string ExternalTaskId { get; set; }

            /// <summary>
            /// <para>The number of failed records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("failedCount")]
            [Validation(Required=false)]
            public long? FailedCount { get; set; }

            /// <summary>
            /// <para>The number of consumed input tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("inputTokens")]
            [Validation(Required=false)]
            public long? InputTokens { get; set; }

            /// <summary>
            /// <para>The number of ready work items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("itemReadyCount")]
            [Validation(Required=false)]
            public long? ItemReadyCount { get; set; }

            /// <summary>
            /// <para>The latest error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-error</para>
            /// </summary>
            [NameInMap("lastError")]
            [Validation(Required=false)]
            public string LastError { get; set; }

            /// <summary>
            /// <para>The node execution ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ne-001</para>
            /// </summary>
            [NameInMap("nodeExecutionId")]
            [Validation(Required=false)]
            public string NodeExecutionId { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stage-1</para>
            /// </summary>
            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The node type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>annotation</para>
            /// </summary>
            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The number of consumed output tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("outputTokens")]
            [Validation(Required=false)]
            public long? OutputTokens { get; set; }

            /// <summary>
            /// <para>The total number of records in the stage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("recordCount")]
            [Validation(Required=false)]
            public long? RecordCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the node has been routed to the downstream stage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("routed")]
            [Validation(Required=false)]
            public bool? Routed { get; set; }

            /// <summary>
            /// <para>The latest signal type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STAGE_COMPLETED</para>
            /// </summary>
            [NameInMap("signalType")]
            [Validation(Required=false)]
            public string SignalType { get; set; }

            /// <summary>
            /// <para>The number of start attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("startAttempts")]
            [Validation(Required=false)]
            public int? StartAttempts { get; set; }

            /// <summary>
            /// <para>The asynchronous node status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WAITING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("taskVersion")]
            [Validation(Required=false)]
            public int? TaskVersion { get; set; }

            /// <summary>
            /// <para>The total number of consumed tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1500</para>
            /// </summary>
            [NameInMap("totalTokens")]
            [Validation(Required=false)]
            public long? TotalTokens { get; set; }

        }

        /// <summary>
        /// <para>The current number of retries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("attempt")]
        [Validation(Required=false)]
        public int? Attempt { get; set; }

        /// <summary>
        /// <para>The semantic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ExpressionEvaluationError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed to evaluate filter expression in node &quot;node-1&quot;: column &quot;score&quot; does not exist.</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The end time in ISO 8601 UTC format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:10.000Z</para>
        /// </summary>
        [NameInMap("finishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The start time of the data window in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735660800</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <para>The maximum number of retries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("maxAttempts")]
        [Validation(Required=false)]
        public int? MaxAttempts { get; set; }

        /// <summary>
        /// <para>The next retry time in ISO 8601 UTC format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:01:00.000Z</para>
        /// </summary>
        [NameInMap("nextRetryTime")]
        [Validation(Required=false)]
        public string NextRetryTime { get; set; }

        /// <summary>
        /// <para>The list of node execution records.</para>
        /// </summary>
        [NameInMap("nodeExecutions")]
        [Validation(Required=false)]
        public List<GetPipelineRunResponseBodyNodeExecutions> NodeExecutions { get; set; }
        public class GetPipelineRunResponseBodyNodeExecutions : TeaModel {
            /// <summary>
            /// <para>The number of execution attempts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("attempt")]
            [Validation(Required=false)]
            public int? Attempt { get; set; }

            /// <summary>
            /// <para>The completion event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>evt-001</para>
            /// </summary>
            [NameInMap("completionEventId")]
            [Validation(Required=false)]
            public string CompletionEventId { get; set; }

            /// <summary>
            /// <para>The node error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>StageFailed</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The node error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stage execution failed</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The external task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hs-001</para>
            /// </summary>
            [NameInMap("externalTaskId")]
            [Validation(Required=false)]
            public string ExternalTaskId { get; set; }

            /// <summary>
            /// <para>The node end time.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:10Z</para>
            /// </summary>
            [NameInMap("finishedAtTime")]
            [Validation(Required=false)]
            public string FinishedAtTime { get; set; }

            /// <summary>
            /// <para>The number of input records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("inputCount")]
            [Validation(Required=false)]
            public long? InputCount { get; set; }

            /// <summary>
            /// <para>The node input data reference.</para>
            /// </summary>
            [NameInMap("inputRef")]
            [Validation(Required=false)]
            public GetPipelineRunResponseBodyNodeExecutionsInputRef InputRef { get; set; }
            public class GetPipelineRunResponseBodyNodeExecutionsInputRef : TeaModel {
                /// <summary>
                /// <para>The immutable data boundary identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("boundary")]
                [Validation(Required=false)]
                public string Boundary { get; set; }

                /// <summary>
                /// <para>The data digest.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sha256:abcdef</para>
                /// </summary>
                [NameInMap("digest")]
                [Validation(Required=false)]
                public string Digest { get; set; }

                /// <summary>
                /// <para>The reference data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataset</para>
                /// </summary>
                [NameInMap("kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para>The data owner identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890123456</para>
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The data resource identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataset-001</para>
                /// </summary>
                [NameInMap("resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

                /// <summary>
                /// <para>The data schema version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("schemaVersion")]
                [Validation(Required=false)]
                public string SchemaVersion { get; set; }

            }

            /// <summary>
            /// <para>The node execution mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASYNC</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The node execution ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ne-001</para>
            /// </summary>
            [NameInMap("nodeExecutionId")]
            [Validation(Required=false)]
            public string NodeExecutionId { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stage-1</para>
            /// </summary>
            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The node type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>annotation</para>
            /// </summary>
            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The node execution order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// <para>The number of output records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("outputCount")]
            [Validation(Required=false)]
            public long? OutputCount { get; set; }

            /// <summary>
            /// <para>The node output data reference.</para>
            /// </summary>
            [NameInMap("outputRef")]
            [Validation(Required=false)]
            public GetPipelineRunResponseBodyNodeExecutionsOutputRef OutputRef { get; set; }
            public class GetPipelineRunResponseBodyNodeExecutionsOutputRef : TeaModel {
                /// <summary>
                /// <para>The immutable data boundary identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("boundary")]
                [Validation(Required=false)]
                public string Boundary { get; set; }

                /// <summary>
                /// <para>The data digest.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sha256:abcdef</para>
                /// </summary>
                [NameInMap("digest")]
                [Validation(Required=false)]
                public string Digest { get; set; }

                /// <summary>
                /// <para>The reference data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataset</para>
                /// </summary>
                [NameInMap("kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para>The data owner identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567890123456</para>
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The data resource identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataset-001</para>
                /// </summary>
                [NameInMap("resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

                /// <summary>
                /// <para>The data schema version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("schemaVersion")]
                [Validation(Required=false)]
                public string SchemaVersion { get; set; }

            }

            /// <summary>
            /// <para>The output start resource identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataset-001</para>
            /// </summary>
            [NameInMap("outputStartResource")]
            [Validation(Required=false)]
            public string OutputStartResource { get; set; }

            /// <summary>
            /// <para>The output start sequence number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("outputStartSeq")]
            [Validation(Required=false)]
            public long? OutputStartSeq { get; set; }

            /// <summary>
            /// <para>The run ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>run-20260101-0001</para>
            /// </summary>
            [NameInMap("runId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <para>The node start time.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:01Z</para>
            /// </summary>
            [NameInMap("startedAtTime")]
            [Validation(Required=false)]
            public string StartedAtTime { get; set; }

            /// <summary>
            /// <para>The node execution status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WAITING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("taskVersion")]
            [Validation(Required=false)]
            public int? TaskVersion { get; set; }

        }

        /// <summary>
        /// <para>The name of the pipeline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-pipeline</para>
        /// </summary>
        [NameInMap("pipelineName")]
        [Validation(Required=false)]
        public string PipelineName { get; set; }

        /// <summary>
        /// <para>The frozen pipeline configuration snapshot for this run.</para>
        /// </summary>
        [NameInMap("pipelineSnapshot")]
        [Validation(Required=false)]
        public GetPipelineRunResponseBodyPipelineSnapshot PipelineSnapshot { get; set; }
        public class GetPipelineRunResponseBodyPipelineSnapshot : TeaModel {
            /// <summary>
            /// <para>The list of frozen orchestration nodes.</para>
            /// </summary>
            [NameInMap("nodes")]
            [Validation(Required=false)]
            public List<GetPipelineRunResponseBodyPipelineSnapshotNodes> Nodes { get; set; }
            public class GetPipelineRunResponseBodyPipelineSnapshotNodes : TeaModel {
                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>stage-1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The node parameters in a key-value structure, which vary depending on the node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;stageId&quot;:&quot;stage-1&quot;}</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                /// <summary>
                /// <para>The node path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/stage-1</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>annotation</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID used to locate the request during troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The inline run results. This parameter is returned only when output.inline is set to true during triggering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;outputRows&quot;: 100, &quot;summary&quot;: &quot;processed 100 rows, 92 matched&quot;, &quot;passed&quot;: true}</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public Dictionary<string, object> Results { get; set; }

        /// <summary>
        /// <para>Run Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>run-20260101-0001</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <para>The execution start time in ISO 8601 UTC format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:01.000Z</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The run statistics, including processedRows (number of processed rows), processedBytes (number of processed bytes), outputRows (number of output rows), outputBytes (number of output bytes), elapsedMs (elapsed time in milliseconds), cpuSec (CPU seconds), cpuCores (number of CPU cores), and tokenCount (number of consumed tokens).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;processedRows&quot;:1000,&quot;elapsedMs&quot;:2500}</para>
        /// </summary>
        [NameInMap("stats")]
        [Validation(Required=false)]
        public Dictionary<string, object> Stats { get; set; }

        /// <summary>
        /// <para>The run status. Valid values: Pending, Running, Succeeded, Failed, and Cancelled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The frozen task version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("taskVersion")]
        [Validation(Required=false)]
        public int? TaskVersion { get; set; }

        /// <summary>
        /// <para>The end time of the data window in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735747200</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

        /// <summary>
        /// <para>The total number of input records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The trigger time in ISO 8601 UTC format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00.000Z</para>
        /// </summary>
        [NameInMap("triggerTime")]
        [Validation(Required=false)]
        public string TriggerTime { get; set; }

        /// <summary>
        /// <para>The trigger type. Valid values: Scheduled, Manual, and RunOnce.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduled</para>
        /// </summary>
        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
