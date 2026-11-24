// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AssignPrivateIpAddressesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The IPv4 prefixes to be allocated to the Elastic Network Interface (ENI). Valid values of N: 1 to 10.</para>
        /// <remarks>
        /// <para>If you need to configure IPv4 prefix settings for the Elastic Network Interface (ENI), you must specify the settings for either Ipv4Prefix.N or Ipv4PrefixCount, but you cannot specify both parameters.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Ipv4Prefix")]
        [Validation(Required=false)]
        public List<string> Ipv4Prefix { get; set; }

        /// <summary>
        /// <para>The number of randomly generated IPv4 prefixes to be allocated to the Elastic Network Interface (ENI). Valid values: 1 to 10.</para>
        /// <remarks>
        /// <para>If you need to configure IPv4 prefix settings for the Elastic Network Interface (ENI), you must specify the settings for either Ipv4Prefix.N or Ipv4PrefixCount, but you cannot specify both parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Ipv4PrefixCount")]
        [Validation(Required=false)]
        public int? Ipv4PrefixCount { get; set; }

        /// <summary>
        /// <para>The ID of the Elastic Network Interface (ENI).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-bp67acfmxazb4p****</para>
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
        /// <para>The secondary private IP addresses (private IP addresses or private IPs) to be allocated from the available IP addresses of the vSwitch to which the Elastic Network Interface (ENI) belongs. Valid values of N:</para>
        /// <list type="bullet">
        /// <item><description>If the Elastic Network Interface (ENI) is in the <c>Available</c> state: 1 to 32.</description></item>
        /// <item><description>If the Elastic Network Interface (ENI) is in the <c>InUse</c> state: The value is limited by the instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>.</description></item>
        /// </list>
        /// <para>When you allocate secondary private IP addresses (private IP addresses or private IPs), you cannot specify both <c>PrivateIpAddress.N</c> and <c>SecondaryPrivateIpAddressCount</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;<c>10.1.**.**</c>&quot;]</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public List<string> PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The region ID of the Elastic Network Interface (ENI). You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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

        /// <summary>
        /// <para>The number of private IP addresses to be automatically assigned from the available IP addresses of the vSwitch.</para>
        /// <para>When you assign secondary private IP addresses, you cannot specify both <c>PrivateIpAddress.N</c> and <c>SecondaryPrivateIpAddressCount</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SecondaryPrivateIpAddressCount")]
        [Validation(Required=false)]
        public int? SecondaryPrivateIpAddressCount { get; set; }

    }

}
