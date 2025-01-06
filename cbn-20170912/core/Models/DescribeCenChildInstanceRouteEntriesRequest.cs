// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenChildInstanceRouteEntriesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the CEN instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-7qthudw0ll6jmc****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The ID of the network instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp18sth14qii3pnvo****</para>
        /// </summary>
        [NameInMap("ChildInstanceId")]
        [Validation(Required=false)]
        public string ChildInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the network instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ChildInstanceRegionId")]
        [Validation(Required=false)]
        public string ChildInstanceRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the route table of the network instance. If you do not specify a route table ID, the system queries the routes in the system route tables of the VPCs by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-p0wxx3apzgn6uqp3r****</para>
        /// </summary>
        [NameInMap("ChildInstanceRouteTableId")]
        [Validation(Required=false)]
        public string ChildInstanceRouteTableId { get; set; }

        /// <summary>
        /// <para>The type of the network instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: virtual private cloud (VPC)</description></item>
        /// <item><description><b>VBR</b>: virtual border router (VBR)</description></item>
        /// <item><description><b>CCN</b>: Cloud Connect Network (CCN) instance</description></item>
        /// <item><description><b>ECR</b>: Express Connect Router (ECR)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ChildInstanceType")]
        [Validation(Required=false)]
        public string ChildInstanceType { get; set; }

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
        /// <para>The number of entries per page. Valid values: <b>1</b> to <b>500</b>. Default value: <b>10</b>.</para>
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
        /// <para>The status of the route. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Active</b>: available</description></item>
        /// <item><description><b>Candidate</b>: standby</description></item>
        /// <item><description><b>Rejected</b>: rejected</description></item>
        /// <item><description><b>Prohibited</b>: prohibited</description></item>
        /// <item><description><b>All</b> (default): all routes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
