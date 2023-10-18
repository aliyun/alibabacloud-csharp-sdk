// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateFullNatEntryRequest : TeaModel {
        /// <summary>
        /// The backend IP address to be modified in FULLNAT address translation.
        /// </summary>
        [NameInMap("AccessIp")]
        [Validation(Required=false)]
        public string AccessIp { get; set; }

        /// <summary>
        /// The backend port to be modified in the mapping of FULLNAT port. Valid values: **1** to **65535**.
        /// </summary>
        [NameInMap("AccessPort")]
        [Validation(Required=false)]
        public string AccessPort { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate a value, and you must make sure that each request has a unique token value. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the value of **RequestId** as the value of **ClientToken**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to only precheck this request. Valid values:
        /// 
        /// *   **true**: prechecks the request without adding the FULLNAT entry. The system checks whether your AccessKey pair is valid, whether RAM users are granted required permissions, and whether the required parameters are set. If the request fails to pass the precheck, an error code is returned. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false**: sends the API request. This is the default value. After the request passes the precheck, a 2XX HTTP status code is returned and the FULLNAT entry is added.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The description of the FULLNAT entry.
        /// 
        /// This parameter is optional. If you enter a description, the description must be 2 to 256 characters in length, and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("FullNatEntryDescription")]
        [Validation(Required=false)]
        public string FullNatEntryDescription { get; set; }

        /// <summary>
        /// The FULLNAT entry name. The name must be 2 to 128 characters in length. It must start with a letter but cannot start with http:// or https://.
        /// </summary>
        [NameInMap("FullNatEntryName")]
        [Validation(Required=false)]
        public string FullNatEntryName { get; set; }

        /// <summary>
        /// The ID of the FULLNAT table to which the FULLNAT entry belongs.
        /// </summary>
        [NameInMap("FullNatTableId")]
        [Validation(Required=false)]
        public string FullNatTableId { get; set; }

        /// <summary>
        /// The protocol of the packets that are forwarded by the port. Valid values:
        /// 
        /// *   **TCP**
        /// *   **UDP**
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// The NAT IP address that provides address translation.
        /// </summary>
        [NameInMap("NatIp")]
        [Validation(Required=false)]
        public string NatIp { get; set; }

        /// <summary>
        /// The frontend port to be modified in the mapping of FULLNAT port. Valid values: **1** to **65535**.
        /// </summary>
        [NameInMap("NatIpPort")]
        [Validation(Required=false)]
        public string NatIpPort { get; set; }

        /// <summary>
        /// The elastic network interface (ENI) ID.
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the Virtual Private Cloud (VPC) NAT gateway to which the FULLNAT entry to be added belongs.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
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
