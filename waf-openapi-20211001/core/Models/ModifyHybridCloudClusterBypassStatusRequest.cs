// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyHybridCloudClusterBypassStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the hybrid cloud cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterResourceId")]
        [Validation(Required=false)]
        public string ClusterResourceId { get; set; }

        /// <summary>
        /// The ID of the Web Application Firewall (WAF) instance.
        /// 
        /// **
        /// 
        /// **You can call the **DescribeInstanceInfo[ operation to obtain the ID of the WAF instance.](https://help.aliyun.com/document_detail/140857.html)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The status of manual bypass. Valid values:
        /// 
        /// *   **on**: enabled.
        /// *   **off**: disabled. This is the default value.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleStatus")]
        [Validation(Required=false)]
        public string RuleStatus { get; set; }

    }

}
