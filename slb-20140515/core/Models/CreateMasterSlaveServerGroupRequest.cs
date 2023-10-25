// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateMasterSlaveServerGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the Classic Load Balancer (CLB) instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The list of backend servers in the primary/secondary server group.
        /// 
        /// The value of this parameter must be a STRING list in the JSON format. You can specify up to 20 elements in each request.
        /// 
        /// *   **ServerId**: This parameter is required. Specify the ID of the backend server. This parameter must be of the STRING type.
        /// 
        /// *   **Port**: This parameter is required. Specify the port that is used by the backend server. This parameter must be of the INTEGER type. Valid values: **1** to **65535**.
        /// 
        /// *   **Weight**: This parameter is required. Specify the weight of the backend server. This parameter must be of the INTEGER type. Valid values: **0** to **100**.
        /// 
        /// *   **Description**: This parameter is optional. Specify the description of the backend server. This parameter must be of the STRING type. The description must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.),and underscores (\_).
        /// 
        /// *   **ServerType**: Specify the type of the backend server. This parameter must be of the STRING type. Valid values:
        /// 
        ///     *   **Master**: primary server
        /// 
        ///     <!---->
        /// 
        ///     *   **Slave**: secondary server
        /// 
        /// *   **Type**: Specify the type of backend server. This parameter must be of the STRING type. Valid values:
        /// 
        ///     *   **ecs**: an ECS instance
        ///     *   **eni**: an elastic network interface (ENI)
        /// 
        /// *   **ServerIp**: the IP address of the ECS instance or ENI
        /// 
        /// A primary/secondary server group can contain at most two backend servers.
        /// 
        /// If you do not set this parameter, an empty primary/secondary server group is created.
        /// 
        /// Examples:
        /// 
        /// *   ECS: `[{ "ServerId": "i-xxxxxxxxx", "Weight": "100", "Type": "ecs", "Port":"82","ServerType":"Master","Description":"test-112" }, { "ServerId": "i-xxxxxxxxx", "Weight": "100", "Type": "ecs", "Port":"84","ServerType":"Slave","Description":"test-112" }]`
        /// 
        /// <!---->
        /// 
        /// *   ENI: `[{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "Port":"80","ServerType":"Master","Description":"test-112" }, { "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "192.168.**.**", "Port":"80","ServerType":"Slave","Description":"test-112" }]`
        /// *   ENI with multiple IP addresses: `[{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni","ServerIp": "192.168.**.**", "Port":"80","ServerType":"Master","Description":"test-112" }, { "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni","ServerIp": "192.168.**.**", "Port":"80","ServerType":"Slave","Description":"test-112" }]`
        /// </summary>
        [NameInMap("MasterSlaveBackendServers")]
        [Validation(Required=false)]
        public string MasterSlaveBackendServers { get; set; }

        /// <summary>
        /// The name of the primary/secondary server group.
        /// </summary>
        [NameInMap("MasterSlaveServerGroupName")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroupName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the CLB instance is deployed.
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

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateMasterSlaveServerGroupRequestTag> Tag { get; set; }
        public class CreateMasterSlaveServerGroupRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
