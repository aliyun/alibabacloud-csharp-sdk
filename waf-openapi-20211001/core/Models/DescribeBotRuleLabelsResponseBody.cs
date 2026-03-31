// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeBotRuleLabelsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAGBgV9tolsLfijC4wam2htS*****D/46H3X2wIS</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19****5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleLabels")]
        [Validation(Required=false)]
        public List<DescribeBotRuleLabelsResponseBodyRuleLabels> RuleLabels { get; set; }
        public class DescribeBotRuleLabelsResponseBodyRuleLabels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>malicious</para>
            /// </summary>
            [NameInMap("BotBehavior")]
            [Validation(Required=false)]
            public string BotBehavior { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>malicious_crawler_python</para>
            /// </summary>
            [NameInMap("LabelKey")]
            [Validation(Required=false)]
            public string LabelKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>human_machine_challenge</para>
            /// </summary>
            [NameInMap("LabelType")]
            [Validation(Required=false)]
            public string LabelType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Web,app</para>
            /// </summary>
            [NameInMap("SubScene")]
            [Validation(Required=false)]
            public string SubScene { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
