// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetManagedRuleResponseBody : TeaModel {
        /// <summary>
        /// The details of the managed rule.
        /// </summary>
        [NameInMap("ManagedRule")]
        [Validation(Required=false)]
        public GetManagedRuleResponseBodyManagedRule ManagedRule { get; set; }
        public class GetManagedRuleResponseBodyManagedRule : TeaModel {
            /// <summary>
            /// The details of the required input parameters for the managed rule.
            /// </summary>
            [NameInMap("CompulsoryInputParameterDetails")]
            [Validation(Required=false)]
            public Dictionary<string, object> CompulsoryInputParameterDetails { get; set; }

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
            /// The URL of the topic that provides guidance on remediation for the managed rule.
            /// </summary>
            [NameInMap("HelpUrls")]
            [Validation(Required=false)]
            public string HelpUrls { get; set; }

            /// <summary>
            /// The identifier of the managed rule.
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// The tags of the managed rule.
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            /// <summary>
            /// The details of the optional input parameters for the managed rule.
            /// </summary>
            [NameInMap("OptionalInputParameterDetails")]
            [Validation(Required=false)]
            public Dictionary<string, object> OptionalInputParameterDetails { get; set; }

            /// <summary>
            /// The risk level of the managed rule. Valid values:
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
            public GetManagedRuleResponseBodyManagedRuleScope Scope { get; set; }
            public class GetManagedRuleResponseBodyManagedRuleScope : TeaModel {
                /// <summary>
                /// The types of resources to which the managed rule applies.
                /// </summary>
                [NameInMap("ComplianceResourceTypes")]
                [Validation(Required=false)]
                public List<string> ComplianceResourceTypes { get; set; }

            }

            /// <summary>
            /// The information about the trigger type of the managed rule.
            /// </summary>
            [NameInMap("SourceDetails")]
            [Validation(Required=false)]
            public List<GetManagedRuleResponseBodyManagedRuleSourceDetails> SourceDetails { get; set; }
            public class GetManagedRuleResponseBodyManagedRuleSourceDetails : TeaModel {
                /// <summary>
                /// The interval at which the rule is triggered. Valid values: Valid values:
                /// 
                /// *   One_Hour
                /// *   Three_Hours
                /// *   Six_Hours
                /// *   Twelve_Hours
                /// *   TwentyFour_Hours
                /// </summary>
                [NameInMap("MaximumExecutionFrequency")]
                [Validation(Required=false)]
                public string MaximumExecutionFrequency { get; set; }

                /// <summary>
                /// The trigger type of the rule. Valid values:
                /// 
                /// *   ConfigurationItemChangeNotification: The rule is triggered by configuration changes.
                /// *   ScheduledNotification: The rule is periodically triggered.
                /// </summary>
                [NameInMap("MessageType")]
                [Validation(Required=false)]
                public string MessageType { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
