// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetDhcpOptionsSetResponseBody : TeaModel {
        [NameInMap("AssociateVpcs")]
        [Validation(Required=false)]
        public List<GetDhcpOptionsSetResponseBodyAssociateVpcs> AssociateVpcs { get; set; }
        public class GetDhcpOptionsSetResponseBodyAssociateVpcs : TeaModel {
            [NameInMap("AssociateStatus")]
            [Validation(Required=false)]
            public string AssociateStatus { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The lease time of the IPv6 addresses for the DHCP options set.
        /// 
        /// *   If you use hours as the unit, Valid values are **24h to 1176h** and **87600h to 175200h**. Default value: **87600h**.
        /// *   If you use days as the unit, Valid values are **1d to 49d** and **3650d to 7300d**. Default value: **3650d**.
        /// </summary>
        [NameInMap("DhcpOptions")]
        [Validation(Required=false)]
        public GetDhcpOptionsSetResponseBodyDhcpOptions DhcpOptions { get; set; }
        public class GetDhcpOptionsSetResponseBodyDhcpOptions : TeaModel {
            /// <summary>
            /// The status of the VPC that is associated with the DHCP options set. Valid values:
            /// 
            /// *   **InUse**: in use
            /// *   **Pending**: being configured
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// The information about the virtual private cloud (VPC) that is associated with the DHCP options set.
            /// </summary>
            [NameInMap("DomainNameServers")]
            [Validation(Required=false)]
            public string DomainNameServers { get; set; }

            [NameInMap("Ipv6LeaseTime")]
            [Validation(Required=false)]
            public string Ipv6LeaseTime { get; set; }

            /// <summary>
            /// The ID of the VPC that is associated with the DHCP options set.
            /// </summary>
            [NameInMap("LeaseTime")]
            [Validation(Required=false)]
            public string LeaseTime { get; set; }

        }

        /// <summary>
        /// The name of the DHCP options set.
        /// </summary>
        [NameInMap("DhcpOptionsSetDescription")]
        [Validation(Required=false)]
        public string DhcpOptionsSetDescription { get; set; }

        /// <summary>
        /// The IP address of the DNS server.
        /// </summary>
        [NameInMap("DhcpOptionsSetId")]
        [Validation(Required=false)]
        public string DhcpOptionsSetId { get; set; }

        /// <summary>
        /// The suffix of the hostname.
        /// </summary>
        [NameInMap("DhcpOptionsSetName")]
        [Validation(Required=false)]
        public string DhcpOptionsSetName { get; set; }

        /// <summary>
        /// The lease time of the IPv4 addresses for the DHCP options set.
        /// 
        /// *   If you use hours as the unit, valid values are **24h to 1176h** and **87600h to 175200h**. Default value: **87600h**.
        /// *   If you use days as the unit, valid values are **1d to 49d** and **3650d to 7300d**. Default value: **3650d**.
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The configuration information about the DHCP options set.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud account to which the DHCP options set belongs.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetDhcpOptionsSetResponseBodyTags> Tags { get; set; }
        public class GetDhcpOptionsSetResponseBodyTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
