// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class DescribeWorkflowInstanceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ag-n72kong0832****</para>
        /// </summary>
        [NameInMap("alertGroupId")]
        [Validation(Required=false)]
        public string AlertGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("alertStrategy")]
        [Validation(Required=false)]
        public string AlertStrategy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c-047fa6bbe732****</para>
        /// </summary>
        [NameInMap("emrClusterId")]
        [Validation(Required=false)]
        public string EmrClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-03-27 00:00:00</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>END</para>
        /// </summary>
        [NameInMap("failureStrategy")]
        [Validation(Required=false)]
        public string FailureStrategy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isComplementData")]
        [Validation(Required=false)]
        public bool? IsComplementData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workflow_instance_name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wg-susqimrr649x****</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-03-27 00:00:00</para>
        /// </summary>
        [NameInMap("restartTime")]
        [Validation(Required=false)]
        public string RestartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("runTimes")]
        [Validation(Required=false)]
        public int? RunTimes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-03-27 00:00:00</para>
        /// </summary>
        [NameInMap("scheduleTime")]
        [Validation(Required=false)]
        public string ScheduleTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-03-27 00:00:00</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>w-3q9jo749ne5****</para>
        /// </summary>
        [NameInMap("workflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wi-3q9jo749ne5****</para>
        /// </summary>
        [NameInMap("workflowInstanceId")]
        [Validation(Required=false)]
        public string WorkflowInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("workflowInstancePriority")]
        [Validation(Required=false)]
        public string WorkflowInstancePriority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("workflowVersion")]
        [Validation(Required=false)]
        public int? WorkflowVersion { get; set; }

    }

}
