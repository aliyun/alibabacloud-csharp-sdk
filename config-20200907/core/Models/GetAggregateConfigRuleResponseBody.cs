// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateConfigRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The rules.</para>
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
            /// <para>The IDs of the members to which the rule applies. Separate multiple member IDs with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>120886317861****</para>
            /// </summary>
            [NameInMap("AccountIdsScope")]
            [Validation(Required=false)]
            public string AccountIdsScope { get; set; }

            /// <summary>
            /// <para>The details of compliance evaluation results.</para>
            /// </summary>
            [NameInMap("Compliance")]
            [Validation(Required=false)]
            public GetAggregateConfigRuleResponseBodyConfigRuleCompliance Compliance { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleCompliance : TeaModel {
                /// <summary>
                /// <para>The statistics on the compliance evaluation results by compliance type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>COMPLIANT: The resources are evaluated as compliant.</description></item>
                /// <item><description>NON_COMPLIANT: The resources are evaluated as non-compliant.</description></item>
                /// <item><description>NOT_APPLICABLE: The rule does not apply to your resources.</description></item>
                /// <item><description>INSUFFICIENT_DATA: No resource data is available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NON_COMPLIANT</para>
                /// </summary>
                [NameInMap("ComplianceType")]
                [Validation(Required=false)]
                public string ComplianceType { get; set; }

                /// <summary>
                /// <para>The number of evaluated resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

            }

            /// <summary>
            /// <para>The ARN of the managed rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:config::100931896542****:rule/cr-7f7d626622af0041****</para>
            /// </summary>
            [NameInMap("ConfigRuleArn")]
            [Validation(Required=false)]
            public string ConfigRuleArn { get; set; }

            /// <summary>
            /// <para>The information about compliance evaluations performed by the rule.</para>
            /// </summary>
            [NameInMap("ConfigRuleEvaluationStatus")]
            [Validation(Required=false)]
            public GetAggregateConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus ConfigRuleEvaluationStatus { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus : TeaModel {
                /// <summary>
                /// <para>The timestamp when the rule was first triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624932221993</para>
                /// </summary>
                [NameInMap("FirstActivatedTimestamp")]
                [Validation(Required=false)]
                public long? FirstActivatedTimestamp { get; set; }

                /// <summary>
                /// <para>Indicates whether resources were evaluated based on the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Resources were evaluated based on the rule.</description></item>
                /// <item><description>false: Resources were not evaluated based on the rule.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FirstEvaluationStarted")]
                [Validation(Required=false)]
                public bool? FirstEvaluationStarted { get; set; }

                /// <summary>
                /// <para>The error code returned for the last failed compliance evaluation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TimeOut</para>
                /// </summary>
                [NameInMap("LastErrorCode")]
                [Validation(Required=false)]
                public string LastErrorCode { get; set; }

                /// <summary>
                /// <para>The error message returned for the last failed compliance evaluation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>time out</para>
                /// </summary>
                [NameInMap("LastErrorMessage")]
                [Validation(Required=false)]
                public string LastErrorMessage { get; set; }

                /// <summary>
                /// <para>The timestamp when the last failed compliance evaluation of the rule ended. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614687022000</para>
                /// </summary>
                [NameInMap("LastFailedEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedEvaluationTimestamp { get; set; }

                /// <summary>
                /// <para>The timestamp when the last failed compliance evaluation of the rule started. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614687022000</para>
                /// </summary>
                [NameInMap("LastFailedInvocationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedInvocationTimestamp { get; set; }

                /// <summary>
                /// <para>The timestamp when the last successful compliance evaluation of the rule ended. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624932227486</para>
                /// </summary>
                [NameInMap("LastSuccessfulEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastSuccessfulEvaluationTimestamp { get; set; }

                /// <summary>
                /// <para>The timestamp when the last successful compliance evaluation of the rule started. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624932227476</para>
                /// </summary>
                [NameInMap("LastSuccessfulInvocationTimestamp")]
                [Validation(Required=false)]
                public long? LastSuccessfulInvocationTimestamp { get; set; }

            }

            /// <summary>
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cr-7f7d626622af0041****</para>
            /// </summary>
            [NameInMap("ConfigRuleId")]
            [Validation(Required=false)]
            public string ConfigRuleId { get; set; }

            /// <summary>
            /// <para>The name of the monitoring rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The name of the rule.</para>
            /// </summary>
            [NameInMap("ConfigRuleName")]
            [Validation(Required=false)]
            public string ConfigRuleName { get; set; }

            /// <summary>
            /// <para>The status of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ACTIVE: The rule is being used to monitor resource configurations.</description></item>
            /// <item><description>DELETING: The rule is being deleted.</description></item>
            /// <item><description>EVALUATING: The rule is triggered and is being used to monitor resource configurations.</description></item>
            /// <item><description>INACTIVE: The rule is disabled and is no longer used to monitor resource configurations.</description></item>
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
            /// <item><description>ConfigurationItemChangeNotification: The managed rule is triggered by configuration changes.</description></item>
            /// <item><description>ScheduledNotification: The managed rule is periodically triggered.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ConfigurationItemChangeNotification</para>
            /// </summary>
            [NameInMap("ConfigRuleTriggerTypes")]
            [Validation(Required=false)]
            public string ConfigRuleTriggerTypes { get; set; }

            /// <summary>
            /// <para>The information about the creation of the rule.</para>
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
                /// <para>The name of the compliance package.</para>
                /// </summary>
                [NameInMap("CompliancePackName")]
                [Validation(Required=false)]
                public string CompliancePackName { get; set; }

                /// <summary>
                /// <para>The ID of the account that was used to create the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100931896542****</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The name of the account that was used to create the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alice</para>
                /// </summary>
                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                /// <summary>
                /// <para>The type of the entity to which the rule belongs. The value is fixed to <c>AGGREGATOR</c>, which indicates an account group.</para>
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
            /// <para>The description of the managed rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The description of the managed rule.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the member account to which the rule does not apply, which means that the resources within the member account are not evaluated based on the rule.</para>
            /// <remarks>
            /// <para> This parameter applies only to a managed rule.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>120886317861****</para>
            /// </summary>
            [NameInMap("ExcludeAccountIdsScope")]
            [Validation(Required=false)]
            public string ExcludeAccountIdsScope { get; set; }

            /// <summary>
            /// <para>The ID of the resource directory to which the rule does not apply, which means that the resources within member accounts in the resource directory are not evaluated based on the rule.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>This parameter applies only to a rule of a global account group.</description></item>
            /// <item><description>This parameter applies only to a managed rule.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fd-pWmkqZ****</para>
            /// </summary>
            [NameInMap("ExcludeFolderIdsScope")]
            [Validation(Required=false)]
            public string ExcludeFolderIdsScope { get; set; }

            /// <summary>
            /// <para>The IDs of the regions excluded from the compliance evaluations performed by the rule. Separate multiple region IDs with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ExcludeRegionIdsScope")]
            [Validation(Required=false)]
            public string ExcludeRegionIdsScope { get; set; }

            /// <summary>
            /// <para>The IDs of the resource groups excluded from the compliance evaluations performed by the rule. Separate multiple resource group IDs with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzdibsjjc****</para>
            /// </summary>
            [NameInMap("ExcludeResourceGroupIdsScope")]
            [Validation(Required=false)]
            public string ExcludeResourceGroupIdsScope { get; set; }

            /// <summary>
            /// <para>The ID of the resource excluded from the compliance evaluations performed by the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23642660635687****</para>
            /// </summary>
            [NameInMap("ExcludeResourceIdsScope")]
            [Validation(Required=false)]
            public string ExcludeResourceIdsScope { get; set; }

            /// <summary>
            /// <para>The scope of the tag that is excluded.</para>
            /// </summary>
            [NameInMap("ExcludeTagsScope")]
            [Validation(Required=false)]
            public List<GetAggregateConfigRuleResponseBodyConfigRuleExcludeTagsScope> ExcludeTagsScope { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleExcludeTagsScope : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key-2</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value-2</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The extended content, which is temporarily only used to configure the trigger time with a 24-hour cycle trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;fixedHour&quot;:&quot;12&quot;}</para>
            /// </summary>
            [NameInMap("ExtendContent")]
            [Validation(Required=false)]
            public string ExtendContent { get; set; }

            /// <summary>
            /// <para>The ID of the resource directory to which the rule applies, which means that the resources within member accounts in the resource directory are evaluated based on the rule.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>This parameter applies only to rules of a global account group.</description></item>
            /// <item><description>This parameter applies only to managed rules.</description></item>
            /// </list>
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
                /// <para>The required input parameters of the managed rule.</para>
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
                /// <para>The description of the managed rule.</para>
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
                /// <para>The tags of the managed rule.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<string> Labels { get; set; }

                /// <summary>
                /// <para>The name of the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ram-user-mfa-check</para>
                /// </summary>
                [NameInMap("ManagedRuleName")]
                [Validation(Required=false)]
                public string ManagedRuleName { get; set; }

                /// <summary>
                /// <para>The optional input parameters of the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("OptionalInputParameterDetails")]
                [Validation(Required=false)]
                public Dictionary<string, object> OptionalInputParameterDetails { get; set; }

                /// <summary>
                /// <para>The details of the source of the managed rule.</para>
                /// </summary>
                [NameInMap("SourceDetails")]
                [Validation(Required=false)]
                public List<GetAggregateConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails> SourceDetails { get; set; }
                public class GetAggregateConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails : TeaModel {
                    /// <summary>
                    /// <para>The event source of the managed rule.</para>
                    /// <remarks>
                    /// <para> Only events related to Cloud Config are supported. The value is fixed to aliyun.config.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliyun.config</para>
                    /// </summary>
                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    /// <summary>
                    /// <para>The intervals at which the managed rule is triggered. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>One_Hour: 1 hour.</description></item>
                    /// <item><description>Three_Hours: 3 hours.</description></item>
                    /// <item><description>Six_Hours: 6 hours.</description></item>
                    /// <item><description>Twelve_Hours: 12 hours</description></item>
                    /// <item><description>TwentyFour_Hours: 24 hours</description></item>
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
                    /// <item><description>ConfigurationItemChangeNotification: The managed rule is triggered by configuration changes.</description></item>
                    /// <item><description>ScheduledNotification: The managed rule is periodically triggered.</description></item>
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
            /// <para>The intervals at which the managed rule is triggered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>One_Hour: 1 hour.</description></item>
            /// <item><description>Three_Hours: 3 hours.</description></item>
            /// <item><description>Six_Hours: 6 hours.</description></item>
            /// <item><description>Twelve_Hours: 12 hours</description></item>
            /// <item><description>TwentyFour_Hours: 24 hours</description></item>
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
            /// <para>The ID of the region to which the rule applies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("RegionIdsScope")]
            [Validation(Required=false)]
            public string RegionIdsScope { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the rule applies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzdibsjjc****</para>
            /// </summary>
            [NameInMap("ResourceGroupIdsScope")]
            [Validation(Required=false)]
            public string ResourceGroupIdsScope { get; set; }

            /// <summary>
            /// <para>The IDs of the resources to which the rule applies. Separate multiple resource IDs with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-8vbf3x310fn56ijfd****</para>
            /// </summary>
            [NameInMap("ResourceIdsScope")]
            [Validation(Required=false)]
            public string ResourceIdsScope { get; set; }

            /// <summary>
            /// <para>The type of the resource evaluated by the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::RAM::User</para>
            /// </summary>
            [NameInMap("ResourceTypesScope")]
            [Validation(Required=false)]
            public string ResourceTypesScope { get; set; }

            /// <summary>
            /// <para>The risk level of the resources that are not compliant with the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: high risk level</description></item>
            /// <item><description>2: medium risk level</description></item>
            /// <item><description>3: low risk level</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public int? RiskLevel { get; set; }

            /// <summary>
            /// <para>The information about how the rule was created.</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public GetAggregateConfigRuleResponseBodyConfigRuleSource Source { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleSource : TeaModel {
                /// <summary>
                /// <para>The identifier of the rule.</para>
                /// <list type="bullet">
                /// <item><description>If the rule was created based on a managed rule, the value of this parameter is the name of the managed rule.</description></item>
                /// <item><description>If the rule is a custom rule, the value of this parameter is the Alibaba Cloud Resource Name (ARN) of the relevant function in Function Compute.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>acs:fc:cn-hangzhou:100931896542****:services/ConfigService.LATEST/functions/specific-config</para>
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <para>The way in which the rule was created. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CUSTOM_FC: The rule is a custom rule.</description></item>
                /// <item><description>ALIYUN: The rule was created based on a managed rule of Alibaba Cloud.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ALIYUN</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The details of the source of the rule.</para>
                /// </summary>
                [NameInMap("SourceDetails")]
                [Validation(Required=false)]
                public List<GetAggregateConfigRuleResponseBodyConfigRuleSourceSourceDetails> SourceDetails { get; set; }
                public class GetAggregateConfigRuleResponseBodyConfigRuleSourceSourceDetails : TeaModel {
                    /// <summary>
                    /// <para>The event source of the managed rule.</para>
                    /// <remarks>
                    /// <para> Only events related to Cloud Config are supported. The value is fixed to aliyun.config.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliyun.config</para>
                    /// </summary>
                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    /// <summary>
                    /// <para>The intervals at which the managed rule is triggered. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>One_Hour: 1 hour.</description></item>
                    /// <item><description>Three_Hours: 3 hours.</description></item>
                    /// <item><description>Six_Hours: 6 hours.</description></item>
                    /// <item><description>Twelve_Hours: 12 hours</description></item>
                    /// <item><description>TwentyFour_Hours: 24 hours</description></item>
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
                    /// <item><description>ConfigurationItemChangeNotification: The managed rule is triggered by configuration changes.</description></item>
                    /// <item><description>ScheduledNotification: The managed rule is periodically triggered.</description></item>
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
            /// <para>The logical relationship among the tag keys if you specify multiple tag keys by using the <c>TagKeyScope</c> parameter. For example, if the <c>TagKeyScope</c> parameter is set to <c>ECS,OSS</c> and the TagKeyLogicScope parameter is set to <c>AND</c>, the rule applies to resources with both the <c>ECS</c> and <c>OSS</c> tag keys. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AND: the logical relationship of AND</description></item>
            /// <item><description>OR: the logical relationship of OR</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AND</para>
            /// </summary>
            [NameInMap("TagKeyLogicScope")]
            [Validation(Required=false)]
            public string TagKeyLogicScope { get; set; }

            /// <summary>
            /// <para>The tag key used to filter resources. The rule applies only to the resources with the specified tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RAM</para>
            /// </summary>
            [NameInMap("TagKeyScope")]
            [Validation(Required=false)]
            public string TagKeyScope { get; set; }

            /// <summary>
            /// <para>The tag value used to filter resources. The rule applies only to the resources with the specified tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MFA</para>
            /// </summary>
            [NameInMap("TagValueScope")]
            [Validation(Required=false)]
            public string TagValueScope { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetAggregateConfigRuleResponseBodyConfigRuleTags> Tags { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleTags : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The tag scope.</para>
            /// </summary>
            [NameInMap("TagsScope")]
            [Validation(Required=false)]
            public List<GetAggregateConfigRuleResponseBodyConfigRuleTagsScope> TagsScope { get; set; }
            public class GetAggregateConfigRuleResponseBodyConfigRuleTagsScope : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key-1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>811234F4-C3AB-4D15-B90B-F55016D1B5AA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
