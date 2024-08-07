// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class UpdateTransitRouterVpcAttachmentZonesRequest : TeaModel {
        /// <summary>
        /// The zones and vSwitches that you want to add to the VPC connection.
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
            /// *   If the VPC connection belongs to the current Alibaba Cloud account, you can call the [DescribeVSwitches](https://help.aliyun.com/document_detail/35748.html) operation to query the IDs of the vSwitches and zones of the VPC.
            /// *   If the VPC connection belongs to another Alibaba Cloud account, you can call the [ListGrantVSwitchesToCen](https://help.aliyun.com/document_detail/427599.html) operation to query the IDs of the vSwitches and zones of the VPC.
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
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, ClientToken is set to the value of RequestId. The value of RequestId for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   **true**: performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and sends the request.
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
        /// The zones and vSwitches that you want to remove from the VPC connection.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

    }

}
