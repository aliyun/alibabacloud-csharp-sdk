// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeTagsRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 50. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResult")]
        [Validation(Required=false)]
        public int? MaxResult { get; set; }

        /// <summary>
        /// <para>The pagination token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is the first query or no subsequent query exists, leave this parameter empty.</description></item>
        /// <item><description>If a subsequent query exists, set this parameter to the NextToken value returned by the previous API call.</description></item>
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
        /// <para>The resource ID. You can specify up to 50 resource IDs.</para>
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
        /// <item><description><b>HAVIP</b>: high-availability virtual IP address instance.</description></item>
        /// <item><description><b>DHCPOPTIONSSET</b>: DHCP options set instance.</description></item>
        /// <item><description><b>GATEWAYENDPOINT</b>: gateway endpoint instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The resource type value is case-insensitive.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeTagsRequestTag> Tag { get; set; }
        public class DescribeTagsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot be an empty string or start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values.</para>
            /// <para>A tag value can be up to 128 characters in length. It can be an empty string but cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
