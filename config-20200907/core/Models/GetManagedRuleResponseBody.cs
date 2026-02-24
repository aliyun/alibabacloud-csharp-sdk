// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetManagedRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the rule template.</para>
        /// </summary>
        [NameInMap("ManagedRule")]
        [Validation(Required=false)]
        public GetManagedRuleResponseBodyManagedRule ManagedRule { get; set; }
        public class GetManagedRuleResponseBodyManagedRule : TeaModel {
            /// <summary>
            /// <para>The information about the required input parameters for the rule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("CompulsoryInputParameterDetails")]
            [Validation(Required=false)]
            public Dictionary<string, object> CompulsoryInputParameterDetails { get; set; }

            /// <summary>
            /// <para>The name of the rule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CDN域名开启HTTPS加密</para>
            /// </summary>
            [NameInMap("ConfigRuleName")]
            [Validation(Required=false)]
            public string ConfigRuleName { get; set; }

            /// <summary>
            /// <para>The description of the rule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CDN域名开启HTTPS协议加密，视为“合规”。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The URL of the document that provides guidance on how to fix the issue.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.aliyundoc.com">https://example.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("HelpUrls")]
            [Validation(Required=false)]
            public string HelpUrls { get; set; }

            /// <summary>
            /// <para>The identifier of the rule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cdn-domain-https-enabled</para>
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <para>The labels of the rule template.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<string> Labels { get; set; }

            /// <summary>
            /// <para>The information about the optional input parameters for the rule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("OptionalInputParameterDetails")]
            [Validation(Required=false)]
            public Dictionary<string, object> OptionalInputParameterDetails { get; set; }

            /// <summary>
            /// <para>The risk level of the rule template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: high risk.</para>
            /// </description></item>
            /// <item><description><para>2: medium risk.</para>
            /// </description></item>
            /// <item><description><para>3: low risk.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            /// <summary>
            /// <para>The effective scope of the rule template.</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public GetManagedRuleResponseBodyManagedRuleScope Scope { get; set; }
            public class GetManagedRuleResponseBodyManagedRuleScope : TeaModel {
                /// <summary>
                /// <para>The resource types for which the rule template is effective.</para>
                /// </summary>
                [NameInMap("ComplianceResourceTypes")]
                [Validation(Required=false)]
                public List<string> ComplianceResourceTypes { get; set; }

            }

            /// <summary>
            /// <para>The trigger methods for the rule.</para>
            /// </summary>
            [NameInMap("SourceDetails")]
            [Validation(Required=false)]
            public List<GetManagedRuleResponseBodyManagedRuleSourceDetails> SourceDetails { get; set; }
            public class GetManagedRuleResponseBodyManagedRuleSourceDetails : TeaModel {
                /// <summary>
                /// <para>The execution period of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>One_Hour: 1 hour.</para>
                /// </description></item>
                /// <item><description><para>Three_Hours: 3 hours.</para>
                /// </description></item>
                /// <item><description><para>Six_Hours: 6 hours.</para>
                /// </description></item>
                /// <item><description><para>Twelve_Hours: 12 hours.</para>
                /// </description></item>
                /// <item><description><para>TwentyFour_Hours: 24 hours.</para>
                /// </description></item>
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
                /// <item><description><para>ConfigurationItemChangeNotification: The rule is triggered by a configuration change.</para>
                /// </description></item>
                /// <item><description><para>ScheduledNotification: The rule is triggered periodically.</para>
                /// </description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E6DDC09-87C1-5310-A924-3491EAAE6F90</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
