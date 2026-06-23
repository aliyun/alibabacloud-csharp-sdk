// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListWorkflowInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The business date. This is generally 00:00:00 of the day before the scheduled instance trigger time, in millisecond-level timestamp format, such as 1743350400000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public long? BizDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The filter. In JSON format, multiple filter conditions have an AND relationship. Currently supported fields are: <c>status, executionDate</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{<br>    &quot;status&quot;: &quot;Success&quot;,
        ///     &quot;executionDate&quot;: &quot;1763481600000&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The list of workflow instance IDs. You can use this parameter to query multiple workflow instances at a time.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<long?> Ids { get; set; }

        /// <summary>
        /// <para>The name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WorkflowInstance1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The account ID of the owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The list of sort fields. Sorting by trigger time, start time, and other fields is supported. The format is &quot;sort field + sort order (Desc/Asc)&quot; (Asc can be omitted). Valid values of the sort field:</para>
        /// <list type="bullet">
        /// <item><description><para>TriggerTime (Desc/Asc)</para>
        /// </description></item>
        /// <item><description><para>StartedTime (Desc/Asc)</para>
        /// </description></item>
        /// <item><description><para>FinishedTime (Desc/Asc)</para>
        /// </description></item>
        /// <item><description><para>CreateTime (Desc/Asc)</para>
        /// </description></item>
        /// <item><description><para>Id (Desc/Asc)</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: Id Desc</para>
        /// 
        /// <b>Example:</b>
        /// <para>Id Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The list of tags. Results are returned if any one of the specified tags is matched.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>The type of the workflow instance.</para>
        /// <list type="bullet">
        /// <item><description><para>Normal: Periodic scheduling</para>
        /// </description></item>
        /// <item><description><para>Manual: Manual task</para>
        /// </description></item>
        /// <item><description><para>SmokeTest: Testing</para>
        /// </description></item>
        /// <item><description><para>SupplementData: Backfill data</para>
        /// </description></item>
        /// <item><description><para>ManualWorkflow: Manual workflow</para>
        /// </description></item>
        /// <item><description><para>TriggerWorkflow: Trigger-based workflow</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The unified workflow instance ID. All workflow instances within the same business date of a single trigger share the same value for this field.</para>
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

    }

}
