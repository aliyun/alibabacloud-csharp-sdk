// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopUaResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8E5C7ED7-503A-5986-A005-36F2511EB89F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The top 10 User-Agents ranked by attack count.</para>
        /// </summary>
        [NameInMap("RuleHitsTopUa")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopUaResponseBodyRuleHitsTopUa> RuleHitsTopUa { get; set; }
        public class DescribeRuleHitsTopUaResponseBodyRuleHitsTopUa : TeaModel {
            /// <summary>
            /// <para>The number of attack requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>531</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The User-Agent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>android</para>
            /// </summary>
            [NameInMap("Ua")]
            [Validation(Required=false)]
            public string Ua { get; set; }

        }

    }

}
