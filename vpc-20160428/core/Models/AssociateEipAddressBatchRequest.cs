// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateEipAddressBatchRequest : TeaModel {
        /// <summary>
        /// The ID of the instance to be associated with EIPs.
        /// 
        /// The instance can be a NAT gateway or a secondary ENI.
        /// </summary>
        [NameInMap("BindedInstanceId")]
        [Validation(Required=false)]
        public string BindedInstanceId { get; set; }

        /// <summary>
        /// The type of instance with which you want to associate the EIPs. Valid values:
        /// 
        /// *   **Nat**: a NAT gateway
        /// *   **NetworkInterface**: a secondary ENI
        /// </summary>
        [NameInMap("BindedInstanceType")]
        [Validation(Required=false)]
        public string BindedInstanceType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among all requests. The token can only contain ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses **RequestId** as **ClientToken**. **RequestId** might be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// The association mode. Set the value to **MULTI_BINDED**, which specifies the Multi-EIP-to-ENI mode.
        /// 
        /// This parameter is required only if **InstanceType** is set to **NetworkInterface**.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region to which the EIPs belong.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to obtain the region ID.
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
