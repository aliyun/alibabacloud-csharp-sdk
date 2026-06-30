// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterPrefixListAssociationResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The information about the prefix lists.</para>
        /// </summary>
        [NameInMap("PrefixLists")]
        [Validation(Required=false)]
        public List<ListTransitRouterPrefixListAssociationResponseBodyPrefixLists> PrefixLists { get; set; }
        public class ListTransitRouterPrefixListAssociationResponseBodyPrefixLists : TeaModel {
            /// <summary>
            /// <para>The ID of the next hop connection.</para>
            /// <remarks>
            /// <para>If <b>BlackHole</b> is returned, it indicates that all CIDR blocks in the prefix list are blackhole routes. All traffic destined for the CIDR blocks in the prefix list is dropped.</para>
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
            /// <para>The next hop type.</para>
            /// <list type="bullet">
            /// <item><description><para><b>BlackHole</b>: The routes are blackhole routes. All traffic destined for the CIDR blocks in the prefix list is dropped.</para>
            /// </description></item>
            /// <item><description><para><b>VPC</b>: The next hop is a Virtual Private Cloud (VPC) connection.</para>
            /// </description></item>
            /// <item><description><para><b>VBR</b>: The next hop is a virtual border router (VBR) connection.</para>
            /// </description></item>
            /// <item><description><para><b>TR</b>: The next hop is an inter-region connection.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

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
            /// <para>The ID of the prefix list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pl-6ehtn5kqxgeyy08fi****</para>
            /// </summary>
            [NameInMap("PrefixListId")]
            [Validation(Required=false)]
            public string PrefixListId { get; set; }

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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6005CA94-676E-1FEE-985E-7602EFAADD6A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
