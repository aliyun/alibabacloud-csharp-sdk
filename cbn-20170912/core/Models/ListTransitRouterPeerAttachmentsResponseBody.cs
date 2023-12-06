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
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If the **NextToken** parameter is empty, no next page exists.
        /// *   If **NextToken** was returned in the previous query, specify the value to obtain the next set of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The queried inter-region connections.
        /// </summary>
        [NameInMap("TransitRouterAttachments")]
        [Validation(Required=false)]
        public List<ListTransitRouterPeerAttachmentsResponseBodyTransitRouterAttachments> TransitRouterAttachments { get; set; }
        public class ListTransitRouterPeerAttachmentsResponseBodyTransitRouterAttachments : TeaModel {
            /// <summary>
            /// Indicates whether the local Enterprise Edition transit router automatically advertises routes of the inter-region connection to the peer transit router. Valid values:
            /// 
            /// *   **false** (default): no
            /// *   **true**: yes
            /// </summary>
            [NameInMap("AutoPublishRouteEnabled")]
            [Validation(Required=false)]
            public bool? AutoPublishRouteEnabled { get; set; }

            /// <summary>
            /// The maximum bandwidth value of the inter-region connection. Unit: Mbit/s.
            /// 
            /// *   This parameter specifies the maximum bandwidth value for the inter-region connection if you set **BandwidthType** to **BandwidthPackage**.
            /// *   This parameter specifies the bandwidth throttling threshold for the inter-region connection if you set **BandwidthType** to **DataTransfer**.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The bandwidth allocation method. Valid values:
            /// 
            /// **BandwidthPackage**: allocates bandwidth from a bandwidth plan.
            /// 
            /// **DataTransfer**: bills bandwidth based on the pay-by-data-transfer metering method.
            /// </summary>
            [NameInMap("BandwidthType")]
            [Validation(Required=false)]
            public string BandwidthType { get; set; }

            /// <summary>
            /// The ID of the bandwidth plan that is used to allocate bandwidth to the inter-region connection.
            /// </summary>
            [NameInMap("CenBandwidthPackageId")]
            [Validation(Required=false)]
            public string CenBandwidthPackageId { get; set; }

            /// <summary>
            /// The CEN instance ID.
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// The time when the inter-region connection was created.
            /// 
            /// The time follows the ISO8601 standard in the `YYYY-MM-DDThh:mmZ` format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("DefaultLinkType")]
            [Validation(Required=false)]
            public string DefaultLinkType { get; set; }

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
            /// The region ID of the peer transit router.
            /// </summary>
            [NameInMap("PeerTransitRouterRegionId")]
            [Validation(Required=false)]
            public string PeerTransitRouterRegionId { get; set; }

            /// <summary>
            /// The region ID of the Enterprise Edition transit router.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The type of the resource to which the transit router is connected. Valid values:
            /// 
            /// *   **VPC**: VPC
            /// *   **CCN**: Cloud Connect Network (CCN) instance
            /// *   **VBR**: virtual border router (VBR)
            /// *   **TR**: transit router
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The status of the inter-region connection. Valid values:
            /// 
            /// *   **Attached**: The inter-region connection is created.
            /// *   **Attaching**: The inter-region connection is being created on the transit router.
            /// *   **Detaching**: The inter-region connection is being deleted from the transit router.
            /// *   **Detached**: The inter-region connection is deleted from the transit router.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRouterPeerAttachmentsResponseBodyTransitRouterAttachmentsTags> Tags { get; set; }
            public class ListTransitRouterPeerAttachmentsResponseBodyTransitRouterAttachmentsTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The description of the inter-region connection.
            /// </summary>
            [NameInMap("TransitRouterAttachmentDescription")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentDescription { get; set; }

            /// <summary>
            /// The ID of the inter-region connection.
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// The name of the inter-region connection.
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
