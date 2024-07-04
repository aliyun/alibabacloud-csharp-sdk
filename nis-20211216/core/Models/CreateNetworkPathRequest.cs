// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class CreateNetworkPathRequest : TeaModel {
        /// <summary>
        /// The description of the network path.
        /// </summary>
        [NameInMap("NetworkPathDescription")]
        [Validation(Required=false)]
        public string NetworkPathDescription { get; set; }

        /// <summary>
        /// The name of the network path.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetworkPathName")]
        [Validation(Required=false)]
        public string NetworkPathName { get; set; }

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
        /// The region ID of the network path that you want to create.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

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
        /// The tags to add to the resource.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateNetworkPathRequestTag> Tag { get; set; }
        public class CreateNetworkPathRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the resource. The tag key can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// 
            /// You can add up to 20 tags in each call.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the resource. You can specify up to 20 tag values. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag value cannot start with `aliyun` or `acs:`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

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
