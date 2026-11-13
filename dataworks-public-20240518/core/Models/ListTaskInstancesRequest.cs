// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListTaskInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The business date. Typically, this is 00:00:00 of the day before the scheduled time of the scheduled instance, in the format of a millisecond-level timestamp, such as 1743350400000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("Bizdate")]
        [Validation(Required=false)]
        public long? Bizdate { get; set; }

        /// <summary>
        /// <para>The filter conditions. The value must be in JSON format. Multiple filter conditions are connected by the logical AND operator. Supported fields: <c>startedTimeStart</c>, <c>startedTimeEnd</c>, <c>finishedTimeStart</c>, <c>finishedTimeEnd</c>, <c>createTimeStart</c>, and <c>createTimeEnd</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;startedTimeStart&quot;: &quot;1763481600000&quot;,
        ///     &quot;startedTimeEnd&quot;: &quot;1763481600000&quot;,
        ///     &quot;finishedTimeStart&quot;: &quot;1763481600000&quot;,
        ///     &quot;finishedTimeEnd&quot;: &quot;1763481600000&quot;,
        ///     &quot;createTimeStart&quot;: &quot;1763481600000&quot;,
        ///     &quot;createTimeEnd&quot;: &quot;1763481600000&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The task instance ID. Task instances may be rerun. If you specify this parameter, the response includes historical information about reruns. Each piece of historical information is distinguished by RunNumber.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The list of task instance IDs. You can use this parameter to query multiple task instances in batches based on task instance IDs.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<long?> Ids { get; set; }

        /// <summary>
        /// <para>The account ID of the task owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The project environment.</para>
        /// <list type="bullet">
        /// <item><description>Prod: Production.</description></item>
        /// <item><description>Dev: Development.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The resource group information. Specify the identifier of the scheduling resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public string RuntimeResource { get; set; }

        /// <summary>
        /// <para>The sort field. Fields such as scheduled time and start time are supported. The format is &quot;Sort field + Sort order (Desc/Asc)&quot; (Asc can be omitted). The valid values for the sort field are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><c>TriggerTime (Desc/Asc)</c></para>
        /// </description></item>
        /// <item><description><para><c>StartedTime (Desc/Asc)</c></para>
        /// </description></item>
        /// <item><description><para><c>FinishedTime (Desc/Asc)</c></para>
        /// </description></item>
        /// <item><description><para><c>CreateTime (Desc/Asc)</c></para>
        /// </description></item>
        /// <item><description><para><c>Id (Desc/Asc)</c></para>
        /// <para>Default value: <c>Id Desc</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Id Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The status of the task instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>NotRun</c>: Not run.</description></item>
        /// <item><description><c>Running</c>: Running.</description></item>
        /// <item><description><c>Failure</c>: Failed.</description></item>
        /// <item><description><c>Success</c>: Successful.</description></item>
        /// <item><description><c>WaitTime</c>: Waiting for scheduled time.</description></item>
        /// <item><description><c>WaitResource</c>: Waiting for resources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The list of task IDs. You can use this parameter to query task instances in batches based on task IDs.</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<long?> TaskIds { get; set; }

        /// <summary>
        /// <para>The name of the task. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQL node</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The task type. For the valid values of TaskType for different nodes, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks nodes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ODPS_SQL</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The running mode upon triggering. This parameter takes effect only when TriggerType is set to Scheduler.</para>
        /// <list type="bullet">
        /// <item><description>Pause: Paused.</description></item>
        /// <item><description>Skip: Dry run.</description></item>
        /// <item><description>Normal: Normal execution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("TriggerRecurrence")]
        [Validation(Required=false)]
        public string TriggerRecurrence { get; set; }

        /// <summary>
        /// <para>The trigger type.</para>
        /// <list type="bullet">
        /// <item><description>Scheduler: Triggered by periodic scheduling.</description></item>
        /// <item><description>Manual: Triggered manually.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduler</para>
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        /// <summary>
        /// <para>The unified workflow instance ID. The value of this field is the same for all task instances within a specific business date under a single trigger.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("UnifiedWorkflowInstanceId")]
        [Validation(Required=false)]
        public long? UnifiedWorkflowInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the workflow to which the task belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public long? WorkflowId { get; set; }

        /// <summary>
        /// <para>The ID of the workflow instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("WorkflowInstanceId")]
        [Validation(Required=false)]
        public long? WorkflowInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the workflow instance.</para>
        /// <list type="bullet">
        /// <item><description>SmokeTest: Test.</description></item>
        /// <item><description>Manual: Manual task.</description></item>
        /// <item><description>SupplementData: Data backfill.</description></item>
        /// <item><description>ManualWorkflow: Manual workflow.</description></item>
        /// <item><description>Normal: Periodic scheduling.</description></item>
        /// <item><description>TriggerWorkflow: Triggered workflow.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("WorkflowInstanceType")]
        [Validation(Required=false)]
        public string WorkflowInstanceType { get; set; }

    }

}
