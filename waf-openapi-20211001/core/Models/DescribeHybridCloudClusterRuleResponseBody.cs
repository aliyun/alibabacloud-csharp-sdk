// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudClusterRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The rule information.</para>
        /// </summary>
        [NameInMap("ClusterRule")]
        [Validation(Required=false)]
        public DescribeHybridCloudClusterRuleResponseBodyClusterRule ClusterRule { get; set; }
        public class DescribeHybridCloudClusterRuleResponseBodyClusterRule : TeaModel {
            /// <summary>
            /// <para>The cluster rule resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdbc-clusterrule-2m*****m0w</para>
            /// </summary>
            [NameInMap("ClusterRuleResourceId")]
            [Validation(Required=false)]
            public string ClusterRuleResourceId { get; set; }

            /// <summary>
            /// <para>The traffic redirection rule configuration:</para>
            /// <list type="bullet">
            /// <item><description><b>check_mode</b>: the mode selection. Valid values:<list type="bullet">
            /// <item><description><b>all</b>: full traffic redirection</description></item>
            /// <item><description><b>part</b>: partial traffic redirection</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>type</b>: the rule matching type. Valid values:<list type="bullet">
            /// <item><description><b>exact</b>: exact match</description></item>
            /// <item><description><b>regex</b>: regular expression</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>substance</b>: the rule value</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;check_mode\&quot;:\&quot;all\&quot;,\&quot;exclude\&quot;:{\&quot;exact\&quot;:[],\&quot;regex\&quot;:[]}}</para>
            /// </summary>
            [NameInMap("RuleConfig")]
            [Validation(Required=false)]
            public string RuleConfig { get; set; }

            /// <summary>
            /// <para>The rule status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>on</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>off</b>: disabled.</para>
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
            /// <para>The rule type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>pullin: traffic redirection rule</description></item>
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
