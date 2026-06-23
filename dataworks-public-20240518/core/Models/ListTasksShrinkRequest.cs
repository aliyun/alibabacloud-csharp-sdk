// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListTasksShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string IdsShrink { get; set; }

        /// <summary>
        /// <para>The name of the task. Fuzzy match is supported.</para>
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
        /// <para>The workspace environment.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Prod</para>
        /// </description></item>
        /// <item><description><para>Dev</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prod</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

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
        /// <para>The information about the resource group. Set this parameter to the ID of a resource group for scheduling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S_res_group_524258031846018_1684XXXXXXXXX</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public string RuntimeResource { get; set; }

        /// <summary>
        /// <para>The field that is used to sort tasks. This parameter is configured in the format of &quot;Sorting field Sorting order&quot;. You can set the sorting order to Desc or Asc. If you do not specify the sorting order, Asc is used by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ModifyTime (Desc/Asc)</c></para>
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
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ODPS_SQL</para>
        /// </description></item>
        /// <item><description><para>SPARK</para>
        /// </description></item>
        /// <item><description><para>PY_ODPS</para>
        /// </description></item>
        /// <item><description><para>PY_ODPS3</para>
        /// </description></item>
        /// <item><description><para>ODPS_SCRIPT</para>
        /// </description></item>
        /// <item><description><para>ODPS_MR</para>
        /// </description></item>
        /// <item><description><para>COMPONENT_SQL</para>
        /// </description></item>
        /// <item><description><para>EMR_HIVE</para>
        /// </description></item>
        /// <item><description><para>EMR_MR</para>
        /// </description></item>
        /// <item><description><para>EMR_SPARK_SQL</para>
        /// </description></item>
        /// <item><description><para>EMR_SPARK</para>
        /// </description></item>
        /// <item><description><para>EMR_SHELL</para>
        /// </description></item>
        /// <item><description><para>EMR_PRESTO</para>
        /// </description></item>
        /// <item><description><para>EMR_IMPALA</para>
        /// </description></item>
        /// <item><description><para>SPARK_STREAMING</para>
        /// </description></item>
        /// <item><description><para>EMR_KYUUBI</para>
        /// </description></item>
        /// <item><description><para>EMR_TRINO</para>
        /// </description></item>
        /// <item><description><para>HOLOGRES_SQL</para>
        /// </description></item>
        /// <item><description><para>HOLOGRES_SYNC_DDL</para>
        /// </description></item>
        /// <item><description><para>HOLOGRES_SYNC_DATA</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ODPS_SQL</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The run mode when triggered. Valid only if TriggerType is Scheduler.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Pause</para>
        /// </description></item>
        /// <item><description><para>Skip</para>
        /// </description></item>
        /// <item><description><para>Normal</para>
        /// </description></item>
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
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Scheduler: Triggered by schedule.</para>
        /// </description></item>
        /// <item><description><para>Manual: Triggered manually.</para>
        /// </description></item>
        /// </list>
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
