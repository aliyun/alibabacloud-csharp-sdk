// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouterPeerAttachmentRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the local Enterprise Edition transit router to automatically advertise the routes of the inter-region connection to the peer transit router. Valid values:
        /// 
        /// *   **false** (default): no.
        /// *   **true**: yes.
        /// </summary>
        [NameInMap("AutoPublishRouteEnabled")]
        [Validation(Required=false)]
        public bool? AutoPublishRouteEnabled { get; set; }

        /// <summary>
        /// The bandwidth value of the inter-region connection. Unit: Mbit/s.
        /// 
        /// *   If you set **BandwidthType** to **BandwidthPackage**, this parameter specifies the bandwidth that is available for the inter-region connection.
        /// 
        /// <!---->
        /// 
        /// *   If you set **BandwidthType** to **DataTransfer**, this parameter specifies the bandwidth limit of the inter-region connection.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The method that is used to allocate bandwidth to the inter-region connection. Valid values:
        /// 
        /// **BandwidthPackage**: allocates bandwidth from a bandwidth plan.
        /// 
        /// **DataTransfer**: uses pay-by-data-transfer bandwidth.
        /// </summary>
        [NameInMap("BandwidthType")]
        [Validation(Required=false)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// The ID of the bandwidth plan that is used to allocate bandwidth to the inter-region connection.
        /// 
        /// >  If you set **BandwidthType** to **DataTransfer**, you do not need to set this parameter.
        /// </summary>
        [NameInMap("CenBandwidthPackageId")]
        [Validation(Required=false)]
        public string CenBandwidthPackageId { get; set; }

        /// <summary>
        /// The ID of the Cloud Enterprise Network (CEN) instance.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. ClientToken can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system automatically uses **RequestId** as **ClientToken**. The value of **RequestId** of each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to check the request but not perform the operation. The system checks the permissions and the status of the specified instances. Valid values:
        /// 
        /// *   **false** (default): checks the request. If the request passes the check, the inter-region connection is created.
        /// *   **true**: checks the request but does not perform the operation. The inter-region connection is not created after the request passes the check. If you use this value, the system checks the required parameters and the request syntax. If the request fails to pass the precheck, an error message is returned. If the request passes the check, the system returns the ID of the request.
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
        /// The ID of the peer transit router.
        /// </summary>
        [NameInMap("PeerTransitRouterId")]
        [Validation(Required=false)]
        public string PeerTransitRouterId { get; set; }

        /// <summary>
        /// The ID of the region where the peer transit router is deployed.
        /// </summary>
        [NameInMap("PeerTransitRouterRegionId")]
        [Validation(Required=false)]
        public string PeerTransitRouterRegionId { get; set; }

        /// <summary>
        /// The ID of the region where the local Enterprise Edition transit router is deployed.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
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
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateTransitRouterPeerAttachmentRequestTag> Tag { get; set; }
        public class CreateTransitRouterPeerAttachmentRequestTag : TeaModel {
            /// <summary>
            /// The tag keys of the resources. 
            /// 
            /// The tag keys cannot be an empty string. The tag keys can be up to 64 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.  
            /// 
            /// You can specify at most 20 tag keys.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag values of the resources. 
            /// 
            /// The tag values can be 0 to 128 characters in length, and cannot start with `aliyun` or `acs:`. It cannot contain `http://` or `https://`.  
            /// 
            /// Each tag key has a unique tag value. You can specify at most 20 tag values in each call.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The description of the inter-region connection.
        /// 
        /// The description must be 2 to 256 characters in length. The description must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("TransitRouterAttachmentDescription")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentDescription { get; set; }

        /// <summary>
        /// The name of the inter-region connection.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("TransitRouterAttachmentName")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentName { get; set; }

        /// <summary>
        /// The ID of the local Enterprise Edition transit router.
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
