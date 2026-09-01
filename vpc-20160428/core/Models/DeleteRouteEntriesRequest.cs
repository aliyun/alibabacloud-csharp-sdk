// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DeleteRouteEntriesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <para><b>true</b>: performs a dry run without deleting routes. The system checks the AccessKey pair, the authorization of the Resource Access Management (RAM) user, and the required parameters. If the check fails, the corresponding error is returned. If the check passes, the error code <c>DryRunOperation</c> is returned.</para>
        /// <para><b>false</b> (default): sends a normal request. If the check passes, a 2xx HTTP status code is returned and the routes are deleted.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the route table resides.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query the region ID.</para>
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
        /// <para>The information about the route entries to delete.</para>
        /// </summary>
        [NameInMap("RouteEntries")]
        [Validation(Required=false)]
        public List<DeleteRouteEntriesRequestRouteEntries> RouteEntries { get; set; }
        public class DeleteRouteEntriesRequestRouteEntries : TeaModel {
            /// <summary>
            /// <para>The destination CIDR block of the route entry to delete. IPv4 CIDR blocks, IPv6 CIDR blocks, and prefix list CIDR blocks are supported. You can specify up to 50 destination CIDR blocks.</para>
            /// <remarks>
            /// <para>If the <b>RouteEntryId</b> parameter is not specified, the <b>DstCidrBlock</b> and <b>NextHop</b> parameters are required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>47.100.XX.XX/24</para>
            /// </summary>
            [NameInMap("DstCidrBlock")]
            [Validation(Required=false)]
            public string DstCidrBlock { get; set; }

            /// <summary>
            /// <para>The ID of the next hop instance to delete. You can specify up to 50 instance IDs.</para>
            /// <remarks>
            /// <para>If the <b>RouteEntryId</b> parameter is not specified, the <b>DstCidrBlock</b> and <b>NextHop</b> parameters are required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-j6c2fp57q8rr4jlu****</para>
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            /// <summary>
            /// <para>The ID of the route entry to delete. You can specify up to 50 route entry IDs.</para>
            /// <remarks>
            /// <para>If the <b>RouteEntryId</b> parameter is not specified, the <b>DstCidrBlock</b> and <b>NextHop</b> parameters are required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>rte-bp1mnnr2al0naomnpv****</para>
            /// </summary>
            [NameInMap("RouteEntryId")]
            [Validation(Required=false)]
            public string RouteEntryId { get; set; }

            /// <summary>
            /// <para>The ID of the route table that contains the route entry to delete. You can specify up to 50 route table IDs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-2ze3jgygk9bmsj23s****</para>
            /// </summary>
            [NameInMap("RouteTableId")]
            [Validation(Required=false)]
            public string RouteTableId { get; set; }

        }

    }

}
