// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class SetDataLevelPermissionExtraConfigRequest : TeaModel {
        /// <summary>
        /// <para>Dataset ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c7223ae-******-3c744528014b</para>
        /// </summary>
        [NameInMap("CubeId")]
        [Validation(Required=false)]
        public string CubeId { get; set; }

        /// <summary>
        /// <para>Policy when no rule is matched:</para>
        /// <list type="bullet">
        /// <item><description>NONE: No permission</description></item>
        /// <item><description>ALL: Full permission</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NONE</para>
        /// </summary>
        [NameInMap("MissHitPolicy")]
        [Validation(Required=false)]
        public string MissHitPolicy { get; set; }

        /// <summary>
        /// <para>Type of dataset row and column permissions. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>ROW_LEVEL: Row-level permission</description></item>
        /// <item><description>COLUMN_LEVEL: Column-level permission</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ROW_LEVEL</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
