// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateConfigRuleRequest : TeaModel {
        /// <summary>
        /// The client token that you want to use to ensure the idempotency of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.``
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The name of the rule.
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

        /// <summary>
        /// The ID of the resource to be excluded from the compliance evaluations performed by the rule. Separate multiple resource IDs with commas (,).
        /// 
        /// >  This parameter applies only to managed rules.
        /// </summary>
        [NameInMap("ExcludeResourceIdsScope")]
        [Validation(Required=false)]
        public string ExcludeResourceIdsScope { get; set; }

        /// <summary>
        /// The input parameter of the rule.
        /// </summary>
        [NameInMap("InputParameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> InputParameters { get; set; }

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

        /// <summary>
        /// The type of the resource to be evaluated by the rule. Separate multiple resource types with commas (,).
        /// </summary>
        [NameInMap("ResourceTypesScope")]
        [Validation(Required=false)]
        public List<string> ResourceTypesScope { get; set; }

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
        /// The ID of the rule.
        /// 
        /// *   If you set the SourceOwner parameter to ALIYUN, set this parameter to the name of the managed rule.
        /// *   If you set the SourceOwner parameter to CUSTOM_FC, set this parameter to the Alibaba Cloud Resource Name (ARN) of the relevant function in Function Compute.
        /// 
        /// For more information about how to query the name of a managed rule, see [Managed rules](~~127404~~).
        /// </summary>
        [NameInMap("SourceIdentifier")]
        [Validation(Required=false)]
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// The type of the rule Valid values:
        /// 
        /// *   ALIYUN: managed rule.
        /// *   CUSTOM_FC: custom rule.
        /// </summary>
        [NameInMap("SourceOwner")]
        [Validation(Required=false)]
        public string SourceOwner { get; set; }

        /// <summary>
        /// The logical relationship among the tag keys if you specify multiple tag keys for the `TagKeyScope` parameter. For example, if you set the `TagKeyScope` parameter to `ECS,OSS` and the TagKeyLogicScope parameter to `AND`, the rule applies to resources with both the `ECS` and `OSS` tag keys. Valid values:
        /// 
        /// *   AND: logical AND
        /// *   OR: logical OR
        /// </summary>
        [NameInMap("TagKeyLogicScope")]
        [Validation(Required=false)]
        public string TagKeyLogicScope { get; set; }

        /// <summary>
        /// The tag key used to filter resources. The rule applies only to the resources with a specified tag key.
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

    }

}
