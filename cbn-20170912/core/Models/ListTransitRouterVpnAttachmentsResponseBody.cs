// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterVpnAttachmentsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the next query. Valid values:
        /// 
        /// *   If **NextToken** is not returned, it indicates that no additional results exist.
        /// *   If **NextToken** was returned in the previous query, specify the value to obtain the next set of results.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The information about the VPN attachment.
        /// </summary>
        [NameInMap("TransitRouterAttachments")]
        [Validation(Required=false)]
        public List<ListTransitRouterVpnAttachmentsResponseBodyTransitRouterAttachments> TransitRouterAttachments { get; set; }
        public class ListTransitRouterVpnAttachmentsResponseBodyTransitRouterAttachments : TeaModel {
            /// <summary>
            /// Specifies whether to allow the transit router to automatically advertise routes to the IPsec-VPN connection. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("AutoPublishRouteEnabled")]
            [Validation(Required=false)]
            public bool? AutoPublishRouteEnabled { get; set; }

            /// <summary>
            /// The ID of the CEN instance.
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// The billing method of the VPN attachment.
            /// 
            /// The value is POSTPAY, which is the default value and specifies the pay-as-you-go billing method.
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The time when the VPN attachment was created.
            /// 
            /// The time follows the ISO8601 standard in the YYYY-MM-DDThh:mmZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The type of resource to which the transit router is connected.
            /// 
            /// Valid value: **VPN**, which indicates that an IPsec-VPN connection is attached to the transit router.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// The status of the VPN attachment. Valid values:
            /// 
            /// *   **Attached**: The VPC attachment has been created on the transit router.
            /// *   **Attaching**: The VPN attachment is being created on the transit router.
            /// *   **Detaching**: The VPN attachment is being deleted from the transit router.
            /// *   **Detached**: The VPN attachment is deleted from the transit router.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// A list of tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRouterVpnAttachmentsResponseBodyTransitRouterAttachmentsTags> Tags { get; set; }
            public class ListTransitRouterVpnAttachmentsResponseBodyTransitRouterAttachmentsTags : TeaModel {
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
            /// The description of the VPN attachment.
            /// </summary>
            [NameInMap("TransitRouterAttachmentDescription")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentDescription { get; set; }

            /// <summary>
            /// The ID of the VPN attachment.
            /// </summary>
            [NameInMap("TransitRouterAttachmentId")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentId { get; set; }

            /// <summary>
            /// The name of the VPN attachment.
            /// </summary>
            [NameInMap("TransitRouterAttachmentName")]
            [Validation(Required=false)]
            public string TransitRouterAttachmentName { get; set; }

            /// <summary>
            /// The ID of the transit router.
            /// </summary>
            [NameInMap("TransitRouterId")]
            [Validation(Required=false)]
            public string TransitRouterId { get; set; }

            /// <summary>
            /// The ID of the IPsec-VPN connection.
            /// </summary>
            [NameInMap("VpnId")]
            [Validation(Required=false)]
            public string VpnId { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the IPsec-VPN connection belongs.
            /// </summary>
            [NameInMap("VpnOwnerId")]
            [Validation(Required=false)]
            public long? VpnOwnerId { get; set; }

            /// <summary>
            /// The ID of the region to which the IPsec-VPN connection belongs.
            /// 
            /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
            /// </summary>
            [NameInMap("VpnRegionId")]
            [Validation(Required=false)]
            public string VpnRegionId { get; set; }

            /// <summary>
            /// The zones where the VPN attachment is deployed.
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<ListTransitRouterVpnAttachmentsResponseBodyTransitRouterAttachmentsZones> Zones { get; set; }
            public class ListTransitRouterVpnAttachmentsResponseBodyTransitRouterAttachmentsZones : TeaModel {
                /// <summary>
                /// The ID of the zone.
                /// 
                /// You can call the [DescribeZones](~~36064~~) operation to query the most recent zone list.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
