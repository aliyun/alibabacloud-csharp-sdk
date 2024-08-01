// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAccountAttributesRequest : TeaModel {
        /// <summary>
        /// The type of resource quota N. Valid values of N: 1 to 8. Valid values:
        /// 
        /// *   instance-network-type: the available network types.
        /// 
        /// *   max-security-groups: the maximum number of security groups.
        /// 
        /// *   max-elastic-network-interfaces: the maximum number of ENIs.
        /// 
        /// *   max-postpaid-instance-vcpu-count: the maximum number of vCPUs for pay-as-you-go instances.
        /// 
        /// *   max-spot-instance-vcpu-count: the maximum number of vCPUs for preemptible instances.
        /// 
        /// *   used-postpaid-instance-vcpu-count: the number of vCPUs that have been allocated to pay-as-you-go instances.
        /// 
        /// *   used-spot-instance-vcpu-count: the number of vCPUs that have been allocated to preemptible instances.
        /// 
        /// *   max-postpaid-yundisk-capacity: the maximum capacity of pay-as-you-go data disks. (The value is deprecated.)
        /// 
        /// *   used-postpaid-yundisk-capacity: the capacity of pay-as-you-go data disks that have been created. (The value is deprecated.)
        /// 
        /// *   max-dedicated-hosts: the maximum number of dedicated hosts.
        /// 
        /// *   supported-postpaid-instance-types: the instance types of pay-as-you-go I/O optimized instances.
        /// 
        /// *   max-axt-command-count: the maximum number of Cloud Assistant commands.
        /// 
        /// *   max-axt-invocation-daily: the maximum number of Cloud Assistant command executions per day.
        /// 
        /// *   real-name-authentication: whether the account has completed the real-name verification.
        /// 
        ///     **
        /// 
        ///     **Note** To create an ECS instance in a region in the Chinese mainland, you must complete the real-name verification.
        /// 
        /// *   max-cloud-assistant-activation-count: the maximum number of activation codes that can be created to use to register managed instances.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("AttributeName")]
        [Validation(Required=false)]
        public List<string> AttributeName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent list of regions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the zone in which the resource resides.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
