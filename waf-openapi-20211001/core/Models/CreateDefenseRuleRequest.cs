// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDefenseRuleRequest : TeaModel {
        /// <summary>
        /// The module to which the protection rule that you want to create belongs.
        /// 
        /// *   **waf_group:** the basic protection rule module.
        /// *   **antiscan:** the scan protection module.
        /// *   **ip_blacklist:** the IP address blacklist module.
        /// *   **custom_acl:** the custom rule module.
        /// *   **whitelist:** the whitelist module.
        /// *   **region_block:** the region blacklist module.
        /// *   **custom_response:** the custom response module.
        /// *   **cc:** the HTTP flood protection module.
        /// *   **tamperproof:** the website tamper-proofing module.
        /// *   **dlp:** the data leakage prevention module.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        /// <summary>
        /// The ID of the Web Application Firewall (WAF) instance.
        /// 
        /// >  You can call the [DescribeInstance](https://help.aliyun.com/document_detail/433756.html) operation to obtain the ID of the WAF instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region where the WAF instance resides. Valid values:
        /// 
        /// *   **cn-hangzhou:** the Chinese mainland.
        /// *   **ap-southeast-1:** outside the Chinese mainland.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// The configurations of the protection rule. Specify a string that contains multiple parameters in the JSON format.
        /// 
        /// >  The parameters vary based on the value of the **DefenseScene** parameter. For more information, see the "**Protection rule parameters**" section in this topic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

        /// <summary>
        /// The ID of the protection rule template for which you want to create a protection rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
