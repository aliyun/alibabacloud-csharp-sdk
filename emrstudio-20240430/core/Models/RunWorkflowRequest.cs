// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class RunWorkflowRequest : TeaModel {
        [NameInMap("alertGroupId")]
        [Validation(Required=false)]
        public string AlertGroupId { get; set; }

        [NameInMap("alertStrategy")]
        [Validation(Required=false)]
        public string AlertStrategy { get; set; }

        [NameInMap("complementDependentMode")]
        [Validation(Required=false)]
        public string ComplementDependentMode { get; set; }

        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        [NameInMap("execType")]
        [Validation(Required=false)]
        public string ExecType { get; set; }

        [NameInMap("expectedParallelismNumber")]
        [Validation(Required=false)]
        public string ExpectedParallelismNumber { get; set; }

        [NameInMap("failureStrategy")]
        [Validation(Required=false)]
        public string FailureStrategy { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("runMode")]
        [Validation(Required=false)]
        public string RunMode { get; set; }

        [NameInMap("scheduleTime")]
        [Validation(Required=false)]
        public string ScheduleTime { get; set; }

        [NameInMap("startParams")]
        [Validation(Required=false)]
        public string StartParams { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("workflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

        [NameInMap("workflowInstancePriority")]
        [Validation(Required=false)]
        public string WorkflowInstancePriority { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
