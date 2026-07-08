// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudClusterRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudClusterRulesResponseBodyData> Data { get; set; }
        public class DescribeHybridCloudClusterRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the hybrid cloud cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1099</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public long? ClusterId { get; set; }

            /// <summary>
            /// <para>The resource ID of the cluster rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdbc-clusterrule-*****khzre0ym0w</para>
            /// </summary>
            [NameInMap("ClusterRuleResourceId")]
            [Validation(Required=false)]
            public string ClusterRuleResourceId { get; set; }

            /// <summary>
            /// <para>The configuration of the traffic redirection rule:</para>
            /// <list type="bullet">
            /// <item><description><para><b>check_mode</b></para>
            /// <para>: the mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>all</b>: redirects all traffic.</para>
            /// </description></item>
            /// <item><description><para><b>part</b>: redirects a portion of traffic.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>type</b></para>
            /// <para>: the match type of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>exact</b>: exact match.</para>
            /// </description></item>
            /// <item><description><para><b>regex</b>: regular expression match.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>substance</b>: the value of the rule.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;check_mode\&quot;: \&quot;all\&quot;, \&quot;type\&quot;: \&quot;exact\&quot;, \&quot;substance\&quot;: \&quot;122\&quot;}</para>
            /// </summary>
            [NameInMap("RuleConfig")]
            [Validation(Required=false)]
            public string RuleConfig { get; set; }

            /// <summary>
            /// <para>The type of the rule. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>pullin</b>: traffic redirection</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pullin</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>The status of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of cloud native mode entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
