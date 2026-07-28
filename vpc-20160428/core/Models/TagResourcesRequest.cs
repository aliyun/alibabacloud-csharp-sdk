// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class TagResourcesRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the resource to which you want to create and bind tags.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <item><description><b>VSWITCH</b>: virtual switch instance.</description></item>
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
        /// <item><description><b>HAVIP</b>: high-availability (HA) virtual IP address instance.</description></item>
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
        /// <para>The tag information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TagResources</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You must specify at least 1 and can specify up to 20 tag keys.</para>
            /// <para>The tag key can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para>The <b>Tag.N.Key</b> parameter is required when you call this operation, and cannot be an empty string.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You must specify at least 1 and can specify up to 20 tag values.</para>
            /// <para>The tag value can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para>The <b>Tag.N.Value</b> parameter is required when you call this operation, and can be an empty string.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
