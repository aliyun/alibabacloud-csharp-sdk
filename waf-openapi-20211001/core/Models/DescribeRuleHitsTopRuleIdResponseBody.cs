// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleHitsTopRuleIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6334274-8870-5D2F-A1AD-D6EF885AC1ED</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of the IDs of the top 10 rules that are matched by requests.</para>
        /// </summary>
        [NameInMap("RuleHitsTopRuleId")]
        [Validation(Required=false)]
        public List<DescribeRuleHitsTopRuleIdResponseBodyRuleHitsTopRuleId> RuleHitsTopRuleId { get; set; }
        public class DescribeRuleHitsTopRuleIdResponseBodyRuleHitsTopRuleId : TeaModel {
            /// <summary>
            /// <para>The number of requests that match the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>181174784</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5465465</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

    }

}
