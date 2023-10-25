// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class RemoveVServerGroupBackendServersRequest : TeaModel {
        /// <summary>
        /// The list of backend servers that you want to remove from the vServer group.
        /// 
        /// You can specify at most 20 backend servers for a vServer group in each call.
        /// 
        /// The value of this parameter is a JSON list of the STRING type. You can specify at most 20 elements in a list for each request.
        /// 
        /// *   **ServerId**: the ID of the Elastic Compute Service (ECS) instance or elastic network interface (ENI) that serves as a backend server.
        /// 
        /// *   **Port**: the port that is used by the backend server. Valid values: **1 to 65535**.
        /// 
        /// *   **Weight**: the weight of the backend server. Valid values: **0 to 100**.
        /// 
        /// *   **Description**: the description of the backend server. The description must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.),and underscores (\_).
        /// 
        /// *   **Type**: the type of backend server. Valid values:
        /// 
        ///     *   **ecs**: an ECS instance. This is the default value.
        ///     *   **eni**: an ENI.
        /// 
        /// *   **ServerIp**: the IP address of the ECS instance or ENI.
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public string BackendServers { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the Classic Load Balancer (CLB) instance is deployed.
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
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
