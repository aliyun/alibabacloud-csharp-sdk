// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListCubeDataLevelPermissionConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the training dataset that you want to remove from the specified custom linguistic model.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c7223ae-****-3c744528014b</para>
        /// </summary>
        [NameInMap("CubeId")]
        [Validation(Required=false)]
        public string CubeId { get; set; }

        /// <summary>
        /// <para>The type of the dataset row and column permission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ROW_LEVEL: row-level permissions</description></item>
        /// <item><description>COLUMN_LEVEL: column-level permissions</description></item>
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
