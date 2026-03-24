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
        /// <para>The top 10 protection rule types that were hit.</para>
        /// </summary>
        [NameInMap("RuleHitsTopTuleType")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopTuleTypeResponseBodyRuleHitsTopTuleType> RuleHitsTopTuleType { get; set; }
        public class DescribeRuleHitsTopTuleTypeResponseBodyRuleHitsTopTuleType : TeaModel {
            /// <summary>
            /// <para>The number of requests that hit the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>698455</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The type of rule that was hit. This parameter is not returned by default, which indicates that data for all rule types is returned.</para>
            /// <list type="bullet">
            /// <item><description><para><b>waf</b>: basic protection rules.</para>
            /// </description></item>
            /// <item><description><para><b>blacklist</b>: IP address blacklist.</para>
            /// </description></item>
            /// <item><description><para><b>custom</b>: custom rules.</para>
            /// </description></item>
            /// <item><description><para><b>antiscan</b>: scan protection rules.</para>
            /// </description></item>
            /// <item><description><para><b>cc_system</b>: HTTP flood protection rules.</para>
            /// </description></item>
            /// <item><description><para><b>region_block</b>: location blacklist.</para>
            /// </description></item>
            /// <item><description><para><b>scene</b>: bot management.</para>
            /// </description></item>
            /// <item><description><para><b>dlp</b>: data leak prevention.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>blacklist</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

    }

}
