// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetOptimizeRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of executed attempts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("attemptCount")]
        [Validation(Required=false)]
        public int? AttemptCount { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-12T10:00:00Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The current execution stage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>attribution</para>
        /// </summary>
        [NameInMap("currentStage")]
        [Validation(Required=false)]
        public string CurrentStage { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The optimize run failed.</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The type-related information and immutable result references. For efficiency analysis, frozen outputBindings and tokenPublication release receipts are returned.</para>
        /// </summary>
        [NameInMap("extra")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extra { get; set; }

        /// <summary>
        /// <para>The completion time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-12T10:01:00Z</para>
        /// </summary>
        [NameInMap("finishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The maximum number of attempts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("maxAttempts")]
        [Validation(Required=false)]
        public int? MaxAttempts { get; set; }

        /// <summary>
        /// <para>The ID of the execution instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>or-20260812-0001</para>
        /// </summary>
        [NameInMap("optimizeRunId")]
        [Validation(Required=false)]
        public string OptimizeRunId { get; set; }

        /// <summary>
        /// <para>The name of the optimization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>efficiency-analysis</para>
        /// </summary>
        [NameInMap("optimizeTaskName")]
        [Validation(Required=false)]
        public string OptimizeTaskName { get; set; }

        /// <summary>
        /// <para>The current execution progress. The fields are defined by the task type.</para>
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public Dictionary<string, object> Progress { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The initial start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-12T10:00:01Z</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The execution status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of analysis trajectories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("trajectoryCount")]
        [Validation(Required=false)]
        public long? TrajectoryCount { get; set; }

        /// <summary>
        /// <para>The trigger type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduled</para>
        /// </summary>
        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        /// <summary>
        /// <para>The task type snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EfficiencyAnalysis</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The end time of the analysis window, in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1786432690000</para>
        /// </summary>
        [NameInMap("windowEndTime")]
        [Validation(Required=false)]
        public long? WindowEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the analysis window, in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1786432688000</para>
        /// </summary>
        [NameInMap("windowStartTime")]
        [Validation(Required=false)]
        public long? WindowStartTime { get; set; }

    }

}
