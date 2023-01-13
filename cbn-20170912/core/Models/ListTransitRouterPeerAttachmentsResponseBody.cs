// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterPeerAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If the returned value of **NextToken** is empty, it indicates that no next query is to be sent.
        /// *   If the returned value of **NextToken** is not empty, the value indicates the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The list of cross-region connections.
        /// </summary>
        [NameInMap("TransitRouterAttachments")]
        [Validation(Required=false)]
        public List<ListTransitRouterPeerAttachmentsResponseBodyTransitRouterAttachments> TransitRouterAttachments { get; set; }
        public class ListTransitRouterPeerAttachmentsResponseBodyTransitRouterAttachments : TeaModel {
            /// <summary>
            /// Indicates whether the local Enterprise Edition transit router automatically advertises routes of the cross-region connection to the peer transit router. Valid values:
            /// 
            /// *   **false** (default): no
            /// *   **true**: yes
            /// </summary>
            [NameInMap("AutoPublishRouteEnabled")]
            [Validation(Required=false)]
            public bool? AutoPublishRouteEnabled { get; set; }

            /// <summary>
            /// The bandwidth value of the cross-region connection. Unit: Mbit/s.
            /// 
            /// *   If **BandwidthType** is set to **BandwidthPackage**, this parameter indicates the bandwidth that is available for the cross-region connection.
            /// *   If **BandwidthType** is set to **DataTransfer**, this parameter indicates the bandwidth limit of the cross-region connection.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The bandwidth allocation method. Valid values:
            /// 
            /// **BandwidthPackage**: allocates bandwidth from a bandwidth plan.
            /// 
            /// **DataTransfer**: uses pay-by-data-transfer bandwidth.
            /// </summary>
            [NameInMap("BandwidthType")]
            [Validation(Required=false)]
            public string BandwidthType { get; set; }

            /// <summary>
            /// The ID of the bandwidth plan that is used to allocate bandwidth to the cross-region connection.
            /// </summary>
            [NameInMap("CenBandwidthPackageId")]
            [Validation(Required=false)]
            public string CenBandwidthPackageId { get; set; }

            /// <summary>
            /// The time when the cross-region connection was created.
            /// 
            /// The time follows the ISO8601 standard in the `YYYY-MM-ddTHH:mmZ` format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The areas that are connected by the bandwidth plan.
            /// </summary>
            [NameInMap("GeographicSpanId")]
            [Validation(Required=false)]
            public string GeographicSpanId { get; set; }

            /// <summary>
            /// The ID of the peer transit router.
            /// </summary>
            [NameInMap("PeerTransitRouterId")]
            [Validation(Required=false)]
            public string PeerTransitRouterId { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the peer transit router belongs.
            /// </summary>
            [NameInMap("PeerTransitRouterOwnerId")]
            [Validation(Required=false)]
            public long? PeerTransitRouterOwnerId { get; set; }

            /// <summary>
            /// The ID of the region where the peer transit router is deployed.
            /// </summary>
            [NameInMap("PeerTransitRouterRegionId")]
            [Validation(Required=false)]
            public string PeerTransitRouterRegionId { get; set; }

            /// <summary>
            /// The ID of the region where the Enterprise Edition transit router is deployed.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The type of the resource to which the transit router is connected. Valid values:
            /// 
            /// *   **VPC**: virtual private cloud (VPC)
            /// *   **CCN**: Cloud Connect Network (CCN) instance
            /// *   **VBR**: virtual border router (VBR)
            /// *   **TR**: transit router
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The status of the cross-region connection. Valid values:
            /// 
            /// *   **Attached**: The local transit router is connected to the peer transit router.
            /// *   **Attaching**: The local transit router is connecting to the peer transit router.
            /// *   **Detaching**: The local transit router is disconnecting from the peer transit router.
            /// *   **Detached**: The local transit router is disconnected from the peer transit router.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The list of tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRouterPeerAttachmentsResponseBodyTransitRouterAttachmentsTags> Tags { get; set; }
            public class ListTransitRouterPeerAttachmentsResponseBodyTransitRouterAttachmentsTags : TeaModel {
                /// <summary>
                /// The key of tag.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The description of the cross-region connection.
            /// </summary>
            [NameInMap("TransitRouterAttachmentDescription")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentDescription { get; set; }

            /// <summary>
            /// The ID of the cross-region connection.
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// The name of the cross-region connection.
            /// </summary>
            [NameInMap("TransitRouterAttachmentName")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentName { get; set; }

            /// <summary>
            /// The ID of the Enterprise Edition transit router.
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

        }

    }

}
