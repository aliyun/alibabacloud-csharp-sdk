// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateConfigRuleShrinkRequest : TeaModel {
        /// <summary>
        /// The client token that you want to use to ensure the idempotency of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.``
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the rule.
        /// 
        /// For more information about how to query the ID of a rule, see [ListConfigRules](https://help.aliyun.com/document_detail/169607.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// The name of the rule.
        /// 
        /// For more information about how to query the name of a rule, see [ListAggregateConfigRules](https://help.aliyun.com/document_detail/264148.html).
        /// </summary>
        [NameInMap("ConfigRuleName")]
        [Validation(Required=false)]
        public string ConfigRuleName { get; set; }

        /// <summary>
        /// The trigger type of the rule. Valid values:
        /// 
        /// *   ConfigurationItemChangeNotification: The rule is triggered by configuration changes.
        /// *   ScheduledNotification: The rule is periodically triggered.
        /// 
        /// >  This parameter applies only to custom rules.
        /// </summary>
        [NameInMap("ConfigRuleTriggerTypes")]
        [Validation(Required=false)]
        public string ConfigRuleTriggerTypes { get; set; }

        /// <summary>
        /// The description of the rule. You can enter up to 500 characters.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ExcludeRegionIdsScope")]
        [Validation(Required=false)]
        public string ExcludeRegionIdsScope { get; set; }

        [NameInMap("ExcludeResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceGroupIdsScope { get; set; }

        /// <summary>
        /// The ID of the resource to be excluded from the compliance evaluations performed by the rule. Separate multiple resource IDs with commas (,).
        /// 
        /// >  This parameter applies only to managed rules.
        /// </summary>
        [NameInMap("ExcludeResourceIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceIdsScope { get; set; }

        [NameInMap("ExcludeTagsScope")]
        [Validation(Required=false)]
        public List<UpdateConfigRuleShrinkRequestExcludeTagsScope> ExcludeTagsScope { get; set; }
        public class UpdateConfigRuleShrinkRequestExcludeTagsScope : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// The input parameters of the rule.
        /// </summary>
        [NameInMap("InputParameters")]
        [Validation(Required=false)]
        public string InputParametersShrink { get; set; }

        /// <summary>
        /// The intervals at which the rule is triggered. Valid values:
        /// 
        /// *   One_Hour: 1 hour.
        /// *   Three_Hours: 3 hours.
        /// *   Six_Hours: 6 hours.
        /// *   Twelve_Hours: 12 hours.
        /// *   TwentyFour_Hours (default): 24 hours.
        /// 
        /// >  This parameter is required if you set the `ConfigRuleTriggerTypes` parameter to `ScheduledNotification`.
        /// </summary>
        [NameInMap("MaximumExecutionFrequency")]
        [Validation(Required=false)]
        public string MaximumExecutionFrequency { get; set; }

        /// <summary>
        /// The ID of the region to which the rule applies. Separate multiple region IDs with commas (,).
        /// 
        /// >  This parameter applies only to managed rules.
        /// </summary>
        [NameInMap("RegionIdsScope")]
        [Validation(Required=false)]
        public string RegionIdsScope { get; set; }

        /// <summary>
        /// The ID of the resource group to which the rule applies. Separate multiple resource group IDs with commas (,).
        /// 
        /// >  This parameter applies only to managed rules.
        /// </summary>
        [NameInMap("ResourceGroupIdsScope")]
        [Validation(Required=false)]
        public string ResourceGroupIdsScope { get; set; }

        [NameInMap("ResourceIdsScope")]
        [Validation(Required=false)]
        public string ResourceIdsScope { get; set; }

        /// <summary>
        /// The type of the resource to be evaluated by the rule. Separate multiple resource types with commas (,).
        /// </summary>
        [NameInMap("ResourceTypesScope")]
        [Validation(Required=false)]
        public string ResourceTypesScopeShrink { get; set; }

        /// <summary>
        /// The risk level of the resources that are not compliant with the rule. Valid values:
        /// 
        /// *   1: high risk level
        /// *   2: medium risk level
        /// *   3: low risk level
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

        /// <summary>
        /// The logical relationship among the tag keys if you specify multiple tag keys by using the `TagKeyScope` parameter. For example, if the `TagKeyScope` parameter is set to `ECS,OSS` and the TagKeyLogicScope parameter is set to `AND`, the rule applies to resources with both the `ECS` and `OSS` tag keys. Valid values:
        /// 
        /// *   AND: logical AND
        /// *   OR: logical OR
        /// </summary>
        [NameInMap("TagKeyLogicScope")]
        [Validation(Required=false)]
        public string TagKeyLogicScope { get; set; }

        /// <summary>
        /// The tag key used to filter resources. The rule applies only to the resources with the specified tag key.
        /// 
        /// >  This parameter applies only to managed rules. You must configure the `TagKeyScope` and `TagValueScope` parameters at the same time.
        /// </summary>
        [NameInMap("TagKeyScope")]
        [Validation(Required=false)]
        public string TagKeyScope { get; set; }

        /// <summary>
        /// The tag key used to filter resources. The rule applies only to the resources with the specified tag key.
        /// 
        /// >  This parameter applies only to managed rules. You must configure the `TagKeyScope` and `TagValueScope` parameters at the same time.
        /// </summary>
        [NameInMap("TagValueScope")]
        [Validation(Required=false)]
        public string TagValueScope { get; set; }

        [NameInMap("TagsScope")]
        [Validation(Required=false)]
        public List<UpdateConfigRuleShrinkRequestTagsScope> TagsScope { get; set; }
        public class UpdateConfigRuleShrinkRequestTagsScope : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}
