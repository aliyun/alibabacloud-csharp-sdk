// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteTablesRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page during paging. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC to which the route table belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-6</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the route table belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the route table to query.</para>
        /// <remarks>
        /// <para>You must specify at least one of the following parameters: VRouterId, RouteTableId, RouterId, and RouteTableName. You cannot specify both VRouterId and RouterId at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp145q7glnuzdvzu2****</para>
        /// </summary>
        [NameInMap("RouteTableId")]
        [Validation(Required=false)]
        public string RouteTableId { get; set; }

        /// <summary>
        /// <para>The name of the route table to query.</para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para>You must specify at least one of the following parameters: VRouterId, RouteTableId, RouterId, and RouteTableName. You cannot specify both VRouterId and RouterId at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>doctest</para>
        /// </summary>
        [NameInMap("RouteTableName")]
        [Validation(Required=false)]
        public string RouteTableName { get; set; }

        /// <summary>
        /// <para>The ID of the router to which the route table belongs.</para>
        /// <remarks>
        /// <para>You must specify at least one of the following parameters: VRouterId, RouteTableId, RouterId, and RouteTableName. You cannot specify both VRouterId and RouterId at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vrt-bp1lhl0taikrteen8****</para>
        /// </summary>
        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

        /// <summary>
        /// <para>The type of the router to which the route table belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VRouter</b> (default): vRouter.</description></item>
        /// <item><description><b>VBR</b>: Virtual Border Router.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VRouter</para>
        /// </summary>
        [NameInMap("RouterType")]
        [Validation(Required=false)]
        public string RouterType { get; set; }

        /// <summary>
        /// <para>The destination type of the route to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Custom</b>: custom route.</description></item>
        /// <item><description><b>System</b>: system route.</description></item>
        /// <item><description><b>BGP</b>: BGP route.</description></item>
        /// <item><description><b>CEN</b>: Cloud Enterprise Network (CEN) route.</description></item>
        /// <item><description><b>ECR</b>: Express Connect Router (ECR) route.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the vRouter to query.</para>
        /// <remarks>
        /// <para>You must specify at least one of the following parameters: VRouterId, RouteTableId, RouterId, and RouteTableName. You cannot specify both VRouterId and RouterId at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vrt-bp1lhl0taikrteen****</para>
        /// </summary>
        [NameInMap("VRouterId")]
        [Validation(Required=false)]
        public string VRouterId { get; set; }

    }

}
