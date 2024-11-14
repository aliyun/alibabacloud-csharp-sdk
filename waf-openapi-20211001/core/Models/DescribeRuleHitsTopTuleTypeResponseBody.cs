// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopTuleTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45E377CE-0B04-578E-B653-EEA63CFE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The top 10 protection modules that are matched.</para>
        /// </summary>
        [NameInMap("RuleHitsTopTuleType")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopTuleTypeResponseBodyRuleHitsTopTuleType> RuleHitsTopTuleType { get; set; }
        public class DescribeRuleHitsTopTuleTypeResponseBodyRuleHitsTopTuleType : TeaModel {
            /// <summary>
            /// <para>The number of requests that match protection rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>698455</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The type of rule that is matched. By default, this parameter is not returned. This indicates that all types of rules that are matched are returned.</para>
            /// <list type="bullet">
            /// <item><description><b>waf:</b> basic protection rules.</description></item>
            /// <item><description><b>blacklist:</b> IP address blacklist rules.</description></item>
            /// <item><description><b>custom:</b> custom rules.</description></item>
            /// <item><description><b>antiscan:</b> scan protection rules.</description></item>
            /// <item><description><b>cc_system:</b> HTTP flood protection rules.</description></item>
            /// <item><description><b>region_block:</b> region blacklist rules.</description></item>
            /// <item><description><b>scene:</b> bot management rules.</description></item>
            /// <item><description><b>dlp:</b> data leakage prevention rules.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cc_system</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

    }

}
