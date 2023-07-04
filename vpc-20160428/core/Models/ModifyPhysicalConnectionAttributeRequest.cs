// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyPhysicalConnectionAttributeRequest : TeaModel {
        /// <summary>
        /// The circuit code of the Express Connect circuit. The circuit code is provided by the connectivity provider.
        /// </summary>
        [NameInMap("CircuitCode")]
        [Validation(Required=false)]
        public string CircuitCode { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate a token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the Express Connect circuit.
        /// 
        /// The description must be 2 to 256 characters in length. It must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The connectivity provider of the Express Connect circuit. Valid values:
        /// 
        /// *   **CT**: China Telecom
        /// *   **CU**: China Unicom
        /// *   **CM**: China Mobile
        /// *   **CO**: other connectivity providers in the Chinese mainland
        /// *   **Equinix**: Equinix
        /// *   **Other**: other connectivity providers outside the Chinese Mainland
        /// </summary>
        [NameInMap("LineOperator")]
        [Validation(Required=false)]
        public string LineOperator { get; set; }

        /// <summary>
        /// The name of the Express Connect circuit.
        /// 
        /// The name must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The geographical location of the data center.
        /// </summary>
        [NameInMap("PeerLocation")]
        [Validation(Required=false)]
        public string PeerLocation { get; set; }

        /// <summary>
        /// The ID of the Express Connect circuit.
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// The port type of the Express Connect circuit. Valid values:
        /// 
        /// *   **100Base-T**: 100 Mbit/s copper Ethernet port
        /// *   **1000Base-T** (default): 1,000 Mbit/s copper Ethernet port
        /// *   **1000Base-LX**: 1,000 Mbit/s single-mode optical port (10 kilometers)
        /// *   **10GBase-T**: 10,000 Mbit/s copper Ethernet port
        /// *   **10GBase-LR**: 10,000 Mbit/s single-mode optical port (10 kilometers)
        /// *   **40GBase-LR**: 40,000 Mbit/s single-mode optical port
        /// *   **100GBase-LR**: 100,000 Mbit/s single-mode optical port
        /// 
        /// >  If you want to use the 40GBase-LR or 100GBase-LR port for an Express Connect circuit, you must first contact your account manager to obtain information about resource supplies.
        /// </summary>
        [NameInMap("PortType")]
        [Validation(Required=false)]
        public string PortType { get; set; }

        /// <summary>
        /// The ID of the redundant Express Connect circuit. The redundant Express Connect circuit must be in the **Allocated**, **Confirmed**, or **Enabled** state.
        /// </summary>
        [NameInMap("RedundantPhysicalConnectionId")]
        [Validation(Required=false)]
        public string RedundantPhysicalConnectionId { get; set; }

        /// <summary>
        /// The region ID of the Express Connect circuit.
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
        /// The bandwidth value for the connection over the Express Connect circuit. Unit: Mbit/s. Valid values: 2 to 10240.
        /// </summary>
        [NameInMap("bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

    }

}
