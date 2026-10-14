// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetOptimizeRunResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("attemptCount")]
        [Validation(Required=false)]
        public int? AttemptCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-12T10:00:00Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>attribution</para>
        /// </summary>
        [NameInMap("currentStage")]
        [Validation(Required=false)]
        public string CurrentStage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The optimize run failed.</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extra { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-12T10:01:00Z</para>
        /// </summary>
        [NameInMap("finishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("maxAttempts")]
        [Validation(Required=false)]
        public int? MaxAttempts { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>or-20260812-0001</para>
        /// </summary>
        [NameInMap("optimizeRunId")]
        [Validation(Required=false)]
        public string OptimizeRunId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>efficiency-analysis</para>
        /// </summary>
        [NameInMap("optimizeTaskName")]
        [Validation(Required=false)]
        public string OptimizeTaskName { get; set; }

        [NameInMap("progress")]
        [Validation(Required=false)]
        public Dictionary<string, object> Progress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-08-12T10:00:01Z</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("trajectoryCount")]
        [Validation(Required=false)]
        public long? TrajectoryCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Scheduled</para>
        /// </summary>
        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EfficiencyAnalysis</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1786432690000</para>
        /// </summary>
        [NameInMap("windowEndTime")]
        [Validation(Required=false)]
        public long? WindowEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1786432688000</para>
        /// </summary>
        [NameInMap("windowStartTime")]
        [Validation(Required=false)]
        public long? WindowStartTime { get; set; }

    }

}
