// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudClusterRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the rule.</para>
        /// </summary>
        [NameInMap("ClusterRule")]
        [Validation(Required=false)]
        public DescribeHybridCloudClusterRuleResponseBodyClusterRule ClusterRule { get; set; }
        public class DescribeHybridCloudClusterRuleResponseBodyClusterRule : TeaModel {
            [NameInMap("ClusterRuleResourceId")]
            [Validation(Required=false)]
            public string ClusterRuleResourceId { get; set; }

            /// <summary>
            /// <para>The configuration of the rule.</para>
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
            /// <item><description><b>on</b>: enabled.</description></item>
            /// <item><description><b>off</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("RuleStatus")]
            [Validation(Required=false)]
            public string RuleStatus { get; set; }

            /// <summary>
            /// <para>The type of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pullin</b>: The traffic redirection rule of the hybrid cloud cluster.</description></item>
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
