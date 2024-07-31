// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyHybridCloudGroupExpansionServerRequest : TeaModel {
        /// <summary>
        /// The ID of the hybrid cloud cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public long? ClusterId { get; set; }

        /// <summary>
        /// The ID of the node group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

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
        /// The ID of the node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Mids")]
        [Validation(Required=false)]
        public string Mids { get; set; }

        /// <summary>
        /// The region in which the WAF instance is deployed. Valid value:
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

    }

}
