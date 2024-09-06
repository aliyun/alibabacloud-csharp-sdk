// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class UpdateWorkflowRequest : TeaModel {
        [NameInMap("alertGroupId")]
        [Validation(Required=false)]
        public string AlertGroupId { get; set; }

        [NameInMap("alertStrategy")]
        [Validation(Required=false)]
        public string AlertStrategy { get; set; }

        [NameInMap("taskDefinitionJsonValue")]
        [Validation(Required=false)]
        public string TaskDefinitionJsonValue { get; set; }

        [NameInMap("taskRelationJsonValue")]
        [Validation(Required=false)]
        public string TaskRelationJsonValue { get; set; }

        [NameInMap("cronExpr")]
        [Validation(Required=false)]
        public string CronExpr { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("executionType")]
        [Validation(Required=false)]
        public string ExecutionType { get; set; }

        [NameInMap("failureStrategy")]
        [Validation(Required=false)]
        public string FailureStrategy { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("parentDirectoryId")]
        [Validation(Required=false)]
        public string ParentDirectoryId { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("scheduleEndTime")]
        [Validation(Required=false)]
        public string ScheduleEndTime { get; set; }

        [NameInMap("scheduleStartTime")]
        [Validation(Required=false)]
        public string ScheduleStartTime { get; set; }

        [NameInMap("scheduleState")]
        [Validation(Required=false)]
        public string ScheduleState { get; set; }

        [NameInMap("taskDefinitionJson")]
        [Validation(Required=false)]
        public string TaskDefinitionJson { get; set; }

        [NameInMap("taskRelationJson")]
        [Validation(Required=false)]
        public string TaskRelationJson { get; set; }

        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        [NameInMap("workflowInstancePriority")]
        [Validation(Required=false)]
        public string WorkflowInstancePriority { get; set; }

        [NameInMap("workflowParams")]
        [Validation(Required=false)]
        public string WorkflowParams { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
