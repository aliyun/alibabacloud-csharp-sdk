// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class UpdateInstanceNetworkTypeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to change the network type from AnyTunnel to SingleTunnel. This parameter is invalid for new instances. For new instances, this parameter is set to null by default.
        /// 
        /// Valid values:
        /// 
        /// *   others/null
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   true
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("anyTunnelToSingleTunnel")]
        [Validation(Required=false)]
        public string AnyTunnelToSingleTunnel { get; set; }

        /// <summary>
        /// A list of network types that you want to enable. The list of enabled network types is randomly ordered. For example, the Internet, internal network, and VPCSingleTunnel network types are enabled. If you want to disable the Internet type, set this parameter to Intranet,VPCSingleTunnel.
        /// </summary>
        [NameInMap("networkTypes")]
        [Validation(Required=false)]
        public string NetworkTypes { get; set; }

        /// <summary>
        /// The vSwitch ID.
        /// </summary>
        [NameInMap("vSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the VPC to which the instance belongs.
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The owner ID of the VPC, which is the ID of the Alibaba Cloud account.
        /// </summary>
        [NameInMap("vpcOwnerId")]
        [Validation(Required=false)]
        public string VpcOwnerId { get; set; }

        /// <summary>
        /// The region ID of the VPC.
        /// </summary>
        [NameInMap("vpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

    }

}
