// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListPipelineRunsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page specified in the request. This value is echoed back.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page. An empty string indicates that the current page is the last page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg5MA==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of pipeline runs.</para>
        /// </summary>
        [NameInMap("runs")]
        [Validation(Required=false)]
        public List<ListPipelineRunsResponseBodyRuns> Runs { get; set; }
        public class ListPipelineRunsResponseBodyRuns : TeaModel {
            /// <summary>
            /// <para>The name of the AgentSpace to which the run belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent-space</para>
            /// </summary>
            [NameInMap("agentSpaceName")]
            [Validation(Required=false)]
            public string AgentSpaceName { get; set; }

            /// <summary>
            /// <para>The current retry count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("attempt")]
            [Validation(Required=false)]
            public int? Attempt { get; set; }

            /// <summary>
            /// <para>The semantic error code.</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The finish time in ISO 8601 UTC format.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-01T00:00:10.000Z</para>
            /// </summary>
            [NameInMap("finishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The start of the data window, in UNIX seconds.</para>
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
            /// <para>The name of the pipeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-pipeline</para>
            /// </summary>
            [NameInMap("pipelineName")]
            [Validation(Required=false)]
            public string PipelineName { get; set; }

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
            /// <para>The run statistics, including processedRows (number of processed rows), processedBytes (number of processed bytes), outputRows (number of output rows), outputBytes (number of output bytes), elapsedMs (elapsed time in milliseconds), cpuSec (CPU seconds), cpuCores (number of CPU cores), and tokenCount (number of tokens consumed).</para>
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
            /// <para>The end of the data window, in UNIX seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735747200</para>
            /// </summary>
            [NameInMap("toTime")]
            [Validation(Required=false)]
            public long? ToTime { get; set; }

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

        /// <summary>
        /// <para>The total number of pipeline runs that match the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
