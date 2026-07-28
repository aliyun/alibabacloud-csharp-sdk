// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class UnTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to unbind all tags from the resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Unbinds all tags from the resources.</description></item>
        /// <item><description><b>false</b> (default): Does not unbind all tags from the resources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the resources.</para>
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
        /// <para>The resource IDs. You can specify up to 50 resource IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp16qjewdsunr41m1****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: virtual private cloud (VPC) instance.</description></item>
        /// <item><description><b>VSWITCH</b>: vSwitch instance.</description></item>
        /// <item><description><b>ROUTETABLE</b>: route table instance.</description></item>
        /// <item><description><b>EIP</b>: elastic IP address (EIP) instance.</description></item>
        /// <item><description><b>VPNGATEWAY</b>: VPN gateway instance.</description></item>
        /// <item><description><b>NATGATEWAY</b>: NAT gateway instance.</description></item>
        /// <item><description><b>COMMONBANDWIDTHPACKAGE</b>: Internet Shared Bandwidth instance.</description></item>
        /// <item><description><b>PREFIXLIST</b>: prefix list instance.</description></item>
        /// <item><description><b>PUBLICIPADDRESSPOOL</b>: IP address pool instance.</description></item>
        /// <item><description><b>IPV4GATEWAY</b>: IPv4 gateway instance.</description></item>
        /// <item><description><b>IPV6GATEWAY</b>: IPv6 gateway instance.</description></item>
        /// <item><description><b>NETWORKACL</b>: network ACL instance.</description></item>
        /// <item><description><b>TRAFFICMIRRORFILTER</b>: traffic mirror filter instance.</description></item>
        /// <item><description><b>TRAFFICMIRRORSESSION</b>: traffic mirror session instance.</description></item>
        /// <item><description><b>FLOWLOG</b>: flow log instance.</description></item>
        /// <item><description><b>HAVIP</b>: high-availability virtual IP address (HaVip) instance.</description></item>
        /// <item><description><b>DHCPOPTIONSSET</b>: DHCP options set instance.</description></item>
        /// <item><description><b>GATEWAYENDPOINT</b>: gateway endpoint instance.</description></item>
        /// <item><description><b>IPV6ADDRESS</b>: IPv6 address instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The resource type value is case-insensitive.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag keys to unbind. You can specify up to 20 tag keys.</para>
        /// <para>Each tag key can be up to 128 characters in length, can be an empty string, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FinanceDept</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
