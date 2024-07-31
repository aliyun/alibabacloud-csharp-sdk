// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateHybridCloudGroupRequest : TeaModel {
        /// <summary>
        /// The region in which the node resides. Specify the parameter in the Carrier code-Continent code-City code format.
        /// </summary>
        [NameInMap("BackSourceMark")]
        [Validation(Required=false)]
        public string BackSourceMark { get; set; }

        /// <summary>
        /// The ID of the hybrid cloud cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// The name of the node group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The type of the node group. Valid values:
        /// 
        /// *   **protect**
        /// *   **control**
        /// *   **storage**
        /// *   **controlStorage**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// The ID of the WAF instance.
        /// 
        /// >  You can call the [DescribeInstance](https://help.aliyun.com/document_detail/433756.html) operation to query the ID of the WAF instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The IP address of the server used for load balancing.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LoadBalanceIp")]
        [Validation(Required=false)]
        public string LoadBalanceIp { get; set; }

        /// <summary>
        /// The region in which the node resides. Specify the parameter in the Carrier code-Continent code-City code format.
        /// </summary>
        [NameInMap("LocationCode")]
        [Validation(Required=false)]
        public string LocationCode { get; set; }

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
        /// The remarks.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud resource group.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}
