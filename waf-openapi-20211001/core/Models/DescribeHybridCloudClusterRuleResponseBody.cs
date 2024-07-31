// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudClusterRuleResponseBody : TeaModel {
        /// <summary>
        /// The details of the rule.
        /// </summary>
        [NameInMap("ClusterRule")]
        [Validation(Required=false)]
        public DescribeHybridCloudClusterRuleResponseBodyClusterRule ClusterRule { get; set; }
        public class DescribeHybridCloudClusterRuleResponseBodyClusterRule : TeaModel {
            /// <summary>
            /// The configuration of the rule.
            /// </summary>
            [NameInMap("RuleConfig")]
            [Validation(Required=false)]
            public string RuleConfig { get; set; }

            /// <summary>
            /// The status of the rule. Valid values:
            /// 
            /// *   **on**: enabled.
            /// *   **off**: disabled.
            /// </summary>
            [NameInMap("RuleStatus")]
            [Validation(Required=false)]
            public string RuleStatus { get; set; }

            /// <summary>
            /// The type of the rule. Valid values:
            /// 
            /// *   **pullin**: The traffic redirection rule of the hybrid cloud cluster.
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
