// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1</b> to <b>50</b>. Default value: <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If this is the first query or no next query exists, you do not need to set this parameter.</para>
        /// </description></item>
        /// <item><description><para>If a next query exists, set the value to the <b>NextToken</b> value returned in the previous API call.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the resource.</para>
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
        /// <para>The IDs of the resources. You can specify up to 50 resource IDs.</para>
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
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: VPC instance.</description></item>
        /// <item><description><b>VSWITCH</b>: vSwitch instance.</description></item>
        /// <item><description><b>ROUTETABLE</b>: route table instance.</description></item>
        /// <item><description><b>EIP</b>: Elastic IP Address (EIP) instance.</description></item>
        /// <item><description><b>VPNGATEWAY</b>: VPN gateway instance.</description></item>
        /// <item><description><b>NATGATEWAY</b>: NAT gateway instance.</description></item>
        /// <item><description><b>COMMONBANDWIDTHPACKAGE</b>: EIP bandwidth plan instance.</description></item>
        /// <item><description><b>PREFIXLIST</b>: prefix list instance.</description></item>
        /// <item><description><b>PUBLICIPADDRESSPOOL</b>: IP address pool instance.</description></item>
        /// <item><description><b>IPV4GATEWAY</b>: IPv4 gateway instance.</description></item>
        /// <item><description><b>IPV6GATEWAY</b>: IPv6 gateway instance.</description></item>
        /// <item><description><b>NETWORKACL</b>: network ACL instance.</description></item>
        /// <item><description><b>TRAFFICMIRRORFILTER</b>: traffic mirroring filter instance.</description></item>
        /// <item><description><b>TRAFFICMIRRORSESSION</b>: traffic mirroring session instance.</description></item>
        /// <item><description><b>FLOWLOG</b>: flow log instance.</description></item>
        /// <item><description><b>HAVIP</b>: high-availability virtual IP address (HAVIP) instance.</description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>ListTagResources</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. You can specify up to 20 tag keys.</para>
            /// <para>The tag key can be up to 128 characters in length. It cannot be an empty string. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para>You must specify at least one of the <b>ResourceId.N</b> and <b>Tag.N</b> (<b>Tag.N.Key</b> and <b>Tag.N.Value</b>) parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. You can specify up to 20 tag values.</para>
            /// <para>The tag value can be up to 128 characters in length and can be an empty string. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para>You must specify at least one of the <b>ResourceId.N</b> and <b>Tag.N</b> (<b>Tag.N.Key</b> and <b>Tag.N.Value</b>) parameters.</para>
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
