// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyContainerDefenseRuleRequest : TeaModel {
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
        /// >  You can call the [ListContainerDefenseRule](~~2590599~~) operation to query the IDs of rules.
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
        public List<ModifyContainerDefenseRuleRequestScope> Scope { get; set; }
        public class ModifyContainerDefenseRuleRequestScope : TeaModel {
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
        public ModifyContainerDefenseRuleRequestWhitelist Whitelist { get; set; }
        public class ModifyContainerDefenseRuleRequestWhitelist : TeaModel {
            /// <summary>
            /// The hash values of the files that need to be added to the whitelist.
            /// 
            /// >  This parameter is not supported.
            /// </summary>
            [NameInMap("Hash")]
            [Validation(Required=false)]
            public List<string> Hash { get; set; }

            /// <summary>
            /// The images that need to be added to the whitelist.
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<string> Image { get; set; }

            /// <summary>
            /// The paths to the files that need to be added to the whitelist.
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public List<string> Path { get; set; }

        }

    }

}
