// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddDataLevelPermissionWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the dataset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7c7223ae-***-3c744528014b</para>
        /// </summary>
        [NameInMap("CubeId")]
        [Validation(Required=false)]
        public string CubeId { get; set; }

        /// <summary>
        /// <para>The operation to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ADD: adds users or user groups to the whitelist.</para>
        /// </description></item>
        /// <item><description><para>DELETE: removes users or user groups from the whitelist.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ADD</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>The type of permission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ROW_LEVEL: row-level permission</para>
        /// </description></item>
        /// <item><description><para>COLUMN_LEVEL: column-level permission</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ROW_LEVEL</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The IDs of the users or user groups to add to the whitelist.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set TargetType to 1 (user), specify the user IDs.</para>
        /// </description></item>
        /// <item><description><para>When <c>TargetType=2</c> (user group), the value is the user group ID.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>43342<em><b>435,1553a</b></em>*41231</para>
        /// </summary>
        [NameInMap("TargetIds")]
        [Validation(Required=false)]
        public string TargetIds { get; set; }

        /// <summary>
        /// <para>The type of object to add to the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: user</para>
        /// </description></item>
        /// <item><description><para>2: user group</para>
        /// </description></item>
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
