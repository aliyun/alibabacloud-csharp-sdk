// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterPeerAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that determines the start point of the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no subsequent query is to be sent.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AA97AFA3-8E48-4BD7-9F3E-A9F6176018A0</para>
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

        /// <summary>
        /// <para>The list of inter-region connections.</para>
        /// </summary>
        [NameInMap("TransitRouterAttachments")]
        [Validation(Required=false)]
        public List<ListTransitRouterPeerAttachmentsResponseBodyTransitRouterAttachments> TransitRouterAttachments { get; set; }
        public class ListTransitRouterPeerAttachmentsResponseBodyTransitRouterAttachments : TeaModel {
            /// <summary>
            /// <para>Indicates whether the Enterprise Edition transit router instance automatically advertises routes of the inter-region connection to the peer region.</para>
            /// <list type="bullet">
            /// <item><description><b>false</b> (default): No.</description></item>
            /// <item><description><b>true</b>: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoPublishRouteEnabled")]
            [Validation(Required=false)]
            public bool? AutoPublishRouteEnabled { get; set; }

            /// <summary>
            /// <para>The bandwidth value of the inter-region connection. Unit: Mbit/s.</para>
            /// <list type="bullet">
            /// <item><description>If <b>BandwidthType</b> is set to <b>BandwidthPackage</b>, this parameter indicates the bandwidth that the inter-region connection can use.</description></item>
            /// <item><description>If <b>BandwidthType</b> is set to <b>DataTransfer</b>, this parameter indicates the bandwidth limit of the inter-region connection.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The bandwidth allocation method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>BandwidthPackage</b>: Bandwidth is allocated from a bandwidth package.</para>
            /// </description></item>
            /// <item><description><para><b>DataTransfer</b>: No bandwidth is allocated to the inter-region connection. Data transfer is pay-as-you-go.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BandwidthPackage</para>
            /// </summary>
            [NameInMap("BandwidthType")]
            [Validation(Required=false)]
            public string BandwidthType { get; set; }

            /// <summary>
            /// <para>The ID of the bandwidth package associated with the inter-region connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cenbwp-3xrxupouolw5ou****</para>
            /// </summary>
            [NameInMap("CenBandwidthPackageId")]
            [Validation(Required=false)]
            public string CenBandwidthPackageId { get; set; }

            /// <summary>
            /// <para>The CEN instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-j3jzhw1zpau2km****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The time when the inter-region connection was created.</para>
            /// <para>The time is displayed in the ISO 8601 standard in UTC. Format: <c>YYYY-MM-DDThh:mmZ</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-16T02:50Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The default link type.</para>
            /// <list type="bullet">
            /// <item><description><b>Gold</b> (default): gold.</description></item>
            /// <item><description><b>Platinum</b>: Platinum.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Gold</para>
            /// </summary>
            [NameInMap("DefaultLinkType")]
            [Validation(Required=false)]
            public string DefaultLinkType { get; set; }

            /// <summary>
            /// <para>The connected areas of the bandwidth package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>china_china</para>
            /// </summary>
            [NameInMap("GeographicSpanId")]
            [Validation(Required=false)]
            public string GeographicSpanId { get; set; }

            /// <summary>
            /// <para>The instance ID of the peer transit routing router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-m5eq27g6bndum7e88****</para>
            /// </summary>
            [NameInMap("PeerTransitRouterId")]
            [Validation(Required=false)]
            public string PeerTransitRouterId { get; set; }

            /// <summary>
            /// <para>The ID of the account to which the peer transit router instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>253460731706911258</para>
            /// </summary>
            [NameInMap("PeerTransitRouterOwnerId")]
            [Validation(Required=false)]
            public long? PeerTransitRouterOwnerId { get; set; }

            /// <summary>
            /// <para>The region ID of the peer transit router instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("PeerTransitRouterRegionId")]
            [Validation(Required=false)]
            public string PeerTransitRouterRegionId { get; set; }

            /// <summary>
            /// <para>The region ID of the Enterprise Edition transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The type of resource associated with the connection.</para>
            /// <list type="bullet">
            /// <item><description><b>VPC</b>: virtual private cloud (VPC) instance.</description></item>
            /// <item><description><b>CCN</b>: Cloud Connect Network instance.</description></item>
            /// <item><description><b>VBR</b>: virtual border router (VBR) instance.</description></item>
            /// <item><description><b>TR</b>: transit router instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TR</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The status of the inter-region connection.</para>
            /// <list type="bullet">
            /// <item><description><b>Attached</b>: attached.</description></item>
            /// <item><description><b>Attaching</b>: being attached.</description></item>
            /// <item><description><b>Detaching</b>: being detached.</description></item>
            /// <item><description><b>Detached</b>: detached.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Attached</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag list.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRouterPeerAttachmentsResponseBodyTransitRouterAttachmentsTags> Tags { get; set; }
            public class ListTransitRouterPeerAttachmentsResponseBodyTransitRouterAttachmentsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag_A1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The description of the inter-region connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdesc</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentDescription")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentDescription { get; set; }

            /// <summary>
            /// <para>The inter-region connection ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-attach-5u4qbayfv2io5v****</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// <para>The name of the inter-region connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TransitRouterAttachmentName")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentName { get; set; }

            /// <summary>
            /// <para>The Enterprise Edition transit router instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-bp1su1ytdxtataupl****</para>
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

    }

}
