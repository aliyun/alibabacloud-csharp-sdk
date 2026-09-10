// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class AddDataCheckConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform full-table validation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: partition-level comparison.</description></item>
        /// <item><description>1: full-table comparison.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("isFullTableCount")]
        [Validation(Required=false)]
        public int? IsFullTableCount { get; set; }

        /// <summary>
        /// <para>The columns of the source table. You can specify multiple columns separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>col_a,col_b</para>
        /// </summary>
        [NameInMap("sourceColumns")]
        [Validation(Required=false)]
        public string SourceColumns { get; set; }

        /// <summary>
        /// <para>The GROUP condition of the source table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>col_a,col_b</para>
        /// </summary>
        [NameInMap("sourceGroupClause")]
        [Validation(Required=false)]
        public string SourceGroupClause { get; set; }

        /// <summary>
        /// <para>The hint for the source.</para>
        /// </summary>
        [NameInMap("sourceHint")]
        [Validation(Required=false)]
        public string SourceHint { get; set; }

        /// <summary>
        /// <para>The partition of the source table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds=20260116</para>
        /// </summary>
        [NameInMap("sourcePartition")]
        [Validation(Required=false)]
        public string SourcePartition { get; set; }

        /// <summary>
        /// <para>The name of the source table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_demo</para>
        /// </summary>
        [NameInMap("sourceTable")]
        [Validation(Required=false)]
        public string SourceTable { get; set; }

        /// <summary>
        /// <para>The WHERE condition of the source table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>col_a &gt; 0 and col_b = \&quot;x\&quot;</para>
        /// </summary>
        [NameInMap("sourceWhereClause")]
        [Validation(Required=false)]
        public string SourceWhereClause { get; set; }

        /// <summary>
        /// <para>The columns of the target table. You can specify multiple columns separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>col_a,col_b</para>
        /// </summary>
        [NameInMap("targetColumns")]
        [Validation(Required=false)]
        public string TargetColumns { get; set; }

        /// <summary>
        /// <para>The GROUP condition of the target table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>col_a,col_b</para>
        /// </summary>
        [NameInMap("targetGroupClause")]
        [Validation(Required=false)]
        public string TargetGroupClause { get; set; }

        /// <summary>
        /// <para>The hint for the target.</para>
        /// </summary>
        [NameInMap("targetHint")]
        [Validation(Required=false)]
        public string TargetHint { get; set; }

        /// <summary>
        /// <para>The partition of the target table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds=20260116</para>
        /// </summary>
        [NameInMap("targetPartition")]
        [Validation(Required=false)]
        public string TargetPartition { get; set; }

        /// <summary>
        /// <para>The name of the target table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table_demo</para>
        /// </summary>
        [NameInMap("targetTable")]
        [Validation(Required=false)]
        public string TargetTable { get; set; }

        /// <summary>
        /// <para>The WHERE condition of the target table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>col_a &gt; 0 and col_b = \&quot;x\&quot;</para>
        /// </summary>
        [NameInMap("targetWhereClause")]
        [Validation(Required=false)]
        public string TargetWhereClause { get; set; }

        /// <summary>
        /// <para>The batch table configurations for same-pattern creation (<c>taskMode=1</c>). Separate multiple configurations with a line break (<c> </c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>lhm|lhm_dw|*</para>
        /// </summary>
        [NameInMap("taskConfigInfo")]
        [Validation(Required=false)]
        public string TaskConfigInfo { get; set; }

        /// <summary>
        /// <para>The ID of the validation task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The total data volume comparison threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("totalCountThreshold")]
        [Validation(Required=false)]
        public float? TotalCountThreshold { get; set; }

    }

}
