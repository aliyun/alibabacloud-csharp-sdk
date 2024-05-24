// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class ModifyVServerGroupBackendServersRequest : TeaModel {
        /// <summary>
        /// The list of new backend servers that you want to use to replace those in the vServer group. You can specify at most 20 backend servers for a vServer group in each call.
        /// 
        /// *   **ServerId**: required. The ID of the ECS instance or ENI that serves as a backend server. This parameter must be of the STRING type.
        /// 
        /// *   **Port**: required. The port that is used by the backend server. This parameter must be of the INTEGER type. Valid values: **1 to 65535**.
        /// 
        /// *   **Weight**: required. The weight of the backend server. This parameter must be of the INTEGER type. Valid values: **0 to 100**.
        /// 
        /// *   **Description**: optional. The description of the backend server. This parameter must be of the STRING type. The description can contain letters, digits, hyphens (-), forward slashes (/), periods (.),and underscores (_).
        /// 
        /// *   **Type**: the type of backend server. This parameter must be of the STRING type. Valid values:
        /// 
        ///     *   **ecs**: an ECS instance. This is the default value.
        ///     *   **eni**: an ENI.
        /// 
        /// *   **ServerIp**: the IP address of the ECS instance or ENI.
        /// 
        /// Examples:
        /// 
        /// *   An ECS instance: `[{ "ServerId": "i-xxxxxxxxx", "Weight": "100", "Type": "ecs", "Port":"80","Description":"test-112" }]`
        /// *   An ENI: `[{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "192.168.\*\*.**", "Port":"80","Description":"test-112" }]`
        /// *   An ENI with multiple IP addresses: `[{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "192.168.\*\*.**", "Port":"80","Description":"test-112" },{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "172.166.\*\*.**", "Port":"80","Description":"test-113" }]`
        /// </summary>
        [NameInMap("NewBackendServers")]
        [Validation(Required=false)]
        public string NewBackendServers { get; set; }

        /// <summary>
        /// The list of backend servers that you want to replace in the vServer group. You can specify at most 20 backend servers for a vServer group in each call.
        /// 
        /// *   **ServerId**: required. The ID of the Elastic Compute Service (ECS) instance or elastic network interface (ENI) that serves as a backend server. This parameter must be of the STRING type.
        /// 
        /// *   **Port**: required. The port that is used by the backend server. This parameter must be of the INTEGER type. Valid values: **1 to 65535**.
        /// 
        /// *   **Weight**: required. The weight of the backend server. This parameter must be of the INTEGER type. Valid values: **0 to 100**.
        /// 
        /// *   **Description**: optional. The description of the backend server. This parameter must be of the STRING type. The description must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.),and underscores (_).
        /// 
        /// *   **Type**: the type of backend server. This parameter must be of the STRING type. Valid values:
        /// 
        ///     *   **ecs**: an ECS instance. This is the default value.
        ///     *   **eni**: an ENI.
        /// 
        /// *   **ServerIp**: the IP address of the ECS instance or ENI.
        /// 
        /// Examples:
        /// 
        /// *   An ECS instance: `[{ "ServerId": "i-xxxxxxxxx", "Weight": "100", "Type": "ecs", "Port":"80","Description":"test-112" }]`
        /// *   An ENI: `[{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "192.168.\*\*.**", "Port":"80","Description":"test-112" }]`
        /// *   An ENI with multiple IP addresses: `[{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "192.168.\*\*.**", "Port":"80","Description":"test-112" },{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "172.166.\*\*.**", "Port":"80","Description":"test-113" }]`
        /// </summary>
        [NameInMap("OldBackendServers")]
        [Validation(Required=false)]
        public string OldBackendServers { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the Classic Load Balancer (CLB) instance is deployed.
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
        /// The ID of the vServer group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
