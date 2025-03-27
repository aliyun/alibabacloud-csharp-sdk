// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListTasksRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<long?> Ids { get; set; }

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
        /// <para>The environment of the workspace.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prod: production environment</description></item>
        /// <item><description>Dev: development environment</description></item>
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
        /// <para>The running mode of the task after it is triggered. This parameter takes effect only if the TriggerType parameter is set to Scheduler.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pause</description></item>
        /// <item><description>Skip</description></item>
        /// <item><description>Normal</description></item>
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
        /// <item><description>Scheduler: scheduling cycle-based trigger</description></item>
        /// <item><description>Manual: manual trigger</description></item>
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
