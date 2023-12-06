// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddContainerDefenseRuleShrinkRequest : TeaModel {
        /// <summary>
        /// The description of the rule.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The action that is performed when the rule is hit. Valid values:
        /// 
        /// *   **1**: alert
        /// *   **2**: block
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public int? RuleAction { get; set; }

        /// <summary>
        /// The ID of the rule. You do not need to manually specify the ID.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// The name of the rule.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The switch of the rule. Valid values:
        /// 
        /// *   **0**: off
        /// *   **1**: on
        /// </summary>
        [NameInMap("RuleSwitch")]
        [Validation(Required=false)]
        public int? RuleSwitch { get; set; }

        /// <summary>
        /// The rule type. Valid values:
        /// 
        /// *   2: user-defined rules
        /// 
        /// > Only the value 2 is supported.
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// The scope.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public List<AddContainerDefenseRuleShrinkRequestScope> Scope { get; set; }
        public class AddContainerDefenseRuleShrinkRequestScope : TeaModel {
            /// <summary>
            /// Specifies whether to include all namespaces. Valid values:
            /// 
            /// *   **0**: You can use the Namespaces parameter to specify the namespaces to include.
            /// *   **1**: All namespaces are included.
            /// </summary>
            [NameInMap("AllNamespace")]
            [Validation(Required=false)]
            public int? AllNamespace { get; set; }

            /// <summary>
            /// The ID of the cluster.
            /// 
            /// >  You can call the [DescribeGroupedContainerInstances](~~182997~~) operation to query the IDs of clusters.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The namespaces to include.
            /// </summary>
            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<string> Namespaces { get; set; }

        }

        /// <summary>
        /// The whitelist.
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public string WhitelistShrink { get; set; }

    }

}
