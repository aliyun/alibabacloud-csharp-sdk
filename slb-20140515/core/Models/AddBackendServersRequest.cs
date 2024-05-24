// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class AddBackendServersRequest : TeaModel {
        /// <summary>
        /// The list of backend servers that you want to add. Set the following parameters:
        /// 
        /// *   **ServerId**: Required. This value must be a string. Enter the ID of an ECS instance, elastic network interface (ENI), or elastic container instance. If **ServerId** is set to the ID of an ENI or elastic container instance, **Type** is required.
        /// 
        /// *   **Weight**: the weight of the backend server. Valid values: **0** to **100**. Default value: **100**.
        /// 
        ///     If the value is set to 0, no requests are forwarded to the backend server.
        /// 
        /// *   **Description**: Optional. The description of the backend server. This value must be a string. The description must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).
        /// 
        /// *   **Type**: the type of the backend server. Valid values:
        /// 
        ///     *   **ecs** (default): an ECS instance
        ///     *   **eni**: an ENI
        ///     *   **eci**: an elastic container instance
        /// 
        /// >  You can specify ENIs and elastic container instances as the backend servers only for high-performance CLB instances.
        /// 
        /// *   **ServerIp**: the IP address of the ECS instance, ENI, or elastic container instance
        /// *   **Port**: the backend port
        /// 
        /// Examples:
        /// 
        /// *   ECS instance: `[{ "ServerId": "i-xxxxxxxxx", "Weight": "100", "Type": "ecs", "Port":"80","Description":"test-112" }]`
        /// *   ENI: `[{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "192.168.\*\*.**", "Port":"80","Description":"test-112" }]`
        /// *   ENI with multiple IP addresses: `[{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "192.168.\*\*.**", "Port":"80","Description":"test-113" },{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "172.166.\*\*.**", "Port":"80","Description":"test-113" }]`
        /// *   Elastic container instance: `[{ "ServerId": "eci-xxxxxxxxx", "Weight": "100", "Type": "eci", "ServerIp": "192.168.\*\*.**", "Port":"80","Description":"test-114" }]`
        /// 
        /// >  The backend servers that you add to a CLB instance must be in the Running state. You can add at most 20 backend servers to a CLB instance in each request.
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public string BackendServers { get; set; }

        /// <summary>
        /// The ID of the CLB instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the Classic Load Balancer (CLB) instance is deployed.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/27584.html) operation to query the most recent region list.
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

    }

}
