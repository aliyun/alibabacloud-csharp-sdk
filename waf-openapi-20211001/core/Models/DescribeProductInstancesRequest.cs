// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeProductInstancesRequest : TeaModel {
        /// <summary>
        /// The ID of the WAF instance.
        /// 
        /// >  You can call the [DescribeInstance](~~433756~~) operation to query the ID of the WAF instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// The ID of the instance.
        /// </summary>
        [NameInMap("ResourceInstanceId")]
        [Validation(Required=false)]
        public string ResourceInstanceId { get; set; }

        /// <summary>
        /// The public IP address of the instance.
        /// </summary>
        [NameInMap("ResourceIp")]
        [Validation(Required=false)]
        public string ResourceIp { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud resource group.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// The name of the instance.
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// The cloud service to which the instance belongs. Valid values:
        /// 
        /// *   **clb4**: Layer 4 Classic Load Balancer (CLB).
        /// *   **clb7**: Layer 7 CLB.
        /// *   **ecs**: Elastic Compute Service (ECS).
        /// </summary>
        [NameInMap("ResourceProduct")]
        [Validation(Required=false)]
        public string ResourceProduct { get; set; }

        /// <summary>
        /// The region ID of the instance. Valid values:
        /// 
        /// *   **cn-chengdu**: China (Chengdu).
        /// *   **cn-beijing**: China (Beijing).
        /// *   **cn-zhangjiakou**: China (Zhangjiakou).
        /// *   **cn-hangzhou**: China (Hangzhou).
        /// *   **cn-shanghai**: China (Shanghai).
        /// *   **cn-shenzhen**: China (Shenzhen).
        /// *   **cn-qingdao**: China (Qingdao).
        /// *   **cn-hongkong**: China (Hong Kong).
        /// *   **ap-southeast-3**: Malaysia (Kuala Lumpur).
        /// *   **ap-southeast-5**: Indonesia (Jakarta).
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

    }

}
