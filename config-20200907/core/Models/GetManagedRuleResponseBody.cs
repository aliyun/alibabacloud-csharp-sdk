// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetManagedRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the managed rule.</para>
        /// </summary>
        [NameInMap("ManagedRule")]
        [Validation(Required=false)]
        public GetManagedRuleResponseBodyManagedRule ManagedRule { get; set; }
        public class GetManagedRuleResponseBodyManagedRule : TeaModel {
            /// <summary>
            /// <para>The details of the required input parameters for the managed rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("CompulsoryInputParameterDetails")]
            [Validation(Required=false)]
            public Dictionary<string, object> CompulsoryInputParameterDetails { get; set; }

            /// <summary>
            /// <para>The name of the managed rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cdn-domain-https-enabled</para>
            /// </summary>
            [NameInMap("ConfigRuleName")]
            [Validation(Required=false)]
            public string ConfigRuleName { get; set; }

            /// <summary>
            /// <para>The description of the managed rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>If HTTPS encryption is enabled for the CDN domain name, the configuration is considered compliant.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The URL of the topic that provides guidance on remediation for the managed rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.aliyundoc.com">https://example.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("HelpUrls")]
            [Validation(Required=false)]
            public string HelpUrls { get; set; }

            /// <summary>
            /// <para>The identifier of the managed rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cdn-domain-https-enabled</para>
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <para>The tags of the managed rule.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            /// <summary>
            /// <para>The details of the optional input parameters for the managed rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("OptionalInputParameterDetails")]
            [Validation(Required=false)]
            public Dictionary<string, object> OptionalInputParameterDetails { get; set; }

            /// <summary>
            /// <para>The risk level of the managed rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: high</description></item>
            /// <item><description>2: medium</description></item>
            /// <item><description>3: low</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            /// <summary>
            /// <para>The effective scope of the managed rule.</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public GetManagedRuleResponseBodyManagedRuleScope Scope { get; set; }
            public class GetManagedRuleResponseBodyManagedRuleScope : TeaModel {
                /// <summary>
                /// <para>The types of resources to which the managed rule applies.</para>
                /// </summary>
                [NameInMap("ComplianceResourceTypes")]
                [Validation(Required=false)]
                public List<string> ComplianceResourceTypes { get; set; }

            }

            /// <summary>
            /// <para>The information about the trigger type of the managed rule.</para>
            /// </summary>
            [NameInMap("SourceDetails")]
            [Validation(Required=false)]
            public List<GetManagedRuleResponseBodyManagedRuleSourceDetails> SourceDetails { get; set; }
            public class GetManagedRuleResponseBodyManagedRuleSourceDetails : TeaModel {
                /// <summary>
                /// <para>The interval at which the rule is triggered. Valid values: Valid values:</para>
                /// <list type="bullet">
                /// <item><description>One_Hour</description></item>
                /// <item><description>Three_Hours</description></item>
                /// <item><description>Six_Hours</description></item>
                /// <item><description>Twelve_Hours</description></item>
                /// <item><description>TwentyFour_Hours</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TwentyFour_Hours</para>
                /// </summary>
                [NameInMap("MaximumExecutionFrequency")]
                [Validation(Required=false)]
                public string MaximumExecutionFrequency { get; set; }

                /// <summary>
                /// <para>The trigger type of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ConfigurationItemChangeNotification: The rule is triggered by configuration changes.</description></item>
                /// <item><description>ScheduledNotification: The rule is periodically triggered.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ConfigurationItemChangeNotification</para>
                /// </summary>
                [NameInMap("MessageType")]
                [Validation(Required=false)]
                public string MessageType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E6DDC09-87C1-5310-A924-3491EAAE6F90</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
