// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class MoveResourceGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the new resource group.
        /// 
        /// You can log on to the [Resource Management console](https://resourcemanager.console.aliyun.com/resource-groups) to view resource group IDs.
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        /// <summary>
        /// The region ID of the NLB instance.
        /// 
        /// You can call the [DescribeRegions](~~443657~~) operation to obtain the region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the bastion host for which you want to change the resource group.
        /// 
        /// >  You can call the [DescribeInstances](~~153281~~) operation to query the ID of the bastion host.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The type of the resource. Valid values:
        /// 
        /// *   **loadbalancer**: a Network Load Balancer (NLB) instance
        /// *   **securitypolicy**: a security policy
        /// *   **servergroup**: a server group
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
