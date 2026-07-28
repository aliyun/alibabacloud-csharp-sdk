// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVpcRouteEntrySummaryRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the route table resides.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>The type of the route. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all</b>: all route types.</description></item>
        /// <item><description><b>custom</b>: custom route.</description></item>
        /// <item><description><b>system</b>: system route.</description></item>
        /// <item><description><b>bgp</b>: BGP route.</description></item>
        /// <item><description><b>cen</b>: Cloud Enterprise Network (CEN) route.</description></item>
        /// <item><description><b>type_vpn_bgp_internal</b>: VPN BGP route.</description></item>
        /// <item><description><b>ECR</b>: Express Connect Router (ECR) route.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("RouteEntryType")]
        [Validation(Required=false)]
        public string RouteEntryType { get; set; }

        /// <summary>
        /// <para>The ID of the route table to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp145q7glnuzdvzu2****</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the route table belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15zckdt37pq72****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
