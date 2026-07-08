// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudClusterRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the rule.</para>
        /// </summary>
        [NameInMap("ClusterRule")]
        [Validation(Required=false)]
        public DescribeHybridCloudClusterRuleResponseBodyClusterRule ClusterRule { get; set; }
        public class DescribeHybridCloudClusterRuleResponseBodyClusterRule : TeaModel {
            /// <summary>
            /// <para>The resource ID of the cluster rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdbc-clusterrule-2m*****m0w</para>
            /// </summary>
            [NameInMap("ClusterRuleResourceId")]
            [Validation(Required=false)]
            public string ClusterRuleResourceId { get; set; }

            /// <summary>
            /// <para>The configuration of the traffic routing rule.</para>
            /// <list type="bullet">
            /// <item><description><para><b>check_mode</b>: Defines the traffic scope for the routing rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>all</b>: Routes all traffic.</para>
            /// </description></item>
            /// <item><description><para><b>part</b>: Routes a portion of the traffic.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>type</b>: The rule\&quot;s match type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>exact</b>: Exact match.</para>
            /// </description></item>
            /// <item><description><para><b>regex</b>: Regular expression match.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para><b>substance</b>: The value of the rule.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;check_mode\&quot;:\&quot;all\&quot;,\&quot;exclude\&quot;:{\&quot;exact\&quot;:[],\&quot;regex\&quot;:[]}}</para>
            /// </summary>
            [NameInMap("RuleConfig")]
            [Validation(Required=false)]
            public string RuleConfig { get; set; }

            /// <summary>
            /// <para>The status of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>on</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>off</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleStatus")]
            [Validation(Required=false)]
            public string RuleStatus { get; set; }

            /// <summary>
            /// <para>The type of the rule.</para>
            /// <list type="bullet">
            /// <item><description>pullin: The traffic routing rule.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pullin</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1F29A6D2-9EB6-526D-A997-36888**99CB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
