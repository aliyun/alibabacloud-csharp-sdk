// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseTemplatesRequest : TeaModel {
        /// <summary>
        /// The scenario in which the protection template is used.
        /// 
        /// *   **waf_group**: basic protection.
        /// *   **antiscan**: scan protection.
        /// *   **ip_blacklist**: IP address blacklist.
        /// *   **custom_acl**: custom rule.
        /// *   **whitelist**: whitelist.
        /// *   **region_block**: region blacklist.
        /// *   **custom_response**: custom response.
        /// *   **cc**: HTTP flood protection.
        /// *   **tamperproof**: website tamper-proofing.
        /// *   **dlp**: data leakage prevention.
        /// </summary>
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        /// <summary>
        /// The sub-scenario in which the protection template is used. Valid values:
        /// 
        /// *   **web**: bot management for website protection.
        /// *   **app**: bot management for app protection.
        /// *   **basic**: bot management for basic protection.
        /// </summary>
        [NameInMap("DefenseSubScene")]
        [Validation(Required=false)]
        public string DefenseSubScene { get; set; }

        /// <summary>
        /// The ID of the Web Application Firewall (WAF) instance.
        /// 
        /// > You can call the [DescribeInstance](~~433756~~) operation to query the ID of the WAF instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// The name of the protected object or protected object group.
        /// 
        /// >  If you specify ResourceType, you must specify this parameter.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud resource group.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// The type of the protected resource. Valid values:
        /// 
        /// *   **single**: protected object. This is the default value.
        /// *   **group**: protected object group.
        /// 
        /// >  If you specify Resource, you must specify this parameter.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The ID of the protection template.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// The type of the protection template. Valid values:
        /// 
        /// *   **user_default**: default template.
        /// *   **user_custom**: custom template.
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
