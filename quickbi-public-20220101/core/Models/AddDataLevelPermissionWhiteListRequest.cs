// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddDataLevelPermissionWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the training dataset that you want to remove from the specified custom linguistic model.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c7223ae-***-3c744528014b</para>
        /// </summary>
        [NameInMap("CubeId")]
        [Validation(Required=false)]
        public string CubeId { get; set; }

        /// <summary>
        /// <para>Operation Type: You can set this parameter to one of the following values.</para>
        /// <list type="bullet">
        /// <item><description>ADD: Add a whitelist</description></item>
        /// <item><description>DELETE: deletes a whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ADD</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>The type of row-level permissions.</para>
        /// <list type="bullet">
        /// <item><description>ROW_LEVEL: row-level permissions,</description></item>
        /// <item><description>COLUMN_LEVEL: column-level permissions</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ROW_LEVEL</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>43342<em><b>435,1553a</b></em>*41231</para>
        /// </summary>
        [NameInMap("TargetIds")]
        [Validation(Required=false)]
        public string TargetIds { get; set; }

        /// <summary>
        /// <para>Modify the type of the whitelist:</para>
        /// <list type="bullet">
        /// <item><description>1: user</description></item>
        /// <item><description>2: user group</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
