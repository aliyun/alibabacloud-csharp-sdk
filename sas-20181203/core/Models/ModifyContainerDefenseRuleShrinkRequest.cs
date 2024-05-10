// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyContainerDefenseRuleShrinkRequest : TeaModel {
        /// <summary>
        /// The description of the rule.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The action specified in the rule. Valid values:
        /// 
        /// *   **1**: alert
        /// *   **2**: block
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public int? RuleAction { get; set; }

        /// <summary>
        /// The ID of the rule.
        /// 
        /// >  You can call the [ListContainerDefenseRule](https://help.aliyun.com/document_detail/2590599.html) operation to query the IDs of rules.
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
        /// The status of the rule. Valid values:
        /// 
        /// *   **1**: enabled
        /// *   **0**: disabled
        /// </summary>
        [NameInMap("RuleSwitch")]
        [Validation(Required=false)]
        public int? RuleSwitch { get; set; }

        /// <summary>
        /// The type of the rule. Valid values:
        /// 
        /// *   1: system rule
        /// *   2: custom rule
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// The effective scope of the rule.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public List<ModifyContainerDefenseRuleShrinkRequestScope> Scope { get; set; }
        public class ModifyContainerDefenseRuleShrinkRequestScope : TeaModel {
            /// <summary>
            /// Specifies whether to include all namespaces. Valid values:
            /// 
            /// *   **0**: no
            /// *   **1**: yes
            /// </summary>
            [NameInMap("AllNamespace")]
            [Validation(Required=false)]
            public int? AllNamespace { get; set; }

            /// <summary>
            /// The ID of the cluster on which the rule takes effect.
            /// 
            /// >  You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of clusters.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The namespaces.
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
