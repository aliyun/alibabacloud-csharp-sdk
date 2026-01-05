// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListWorkflowInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The data timestamp. The value of this parameter is 00:00:00 of the day before the scheduling time of the instance. The value is a UNIX timestamp. Unit: milliseconds. Example: 1743350400000.</para>
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
        /// <para>{<br>    &quot;status&quot;: &quot;Success&quot;,
        ///     &quot;executionDate&quot;: &quot;1763481600000&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The IDs of the workflow instances. You can query multiple instances at a time by instance ID.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string IdsShrink { get; set; }

        /// <summary>
        /// <para>The instance name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WorkflowInstance1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The account ID of the workflow instance owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
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
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The fields used for sorting. Fields such as TriggerTime and StartedTime are supported. The value of this parameter is in the Sort field + Sort by (Desc/Asc) format. By default, results are sorted in ascending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TriggerTime (Desc/Asc)</description></item>
        /// <item><description>StartedTime (Desc/Asc)</description></item>
        /// <item><description>FinishedTime (Desc/Asc)</description></item>
        /// <item><description>CreateTime (Desc/Asc)</description></item>
        /// <item><description>Id (Desc/Asc)</description></item>
        /// </list>
        /// <para>Default value: Id Desc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Id Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The type of the workflow instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Normal: Scheduled execution</description></item>
        /// <item><description>Manual: Manually triggered node</description></item>
        /// <item><description>SmokeTest: Smoke test</description></item>
        /// <item><description>SupplementData: Data backfill</description></item>
        /// <item><description>ManualWorkflow: Manually triggered workflow</description></item>
        /// <item><description>TriggerWorkflow: Triggered Workflow</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
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
