// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListConfigRulesForTargetResponseBody : TeaModel {
        /// <summary>
        /// <para>The tag detection tasks.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListConfigRulesForTargetResponseBodyData> Data { get; set; }
        public class ListConfigRulesForTargetResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the account group.</para>
            /// <para>You can use the ID to query the content of the related resource non-compliance report in Cloud Config.</para>
            /// <remarks>
            /// <para> This parameter is returned only if you use the Tag Policy feature in multi-account mode.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ca-efdc33dc9b37002d****</para>
            /// </summary>
            [NameInMap("AggregatorId")]
            [Validation(Required=false)]
            public string AggregatorId { get; set; }

            /// <summary>
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cr-0lb4866180880069****</para>
            /// </summary>
            [NameInMap("ConfigRuleId")]
            [Validation(Required=false)]
            public string ConfigRuleId { get; set; }

            /// <summary>
            /// <para>The use scenario of the tag policy. Valid values:</para>
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
            /// <para>Indicates whether automatic remediation is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Remediation")]
            [Validation(Required=false)]
            public bool? Remediation { get; set; }

            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CostCenter</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value for automatic remediation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Project</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

            /// <summary>
            /// <para>The ID of the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>134254031178****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The type of the object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>USER: the current logon account. This value is available if you use the Tag Policy feature in single-account mode.</description></item>
            /// <item><description>ROOT: the Root folder in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
            /// <item><description>FOLDER: a folder other than the Root folder in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
            /// <item><description>ACCOUNT: a member in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the next query is required.</para>
        /// <list type="bullet">
        /// <item><description>If the value of this parameter is empty (<c>&quot;NextToken&quot;: &quot;&quot;</c>), all results are returned, and the next query is not required.</description></item>
        /// <item><description>If the value of this parameter is not empty, the next query is required, and the value is the token used to start the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7126AECD-D7AD-5073-8E88-DD2BD1FC139E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
