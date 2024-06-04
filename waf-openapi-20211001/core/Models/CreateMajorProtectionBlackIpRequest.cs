// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateMajorProtectionBlackIpRequest : TeaModel {
        /// <summary>
        /// The description of the IP address blacklist.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The time after which the IP address blacklist becomes invalid. Unit: seconds.
        /// 
        /// >  If you set the value to **0**, the blacklist is permanently valid.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public long? ExpiredTime { get; set; }

        /// <summary>
        /// The ID of the Web Application Firewall (WAF) instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The IP addresses that you want to add to the IP address blacklist. CIDR blocks and IP addresses are supported. IPv4 and IPv6 addresses are supported. Separate the CIDR blocks or IP addresses with commas (,). For more information, see [Protection for major events](https://help.aliyun.com/document_detail/425591.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public string IpList { get; set; }

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
        /// The ID of the IP address blacklist rule for major event protection.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// The ID of the IP address blacklist rule template for major event protection.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
