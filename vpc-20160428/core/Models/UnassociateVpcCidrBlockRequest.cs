// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UnassociateVpcCidrBlockRequest : TeaModel {
        /// <summary>
        /// The secondary IPv6 CIDR block to be deleted.
        /// 
        /// >  You must set one of the **Ipv6CidrBlock** and **SecondaryCidrBlock** parameters.
        /// </summary>
        [NameInMap("IPv6CidrBlock")]
        [Validation(Required=false)]
        public string IPv6CidrBlock { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the VPC to which the secondary CIDR block to be deleted belongs.
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

        /// <summary>
        /// The secondary IPv4 CIDR block to be deleted.
        /// 
        /// >  You must set one of the **SecondaryCidrBlock** and **Ipv6CidrBlock** parameters.
        /// </summary>
        [NameInMap("SecondaryCidrBlock")]
        [Validation(Required=false)]
        public string SecondaryCidrBlock { get; set; }

        /// <summary>
        /// The ID of the VPC from which you want to delete a secondary CIDR block.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
