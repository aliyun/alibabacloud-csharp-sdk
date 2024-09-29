// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class CreateWorkflowRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ag-v7n2gp3vv3j****</para>
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

        [NameInMap("taskDefinitionJsonValue")]
        [Validation(Required=false)]
        public string TaskDefinitionJsonValue { get; set; }

        [NameInMap("taskRelationJsonValue")]
        [Validation(Required=false)]
        public string TaskRelationJsonValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0 0 * * * ? *</para>
        /// </summary>
        [NameInMap("cronExpr")]
        [Validation(Required=false)]
        public string CronExpr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PARALLEL</para>
        /// </summary>
        [NameInMap("executionType")]
        [Validation(Required=false)]
        public string ExecutionType { get; set; }

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
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wd-v7n2gp3vv3j****</para>
        /// </summary>
        [NameInMap("parentDirectoryId")]
        [Validation(Required=false)]
        public string ParentDirectoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wg-acfmv4opbs****</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("scheduleEndTime")]
        [Validation(Required=false)]
        public string ScheduleEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("scheduleStartTime")]
        [Validation(Required=false)]
        public string ScheduleStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OFFLINE</para>
        /// </summary>
        [NameInMap("scheduleState")]
        [Validation(Required=false)]
        public string ScheduleState { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;taskId&quot;:&quot;t1&quot;,&quot;name&quot;:&quot;t1&quot;,&quot;taskParams&quot;:{&quot;rawScript&quot;:&quot;echo 1&quot;},&quot;taskType&quot;:&quot;SHELL&quot;}]</para>
        /// </summary>
        [NameInMap("taskDefinitionJson")]
        [Validation(Required=false)]
        public string TaskDefinitionJson { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;preTaskId&quot;:&quot;0&quot;, &quot;postTaskId&quot;:&quot;t1&quot;}]</para>
        /// </summary>
        [NameInMap("taskRelationJson")]
        [Validation(Required=false)]
        public string TaskRelationJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("workflowInstancePriority")]
        [Validation(Required=false)]
        public string WorkflowInstancePriority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;prop&quot;:&quot;key1&quot;,&quot;value&quot;:&quot;value1&quot;}]</para>
        /// </summary>
        [NameInMap("workflowParams")]
        [Validation(Required=false)]
        public string WorkflowParams { get; set; }

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
