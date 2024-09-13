// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateForwardEntryRequest : TeaModel {
        /// <summary>
        /// The elastic IP address (EIP) that is used to access the Internet.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExternalIp")]
        [Validation(Required=false)]
        public string ExternalIp { get; set; }

        /// <summary>
        /// The external port or port range that is used for port forwarding.
        /// 
        /// *   Valid values: 1 to 65535.
        /// *   To specify a port range, separate the first port and the last port with a forward slash (/), such as 10/20.
        /// *   If you set ExternalPort to a port range, you must also set InternalPort to a port range. The number of ports in the port ranges must be the same. For example, if you set ExternalPort to 10/20, you can set InternalPort to 80/90.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExternalPort")]
        [Validation(Required=false)]
        public string ExternalPort { get; set; }

        /// <summary>
        /// The name of the DNAT entry. The name must be 2 to 128 characters in length. The name cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("ForwardEntryName")]
        [Validation(Required=false)]
        public string ForwardEntryName { get; set; }

        /// <summary>
        /// The probe port. The port must be within the internal port range. By default, this parameter is left empty.
        /// </summary>
        [NameInMap("HealthCheckPort")]
        [Validation(Required=false)]
        public int? HealthCheckPort { get; set; }

        /// <summary>
        /// The private IP address of the instance that uses the DNAT entry for Internet communication.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InternalIp")]
        [Validation(Required=false)]
        public string InternalIp { get; set; }

        /// <summary>
        /// The internal port or port range that is used for port forwarding.
        /// 
        /// *   Valid values: 1 to 65535.
        /// *   To specify a port range, separate the first port and the last port with a forward slash (/), such as 10/20.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InternalPort")]
        [Validation(Required=false)]
        public string InternalPort { get; set; }

        /// <summary>
        /// The protocol. Valid values:
        /// 
        /// *   **TCP**: forwards TCP packets.
        /// *   **UDP**: forwards UDP packets.
        /// *   **Any** (default): forwards all packets.
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// The ID of the Network Address Translation (NAT) gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// The secondary EIP that is used to access the Internet. You need to select a secondary EIP that is bound to NAT. After the DNAT entry is created, the secondary EIP takes effect.
        /// </summary>
        [NameInMap("StandbyExternalIp")]
        [Validation(Required=false)]
        public string StandbyExternalIp { get; set; }

    }

}
