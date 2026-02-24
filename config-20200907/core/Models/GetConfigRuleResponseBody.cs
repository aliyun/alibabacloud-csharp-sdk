// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetConfigRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the rule.</para>
        /// </summary>
        [NameInMap("ConfigRule")]
        [Validation(Required=false)]
        public GetConfigRuleResponseBodyConfigRule ConfigRule { get; set; }
        public class GetConfigRuleResponseBodyConfigRule : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the rule belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120886317861****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The compliance statistics of the rule.</para>
            /// </summary>
            [NameInMap("Compliance")]
            [Validation(Required=false)]
            public GetConfigRuleResponseBodyConfigRuleCompliance Compliance { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleCompliance : TeaModel {
                /// <summary>
                /// <para>The compliance evaluation result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>COMPLIANT: The resource is compliant.</para>
                /// </description></item>
                /// <item><description><para>NON_COMPLIANT: The resource is non-compliant.</para>
                /// </description></item>
                /// <item><description><para>NOT_APPLICABLE: The rule does not apply to the resource.</para>
                /// </description></item>
                /// <item><description><para>INSUFFICIENT_DATA: No data is available.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NON_COMPLIANT</para>
                /// </summary>
                [NameInMap("ComplianceType")]
                [Validation(Required=false)]
                public string ComplianceType { get; set; }

                /// <summary>
                /// <para>The number of resources that are evaluated based on the compliance result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

            }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:config::100931896542****:rule/cr-7f7d626622af0041****</para>
            /// </summary>
            [NameInMap("ConfigRuleArn")]
            [Validation(Required=false)]
            public string ConfigRuleArn { get; set; }

            /// <summary>
            /// <para>The execution status of the rule.</para>
            /// </summary>
            [NameInMap("ConfigRuleEvaluationStatus")]
            [Validation(Required=false)]
            public GetConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus ConfigRuleEvaluationStatus { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus : TeaModel {
                /// <summary>
                /// <para>The timestamp when the rule was first activated. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624932221993</para>
                /// </summary>
                [NameInMap("FirstActivatedTimestamp")]
                [Validation(Required=false)]
                public long? FirstActivatedTimestamp { get; set; }

                /// <summary>
                /// <para>Indicates whether the rule has been evaluated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: The rule has been evaluated.</para>
                /// </description></item>
                /// <item><description><para>false: The rule has not been evaluated.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FirstEvaluationStarted")]
                [Validation(Required=false)]
                public bool? FirstEvaluationStarted { get; set; }

                /// <summary>
                /// <para>The error code returned for the last failed execution of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TimeOut</para>
                /// </summary>
                [NameInMap("LastErrorCode")]
                [Validation(Required=false)]
                public string LastErrorCode { get; set; }

                /// <summary>
                /// <para>The error message returned for the last failed execution of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Time out</para>
                /// </summary>
                [NameInMap("LastErrorMessage")]
                [Validation(Required=false)]
                public string LastErrorMessage { get; set; }

                /// <summary>
                /// <para>The timestamp when the last failed evaluation of the rule ended. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614687022000</para>
                /// </summary>
                [NameInMap("LastFailedEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedEvaluationTimestamp { get; set; }

                /// <summary>
                /// <para>The timestamp when the last failed invocation of the rule started. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614687022000</para>
                /// </summary>
                [NameInMap("LastFailedInvocationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedInvocationTimestamp { get; set; }

                /// <summary>
                /// <para>The timestamp when the last successful evaluation of the rule ended. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624932227486</para>
                /// </summary>
                [NameInMap("LastSuccessfulEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastSuccessfulEvaluationTimestamp { get; set; }

                /// <summary>
                /// <para>The timestamp when the last successful invocation of the rule started. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624932227476</para>
                /// </summary>
                [NameInMap("LastSuccessfulInvocationTimestamp")]
                [Validation(Required=false)]
                public long? LastSuccessfulInvocationTimestamp { get; set; }

            }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cr-7f7d626622af0041****</para>
            /// </summary>
            [NameInMap("ConfigRuleId")]
            [Validation(Required=false)]
            public string ConfigRuleId { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RAM用户开启MFA</para>
            /// </summary>
            [NameInMap("ConfigRuleName")]
            [Validation(Required=false)]
            public string ConfigRuleName { get; set; }

            /// <summary>
            /// <para>The status of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ACTIVE: The rule is enabled.</para>
            /// </description></item>
            /// <item><description><para>DELETING: The rule is being deleted.</para>
            /// </description></item>
            /// <item><description><para>EVALUATING: The rule is being used to evaluate resource configurations.</para>
            /// </description></item>
            /// <item><description><para>INACTIVE: The rule is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("ConfigRuleState")]
            [Validation(Required=false)]
            public string ConfigRuleState { get; set; }

            /// <summary>
            /// <para>The trigger type of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ConfigurationItemChangeNotification: The rule is triggered by configuration changes.</para>
            /// </description></item>
            /// <item><description><para>ScheduledNotification: The rule is triggered periodically.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ConfigurationItemChangeNotification</para>
            /// </summary>
            [NameInMap("ConfigRuleTriggerTypes")]
            [Validation(Required=false)]
            public string ConfigRuleTriggerTypes { get; set; }

            /// <summary>
            /// <para>The information about the creator of the rule.</para>
            /// </summary>
            [NameInMap("CreateBy")]
            [Validation(Required=false)]
            public GetConfigRuleResponseBodyConfigRuleCreateBy CreateBy { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleCreateBy : TeaModel {
                /// <summary>
                /// <para>The ID of the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cp-541e626622af008****</para>
                /// </summary>
                [NameInMap("CompliancePackId")]
                [Validation(Required=false)]
                public string CompliancePackId { get; set; }

                /// <summary>
                /// <para>The name of the compliance package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OSS合规基线</para>
                /// </summary>
                [NameInMap("CompliancePackName")]
                [Validation(Required=false)]
                public string CompliancePackName { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account that was used to create the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100931896542****</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The name of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alice</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

            }

            /// <summary>
            /// <para>The timestamp when the rule was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1604684022000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RAM用户开启MFA，视为“合规”。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The IDs of the regions where the rule does not apply. The rule does not evaluate resources in these regions. Separate multiple region IDs with a comma (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ExcludeRegionIdsScope")]
            [Validation(Required=false)]
            public string ExcludeRegionIdsScope { get; set; }

            /// <summary>
            /// <para>The IDs of the resource groups where the rule does not apply. The rule does not evaluate resources in these resource groups. Separate multiple resource group IDs with a comma (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzdibsjjc****</para>
            /// </summary>
            [NameInMap("ExcludeResourceGroupIdsScope")]
            [Validation(Required=false)]
            public string ExcludeResourceGroupIdsScope { get; set; }

            /// <summary>
            /// <para>The IDs of the resources that are not evaluated by the rule. Separate multiple resource IDs with a comma (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>23642660635687****</para>
            /// </summary>
            [NameInMap("ExcludeResourceIdsScope")]
            [Validation(Required=false)]
            public string ExcludeResourceIdsScope { get; set; }

            /// <summary>
            /// <para>The tags of the resources that are not evaluated by the rule.</para>
            /// </summary>
            [NameInMap("ExcludeTagsScope")]
            [Validation(Required=false)]
            public List<GetConfigRuleResponseBodyConfigRuleExcludeTagsScope> ExcludeTagsScope { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleExcludeTagsScope : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key-2</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value-2</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The extended content. This parameter is used only to specify the trigger time for a rule that is triggered on a 24-hour cycle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;fixedHour&quot;:&quot;12&quot;}</para>
            /// </summary>
            [NameInMap("ExtendContent")]
            [Validation(Required=false)]
            public string ExtendContent { get; set; }

            /// <summary>
            /// <para>The input parameters of the rule.</para>
            /// </summary>
            [NameInMap("InputParameters")]
            [Validation(Required=false)]
            public Dictionary<string, object> InputParameters { get; set; }

            /// <summary>
            /// <para>The details of the managed rule.</para>
            /// </summary>
            [NameInMap("ManagedRule")]
            [Validation(Required=false)]
            public GetConfigRuleResponseBodyConfigRuleManagedRule ManagedRule { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleManagedRule : TeaModel {
                /// <summary>
                /// <para>The details of the required input parameters of the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("CompulsoryInputParameterDetails")]
                [Validation(Required=false)]
                public Dictionary<string, object> CompulsoryInputParameterDetails { get; set; }

                /// <summary>
                /// <para>The description of the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS磁盘未因欠费或安全等原因而被锁定，视为“合规”。</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The identifier of the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ram-user-mfa-check</para>
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <para>The list of rule labels.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<string> Labels { get; set; }

                /// <summary>
                /// <para>The name of the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RAM用户开启MFA</para>
                /// </summary>
                [NameInMap("ManagedRuleName")]
                [Validation(Required=false)]
                public string ManagedRuleName { get; set; }

                /// <summary>
                /// <para>The details of the optional input parameters of the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("OptionalInputParameterDetails")]
                [Validation(Required=false)]
                public Dictionary<string, object> OptionalInputParameterDetails { get; set; }

                /// <summary>
                /// <para>The source details of the managed rule.</para>
                /// </summary>
                [NameInMap("SourceDetails")]
                [Validation(Required=false)]
                public List<GetConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails> SourceDetails { get; set; }
                public class GetConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails : TeaModel {
                    /// <summary>
                    /// <para>The event source.</para>
                    /// <remarks>
                    /// <para>Only Cloud Config events are supported. The value is aliyun.config.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliyun.config</para>
                    /// </summary>
                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    /// <summary>
                    /// <para>The execution frequency of the rule. Valid values:</para>
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
                    /// <remarks>
                    /// <para>This parameter is returned only when the rule is triggered periodically.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>One_Hour</para>
                    /// </summary>
                    [NameInMap("MaximumExecutionFrequency")]
                    [Validation(Required=false)]
                    public string MaximumExecutionFrequency { get; set; }

                    /// <summary>
                    /// <para>The trigger type of the rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>ConfigurationItemChangeNotification: The rule is triggered by configuration changes.</para>
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
            /// <para>The execution frequency of the rule. Valid values:</para>
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
            /// <remarks>
            /// <para>This parameter is returned only when the rule is triggered periodically.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>One_Hour</para>
            /// </summary>
            [NameInMap("MaximumExecutionFrequency")]
            [Validation(Required=false)]
            public string MaximumExecutionFrequency { get; set; }

            /// <summary>
            /// <para>The timestamp when the rule was last updated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1614687022000</para>
            /// </summary>
            [NameInMap("ModifiedTimestamp")]
            [Validation(Required=false)]
            public long? ModifiedTimestamp { get; set; }

            /// <summary>
            /// <para>The IDs of the regions where the rule applies. The rule evaluates only resources in these regions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("RegionIdsScope")]
            [Validation(Required=false)]
            public string RegionIdsScope { get; set; }

            /// <summary>
            /// <para>The IDs of the resource groups where the rule applies. The rule evaluates only resources in these resource groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzdibsjjc****</para>
            /// </summary>
            [NameInMap("ResourceGroupIdsScope")]
            [Validation(Required=false)]
            public string ResourceGroupIdsScope { get; set; }

            /// <summary>
            /// <para>The IDs of the resources that are evaluated by the rule. Separate multiple resource IDs with a comma (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-8vbf3x310fn56ijfd****</para>
            /// </summary>
            [NameInMap("ResourceIdsScope")]
            [Validation(Required=false)]
            public string ResourceIdsScope { get; set; }

            /// <summary>
            /// <para>The rule evaluates only resources that have the specified names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-xxx</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("ResourceNameScope")]
            [Validation(Required=false)]
            public string ResourceNameScope { get; set; }

            /// <summary>
            /// <para>The types of the resources that are evaluated by the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::RAM::User</para>
            /// </summary>
            [NameInMap("ResourceTypesScope")]
            [Validation(Required=false)]
            public string ResourceTypesScope { get; set; }

            /// <summary>
            /// <para>The risk level of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: high</para>
            /// </description></item>
            /// <item><description><para>2: medium</para>
            /// </description></item>
            /// <item><description><para>3: low</para>
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
            /// <para>The effective scope of the rule.</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public GetConfigRuleResponseBodyConfigRuleScope Scope { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleScope : TeaModel {
                /// <summary>
                /// <para>The list of resource types that are evaluated by the rule. You can also view this information in the ResourceTypesScope field.</para>
                /// </summary>
                [NameInMap("ComplianceResourceTypes")]
                [Validation(Required=false)]
                public List<string> ComplianceResourceTypes { get; set; }

            }

            /// <summary>
            /// <para>The source of the rule.</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public GetConfigRuleResponseBodyConfigRuleSource Source { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleSource : TeaModel {
                /// <summary>
                /// <para>The identifier of the rule.</para>
                /// <list type="bullet">
                /// <item><description><para>If the rule is a managed rule, the value of this parameter is the identifier of the managed rule.</para>
                /// </description></item>
                /// <item><description><para>If the rule is a custom rule, the value of this parameter is the ARN of the function.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>acs:fc:cn-hangzhou:100931896542****:services/ConfigService.LATEST/functions/specific-config</para>
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <para>The owner of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>CUSTOM_FC: a custom rule.</para>
                /// </description></item>
                /// <item><description><para>ALIYUN: a managed rule.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The source details.</para>
                /// </summary>
                [NameInMap("SourceDetails")]
                [Validation(Required=false)]
                public List<GetConfigRuleResponseBodyConfigRuleSourceSourceDetails> SourceDetails { get; set; }
                public class GetConfigRuleResponseBodyConfigRuleSourceSourceDetails : TeaModel {
                    /// <summary>
                    /// <para>The event source.</para>
                    /// <remarks>
                    /// <para>Only Cloud Config events are supported. The value is aliyun.config.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliyun.config</para>
                    /// </summary>
                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    /// <summary>
                    /// <para>The execution frequency of the rule. Valid values:</para>
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
                    /// <remarks>
                    /// <para>This parameter is returned only when the rule is triggered periodically.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>One_Hour</para>
                    /// </summary>
                    [NameInMap("MaximumExecutionFrequency")]
                    [Validation(Required=false)]
                    public string MaximumExecutionFrequency { get; set; }

                    /// <summary>
                    /// <para>The trigger type of the rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>ConfigurationItemChangeNotification: The rule is triggered by configuration changes.</para>
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
            /// <para>This parameter is not returned for rules that are created using the <c>TagsScope</c> parameter.</para>
            /// <para>This parameter is returned for rules that are created using the deprecated TagKeyScope parameter. We do not recommend that you use the <c>TagKeyScope</c> parameter. For example, if <c>TagKeyScope</c> is set to <c>ECS,OSS</c> and this parameter is set to <c>AND</c>, the rule applies only to resources that have both the <c>ECS</c> and <c>OSS</c> tags.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>AND</para>
            /// </description></item>
            /// <item><description><para>OR</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OR</para>
            /// </summary>
            [NameInMap("TagKeyLogicScope")]
            [Validation(Required=false)]
            public string TagKeyLogicScope { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>This parameter is deprecated. Use the <c>TagsScope</c> parameter instead.</para>
            /// <para>The rule applies only to resources with the specified tag.</para>
            /// <remarks>
            /// <para>The <c>TagKeyScope</c> and <c>TagValueScope</c> parameters are returned at the same time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>RAM</para>
            /// </summary>
            [NameInMap("TagKeyScope")]
            [Validation(Required=false)]
            [Obsolete]
            public string TagKeyScope { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>This parameter is deprecated. Use the <c>TagsScope</c> parameter instead.</para>
            /// <para>The rule applies only to resources with the specified tag.</para>
            /// <remarks>
            /// <para>The <c>TagKeyScope</c> and <c>TagValueScope</c> parameters are returned at the same time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>MFA</para>
            /// </summary>
            [NameInMap("TagValueScope")]
            [Validation(Required=false)]
            [Obsolete]
            public string TagValueScope { get; set; }

            /// <summary>
            /// <para>The tags of the resource.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetConfigRuleResponseBodyConfigRuleTags> Tags { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key-1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value-1</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The tag-based scope.</para>
            /// </summary>
            [NameInMap("TagsScope")]
            [Validation(Required=false)]
            public List<GetConfigRuleResponseBodyConfigRuleTagsScope> TagsScope { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleTagsScope : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key-1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value-1</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>811234F4-C3AB-4D15-B90B-F55016D1B5AA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
