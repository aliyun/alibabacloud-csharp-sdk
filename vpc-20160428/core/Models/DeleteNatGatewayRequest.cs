// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DeleteNatGatewayRequest : TeaModel {
        /// <summary>
        /// Specifies whether to forcefully delete the NAT gateway. Valid values:
        /// 
        /// *   **true** If you set the value to **true**:
        /// 
        ///     *   If the NAT gateway has SNAT entries, the system automatically deletes them.
        ///     *   If the NAT gateway has DNAT entries, the system automatically deletes them.
        ///     *   If the NAT gateway is associated with an elastic IP address (EIP), the system automatically disassociates the EIP from the NAT gateway.
        ///     *   If the NAT gateway is associated with a NAT bandwidth plan, the system automatically disassociates the NAT bandwidth plan.
        /// 
        /// *   **false**(default): no If you set the value to **false**:
        /// 
        ///     *   If the NAT gateway is associated with a NAT bandwidth plan, disassociate the NAT bandwidth plan first.
        ///     *   If the NAT gateway has SNAT entries, delete them first.
        ///     *   If the NAT gateway has DNAT entries, delete them first.
        ///     *   If the NAT gateway is associated with an EIP, disassociate the EIP from the NAT gateway first.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The ID of the NAT gateway that you want to delete.
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

    }

}
