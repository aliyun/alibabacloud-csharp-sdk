// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateConfigRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the rule.</para>
        /// </summary>
        [NameInMap("ConfigRule")]
        [Validation(Required=false)]
        public GetAggregateConfigRuleResponseBodyConfigRule ConfigRule { get; set; }
        public class GetAggregateConfigRuleResponseBodyConfigRule : TeaModel {
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
            /// <para>The rule applies only to resources in the specified member accounts. Separate multiple member account IDs with a comma (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>120886317861****</para>
            /// </summary>
            [NameInMap("AccountIdsScope")]
            [Validation(Required=false)]
            public string AccountIdsScope { get; set; }

            /// <summary>
            /// <para>The compliance statistics of the rule.</para>
            /// </summary>
            [NameInMap("Compliance")]
            [Validation(Required=false)]
            public GetAggregateConfigRuleResponseBodyConfigRuleCompliance Compliance { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleCompliance : TeaModel {
                /// <summary>
                /// <para>The compliance evaluation result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>COMPLIANT: The resource is compliant.</para>
                /// </description></item>
                /// <item><description><para>NON_COMPLIANT: The resource is not compliant.</para>
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
                /// <para>The number of resources that have the corresponding compliance evaluation result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

            }

            /// <summary>
            /// <para>The ARN of the rule.</para>
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
            public GetAggregateConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus ConfigRuleEvaluationStatus { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus : TeaModel {
                /// <summary>
                /// <para>The timestamp when the rule was first activated.</para>
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
                /// <para>time out</para>
                /// </summary>
                [NameInMap("LastErrorMessage")]
                [Validation(Required=false)]
                public string LastErrorMessage { get; set; }

                /// <summary>
                /// <para>The timestamp of the last failed evaluation. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614687022000</para>
                /// </summary>
                [NameInMap("LastFailedEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedEvaluationTimestamp { get; set; }

                /// <summary>
                /// <para>The timestamp of the last failed invocation. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614687022000</para>
                /// </summary>
                [NameInMap("LastFailedInvocationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedInvocationTimestamp { get; set; }

                /// <summary>
                /// <para>The timestamp of the last successful evaluation. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624932227486</para>
                /// </summary>
                [NameInMap("LastSuccessfulEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastSuccessfulEvaluationTimestamp { get; set; }

                /// <summary>
                /// <para>The timestamp of the last successful invocation. Unit: milliseconds.</para>
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
            /// <para>The name of the rule.</para>
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
            /// <item><description><para>EVALUATING: The rule is being evaluated.</para>
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
            public GetAggregateConfigRuleResponseBodyConfigRuleCreateBy CreateBy { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleCreateBy : TeaModel {
                /// <summary>
                /// <para>The ID of the account group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ca-04b3fd170e340007****</para>
                /// </summary>
                [NameInMap("AggregatorId")]
                [Validation(Required=false)]
                public string AggregatorId { get; set; }

                /// <summary>
                /// <para>The name of the account group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test_Group</para>
                /// </summary>
                [NameInMap("AggregatorName")]
                [Validation(Required=false)]
                public string AggregatorName { get; set; }

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
                /// <para>The ID of the account that created the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100931896542****</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The name of the rule creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alice</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>The type of the rule creator. Only <c>AGGREGATOR</c> (account group) is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AGGREGATOR</para>
                /// </summary>
                [NameInMap("CreatorType")]
                [Validation(Required=false)]
                public string CreatorType { get; set; }

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
            /// <para>The rule does not apply to resources in the specified member accounts. The system does not evaluate resources in these accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120886317861****</para>
            /// </summary>
            [NameInMap("ExcludeAccountIdsScope")]
            [Validation(Required=false)]
            public string ExcludeAccountIdsScope { get; set; }

            /// <summary>
            /// <para>The rule does not apply to resources within the member accounts in the specified folders of the resource directory. The system does not evaluate resources in these folders.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-pWmkqZ****</para>
            /// </summary>
            [NameInMap("ExcludeFolderIdsScope")]
            [Validation(Required=false)]
            public string ExcludeFolderIdsScope { get; set; }

            /// <summary>
            /// <para>The rule does not apply to resources in the specified regions. The system does not evaluate resources in these regions. Separate multiple region IDs with a comma (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ExcludeRegionIdsScope")]
            [Validation(Required=false)]
            public string ExcludeRegionIdsScope { get; set; }

            /// <summary>
            /// <para>The rule does not apply to resources in the specified resource groups. The system does not evaluate resources in these resource groups. Separate multiple resource group IDs with a comma (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzdibsjjc****</para>
            /// </summary>
            [NameInMap("ExcludeResourceGroupIdsScope")]
            [Validation(Required=false)]
            public string ExcludeResourceGroupIdsScope { get; set; }

            /// <summary>
            /// <para>The IDs of the resources that are not evaluated by the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23642660635687****</para>
            /// </summary>
            [NameInMap("ExcludeResourceIdsScope")]
            [Validation(Required=false)]
            public string ExcludeResourceIdsScope { get; set; }

            /// <summary>
            /// <para>The excluded scope of the tags.</para>
            /// </summary>
            [NameInMap("ExcludeTagsScope")]
            [Validation(Required=false)]
            public List<GetAggregateConfigRuleResponseBodyConfigRuleExcludeTagsScope> ExcludeTagsScope { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleExcludeTagsScope : TeaModel {
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
            /// <para>The extended content. This parameter is used to configure the trigger time for a rule that is triggered on a 24-hour cycle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;fixedHour&quot;:&quot;12&quot;}</para>
            /// </summary>
            [NameInMap("ExtendContent")]
            [Validation(Required=false)]
            public string ExtendContent { get; set; }

            /// <summary>
            /// <para>The rule applies only to resources within the member accounts in the specified folders of the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd-ZtHsRH****</para>
            /// </summary>
            [NameInMap("FolderIdsScope")]
            [Validation(Required=false)]
            public string FolderIdsScope { get; set; }

            /// <summary>
            /// <para>The input parameters of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;tag1Key&quot;:&quot;ECS&quot;,&quot;tag1Value&quot;:&quot;test&quot;}</para>
            /// </summary>
            [NameInMap("InputParameters")]
            [Validation(Required=false)]
            public Dictionary<string, object> InputParameters { get; set; }

            /// <summary>
            /// <para>The details of the managed rule.</para>
            /// </summary>
            [NameInMap("ManagedRule")]
            [Validation(Required=false)]
            public GetAggregateConfigRuleResponseBodyConfigRuleManagedRule ManagedRule { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleManagedRule : TeaModel {
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
                /// <para>A list of labels for the managed rule.</para>
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
                /// <para>The details of the optional input parameters for the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("OptionalInputParameterDetails")]
                [Validation(Required=false)]
                public Dictionary<string, object> OptionalInputParameterDetails { get; set; }

                /// <summary>
                /// <para>The details of the managed rule source.</para>
                /// </summary>
                [NameInMap("SourceDetails")]
                [Validation(Required=false)]
                public List<GetAggregateConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails> SourceDetails { get; set; }
                public class GetAggregateConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails : TeaModel {
                    /// <summary>
                    /// <para>The event source.</para>
                    /// <remarks>
                    /// <para>Only Cloud Config events are supported: aliyun.config.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliyun.config</para>
                    /// </summary>
                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    /// <summary>
                    /// <para>The frequency at which the rule is executed.</para>
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
            /// <para>The frequency at which the rule is executed.</para>
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
            /// <para>The rule applies only to resources in the specified regions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("RegionIdsScope")]
            [Validation(Required=false)]
            public string RegionIdsScope { get; set; }

            /// <summary>
            /// <para>The rule applies only to resources in the specified resource groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzdibsjjc****</para>
            /// </summary>
            [NameInMap("ResourceGroupIdsScope")]
            [Validation(Required=false)]
            public string ResourceGroupIdsScope { get; set; }

            /// <summary>
            /// <para>The rule applies only to the specified resources. Separate multiple resource IDs with a comma (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-8vbf3x310fn56ijfd****</para>
            /// </summary>
            [NameInMap("ResourceIdsScope")]
            [Validation(Required=false)]
            public string ResourceIdsScope { get; set; }

            /// <summary>
            /// <para>The rule applies only to resources that have the specified names.</para>
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
            /// <para>The resource types that are evaluated by the rule.</para>
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
            /// <para>The source of the rule.</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public GetAggregateConfigRuleResponseBodyConfigRuleSource Source { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleSource : TeaModel {
                /// <summary>
                /// <para>The identifier of the rule.</para>
                /// <list type="bullet">
                /// <item><description><para>If the rule is a managed rule, the value of this parameter is the identifier of the managed rule.</para>
                /// </description></item>
                /// <item><description><para>If the rule is a custom rule, the value of this parameter is the Alibaba Cloud Resource Name (ARN) of the function.</para>
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
                /// <para>The details of the rule source.</para>
                /// </summary>
                [NameInMap("SourceDetails")]
                [Validation(Required=false)]
                public List<GetAggregateConfigRuleResponseBodyConfigRuleSourceSourceDetails> SourceDetails { get; set; }
                public class GetAggregateConfigRuleResponseBodyConfigRuleSourceSourceDetails : TeaModel {
                    /// <summary>
                    /// <para>The event source.</para>
                    /// <remarks>
                    /// <para>Only Cloud Config events are supported: aliyun.config.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliyun.config</para>
                    /// </summary>
                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    /// <summary>
                    /// <para>The frequency at which the rule is executed. Valid values:</para>
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
            /// <para>This parameter is returned only for rules that are created using the deprecated <c>TagKeyScope</c> parameter. For example, if <c>TagKeyScope</c> is set to <c>ECS,OSS</c> and this parameter is set to <c>AND</c>, the rule applies to resources that have both the <c>ECS</c> and <c>OSS</c> tags.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>AND</para>
            /// </description></item>
            /// <item><description><para>OR</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("TagKeyLogicScope")]
            [Validation(Required=false)]
            public string TagKeyLogicScope { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>This parameter is deprecated. Use the <c>TagsScope</c> parameter instead.</para>
            /// <para>The rule applies only to resources that have the specified tag key.</para>
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
            /// <para>The rule applies only to resources that have the specified tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MFA</para>
            /// </summary>
            [NameInMap("TagValueScope")]
            [Validation(Required=false)]
            [Obsolete]
            public string TagValueScope { get; set; }

            /// <summary>
            /// <para>The resource tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetAggregateConfigRuleResponseBodyConfigRuleTags> Tags { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleTags : TeaModel {
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
            /// <para>The scope of the tags.</para>
            /// </summary>
            [NameInMap("TagsScope")]
            [Validation(Required=false)]
            public List<GetAggregateConfigRuleResponseBodyConfigRuleTagsScope> TagsScope { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleTagsScope : TeaModel {
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
