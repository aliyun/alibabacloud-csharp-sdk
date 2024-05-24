// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class RemoveBackendServersRequest : TeaModel {
        /// <summary>
        /// The backend servers to be removed.
        /// 
        /// *   **ServerId**: The IDs of the backend servers. Set the value to a string. This parameter is required.
        /// 
        /// *   **Type**: The type of the backend server. Valid values:
        /// 
        ///     *   **ecs** (default): an Elastic Compute Service (ECS) instance
        /// 
        ///     <!---->
        /// 
        ///     *   **eni**: an elastic network interface (ENI)
        /// 
        /// *   **Weight**: the weight of the backend server. Valid values: **0** to **100**. Set the value to an integer.
        /// 
        /// You can remove at most 20 backend servers in each call. Examples:
        /// 
        /// *   Remove an ECS instance: `[{"ServerId":"i-bp1fq61enf4loa5i****", "Type": "ecs","Weight":"100"}]`
        /// *   Remove an ENI: `[{"ServerId":"eni-2ze1sdp5****","Type": "eni","Weight":"100"}]`
        /// 
        /// This parameter is required.
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

    }

}
