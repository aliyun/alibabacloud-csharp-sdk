// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyHybridCloudClusterRuleRequest : TeaModel {
        /// <summary>
        /// The ID of the hybrid cloud cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// The ID of the WAF instance.
        /// 
        /// >  You can call the DescribeInstanceInfo operation to query the ID of the WAF instance.[](~~140857~~)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region in which the WAF instance is deployed. Valid values:
        /// 
        /// *   **cn-hangzhou**: Chinese mainland.
        /// *   **ap-southeast-1**: outside the Chinese mainland.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud resource group.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// The configuration of the rule.
        /// </summary>
        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public string RuleConfig { get; set; }

        /// <summary>
        /// The status of the rule. Valid values:
        /// 
        /// *   **on**: enables the rule.
        /// *   **off**: disables the rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleStatus")]
        [Validation(Required=false)]
        public string RuleStatus { get; set; }

        /// <summary>
        /// The type of the rule. Valid values:
        /// 
        /// *   **pullin**: The traffic redirection rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
