/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class CreateAndAnalyzeNetworkPathRequest : TeaModel {
        /// <summary>
        /// The protocol type. Valid values:
        /// 
        /// *   **tcp**: Transmission Control Protocol (TCP)
        /// *   **udp**: User Datagram Protocol (UDP)
        /// *   **icmp**: Internet Control Message Protocol (ICMP)
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// The ID of the region for which you want to initiate a task for analyzing network reachability.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the source resource.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// The source IP address.
        /// </summary>
        [NameInMap("SourceIpAddress")]
        [Validation(Required=false)]
        public string SourceIpAddress { get; set; }

        /// <summary>
        /// The source port.
        /// </summary>
        [NameInMap("SourcePort")]
        [Validation(Required=false)]
        public int? SourcePort { get; set; }

        /// <summary>
        /// The type of the source resource. Valid values:
        /// 
        /// *   **ecs**: the Elastic Compute Service (ECS) instance
        /// *   **internetIp**: the public IP address
        /// *   **vsw**: the vSwitch
        /// *   **vpn**: the VPN gateway
        /// *   **vbr**: the virtual border router (VBR)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// The ID of the destination resource.
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// The destination IP address.
        /// </summary>
        [NameInMap("TargetIpAddress")]
        [Validation(Required=false)]
        public string TargetIpAddress { get; set; }

        /// <summary>
        /// The destination port.
        /// </summary>
        [NameInMap("TargetPort")]
        [Validation(Required=false)]
        public int? TargetPort { get; set; }

        /// <summary>
        /// The type of the destination resource. Valid values:
        /// 
        /// *   **ecs**: the ECS instance
        /// *   **internetIp**: the public IP address
        /// *   **vsw**: the vSwitch
        /// *   **vpn**: the VPN gateway
        /// *   **vbr**: the VBR
        /// *   **clb**: the Classic Load Balancer (CLB) instance
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
