// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcPeer20220101.Models
{
    public class CreateVpcPeerConnectionRequest : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account to which the accepter VPC belongs.
        /// 
        /// *   To create a VPC peering connection within your Alibaba Cloud account, enter the ID of your Alibaba Cloud account.
        /// 
        /// *   To create a VPC peering connection between your Alibaba Cloud account and another Alibaba Cloud account, enter the ID of the peer Alibaba Cloud account.
        /// 
        /// > If the accepter VPC belongs to a Resource Access Management (RAM) user, you must set the value of **AcceptingAliUid** to the ID of the corresponding Alibaba Cloud account.
        /// </summary>
        [NameInMap("AcceptingAliUid")]
        [Validation(Required=false)]
        public long? AcceptingAliUid { get; set; }

        /// <summary>
        /// The region ID of the accepter VPC of the VPC peering connection that you want to create.
        /// 
        /// *   To create an intra-region VPC peering connection, enter a region ID that is the same as that of the requester VPC.
        /// *   To create an inter-region VPC peering connection, enter a region ID that is different from that of the requester VPC.
        /// </summary>
        [NameInMap("AcceptingRegionId")]
        [Validation(Required=false)]
        public string AcceptingRegionId { get; set; }

        /// <summary>
        /// The ID of the accepter VPC.
        /// </summary>
        [NameInMap("AcceptingVpcId")]
        [Validation(Required=false)]
        public string AcceptingVpcId { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **client token** as the **request ID**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the VPC peering connection.
        /// 
        /// The description must be 2 to 256 characters in length. The description must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The name of the VPC peering connection.
        /// 
        /// The name must be 2 to 128 characters in length and can contain letters, digits, underscores (\_), and hyphens (-). It must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the region where you want to create a VPC peering connection.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// 
        /// For more information about resource groups, see [What is a resource group?](~~94475~~)
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the requester VPC.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
