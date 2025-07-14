// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudClusterRulesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudClusterRulesResponseBodyData> Data { get; set; }
        public class DescribeHybridCloudClusterRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1099</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public long? ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hdbc-clusterrule-*****khzre0ym0w</para>
            /// </summary>
            [NameInMap("ClusterRuleResourceId")]
            [Validation(Required=false)]
            public string ClusterRuleResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;check_mode\&quot;: \&quot;all\&quot;, \&quot;type\&quot;: \&quot;exact\&quot;, \&quot;substance\&quot;: \&quot;122\&quot;}</para>
            /// </summary>
            [NameInMap("RuleConfig")]
            [Validation(Required=false)]
            public string RuleConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pullin</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
