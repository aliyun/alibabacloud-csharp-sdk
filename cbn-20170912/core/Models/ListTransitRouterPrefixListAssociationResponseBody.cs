// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterPrefixListAssociationResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>A list of prefix lists.</para>
        /// </summary>
        [NameInMap("PrefixLists")]
        [Validation(Required=false)]
        public List<ListTransitRouterPrefixListAssociationResponseBodyPrefixLists> PrefixLists { get; set; }
        public class ListTransitRouterPrefixListAssociationResponseBodyPrefixLists : TeaModel {
            /// <summary>
            /// <para>The ID of the next hop.</para>
            /// <remarks>
            /// <para>A value of <b>BlackHole</b> indicates that all the CIDR blocks in the prefix list are blackhole routes. Packets destined for the CIDR blocks are dropped.</para>
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
            /// <item><description><b>BlackHole</b>: All the CIDR blocks in the prefix list are blackhole routes. Packets destined for the CIDR blocks are dropped.</description></item>
            /// <item><description><b>VPC</b>: The next hop of the CIDR blocks in the prefix list is a VPC connection.</description></item>
            /// <item><description><b>VBR</b>: The next hop of the CIDR blocks in the prefix list is a VBR connection.</description></item>
            /// <item><description><b>TR</b>: The next hop of the CIDR blocks in the prefix list is an inter-region connection.</description></item>
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
            /// <para>The status of the prefix list. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Active</b>: The prefix list is effective.</description></item>
            /// <item><description><b>Updating</b>: The prefix list is being updated.</description></item>
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
        /// <para>The ID of the request.</para>
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
