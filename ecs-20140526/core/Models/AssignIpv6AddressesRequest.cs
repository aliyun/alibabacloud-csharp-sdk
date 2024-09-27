// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AssignIpv6AddressesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.**** For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The IPv6 addresses to assign to the ENI. Valid values of N: 1 to 10.</para>
        /// <para>Example: Ipv6Address.1=2001:db8:1234:1a00::\<em>\</em>\<em>\</em></para>
        /// <remarks>
        /// <para> You must specify <c>Ipv6Addresses.N</c> or <c>Ipv6AddressCount</c>, but not both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2001:db8:1234:1a00::****</para>
        /// </summary>
        [NameInMap("Ipv6Address")]
        [Validation(Required=false)]
        public List<string> Ipv6Address { get; set; }

        /// <summary>
        /// <para>The number of IPv6 addresses to randomly generate for the ENI. Valid values: 1 to 10.</para>
        /// <remarks>
        /// <para> You must specify <c>Ipv6Addresses.N</c> or <c>Ipv6AddressCount</c>, but not both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv6AddressCount")]
        [Validation(Required=false)]
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// <para>The IPv6 prefixes to assign to the ENI. Valid values of N: 1 to 10.</para>
        /// <remarks>
        /// <para> To assign IPv6 prefixes to the ENI, you must specify Ipv6Prefix.N or Ipv6PrefixCount, but not both.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Ipv6Prefix")]
        [Validation(Required=false)]
        public List<string> Ipv6Prefix { get; set; }

        /// <summary>
        /// <para>The number of IPv6 prefixes to assign to the ENI. Valid values: 1 to 10.</para>
        /// <remarks>
        /// <para> To assign IPv6 prefixes to the ENI, you must specify Ipv6Prefix.N or Ipv6PrefixCount, but not both.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hide</para>
        /// </summary>
        [NameInMap("Ipv6PrefixCount")]
        [Validation(Required=false)]
        public int? Ipv6PrefixCount { get; set; }

        /// <summary>
        /// <para>The ENI ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-bp1iqejowblx6h8j****</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the ENI. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
