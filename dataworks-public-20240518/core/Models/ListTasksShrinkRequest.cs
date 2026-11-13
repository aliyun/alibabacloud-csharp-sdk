// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListTasksShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of task IDs. You can query multiple tasks at a time by specifying task IDs.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string IdsShrink { get; set; }

        /// <summary>
        /// <para>The name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQL node</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// <para>The number of entries per page. Default value: 10. Maximum value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The project environment.</para>
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
        /// <para>The sort field. You can sort by fields such as modification time and creation time. The format is &quot;Sort field + Sort order (Desc/Asc)&quot;. Asc can be omitted. Valid values for the sort field:</para>
        /// <list type="bullet">
        /// <item><description><c>ModifyTime (Desc/Asc)</c></description></item>
        /// <item><description><c>CreateTime (Desc/Asc)</c></description></item>
        /// <item><description><c>Id (Desc/Asc)</c></description></item>
        /// </list>
        /// <para>Default value: <c>Id Desc</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Id Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The task type. Examples:</para>
        /// <list type="bullet">
        /// <item><description>ODPS_SQL</description></item>
        /// <item><description>SPARK</description></item>
        /// <item><description>PY_ODPS</description></item>
        /// <item><description>PY_ODPS3</description></item>
        /// <item><description>ODPS_SCRIPT</description></item>
        /// <item><description>ODPS_MR</description></item>
        /// <item><description>COMPONENT_SQL</description></item>
        /// <item><description>EMR_HIVE</description></item>
        /// <item><description>EMR_MR</description></item>
        /// <item><description>EMR_SPARK_SQL</description></item>
        /// <item><description>EMR_SPARK</description></item>
        /// <item><description>EMR_SHELL</description></item>
        /// <item><description>EMR_PRESTO</description></item>
        /// <item><description>EMR_IMPALA</description></item>
        /// <item><description>SPARK_STREAMING</description></item>
        /// <item><description>EMR_KYUUBI</description></item>
        /// <item><description>EMR_TRINO</description></item>
        /// <item><description>HOLOGRES_SQL</description></item>
        /// <item><description>HOLOGRES_SYNC_DDL</description></item>
        /// <item><description>HOLOGRES_SYNC_DATA</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ODPS_SQL</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The running mode upon triggering. This parameter takes effect only when TriggerType is set to Scheduler.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("TriggerRecurrence")]
        [Validation(Required=false)]
        public string TriggerRecurrence { get; set; }

        /// <summary>
        /// <para>The trigger type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduler</para>
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        /// <summary>
        /// <para>The ID of the workflow to which the task belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public long? WorkflowId { get; set; }

    }

}
