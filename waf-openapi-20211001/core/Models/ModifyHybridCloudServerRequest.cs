// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyHybridCloudServerRequest : TeaModel {
        /// <summary>
        /// The continent.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Continents")]
        [Validation(Required=false)]
        public string Continents { get; set; }

        /// <summary>
        /// The name of the node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CustomName")]
        [Validation(Required=false)]
        public string CustomName { get; set; }

        /// <summary>
        /// The ID of the WAF instance.
        /// 
        /// >  You can call the [DescribeInstanceInfo](https://help.aliyun.com/document_detail/140857.html) operation to query the ID of the WAF instance.
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
        [NameInMap("Mid")]
        [Validation(Required=false)]
        public string Mid { get; set; }

        /// <summary>
        /// The cloud service provider.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// The city.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

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
