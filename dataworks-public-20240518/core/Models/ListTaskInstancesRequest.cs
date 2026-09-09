// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListTaskInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The business date. This is typically 00:00:00 of the day before the scheduled time of the periodic instance. The value is a millisecond-level timestamp, such as 1743350400000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("Bizdate")]
        [Validation(Required=false)]
        public long? Bizdate { get; set; }

        /// <summary>
        /// <para>The filter. The value is in JSON format. Multiple filter conditions are combined with AND logic. Currently supported fields: <c>startedTimeStart, startedTimeEnd, finishedTimeStart, finishedTimeEnd, createTimeStart, createTimeEnd</c></para>
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
        /// <para>The instance ID. If an instance has been rerun, specifying this parameter returns the historical information including reruns. You can use RunNumber to distinguish each historical record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The list of instance IDs. You can use this parameter to query multiple instances in a batch.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<long?> Ids { get; set; }

        /// <summary>
        /// <para>The account ID of the node owner.</para>
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
        /// <para>The project environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prod: production.</description></item>
        /// <item><description>Dev: development.</description></item>
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
        /// <para>The schedule resource information. Specify the identifier of the schedule resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public string RuntimeResource { get; set; }

        /// <summary>
        /// <para>The sort field. Supports fields such as scheduled time and start time. The format is &quot;sort field + sort order (Desc/Asc)&quot;. Asc can be omitted. Valid values:</para>
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
        /// <para>Default value: <c>Id Desc</c></para>
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
        /// <para>The status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>NotRun</c>: not run.</description></item>
        /// <item><description><c>Running</c>: running.</description></item>
        /// <item><description><c>Failure</c>: failed.</description></item>
        /// <item><description><c>Success</c>: succeeded.</description></item>
        /// <item><description><c>WaitTime</c>: waiting for the scheduled time.</description></item>
        /// <item><description><c>WaitResource</c>: waiting for resources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the corresponding node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The list of node IDs. You can use this parameter to query instances of multiple nodes in a batch.</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<long?> TaskIds { get; set; }

        /// <summary>
        /// <para>The name of the corresponding node. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQL node</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The node type. For the TaskType values of each node, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks nodes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ODPS_SQL</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The run mode at the time of triggering. This parameter takes effect only when TriggerType is set to Scheduler. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pause: paused.</description></item>
        /// <item><description>Skip: dry run.</description></item>
        /// <item><description>Normal: normal run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("TriggerRecurrence")]
        [Validation(Required=false)]
        public string TriggerRecurrence { get; set; }

        /// <summary>
        /// <para>The trigger type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Scheduler: triggered by periodic scheduling.</description></item>
        /// <item><description>Manual: manually triggered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        /// <summary>
        /// <para>The unified workflow instance ID. All instances within the same business date under a single trigger share the same value for this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("UnifiedWorkflowInstanceId")]
        [Validation(Required=false)]
        public long? UnifiedWorkflowInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the workflow to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public long? WorkflowId { get; set; }

        /// <summary>
        /// <para>The ID of the workflow instance to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("WorkflowInstanceId")]
        [Validation(Required=false)]
        public long? WorkflowInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the workflow instance to which the instance belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SmokeTest: test.</description></item>
        /// <item><description>Manual: manual node.</description></item>
        /// <item><description>SupplementData: data backfill.</description></item>
        /// <item><description>ManualWorkflow: manual workflow.</description></item>
        /// <item><description>Normal: periodic scheduling.</description></item>
        /// <item><description>TriggerWorkflow: trigger-based workflow.</description></item>
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
