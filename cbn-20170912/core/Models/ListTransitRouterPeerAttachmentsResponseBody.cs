// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterPeerAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the <b>NextToken</b> parameter is empty, no next page exists.</description></item>
        /// <item><description>If <b>NextToken</b> was returned in the previous query, specify the value to obtain the next set of results.</description></item>
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
        /// <para>A list of inter-region connections.</para>
        /// </summary>
        [NameInMap("TransitRouterAttachments")]
        [Validation(Required=false)]
        public List<ListTransitRouterPeerAttachmentsResponseBodyTransitRouterAttachments> TransitRouterAttachments { get; set; }
        public class ListTransitRouterPeerAttachmentsResponseBodyTransitRouterAttachments : TeaModel {
            /// <summary>
            /// <para>Indicates whether the local Enterprise Edition transit router automatically advertises routes of the cross-region connection to the peer transit router. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b> (default)</description></item>
            /// <item><description><b>true</b></description></item>
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
            /// <item><description>This parameter specifies the maximum bandwidth value for the inter-region connection if you set <b>BandwidthType</b> to <b>BandwidthPackage</b>.</description></item>
            /// <item><description>This parameter specifies the bandwidth throttling threshold for the inter-region connection if you set <b>BandwidthType</b> to <b>DataTransfer</b>.</description></item>
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
            /// <item><description><b>BandwidthPackage</b>: allocates bandwidth from a bandwidth plan.</description></item>
            /// <item><description><b>DataTransfer</b>: bandwidth is billed based on the pay-by-data-transfer metering method.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BandwidthPackage</para>
            /// </summary>
            [NameInMap("BandwidthType")]
            [Validation(Required=false)]
            public string BandwidthType { get; set; }

            /// <summary>
            /// <para>The ID of the bandwidth plan that is used to allocate bandwidth to the inter-region connection.</para>
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
            /// <para>The time follows the ISO8601 standard in the <c>YYYY-MM-DDThh:mmZ</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-16T02:50Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The default line type.</para>
            /// <list type="bullet">
            /// <item><description><b>Gold</b> (default)</description></item>
            /// <item><description><b>Platinum</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Gold</para>
            /// </summary>
            [NameInMap("DefaultLinkType")]
            [Validation(Required=false)]
            public string DefaultLinkType { get; set; }

            /// <summary>
            /// <para>The areas that are connected by the bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>china_china</para>
            /// </summary>
            [NameInMap("GeographicSpanId")]
            [Validation(Required=false)]
            public string GeographicSpanId { get; set; }

            /// <summary>
            /// <para>The ID of the peer transit router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tr-m5eq27g6bndum7e88****</para>
            /// </summary>
            [NameInMap("PeerTransitRouterId")]
            [Validation(Required=false)]
            public string PeerTransitRouterId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the peer transit router belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>253460731706911258</para>
            /// </summary>
            [NameInMap("PeerTransitRouterOwnerId")]
            [Validation(Required=false)]
            public long? PeerTransitRouterOwnerId { get; set; }

            /// <summary>
            /// <para>The region ID of the peer transit router.</para>
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
            /// <para>The type of the resource to which the transit router is connected. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VPC</b>: virtual private cloud (VPC)</description></item>
            /// <item><description><b>CCN</b>: Cloud Connect Network (CCN) instance</description></item>
            /// <item><description><b>VBR</b>: virtual border router (VBR)</description></item>
            /// <item><description><b>TR</b>: transit router</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TR</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The status of the inter-region connection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Attached</b></description></item>
            /// <item><description><b>Attaching</b></description></item>
            /// <item><description><b>Detaching</b></description></item>
            /// <item><description><b>Detached</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Attached</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>A list of tags.</para>
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
            /// <para>The ID of the inter-region connection.</para>
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
            /// <para>The ID of the Enterprise Edition transit router.</para>
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
