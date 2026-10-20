// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class AnalysisTask : TeaModel {
        /// <summary>
        /// <para>The task completion time as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1789747260000</para>
        /// </summary>
        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public long? CompletedAt { get; set; }

        /// <summary>
        /// <para>The task creation time as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1789747200000</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The error code for the task failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NO_VALID_ATTRIBUTION_LABEL</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message for the task failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>No valid attribution label was found</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The generated analysis report. This field is typically not returned by list operations.</para>
        /// </summary>
        [NameInMap("report")]
        [Validation(Required=false)]
        public Dictionary<string, object> Report { get; set; }

        /// <summary>
        /// <para>The number of evaluation details selected by the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("selectedCount")]
        [Validation(Required=false)]
        public int? SelectedCount { get; set; }

        /// <summary>
        /// <para>The task status. Valid values: PENDING, RUNNING, SUCCEEDED, PARTIAL_SUCCEEDED, and FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCEEDED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The analysis task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>analysis-task-8b36f2e2b1f94f9c91ce7a4b0f6d9c25</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The analysis task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Low-score sample attribution analysis</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The analysis task type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ATTRIBUTION_SUMMARY</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
