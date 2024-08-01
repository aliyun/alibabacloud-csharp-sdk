// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListManagedRulesResponseBody : TeaModel {
        /// <summary>
        /// The managed rules.
        /// </summary>
        [NameInMap("ManagedRules")]
        [Validation(Required=false)]
        public ListManagedRulesResponseBodyManagedRules ManagedRules { get; set; }
        public class ListManagedRulesResponseBodyManagedRules : TeaModel {
            /// <summary>
            /// The details of the managed rule.
            /// </summary>
            [NameInMap("ManagedRuleList")]
            [Validation(Required=false)]
            public List<ListManagedRulesResponseBodyManagedRulesManagedRuleList> ManagedRuleList { get; set; }
            public class ListManagedRulesResponseBodyManagedRulesManagedRuleList : TeaModel {
                /// <summary>
                /// The name of the managed rule.
                /// </summary>
                [NameInMap("ConfigRuleName")]
                [Validation(Required=false)]
                public string ConfigRuleName { get; set; }

                /// <summary>
                /// The description of the managed rule.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The URL of the topic that describes how the managed rule remediates the incompliant configurations.
                /// </summary>
                [NameInMap("HelpUrls")]
                [Validation(Required=false)]
                public string HelpUrls { get; set; }

                /// <summary>
                /// The unique identifier of the managed rule.
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// The classification description of the managed rule.
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<string> Labels { get; set; }

                /// <summary>
                /// The ID of the remediation template.
                /// </summary>
                [NameInMap("RemediationTemplateIdentifier")]
                [Validation(Required=false)]
                public string RemediationTemplateIdentifier { get; set; }

                /// <summary>
                /// The name of the remediation template.
                /// </summary>
                [NameInMap("RemediationTemplateName")]
                [Validation(Required=false)]
                public string RemediationTemplateName { get; set; }

                /// <summary>
                /// The risk level of the resources that do not comply with the rule. Valid values:
                /// 
                /// *   1: high
                /// *   2: medium
                /// *   3: low
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// The effective scope of the managed rule.
                /// </summary>
                [NameInMap("Scope")]
                [Validation(Required=false)]
                public ListManagedRulesResponseBodyManagedRulesManagedRuleListScope Scope { get; set; }
                public class ListManagedRulesResponseBodyManagedRulesManagedRuleListScope : TeaModel {
                    /// <summary>
                    /// The types of resources to which the managed rule applies.
                    /// </summary>
                    [NameInMap("ComplianceResourceTypes")]
                    [Validation(Required=false)]
                    public List<string> ComplianceResourceTypes { get; set; }

                }

                /// <summary>
                /// Indicates whether precheck is supported. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("SupportPreviewManagedRule")]
                [Validation(Required=false)]
                public bool? SupportPreviewManagedRule { get; set; }

            }

            /// <summary>
            /// The page number.
            /// 
            /// Page start from page 1.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page. Valid values: 1 to 500.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
