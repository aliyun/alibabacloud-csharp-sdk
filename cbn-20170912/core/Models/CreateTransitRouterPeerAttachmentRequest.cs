// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterPeerAttachmentRequest : TeaModel {
        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("AutoPublishRouteEnabled")]
        [Validation(Required=false)]
        public bool? AutoPublishRouteEnabled { get; set; }

        /// <summary>
        /// The tag keys of the resources. 
        /// 
        /// The tag keys cannot be an empty string. The tag keys can be up to 64 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.  
        /// 
        /// You can specify at most 20 tag keys.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("BandwidthType")]
        [Validation(Required=false)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// The tag values of the resources. 
        /// 
        /// The tag values can be 0 to 128 characters in length, and cannot start with `aliyun` or `acs:`. It cannot contain `http://` or `https://`.  
        /// 
        /// Each tag key has a unique tag value. You can specify at most 20 tag values in each call.
        /// </summary>
        [NameInMap("CenBandwidthPackageId")]
        [Validation(Required=false)]
        public string CenBandwidthPackageId { get; set; }

        /// <summary>
        /// The ID of the peer transit router.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The description of the inter-region connection.
        /// 
        /// The description must be 2 to 256 characters in length. The description must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the inter-region connection.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Specifies whether to check the request but not perform the operation. The system checks the permissions and the status of the specified instances. Valid values:
        /// 
        /// *   **false** (default): checks the request. If the request passes the check, the inter-region connection is created.
        /// *   **true**: checks the request but does not perform the operation. The inter-region connection is not created after the request passes the check. If you use this value, the system checks the required parameters and the request syntax. If the request fails to pass the precheck, an error message is returned. If the request passes the check, the system returns the ID of the request.
        /// </summary>
        [NameInMap("PeerTransitRouterId")]
        [Validation(Required=false)]
        public string PeerTransitRouterId { get; set; }

        /// <summary>
        /// The method that is used to allocate bandwidth to the inter-region connection. Valid values:
        /// 
        /// **BandwidthPackage**: allocates bandwidth from a bandwidth plan.
        /// 
        /// **DataTransfer**: uses pay-by-data-transfer bandwidth.
        /// </summary>
        [NameInMap("PeerTransitRouterRegionId")]
        [Validation(Required=false)]
        public string PeerTransitRouterRegionId { get; set; }

        /// <summary>
        /// Specifies whether to enable the local Enterprise Edition transit router to automatically advertise the routes of the inter-region connection to the peer transit router. Valid values:
        /// 
        /// *   **false** (default): no.
        /// *   **true**: yes.
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
        /// 614519
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTransitRouterPeerAttachmentRequestTag> Tag { get; set; }
        public class CreateTransitRouterPeerAttachmentRequestTag : TeaModel {
            /// <summary>
            /// master
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// ## Background information
            /// 
            /// By default, 1 Kbit/s of bandwidth is provided for inter-region communication between transit routers. This allows you to test the connectivity of inter-region IPv4 networks. To allow services that are deployed in different regions to communicate with each other, you must create an inter-region connection and allocate bandwidth resources to the connection.  
            /// 
            /// Enterprise Edition transit routers allow you to allocate bandwidth resources to inter-region connections by using the following methods: 
            /// 
            /// - **Allocate bandwidth resources from a bandwidth plan**:  You must purchase a bandwidth plan, and then allocate bandwidth resources from the bandwidth plan to inter-region connections. For more information, see [CreateCenBandwidthPackage](https://www.alibabacloud.com/help/en/cloud-enterprise-network/latest/createcenbandwidthpackage).
            /// 
            /// - **Use pay-by-data-transfer bandwidth resources**:  You can set a maximum bandwidth value for an inter-region connection. Then, you are charged for the amount of data transfer over the connection. For more information, see [Cross-region data transfers](https://www.alibabacloud.com/help/en/cloud-data-transmission/latest/cross-region-data-transfers).
            /// 
            /// 
            /// ## Usage notes
            /// 
            /// **CreateTransitRouterPeerAttachment** is an asynchronous operation. After you send a request, the system returns the inter-region connection ID but the operation is still being performed in the system background. You can call **ListTransitRouterPeerAttachments** to query the status of an inter-region connection.  
            /// 
            /// - If an inter-region connection is in the **Attaching** state, the inter-region connection is being created. You can query the inter-region connection but cannot perform other regions.
            /// - If an inter-region connection is in the **Attached** state, the inter-region connection is created.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the bandwidth plan that is used to allocate bandwidth to the inter-region connection.
        /// 
        /// >  If you set **BandwidthType** to **DataTransfer**, you do not need to set this parameter.
        /// </summary>
        [NameInMap("TransitRouterAttachmentDescription")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentDescription { get; set; }

        /// <summary>
        /// The bandwidth value of the inter-region connection. Unit: Mbit/s.
        /// 
        /// *   If you set **BandwidthType** to **BandwidthPackage**, this parameter specifies the bandwidth that is available for the inter-region connection.
        /// 
        /// <!---->
        /// 
        /// *   If you set **BandwidthType** to **DataTransfer**, this parameter specifies the bandwidth limit of the inter-region connection.
        /// </summary>
        [NameInMap("TransitRouterAttachmentName")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentName { get; set; }

        /// <summary>
        /// The ID of the region where the peer transit router is deployed.
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
