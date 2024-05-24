// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class AddVServerGroupBackendServersRequest : TeaModel {
        /// <summary>
        /// The list of backend servers. You can specify up to 20 backend servers in each request.
        /// 
        /// The following parameters are used to specify the backend servers:
        /// 
        /// *   **ServerId**: The ID of the backend server. You can specify the ID of an Elastic Compute Service (ECS) instance or an elastic network interface (ENI).
        /// 
        /// *   **Port**: Required. The port that is used by the backend server. Valid values: **1 to 65535**.
        /// 
        /// *   **Weight**: The weight of the backend server. Valid values: **0** to **100**. Default value: **100**. If the value is set to 0, no requests are forwarded to the backend server.
        /// 
        /// *   **Type**: The type of backend server. Valid values:
        /// 
        ///     *   **ecs**: an ECS instance. This is the default value.
        ///     *   **eni**: an ENI.
        /// 
        /// *   **Description**: Optional. The description of the backend server. This parameter is of the STRING type. The description must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).
        /// 
        /// *   **ServerIp**: The IP address of the ECS instance or ENI.
        /// 
        /// Examples:
        /// 
        /// *   ECS instance:`  [{ "ServerId": "i-xxxxxxxxx", "Weight": "100", "Type": "ecs", "Port": "80", "Description": "test-112" }]. `
        /// *   ENI:`  [{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "192.168. **. **", "Port":"80","Description":"test-112" }] `
        /// *   ENI with multiple IP addresses:`  [{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "192.168. **. **", "Port":"80","Description":"test-112" },{ "ServerId": "eni-xxxxxxxxx", "Weight": "100", "Type": "eni", "ServerIp": "172.166. **. **", "Port":"80","Description":"test-113" }] `
        /// 
        /// This parameter is required.
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
        /// The ID of the region where the Classic Load Balancer (CLB) instance is created.
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
        /// The ID of the server group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
