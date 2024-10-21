// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenRouteMapsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-wx12mmlt17ld82****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The region ID of the routing policy.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("CenRegionId")]
        [Validation(Required=false)]
        public string CenRegionId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The routing policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cenrmap-y40mxdvf7joc12****</para>
        /// </summary>
        [NameInMap("RouteMapId")]
        [Validation(Required=false)]
        public string RouteMapId { get; set; }

        /// <summary>
        /// <para>The route table ID of the transit router with which the routing policy is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-gw8nx3515m1mbd1z1****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableId { get; set; }

        /// <summary>
        /// <para>The direction in which the routing policy is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RegionIn</b>: Routes are advertised to the gateways in the regions that are connected by the CEN instance.</description></item>
        /// </list>
        /// <para>For example, routes are advertised from network instances deployed in the current region or other regions to the gateway deployed in the current region.</para>
        /// <list type="bullet">
        /// <item><description><b>RegionOut</b>: Routes are advertised from the gateways in the regions that are connected by the CEN instance.</description></item>
        /// </list>
        /// <para>For example, routes are advertised from the gateway deployed in the current region to network instances deployed in the current region, or to gateways deployed in other regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RegionOut</para>
        /// </summary>
        [NameInMap("TransmitDirection")]
        [Validation(Required=false)]
        public string TransmitDirection { get; set; }

    }

}
