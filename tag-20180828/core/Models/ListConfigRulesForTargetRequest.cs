// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListConfigRulesForTargetRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Default value: 50. Maximum value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResult")]
        [Validation(Required=false)]
        public int? MaxResult { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The use scenario of the tag policy. This parameter specifies a filter condition for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tags: enables tags with specified tag values to be added to resources.</description></item>
        /// <item><description>rg_inherit: enables resources in a resource group to automatically inherit tags from the resource group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tags</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The region ID. Set the value to cn-shanghai.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The tag key. This parameter specifies a filter condition for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CostCenter</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public string TagKey { get; set; }

        /// <summary>
        /// <para>The ID of the object. This parameter specifies a filter condition for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>134254031178****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the object. This parameter specifies a filter condition for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>USER: the current logon account. This value is available if you use the Tag Policy feature in single-account mode.</description></item>
        /// <item><description>ROOT: the Root folder in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
        /// <item><description>FOLDER: a folder other than the Root folder in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
        /// <item><description>ACCOUNT: a member in a resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The value of this parameter is not case-sensitive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ACCOUNT</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The mode of the Tag Policy feature. This parameter specifies a filter condition for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>USER: single-account mode</description></item>
        /// <item><description>RD: multi-account mode</description></item>
        /// </list>
        /// <para>For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.</para>
        /// <remarks>
        /// <para> The value of this parameter is not case-sensitive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
