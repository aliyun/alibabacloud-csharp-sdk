// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCloudResourcesRequest : TeaModel {
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
        /// The ID of the Alibaba Cloud account to which the resource belongs.
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        /// <summary>
        /// The page number. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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
        /// The domain name. You can use this parameter if you set ResourceProduct to fc or sae.
        /// </summary>
        [NameInMap("ResourceDomain")]
        [Validation(Required=false)]
        public string ResourceDomain { get; set; }

        /// <summary>
        /// The function name. You can use this parameter if you set ResourceProduct to fc.
        /// </summary>
        [NameInMap("ResourceFunction")]
        [Validation(Required=false)]
        public string ResourceFunction { get; set; }

        /// <summary>
        /// The ID of the resource.
        /// </summary>
        [NameInMap("ResourceInstanceId")]
        [Validation(Required=false)]
        public string ResourceInstanceId { get; set; }

        [NameInMap("ResourceInstanceName")]
        [Validation(Required=false)]
        public string ResourceInstanceName { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud resource group.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// The name of the resource.
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        [Obsolete]
        public string ResourceName { get; set; }

        /// <summary>
        /// The cloud service to which the resource belongs. Valid values:
        /// 
        /// *   **alb**: Application Load Balancer (ALB).
        /// *   **mse**: Microservices Engine (MSE).
        /// *   **fc**: Function Compute.
        /// *   **sae**: Serverless App Engine (SAE).
        /// 
        /// >  Different cloud services are available in different regions. The specified cloud service must be available in the specified region.
        /// </summary>
        [NameInMap("ResourceProduct")]
        [Validation(Required=false)]
        public string ResourceProduct { get; set; }

        /// <summary>
        /// The region ID of the resource. For information about region IDs, see the following table.
        /// 
        /// >  Different cloud services are available in different regions. The specified cloud service must be available in the specified region.
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

        /// <summary>
        /// The route name. You can use this parameter if you set ResourceProduct to mse.
        /// </summary>
        [NameInMap("ResourceRouteName")]
        [Validation(Required=false)]
        public string ResourceRouteName { get; set; }

    }

}
