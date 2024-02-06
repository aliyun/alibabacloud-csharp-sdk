// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateSnatEntryRequest : TeaModel {
        /// <summary>
        /// The ID of the Network Address Translation (NAT) gateway.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// The name of the SNAT entry. The name must be 1 to 128 characters in length. The name cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("SnatEntryName")]
        [Validation(Required=false)]
        public string SnatEntryName { get; set; }

        /// <summary>
        /// The elastic IP address (EIP) in the SNAT entry. Separate multiple EIPs with commas (,).
        /// </summary>
        [NameInMap("SnatIp")]
        [Validation(Required=false)]
        public string SnatIp { get; set; }

        /// <summary>
        /// The CIDR block. You can specify the CIDR block of a network, a vSwitch, or an instance. You can also specify a custom CIDR block. All instances within the CIDR block can access the Internet or external networks by using SNAT.
        /// 
        /// >  If you specify **SourceVSwitchId** and **SourceCIDR**, **SourceVSwitchId** does not take effect. The value that you specified for **SourceCIDR** takes precedence.
        /// </summary>
        [NameInMap("SourceCIDR")]
        [Validation(Required=false)]
        public string SourceCIDR { get; set; }

        /// <summary>
        /// The ID of the network. This parameter specifies that all ENS instances in the network can use the SNAT entry to access the Internet.
        /// 
        /// >  If you specify **SourceNetworkId** and **SourceVSwitchId** or **SourceCIDR**, **SourceNetworkId** does not take effect. The value that you specified for **SourceCIDR** takes precedence. Priority: **SourceCIDR** > **SourceVSwitchId** > **SourceNetworkId**.
        /// </summary>
        [NameInMap("SourceNetworkId")]
        [Validation(Required=false)]
        public string SourceNetworkId { get; set; }

        /// <summary>
        /// The ID of the vSwitch that you need to access over the Internet. This parameter specifies that Edge Node Service (ENS) instances in the vSwitch can use the SNAT entry to access the Internet.
        /// 
        /// >  If you specify **SourceVSwitchId** and **SourceCIDR**, **SourceVSwitchId** does not take effect. The value that you specified for **SourceCIDR** takes precedence.
        /// </summary>
        [NameInMap("SourceVSwitchId")]
        [Validation(Required=false)]
        public string SourceVSwitchId { get; set; }

        /// <summary>
        /// The secondary EIP in the SNAT entry. Separate multiple secondary EIPs with commas (,).
        /// </summary>
        [NameInMap("StandbySnatIp")]
        [Validation(Required=false)]
        public string StandbySnatIp { get; set; }

    }

}
