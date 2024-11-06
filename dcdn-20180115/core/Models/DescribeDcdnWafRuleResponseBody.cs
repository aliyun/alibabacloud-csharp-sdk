// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66A98669-CC6E-4F3E-80A6-3014697B11AE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the protection rule.</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public DescribeDcdnWafRuleResponseBodyRule Rule { get; set; }
        public class DescribeDcdnWafRuleResponseBodyRule : TeaModel {
            /// <summary>
            /// <para>The type of the protection policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>waf_group: basic web protection</description></item>
            /// <item><description>custom_acl: custom protection</description></item>
            /// <item><description>whitelist: IP address whitelist</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom_acl</para>
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// <para>The time when the scaling group was modified. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
            /// <para>200001</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// <para>The configurations of the protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;action\&quot;:\&quot;monitor\&quot;,\&quot;actionExternal\&quot;:\&quot;{}\&quot;,\&quot;ccStatus\&quot;:1,\&quot;conditions\&quot;:[{\&quot;key\&quot;:\&quot;URL\&quot;,\&quot;opValue\&quot;:\&quot;eq\&quot;,\&quot;targetKey\&quot;:\&quot;request_uri\&quot;,\&quot;values\&quot;:\&quot;/example\&quot;},{\&quot;key\&quot;:\&quot;Header\&quot;,\&quot;opValue\&quot;:\&quot;eq\&quot;,\&quot;subKey\&quot;:\&quot;trt\&quot;,\&quot;targetKey\&quot;:\&quot;header.trt\&quot;,\&quot;values\&quot;:\&quot;3333\&quot;}],\&quot;effect\&quot;:\&quot;service\&quot;,\&quot;name\&quot;:\&quot;aaa333\&quot;,\&quot;origin\&quot;:\&quot;custom\&quot;,\&quot;ratelimit\&quot;:{\&quot;interval\&quot;:5,\&quot;status\&quot;:{\&quot;code\&quot;:404,\&quot;count\&quot;:2,\&quot;stat\&quot;:{\&quot;mode\&quot;:\&quot;count\&quot;,\&quot;value\&quot;:2.0}},\&quot;target\&quot;:\&quot;remote_addr\&quot;,\&quot;threshold\&quot;:2,\&quot;ttl\&quot;:1800}}</para>
            /// </summary>
            [NameInMap("RuleConfig")]
            [Validation(Required=false)]
            public string RuleConfig { get; set; }

            /// <summary>
            /// <para>The ID of the protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100001</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The status of the protection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on</description></item>
            /// <item><description>off</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleStatus")]
            [Validation(Required=false)]
            public string RuleStatus { get; set; }

        }

    }

}
