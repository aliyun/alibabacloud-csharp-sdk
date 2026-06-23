// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DeleteRouteEntryRequest : TeaModel {
        /// <summary>
        /// <para>The destination CIDR block of the route. IPv4 CIDR blocks, IPv6 CIDR blocks, prefix list CIDR blocks, and prefix list instance IDs are supported. This parameter is mutually exclusive with the RouteEntryId parameter.</para>
        /// <remarks>
        /// <para>If the <b>RouteEntryId</b> parameter is not specified, the <b>DestinationCidrBlock</b> and <b>RouteTableId</b> parameters are required. Configure the <b>NextHopId</b> or <b>NextHopList</b> parameter as needed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.XX.XX/16</para>
        /// </summary>
        [NameInMap("DestinationCidrBlock")]
        [Validation(Required=false)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <para><b>true</b>: performs a dry run without deleting the route. The system checks the AccessKey pair, the authorization of the Resource Access Management (RAM) user, and the required parameters. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</para>
        /// <para><b>false</b> (default): sends a normal request. After the check succeeds, a 2xx HTTP status code is returned and the route is deleted.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the next hop instance.</para>
        /// <list type="bullet">
        /// <item><description>To delete a non-ECMP route, specify <b>NextHopId</b>. Do not specify <b>NextHopList</b>.</description></item>
        /// <item><description>To delete an ECMP route, specify <b>NextHopList</b>. Do not specify <b>NextHopId</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ri-2zeo3xzyf38r4urzd****</para>
        /// </summary>
        [NameInMap("NextHopId")]
        [Validation(Required=false)]
        public string NextHopId { get; set; }

        /// <summary>
        /// <para>The information about the next hop instances of the ECMP route. A maximum of 16 next hop instances are supported.</para>
        /// </summary>
        [NameInMap("NextHopList")]
        [Validation(Required=false)]
        public List<DeleteRouteEntryRequestNextHopList> NextHopList { get; set; }
        public class DeleteRouteEntryRequestNextHopList : TeaModel {
            /// <summary>
            /// <para>The ID of the next hop instance of the ECMP route. A maximum of 16 next hop instances are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ri-2zeo3xzyf38r43cd****</para>
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// <para>The type of the next hop of the ECMP route. Set the value to <b>RouterInterface</b> (router interface). A maximum of 16 next hop instances are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RouterInterface</para>
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the route table resides.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>The ID of the route that you want to delete. This parameter is mutually exclusive with the DestinationCidrBlock parameter.</para>
        /// <remarks>
        /// <para>If the <b>DestinationCidrBlock</b> parameter is not specified, the <b>RouteEntryId</b> parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rte-bp1mnnr2al0naomnpv****</para>
        /// </summary>
        [NameInMap("RouteEntryId")]
        [Validation(Required=false)]
        public string RouteEntryId { get; set; }

        /// <summary>
        /// <para>The ID of the route table that contains the route.  </para>
        /// <remarks>
        /// <para>If the <b>RouteEntryId</b> parameter is not specified, the <b>DestinationCidrBlock</b> and <b>RouteTableId</b> parameters are required. Configure the <b>NextHopId</b> or <b>NextHopList</b> parameter as needed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-2ze3jgygk9bmsj23s****</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

    }

}
