// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListFullNatEntriesRequest : TeaModel {
        /// <summary>
        /// The ID of the FULLNAT table to which the FULLNAT entries to be queried belong.
        /// 
        /// >  You must specify at least one of the **FullNatTableId** and **NatGatewayId** parameters.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the elastic network interface (ENI) that you want to query. You can specify up to 20 ENIs.
        /// </summary>
        [NameInMap("FullNatEntryId")]
        [Validation(Required=false)]
        public string FullNatEntryId { get; set; }

        [NameInMap("FullNatEntryNames")]
        [Validation(Required=false)]
        public List<string> FullNatEntryNames { get; set; }

        /// <summary>
        /// The name of the FULLNAT entry that you want to query. You can enter the names of up to 20 FULLNAT entries.
        /// 
        /// The name must be 2 to 128 characters in length and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("FullNatTableId")]
        [Validation(Required=false)]
        public string FullNatTableId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// The protocol of the packets that are forwarded by the port. Valid values:
        /// 
        /// *   **TCP**
        /// *   **UDP**
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The ID of the VPC NAT gateway.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        [NameInMap("NetworkInterfaceIds")]
        [Validation(Required=false)]
        public List<string> NetworkInterfaceIds { get; set; }

        /// <summary>
        /// The region ID of the virtual private cloud (VPC) NAT gateway to which the FULLNAT entries to be queried belong.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the NAT gateway.
        /// 
        /// >  You must specify at least one of the **FullNatTableId** and **NatGatewayId** parameters.
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
