// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class MoveResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource group to which you want to move the cloud resource instance.</para>
        /// <remarks>
        /// <para>A resource group is a mechanism for managing resources by group within an Alibaba Cloud account. Resource groups help you address complex resource grouping and authorization management issues within a single cloud account. For more information, see <a href="https://help.aliyun.com/document_detail/94475.html">What is Resource Management?</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm3peow3k****</para>
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the cloud resource.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The instance ID of the cloud resource for which you want to modify the resource group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-hp31psbg8ec3023s6****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of the cloud resource for which you want to modify the resource group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Vpc</b>: virtual private cloud (VPC)</description></item>
        /// <item><description><b>Eip</b>: elastic IP address (EIP)</description></item>
        /// <item><description><b>BandwidthPackage</b>: Internet Shared Bandwidth</description></item>
        /// <item><description><b>PrefixList</b>: prefix list</description></item>
        /// <item><description><b>PublicIpAddressPool</b>: IPAM pool</description></item>
        /// <item><description><b>FlowLog</b>: flow log</description></item>
        /// <item><description><b>HaVip</b>: high-availability (HA) virtual IP address</description></item>
        /// <item><description><b>TrafficMirrorFilter</b>: traffic mirror filter</description></item>
        /// <item><description><b>TrafficMirrorSession</b>: traffic mirror session</description></item>
        /// <item><description><b>IPv4Gateway</b>: IPv4 gateway</description></item>
        /// <item><description><b>IPv6Gateway</b>: IPv6 gateway</description></item>
        /// <item><description><b>IPv6Address</b>: IPv6 address</description></item>
        /// <item><description><b>DhcpOptionsSet</b>: DHCP options set</description></item>
        /// <item><description><b>GatewayEndpoint</b>: gateway endpoint</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
