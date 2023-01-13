// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class UpdateTransitRouterVpcAttachmentZonesRequest : TeaModel {
        /// <summary>
        /// The zone mappings that you want to add to the VPC connection.
        /// </summary>
        [NameInMap("AddZoneMappings")]
        [Validation(Required=false)]
        public List<UpdateTransitRouterVpcAttachmentZonesRequestAddZoneMappings> AddZoneMappings { get; set; }
        public class UpdateTransitRouterVpcAttachmentZonesRequestAddZoneMappings : TeaModel {
            /// <summary>
            /// The ID of the vSwitch that you want to add to the VPC connection.
            /// 
            /// You can specify at most 10 vSwitches in each call.
            /// 
            /// *   If the VPC connection belongs to the current Alibaba Cloud account, you can call the [DescribeVSwitches](~~35748~~) operation to query the IDs of the vSwitches zones of the VPC.
            /// *   If the VPC connection belongs to another Alibaba Cloud account, you can call the [ListGrantVSwitchesToCen](~~427599~~) operation to query the IDs of the vSwitches zones of the VPC.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The ID of the zone where the vSwitch that you want to add to the VPC connection is deployed.
            /// 
            /// You can specify at most 10 vSwitches in each call.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. ClientToken can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, ClientToken is set to the value of RequestId. The value of RequestId for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether only to check the request. Valid values:
        /// 
        /// *   **true**: prechecks the request but does not modify the zones or vSwitches of the VPC connection. The system checks the required parameters, request syntax, and limits. If the request fails the check, an error message is returned. If the request passes the check, the `DryRunOperation` error code is returned.
        /// *   **false** (default): sends the request. If the request passes the precheck, the zones and vSwitches of the VPC connection are modified.
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
        /// The zone mappings that you want to remove from the VPC connection.
        /// </summary>
        [NameInMap("RemoveZoneMappings")]
        [Validation(Required=false)]
        public List<UpdateTransitRouterVpcAttachmentZonesRequestRemoveZoneMappings> RemoveZoneMappings { get; set; }
        public class UpdateTransitRouterVpcAttachmentZonesRequestRemoveZoneMappings : TeaModel {
            /// <summary>
            /// The ID of the vSwitch that you want to remove from the VPC connection.
            /// 
            /// You can remove at most 10 vSwitches from a VPC in each call.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The ID of the zone where the vSwitch that you want to remove from the VPC connection is deployed.
            /// 
            /// You can remove at most 10 vSwitches from a VPC in each call.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the VPC connection.
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

    }

}
