// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ExecDataCheckSaveTaskRequest : TeaModel {
        /// <summary>
        /// <para>The global parameters for the validation phase. Separate multiple parameters with a line feed (<c> </c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("checkGlobalParams")]
        [Validation(Required=false)]
        public string CheckGlobalParams { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform full-table validation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Partition-level validation. This is the default value.</description></item>
        /// <item><description>1: Full-table validation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("fullTableCount")]
        [Validation(Required=false)]
        public int? FullTableCount { get; set; }

        /// <summary>
        /// <para>The global parameters for the source. Separate multiple parameters with a line feed (<c> </c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("sourceGlobalParams")]
        [Validation(Required=false)]
        public string SourceGlobalParams { get; set; }

        /// <summary>
        /// <para>Specifies whether to execute immediately after saving. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: No. This is the default value.</description></item>
        /// <item><description>1: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("startImmediately")]
        [Validation(Required=false)]
        public int? StartImmediately { get; set; }

        /// <summary>
        /// <para>The global parameters for the target. Separate multiple parameters with a line feed (<c> </c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("targetGlobalParams")]
        [Validation(Required=false)]
        public string TargetGlobalParams { get; set; }

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
        /// <para>The total data volume comparison threshold, used to determine whether the data volume difference between the source and target is within an acceptable range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("totalCountThreshold")]
        [Validation(Required=false)]
        public float? TotalCountThreshold { get; set; }

    }

}
