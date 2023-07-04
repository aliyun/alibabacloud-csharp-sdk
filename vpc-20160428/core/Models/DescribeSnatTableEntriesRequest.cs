// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSnatTableEntriesRequest : TeaModel {
        /// <summary>
        /// The ID of the NAT gateway.
        /// 
        /// >  You must set at least one of the **SnatTableId** and **NatGatewayId** parameters.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the NAT gateway.
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
        /// The ID of the SNAT entry.
        /// </summary>
        [NameInMap("SnatEntryId")]
        [Validation(Required=false)]
        public string SnatEntryId { get; set; }

        /// <summary>
        /// The name of the SNAT entry.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain digits, underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("SnatEntryName")]
        [Validation(Required=false)]
        public string SnatEntryName { get; set; }

        /// <summary>
        /// *   When you query SNAT entries of Internet NAT gateways, this parameter specifies the EIP in an SNAT entry.
        /// *   When you query SNAT entries of VPC NAT gateways, this parameter specifies the NAT IP address in an SNAT entry.
        /// </summary>
        [NameInMap("SnatIp")]
        [Validation(Required=false)]
        public string SnatIp { get; set; }

        /// <summary>
        /// The ID of the SNAT table.
        /// 
        /// >  You must set at least one of the **SnatTableId** and **NatGatewayId** parameters.
        /// </summary>
        [NameInMap("SnatTableId")]
        [Validation(Required=false)]
        public string SnatTableId { get; set; }

        /// <summary>
        /// The source CIDR block specified in the SNAT entry.
        /// </summary>
        [NameInMap("SourceCIDR")]
        [Validation(Required=false)]
        public string SourceCIDR { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// 
        /// *   When you query SNAT entries of Internet NAT gateways, this parameter specifies that Elastic Compute Service (ECS) instances in the vSwitch can use SNAT entries to access the Internet.
        /// *   When you query SNAT entries of virtual private cloud (VPC) NAT gateways, this parameter specifies that ECS instances in the vSwitch can use SNAT entries to access external networks.
        /// </summary>
        [NameInMap("SourceVSwitchId")]
        [Validation(Required=false)]
        public string SourceVSwitchId { get; set; }

    }

}
