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
            /// <para>The details of compliance evaluation results.</para>
            /// </summary>
            [NameInMap("Compliance")]
            [Validation(Required=false)]
            public GetConfigRuleResponseBodyConfigRuleCompliance Compliance { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleCompliance : TeaModel {
                /// <summary>
                /// <para>The statistics on the compliance evaluation results by compliance type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>COMPLIANT: The resource was evaluated as compliant.</description></item>
                /// <item><description>NON_COMPLIANT: The resource was evaluated as incompliant.</description></item>
                /// <item><description>NOT_APPLICABLE: The rule did not apply to your resource.</description></item>
                /// <item><description>INSUFFICIENT_DATA: No resource data was available.</description></item>
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
            public GetConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus ConfigRuleEvaluationStatus { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleConfigRuleEvaluationStatus : TeaModel {
                /// <summary>
                /// <para>The timestamp generated when the rule was first triggered. Unit: millisecond.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624932221993</para>
                /// </summary>
                [NameInMap("FirstActivatedTimestamp")]
                [Validation(Required=false)]
                public long? FirstActivatedTimestamp { get; set; }

                /// <summary>
                /// <para>Indicates whether resource configurations were evaluated based on the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Resource configurations were evaluated based on the rule.</description></item>
                /// <item><description>false: Resource configurations were not evaluated based on the rule.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FirstEvaluationStarted")]
                [Validation(Required=false)]
                public bool? FirstEvaluationStarted { get; set; }

                /// <summary>
                /// <para>The error code returned for the previous failed compliance evaluation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TimeOut</para>
                /// </summary>
                [NameInMap("LastErrorCode")]
                [Validation(Required=false)]
                public string LastErrorCode { get; set; }

                /// <summary>
                /// <para>The error message returned for the previous failed compliance evaluation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Time out</para>
                /// </summary>
                [NameInMap("LastErrorMessage")]
                [Validation(Required=false)]
                public string LastErrorMessage { get; set; }

                /// <summary>
                /// <para>The timestamp generated when the previous failed compliance evaluation of the rule ended. Unit: millisecond.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614687022000</para>
                /// </summary>
                [NameInMap("LastFailedEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedEvaluationTimestamp { get; set; }

                /// <summary>
                /// <para>The timestamp generated when the previous failed compliance evaluation of the rule started. Unit: millisecond.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1614687022000</para>
                /// </summary>
                [NameInMap("LastFailedInvocationTimestamp")]
                [Validation(Required=false)]
                public long? LastFailedInvocationTimestamp { get; set; }

                /// <summary>
                /// <para>The timestamp generated when the previous successful compliance evaluation of the rule ended. Unit: millisecond.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1624932227486</para>
                /// </summary>
                [NameInMap("LastSuccessfulEvaluationTimestamp")]
                [Validation(Required=false)]
                public long? LastSuccessfulEvaluationTimestamp { get; set; }

                /// <summary>
                /// <para>The timestamp generated when the previous successful compliance evaluation of the rule started. Unit: millisecond.</para>
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
            /// <para>ecs-disk-auto-snapshot-policy</para>
            /// </summary>
            [NameInMap("ConfigRuleName")]
            [Validation(Required=false)]
            public string ConfigRuleName { get; set; }

            /// <summary>
            /// <para>The status of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ACTIVE: The rule is enabled.</description></item>
            /// <item><description>DELETING: The rule is being deleted.</description></item>
            /// <item><description>EVALUATING: The rule is being used to evaluate resource configurations.</description></item>
            /// <item><description>INACTIVE: The rule is disabled.</description></item>
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
            /// <item><description>ConfigurationItemChangeNotification: The rule was triggered by configuration changes.</description></item>
            /// <item><description>ScheduledNotification: The rule was periodically triggered.</description></item>
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
            public GetConfigRuleResponseBodyConfigRuleCreateBy CreateBy { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleCreateBy : TeaModel {
                /// <summary>
                /// <para>The compliance package ID.</para>
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
                /// <para>example-name</para>
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

            }

            /// <summary>
            /// <para>The timestamp generated when the rule was created. Unit: millisecond.</para>
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
            /// <para>example-description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>ExcludeRegionIdsScope</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("ExcludeRegionIdsScope")]
            [Validation(Required=false)]
            public string ExcludeRegionIdsScope { get; set; }

            /// <summary>
            /// <para>ExcludeResourceGroupIdsScope</para>
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
            /// <para>ExcludeTagsScope</para>
            /// </summary>
            [NameInMap("ExcludeTagsScope")]
            [Validation(Required=false)]
            public List<GetConfigRuleResponseBodyConfigRuleExcludeTagsScope> ExcludeTagsScope { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleExcludeTagsScope : TeaModel {
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
            /// <para>Optional field, only used in conjunction with the 24-hour cycle execution to set the trigger time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;fixedHour&quot;:&quot;12&quot;}</para>
            /// </summary>
            [NameInMap("ExtendContent")]
            [Validation(Required=false)]
            public string ExtendContent { get; set; }

            /// <summary>
            /// <para>The input parameters of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
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
                /// <para>The settings of the required input parameters for the managed rule.</para>
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
                /// <para>example-description</para>
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
                /// <para>The rule tags.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<string> Labels { get; set; }

                /// <summary>
                /// <para>The name of the managed rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-name</para>
                /// </summary>
                [NameInMap("ManagedRuleName")]
                [Validation(Required=false)]
                public string ManagedRuleName { get; set; }

                /// <summary>
                /// <para>The settings of the optional input parameters for the managed rule.</para>
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
                public List<GetConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails> SourceDetails { get; set; }
                public class GetConfigRuleResponseBodyConfigRuleManagedRuleSourceDetails : TeaModel {
                    /// <summary>
                    /// <para>The event source.</para>
                    /// <remarks>
                    /// <para> Only aliyun.config is returned, which indicates that only events related to Cloud Config are supported.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliyun.config</para>
                    /// </summary>
                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    /// <summary>
                    /// <para>The interval at which the rule is triggered. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>One_Hour</description></item>
                    /// <item><description>Three_Hours</description></item>
                    /// <item><description>Six_Hours</description></item>
                    /// <item><description>Twelve_Hours</description></item>
                    /// <item><description>TwentyFour_Hours</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> This parameter is returned if the rule is periodically triggered.</para>
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
            /// <para>The interval at which the rule is triggered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>One_Hour</description></item>
            /// <item><description>Three_Hours</description></item>
            /// <item><description>Six_Hours</description></item>
            /// <item><description>Twelve_Hours</description></item>
            /// <item><description>TwentyFour_Hours</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is returned if the rule is periodically triggered.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>One_Hour</para>
            /// </summary>
            [NameInMap("MaximumExecutionFrequency")]
            [Validation(Required=false)]
            public string MaximumExecutionFrequency { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the rule was last updated. Unit: millisecond.</para>
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
            /// <para>ResourceIdsScope</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-8vbf3x310fn56ijfd****</para>
            /// </summary>
            [NameInMap("ResourceIdsScope")]
            [Validation(Required=false)]
            public string ResourceIdsScope { get; set; }

            /// <summary>
            /// <para>The type of the resource to be evaluated by the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::RAM::User</para>
            /// </summary>
            [NameInMap("ResourceTypesScope")]
            [Validation(Required=false)]
            public string ResourceTypesScope { get; set; }

            /// <summary>
            /// <para>The risk level of the resources that do not comply with the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: high.</description></item>
            /// <item><description>2: medium.</description></item>
            /// <item><description>3: low.</description></item>
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
                /// <para>The types of the resources to be evaluated against the rule. You can also view the resource types by using the ResourceTypesScope parameter.</para>
                /// </summary>
                [NameInMap("ComplianceResourceTypes")]
                [Validation(Required=false)]
                public List<string> ComplianceResourceTypes { get; set; }

            }

            /// <summary>
            /// <para>The information about how the rule was created.</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public GetConfigRuleResponseBodyConfigRuleSource Source { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleSource : TeaModel {
                /// <summary>
                /// <para>The identifier of the rule.</para>
                /// <list type="bullet">
                /// <item><description>If the rule is a managed rule, the value of this parameter is the identifier of the managed rule.</description></item>
                /// <item><description>If the rule is a custom rule, the value of this parameter is the Alibaba Cloud Resource Name (ARN) of a function.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>acs:fc:cn-hangzhou:100931896542****:services/ConfigService.LATEST/functions/specific-config</para>
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <para>The type of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CUSTOM_FC: a custom rule.</description></item>
                /// <item><description>ALIYUN: a managed rule.</description></item>
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
                public List<GetConfigRuleResponseBodyConfigRuleSourceSourceDetails> SourceDetails { get; set; }
                public class GetConfigRuleResponseBodyConfigRuleSourceSourceDetails : TeaModel {
                    /// <summary>
                    /// <para>The event source.</para>
                    /// <remarks>
                    /// <para> Only aliyun.config is returned, which indicates that only events related to Cloud Config are supported.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliyun.config</para>
                    /// </summary>
                    [NameInMap("EventSource")]
                    [Validation(Required=false)]
                    public string EventSource { get; set; }

                    /// <summary>
                    /// <para>The interval at which the rule is triggered. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>One_Hour</description></item>
                    /// <item><description>Three_Hours</description></item>
                    /// <item><description>Six_Hours</description></item>
                    /// <item><description>Twelve_Hours</description></item>
                    /// <item><description>TwentyFour_Hours</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> This parameter is returned if the rule is periodically triggered.</para>
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
            /// <para>The ID of the member account to which the rule does not apply, which means that the resources within the member account are not evaluated based on the rule.</para>
            /// <remarks>
            /// <para>This parameter applies only to a managed rule.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>120886317861****</para>
            /// </summary>
            [NameInMap("TagKeyLogicScope")]
            [Validation(Required=false)]
            public string TagKeyLogicScope { get; set; }

            /// <summary>
            /// <para>The tag key used to filter resources. The rule applies only to the resources with the specified tag key.</para>
            /// <remarks>
            /// <para>The <c>TagKeyScope</c> and <c>TagValueScope</c> parameters are returned at the same time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>RAM</para>
            /// </summary>
            [NameInMap("TagKeyScope")]
            [Validation(Required=false)]
            public string TagKeyScope { get; set; }

            /// <summary>
            /// <para>The tag value used to filter resources. The rule applies only to the resources with the specified tag value.</para>
            /// <remarks>
            /// <para>The <c>TagKeyScope</c> and <c>TagValueScope</c> parameters are returned at the same time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>MFA</para>
            /// </summary>
            [NameInMap("TagValueScope")]
            [Validation(Required=false)]
            public string TagValueScope { get; set; }

            /// <summary>
            /// <para>The tag list.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetConfigRuleResponseBodyConfigRuleTags> Tags { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleTags : TeaModel {
                /// <summary>
                /// <para>The tag key. The tag key can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
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
            /// <para>TagsScope</para>
            /// </summary>
            [NameInMap("TagsScope")]
            [Validation(Required=false)]
            public List<GetConfigRuleResponseBodyConfigRuleTagsScope> TagsScope { get; set; }
            public class GetConfigRuleResponseBodyConfigRuleTagsScope : TeaModel {
                /// <summary>
                /// <para>TagKey</para>
                /// 
                /// <b>Example:</b>
                /// <para>key-1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>TagValue</para>
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
