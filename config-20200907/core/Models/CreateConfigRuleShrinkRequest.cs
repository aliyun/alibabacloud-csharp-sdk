// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateConfigRuleShrinkRequest : TeaModel {
        /// <summary>
        /// The client token that you want to use to ensure the idempotency of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.``
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The name of the rule.
        /// 
        /// This parameter is required.
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
        /// >  If a rule supports the preceding trigger types, separate the types with a comma (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigRuleTriggerTypes")]
        [Validation(Required=false)]
        public string ConfigRuleTriggerTypes { get; set; }

        /// <summary>
        /// The description of the rule.
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
        public List<CreateConfigRuleShrinkRequestExcludeTagsScope> ExcludeTagsScope { get; set; }
        public class CreateConfigRuleShrinkRequestExcludeTagsScope : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// The input parameter of the rule.
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
        /// >  This parameter is required if the ConfigRuleTriggerTypes parameter is set to ScheduledNotification.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceTypesScope")]
        [Validation(Required=false)]
        public string ResourceTypesScopeShrink { get; set; }

        /// <summary>
        /// The risk level of the resources that do not comply with the rule. Valid values:
        /// 
        /// *   1: high.
        /// *   2: medium.
        /// *   3: low.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public int? RiskLevel { get; set; }

        /// <summary>
        /// The ID of the rule.
        /// 
        /// *   If you set the SourceOwner parameter to ALIYUN, set this parameter to the name of the managed rule.
        /// *   If you set the SourceOwner parameter to CUSTOM_FC, set this parameter to the Alibaba Cloud Resource Name (ARN) of the relevant function in Function Compute.
        /// 
        /// For more information about how to query the name of a managed rule, see [Managed rules](https://help.aliyun.com/document_detail/127404.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceIdentifier")]
        [Validation(Required=false)]
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// The type of the rule Valid values:
        /// 
        /// *   ALIYUN: managed rule.
        /// *   CUSTOM_FC: custom rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceOwner")]
        [Validation(Required=false)]
        public string SourceOwner { get; set; }

        /// <summary>
        /// The logical relationship among the tag keys if you specify multiple tag keys for `TagKeyScope`. For example, if you set `TagKeyScope` to `ECS,OSS` and set TagKeyLogicScope to `AND`, the rule applies to resources with both the `ECS` and `OSS` tag keys. Valid values:
        /// 
        /// *   AND
        /// *   OR
        /// </summary>
        [NameInMap("TagKeyLogicScope")]
        [Validation(Required=false)]
        public string TagKeyLogicScope { get; set; }

        /// <summary>
        /// The tag key used to filter resources. The rule applies only to the resources with the specified tag key.
        /// 
        /// >  This parameter applies only to managed rules. You must specify both `TagKeyScope` and `TagValueScope`.
        /// </summary>
        [NameInMap("TagKeyScope")]
        [Validation(Required=false)]
        public string TagKeyScope { get; set; }

        /// <summary>
        /// The tag value used to filter resources. The rule applies only to the resources that use the specified tag value.
        /// 
        /// >  This parameter applies only to managed rules. You must specify both `TagKeyScope` and `TagValueScope`.
        /// </summary>
        [NameInMap("TagValueScope")]
        [Validation(Required=false)]
        public string TagValueScope { get; set; }

        [NameInMap("TagsScope")]
        [Validation(Required=false)]
        public List<CreateConfigRuleShrinkRequestTagsScope> TagsScope { get; set; }
        public class CreateConfigRuleShrinkRequestTagsScope : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}
