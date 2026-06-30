// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterPrefixListAssociationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the next hop connection.</para>
        /// <remarks>
        /// <para>If you want to query information about the prefix list that is used to generate blackhole routes, set this parameter to <b>BlackHole</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-flbq507rg2ckrj****</para>
        /// </summary>
        [NameInMap("NextHop")]
        [Validation(Required=false)]
        public string NextHop { get; set; }

        /// <summary>
        /// <para>The ID of the network instance that is associated with the next hop connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-6eh7fp9hdqa2wv85t****</para>
        /// </summary>
        [NameInMap("NextHopInstanceId")]
        [Validation(Required=false)]
        public string NextHopInstanceId { get; set; }

        /// <summary>
        /// <para>The next hop type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BlackHole</b>: queries the prefix lists that generate blackhole routes.</para>
        /// </description></item>
        /// <item><description><para><b>VPC</b>: queries the prefix lists whose next hop is a Virtual Private Cloud (VPC) connection.</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: queries the prefix lists whose next hop is a virtual border router (VBR) connection.</para>
        /// </description></item>
        /// <item><description><para><b>TR</b>: queries the prefix lists whose next hop is an inter-region connection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("NextHopType")]
        [Validation(Required=false)]
        public string NextHopType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the prefix list belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1210123456123456</para>
        /// </summary>
        [NameInMap("OwnerUid")]
        [Validation(Required=false)]
        public long? OwnerUid { get; set; }

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
        /// <para>The number of entries to return on each page. Maximum value: <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the prefix list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-6ehtn5kqxgeyy08fi****</para>
        /// </summary>
        [NameInMap("PrefixListId")]
        [Validation(Required=false)]
        public string PrefixListId { get; set; }

        /// <summary>
        /// <para>The region ID of the transit router.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to obtain the region ID.</para>
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
        /// <para>The status of the prefix list.</para>
        /// <list type="bullet">
        /// <item><description><para><b>Active</b>: The prefix list is active.</para>
        /// </description></item>
        /// <item><description><para><b>Updating</b>: The prefix list is being updated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the transit router.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-6ehx7q2jze8ch5ji0****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// <para>The ID of the route table of the transit router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-6ehgc262hr170qgyc****</para>
        /// </summary>
        [NameInMap("TransitRouterTableId")]
        [Validation(Required=false)]
        public string TransitRouterTableId { get; set; }

    }

}
