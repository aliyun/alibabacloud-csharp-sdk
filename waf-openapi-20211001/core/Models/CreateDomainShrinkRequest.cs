// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDomainShrinkRequest : TeaModel {
        /// <summary>
        /// The mode in which you want to add the domain name to WAF. Valid values:
        /// 
        /// *   **share:** adds the domain name to WAF in CNAME record mode. This is the default value.
        /// *   **hybrid_cloud_cname:** adds the domain name to WAF in hybrid cloud reverse proxy mode.
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// The domain name that you want to add to WAF.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The ID of the Web Application Firewall (WAF) instance.
        /// 
        /// > You can call the [DescribeInstance](https://help.aliyun.com/document_detail/433756.html) operation to obtain the ID of the WAF instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The configurations of the listeners.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public string ListenShrink { get; set; }

        /// <summary>
        /// The configurations of the forwarding rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Redirect")]
        [Validation(Required=false)]
        public string RedirectShrink { get; set; }

        /// <summary>
        /// The region where the WAF instance resides. Valid values:
        /// 
        /// *   **cn-hangzhou**: the Chinese mainland
        /// *   **ap-southeast-1**: outside the Chinese mainland
        /// 
        /// This parameter is required.
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

    }

}
