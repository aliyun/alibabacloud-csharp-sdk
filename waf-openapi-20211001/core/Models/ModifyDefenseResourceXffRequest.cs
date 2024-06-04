// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyDefenseResourceXffRequest : TeaModel {
        /// <summary>
        /// The status of the tracking cookie.
        /// 
        /// *   **0**: disabled
        /// *   **1**: enabled. This is the default value.
        /// </summary>
        [NameInMap("AcwCookieStatus")]
        [Validation(Required=false)]
        public int? AcwCookieStatus { get; set; }

        /// <summary>
        /// The status of the secure attribute of the tracking cookie.
        /// 
        /// *   **0**: disabled. This is the default value.
        /// *   **1**: enabled.
        /// </summary>
        [NameInMap("AcwSecureStatus")]
        [Validation(Required=false)]
        public int? AcwSecureStatus { get; set; }

        /// <summary>
        /// The status of the secure attribute of the slider CAPTCHA cookie.
        /// 
        /// *   **0**: disabled. This is the default value.
        /// *   **1**: enabled.
        /// </summary>
        [NameInMap("AcwV3SecureStatus")]
        [Validation(Required=false)]
        public int? AcwV3SecureStatus { get; set; }

        /// <summary>
        /// The custom header fields.
        /// 
        /// >  The first IP address in the specified custom header field is used as the originating IP address of the client to prevent X-Forwarded-For forgery. If you specify multiple header fields, WAF reads the values of the header fields in sequence until the originating IP address is obtained. If the originating IP address cannot be obtained, the first IP address in the X-Forwarded-For header is used as the originating IP address of the client.
        /// </summary>
        [NameInMap("CustomHeaders")]
        [Validation(Required=false)]
        public List<string> CustomHeaders { get; set; }

        /// <summary>
        /// The ID of the Web Application Firewall (WAF) instance.
        /// 
        /// >  You can call the [DescribeInstance](https://help.aliyun.com/document_detail/433756.html) operation to query the ID of the WAF instance.
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
        /// The name of the protected object.
        /// 
        /// This parameter is required.
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
        /// Specifies whether a Layer 7 proxy is deployed in front of WAF. Layer 7 proxies include Anti-DDoS Proxy and Alibaba Cloud CDN. Valid values:
        /// 
        /// *   **0**: No Layer 7 proxies are deployed. This is the default value.
        /// *   **1**: A Layer 7 proxy is deployed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("XffStatus")]
        [Validation(Required=false)]
        public int? XffStatus { get; set; }

    }

}
