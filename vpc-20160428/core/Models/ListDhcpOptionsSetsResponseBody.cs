// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListDhcpOptionsSetsResponseBody : TeaModel {
        /// <summary>
        /// The list of the DHCP options sets.
        /// </summary>
        [NameInMap("DhcpOptionsSets")]
        [Validation(Required=false)]
        public List<ListDhcpOptionsSetsResponseBodyDhcpOptionsSets> DhcpOptionsSets { get; set; }
        public class ListDhcpOptionsSetsResponseBodyDhcpOptionsSets : TeaModel {
            /// <summary>
            /// The number of VPCs with which the DHCP options set is associated.
            /// </summary>
            [NameInMap("AssociateVpcCount")]
            [Validation(Required=false)]
            public int? AssociateVpcCount { get; set; }

            /// <summary>
            /// The configuration information about the DHCP options set.
            /// </summary>
            [NameInMap("DhcpOptions")]
            [Validation(Required=false)]
            public ListDhcpOptionsSetsResponseBodyDhcpOptionsSetsDhcpOptions DhcpOptions { get; set; }
            public class ListDhcpOptionsSetsResponseBodyDhcpOptionsSetsDhcpOptions : TeaModel {
                /// <summary>
                /// The suffix of the hostname.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The IP address of the DNS server.
                /// </summary>
                [NameInMap("DomainNameServers")]
                [Validation(Required=false)]
                public string DomainNameServers { get; set; }

                /// <summary>
                /// The lease time of the IPv6 addresses for the DHCP options set.
                /// 
                /// *   If you use hours as the unit, valid values are **24h to 1176h** and **87600h to 175200h**. Default value: **87600h**.
                /// *   If you use days as the unit, valid values are **1d to 49d** and **3650d to 7300d**. Default value: **3650d**.
                /// </summary>
                [NameInMap("Ipv6LeaseTime")]
                [Validation(Required=false)]
                public string Ipv6LeaseTime { get; set; }

                /// <summary>
                /// The lease time of the IPv4 addresses for the DHCP options set.
                /// 
                /// *   If you use hours as the unit, valid values are **24h to 1176h** and **87600h to 175200h**. Default value: **87600h**.
                /// *   If you use days as the unit, valid values are **1d to 49d** and **3650d to 7300d**. Default value: **3650d**.
                /// </summary>
                [NameInMap("LeaseTime")]
                [Validation(Required=false)]
                public string LeaseTime { get; set; }

            }

            /// <summary>
            /// The description of the DHCP options set.
            /// </summary>
            [NameInMap("DhcpOptionsSetDescription")]
            [Validation(Required=false)]
            public string DhcpOptionsSetDescription { get; set; }

            /// <summary>
            /// The ID of the DHCP options set.
            /// </summary>
            [NameInMap("DhcpOptionsSetId")]
            [Validation(Required=false)]
            public string DhcpOptionsSetId { get; set; }

            /// <summary>
            /// The name of the DHCP options set.
            /// </summary>
            [NameInMap("DhcpOptionsSetName")]
            [Validation(Required=false)]
            public string DhcpOptionsSetName { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the DHCP options set belongs.
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the DHCP options set belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The status of the DHCP options set. Valid values:
            /// 
            /// *   **Available**
            /// *   **InUse**
            /// *   **Pending**
            /// *   **Deleted**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tag list.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListDhcpOptionsSetsResponseBodyDhcpOptionsSetsTags> Tags { get; set; }
            public class ListDhcpOptionsSetsResponseBodyDhcpOptionsSetsTags : TeaModel {
                /// <summary>
                /// The key of tag N added to the resource.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of tag N added to the resource.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value is returned for **NextToken**, the value is used to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
