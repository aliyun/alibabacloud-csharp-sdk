// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateSecurityProxyRequest : TeaModel {
        /// <summary>
        /// The status of the NAT firewall. Valid values:
        /// 
        /// *   **open**: enabled
        /// *   **close**: disabled
        /// </summary>
        [NameInMap("FirewallSwitch")]
        [Validation(Required=false)]
        public string FirewallSwitch { get; set; }

        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the NAT gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// The routes to be switched to the NAT gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NatRouteEntryList")]
        [Validation(Required=false)]
        public List<CreateSecurityProxyRequestNatRouteEntryList> NatRouteEntryList { get; set; }
        public class CreateSecurityProxyRequestNatRouteEntryList : TeaModel {
            /// <summary>
            /// The destination CIDR block of the default route.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DestinationCidr")]
            [Validation(Required=false)]
            public string DestinationCidr { get; set; }

            /// <summary>
            /// The next hop of the original NAT gateway.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// The network type of the next hop. Set the value to NatGateway.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// The route table to which the default route of the NAT gateway belongs.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

        /// <summary>
        /// The name of the NAT firewall. The name must be 4 to 50 characters in length, and can contain letters, digits, and underscores (_). However, it cannot start with an underscore.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProxyName")]
        [Validation(Required=false)]
        public string ProxyName { get; set; }

        /// <summary>
        /// The region ID of the virtual private cloud (VPC).
        /// 
        /// >  For more information about Cloud Firewall supported regions, see [Supported regions](https://help.aliyun.com/document_detail/195657.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// Specifies whether to enable the strict mode. Valid values:
        /// 
        /// *   1: yes
        /// *   0: no
        /// </summary>
        [NameInMap("StrictMode")]
        [Validation(Required=false)]
        public int? StrictMode { get; set; }

        /// <summary>
        /// The ID of the VPC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The mode of the vSwitch that you want to use. Valid values:
        /// 
        /// *   **true**: automatic
        /// *   **false**: manual
        /// </summary>
        [NameInMap("VswitchAuto")]
        [Validation(Required=false)]
        public string VswitchAuto { get; set; }

        /// <summary>
        /// The CIDR block of the vSwitch.
        /// </summary>
        [NameInMap("VswitchCidr")]
        [Validation(Required=false)]
        public string VswitchCidr { get; set; }

        /// <summary>
        /// The ID of the vSwitch. This parameter is required if you set the VswitchAuto parameter to true.
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

    }

}
