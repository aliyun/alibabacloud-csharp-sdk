// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetBackendServersRequest : TeaModel {
        /// <summary>
        /// The list of backend servers that you want to modify.
        /// 
        /// The value of this parameter must be a STRING list in the JSON format. You can specify up to 20 elements in each request.
        /// 
        /// *   **ServerId**: Required. Specify the ID of the backend server. This parameter must be of the STRING type.
        /// 
        /// *   **Port**: Required. Specify the port that is used by the backend server. This parameter must be of the INTEGER type. Valid values: **1** to **65535**.
        /// 
        /// *   **Weight**: Specify the weight of the backend server. This parameter must be of the INTEGER type. Valid values: **0** to **100**.
        /// 
        /// *   **Description**: Optional. The description of the backend server. This value must be a string. The description must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (\_).
        /// 
        /// *   **Type**: the type of backend server. This parameter must be of the STRING type. Valid values:
        /// 
        ///     *   **ecs** (default): an Elastic Compute Service (ECS) instance
        ///     *   **eni**: an elastic network interface (ENI). You can specify ENIs as the backend servers only for high-performance CLB instances.
        /// 
        /// *   **ServerIp**: the IP address of the ECS instance or ENI
        /// 
        /// Examples:
        /// 
        /// *   ECS instance: `[{ "ServerId": "ecs-******FmYAXG", "Weight": "100", "Type": "ecs", "Port":"80","Description":"test-112" }]`
        /// *   ENI: `[{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "192.168.**.**", "Port":"80","Description":"test-112" }]`
        /// *   ENI with multiple IP addresses: `[{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "192.168.**.**", "Port":"80","Description":"test-112" },{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "172.166.**.**", "Port":"80","Description":"test-113" }]`
        /// 
        /// > 
        /// *   The backend servers must be in the Running state. You can specify up to 20 backend servers in each request.
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public string BackendServers { get; set; }

        /// <summary>
        /// The ID of the CLB instance.
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
        /// The region ID of the Classic Load Balancer (CLB) instance.
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
