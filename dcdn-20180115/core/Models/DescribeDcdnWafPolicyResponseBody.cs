// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the protection policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public DescribeDcdnWafPolicyResponseBodyPolicy Policy { get; set; }
        public class DescribeDcdnWafPolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <para>The type of the protection policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>waf_group: basic web protection</description></item>
            /// <item><description>custom_acl: custom protection</description></item>
            /// <item><description>whitelist: whitelist</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>waf_group</para>
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// <para>The number of domain names that use the protection policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("DomainCount")]
            [Validation(Required=false)]
            public int? DomainCount { get; set; }

            /// <summary>
            /// <para>The time when the protection policy was modified. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-29T17:08:45Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the protection policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100001</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// <para>The name of the protection policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>policy_test</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The status of the protection policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on</description></item>
            /// <item><description>off</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the current policy is the default policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>default</description></item>
            /// <item><description>custom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>The protection rule configurations corresponding to the protection policy. The configurations only support Bot management. For more information, see <a href="~~BatchCreateDcdnWafRules~~">BatchCreateDcdnWafRules</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{     &quot;type&quot;:&quot;target_type&quot;,     &quot;status&quot;:&quot;on&quot;,     &quot;config&quot;:{&quot;target&quot;:&quot;app&quot;},     &quot;action&quot;:&quot;&quot;   }</para>
            /// </summary>
            [NameInMap("RuleConfigs")]
            [Validation(Required=false)]
            public string RuleConfigs { get; set; }

            /// <summary>
            /// <para>The number of protection rules in the protection policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public long? RuleCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66A98669-CC6E-4F3E-80A6-3014697B11AE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
