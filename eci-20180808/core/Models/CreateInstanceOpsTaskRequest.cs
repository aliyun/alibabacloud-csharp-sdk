// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class CreateInstanceOpsTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the container group.
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// The type of the O&M task. Valid values:
        /// 
        /// *   coredump
        /// *   tcpdump
        /// </summary>
        [NameInMap("OpsType")]
        [Validation(Required=false)]
        public string OpsType { get; set; }

        /// <summary>
        /// The value of the O\&M task. You can set this parameter based on the value of OpsType.
        /// 
        /// *   If OpsType is set to coredump, the valid values of OpsValue are:
        /// 
        ///     *   enable: enables coredump.
        ///     *   disable: disables coredump.
        /// 
        /// *   If OpsType is set to tcpdump, the value of OpsValue is a JSON-formatted parameter string. Example: `{"Enable":true, "IfDeviceName":"eth0"}`. The value may contain the following parameters:
        /// 
        ///     *   Enable: specifies whether to enable tcpdump. You must specify this parameter. Valid values: true and false.
        ///     *   Protocol: the network protocol. Valid values: tcp, udp, and icmpv4.
        ///     *   SourceIp: the source IP address.
        ///     *   SourceCidr: the source CIDR block. If you specify both an IP address and a CIDR block, the IP address is ignored if the CIDR block is valid.
        ///     *   SourcePort: the source port. Valid values: 1 to 65535.
        ///     *   DestIp: the destination IP address.
        ///     *   DestCidr: the destination CIDR block. If you specify both an IP address and a CIDR block, the IP address is ignored if the CIDR block is valid.
        ///     *   DestPort: the destination port. Valid values: 1 to 65535.
        ///     *   IfDeviceName: the destination network interface controller. Default value: eth0.
        ///     *   Snaplen: the length to be captured. Default value: 65535. Unit: bytes.
        ///     *   Duration: the captured period. Unit: seconds.
        ///     *   PacketNum: the number of packets to be captured.
        ///     *   FileSize: the size of the destination files on packets. Unit: bytes. Maximum value: 1073741824. 1073741824 bytes is equal to 1 GB.
        /// </summary>
        [NameInMap("OpsValue")]
        [Validation(Required=false)]
        public string OpsValue { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the O&M task.
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

    }

}
