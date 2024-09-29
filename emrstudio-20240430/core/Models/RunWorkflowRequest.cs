// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class RunWorkflowRequest : TeaModel {
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
        /// <para>OFF_MODE</para>
        /// </summary>
        [NameInMap("complementDependentMode")]
        [Validation(Required=false)]
        public string ComplementDependentMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>START_PROCESS</para>
        /// </summary>
        [NameInMap("execType")]
        [Validation(Required=false)]
        public string ExecType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("expectedParallelismNumber")]
        [Validation(Required=false)]
        public string ExpectedParallelismNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>END</para>
        /// </summary>
        [NameInMap("failureStrategy")]
        [Validation(Required=false)]
        public string FailureStrategy { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wg-acfmv4opbs****</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RUN_MODE_PARALLEL</para>
        /// </summary>
        [NameInMap("runMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00,2024-01-02 00:00:00</para>
        /// </summary>
        [NameInMap("scheduleTime")]
        [Validation(Required=false)]
        public string ScheduleTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;:&quot;value1&quot;}</para>
        /// </summary>
        [NameInMap("startParams")]
        [Validation(Required=false)]
        public string StartParams { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>w-3q9jo749ne5****</para>
        /// </summary>
        [NameInMap("workflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("workflowInstancePriority")]
        [Validation(Required=false)]
        public string WorkflowInstancePriority { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
