// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateDhcpOptionsSetRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the DHCP options set.
        /// 
        /// The description must be 1 to 256 characters in length. It must start with a letter and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("DhcpOptionsSetDescription")]
        [Validation(Required=false)]
        public string DhcpOptionsSetDescription { get; set; }

        /// <summary>
        /// The name of the DHCP options set.
        /// 
        /// The name must be 1 to 128 characters in length and can contain letters, digits, underscores (_), and hyphens (-). It must start with a letter.
        /// </summary>
        [NameInMap("DhcpOptionsSetName")]
        [Validation(Required=false)]
        public string DhcpOptionsSetName { get; set; }

        /// <summary>
        /// The root domain. For example, you can set the value to example.com.
        /// 
        /// After a DHCP options set is associated with a virtual private cloud (VPC), the root domain in the DHCP options set is automatically synchronized with the ECS instances in the VPC.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The IP address of the DNS server. You can enter at most four DNS server IP addresses. Separate IP addresses with commas (,).
        /// 
        /// >  If no IP address is specified, the Elastic Compute Service (ECS) instance uses the IP addresses 100.100.2.136 and 100.100.2.138, which are provided by Alibaba Cloud by default.
        /// </summary>
        [NameInMap("DomainNameServers")]
        [Validation(Required=false)]
        public string DomainNameServers { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request.
        /// 
        /// **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// 
        /// **false** (default): performs a dry run and sends the request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The lease time of the IPv6 addresses for the DHCP options set.
        /// 
        /// *   If you use hours as the unit, valid values are **24h to 1176h** and **87600h to 175200h**. Default value: **87600h**.
        /// *   If you use days as the unit, valid values are **1d to 49d** and **3650d to 7300d**. Default value: **3650d**.
        /// 
        /// >  When you enter a value, you must also specify the unit.
        /// </summary>
        [NameInMap("Ipv6LeaseTime")]
        [Validation(Required=false)]
        public string Ipv6LeaseTime { get; set; }

        /// <summary>
        /// The lease time of the IPv4 addresses for the DHCP options set.
        /// 
        /// *   If you use hours as the unit, valid values are **24h to 1176h** and **87600h to 175200h**. Default value: **87600h**.
        /// *   If you use days as the unit, valid values are **1d to 49d** and **3650d to 7300d**. Default value: **3650d**.
        /// 
        /// >  When you enter a value, you must also specify the unit.
        /// </summary>
        [NameInMap("LeaseTime")]
        [Validation(Required=false)]
        public string LeaseTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region to which the DHCP options set belongs.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the DHCP options set belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The tag of the resource.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDhcpOptionsSetRequestTag> Tag { get; set; }
        public class CreateDhcpOptionsSetRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// A tag key can be at most 128 characters in length. It cannot start with `aliyun` or `acs:`, and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the resource. You can specify at most 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length, and cannot contain `http://` or `https://`. The tag value cannot start with `aliyun` or `acs:`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
