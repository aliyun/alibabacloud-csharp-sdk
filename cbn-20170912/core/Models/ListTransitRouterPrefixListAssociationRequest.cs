// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterPrefixListAssociationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the next hop.</para>
        /// <remarks>
        /// <para>Set the value to <b>BlackHole</b> if you want to query the prefix list that generates blackhole routes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-flbq507rg2ckrj****</para>
        /// </summary>
        [NameInMap("NextHop")]
        [Validation(Required=false)]
        public string NextHop { get; set; }

        /// <summary>
        /// <para>The ID of the network instance associated with the next hop connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-6eh7fp9hdqa2wv85t****</para>
        /// </summary>
        [NameInMap("NextHopInstanceId")]
        [Validation(Required=false)]
        public string NextHopInstanceId { get; set; }

        /// <summary>
        /// <para>The type of the next hop. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BlackHole</b>: The prefix list that generates blackhole routes.</description></item>
        /// <item><description><b>VPC</b>: The prefix list whose next hop is a virtual private cloud (VPC) connection.</description></item>
        /// <item><description><b>VBR</b>: The prefix list whose next hop is a virtual border router (VBR) connection.</description></item>
        /// <item><description><b>TR</b>: The prefix list whose next hop is an inter-region connection on the transit router.</description></item>
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
        /// <para>The ID of the region where the transit router is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query the most recent region list.</para>
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
        /// <para>The status of the prefix list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Active</b></description></item>
        /// <item><description><b>Updating</b></description></item>
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
