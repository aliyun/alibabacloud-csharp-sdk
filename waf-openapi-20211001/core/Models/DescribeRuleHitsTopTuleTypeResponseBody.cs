// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopTuleTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45E377CE-0B04-578E-B653-EEA63CFE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The top 10 protection types with the most rule hits.</para>
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
            /// <para>The type of the rule hit by the protected object. By default, this parameter is not returned, which indicates that all rules are displayed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>waf</b>: basic protection rule.</para>
            /// </description></item>
            /// <item><description><para><b>blacklist</b>: IP blacklist.</para>
            /// </description></item>
            /// <item><description><para><b>custom</b>: custom rule.</para>
            /// </description></item>
            /// <item><description><para><b>antiscan</b>: scan protection rule.</para>
            /// </description></item>
            /// <item><description><para><b>cc_system</b>: HTTP flood protection rule.</para>
            /// </description></item>
            /// <item><description><para><b>region_block</b>: area blocking.</para>
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
