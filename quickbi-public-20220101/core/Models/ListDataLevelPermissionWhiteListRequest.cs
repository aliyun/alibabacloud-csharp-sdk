// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListDataLevelPermissionWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>Dataset ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3d5db23c-e4f2-49dd-a883-92285b48e14a</para>
        /// </summary>
        [NameInMap("CubeId")]
        [Validation(Required=false)]
        public string CubeId { get; set; }

        /// <summary>
        /// <para>Type of row and column permission that the whitelist belongs to:</para>
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
