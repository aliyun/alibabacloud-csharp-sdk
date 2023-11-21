// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreatePhysicalConnectionRequest : TeaModel {
        /// <summary>
        /// The access point ID of the Express Connect circuit.
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// The circuit code of the Express Connect circuit. The circuit code is provided by the connectivity provider.
        /// </summary>
        [NameInMap("CircuitCode")]
        [Validation(Required=false)]
        public string CircuitCode { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the Express Connect circuit.
        /// 
        /// The description must be 2 to 256 characters in length. The description must start with a letter but cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The advanced features of the device.
        /// </summary>
        [NameInMap("DeviceAdvancedCapacity")]
        [Validation(Required=false)]
        public List<string> DeviceAdvancedCapacity { get; set; }

        /// <summary>
        /// The connectivity provider of the Express Connect circuit. Valid values:
        /// 
        /// *   **CT**: China Telecom.
        /// *   **CU**: China Unicom.
        /// *   **CM**: China Mobile.
        /// *   **CO**: other connectivity providers in the Chinese mainland.
        /// *   **Equinix**: Equinix.
        /// *   **Other**: other connectivity providers outside the Chinese mainland.
        /// </summary>
        [NameInMap("LineOperator")]
        [Validation(Required=false)]
        public string LineOperator { get; set; }

        /// <summary>
        /// The name of the Express Connect circuit.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter but cannot start with `http://` or `https://`.
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
        /// The port type. Valid values:
        /// 
        /// *   **100Base-T**: 100 Mbit/s copper Ethernet port
        /// *   **1000Base-T**: 1,000 Mbit/s copper Ethernet port
        /// *   **1000Base-LX**: 1,000 Mbit/s single-mode optical port (10 km)
        /// *   **10GBase-T**: 10,000 Mbit/s copper Ethernet port
        /// *   **10GBase-LR**: 10,000 Mbit/s single-mode optical port (10 km)
        /// *   **40GBase-LR**: 40,000 Mbit/s single-mode optical port
        /// *   **100GBase-LR**: 100,000 Mbit/s single-mode optical port
        /// 
        /// >  To use ports 40GBase-LR and 100GBase-LR, you must first contact your account manager.
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

        /// <summary>
        /// The ID of the resource group to which the Express Connect circuit belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The tag list.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePhysicalConnectionRequestTag> Tag { get; set; }
        public class CreatePhysicalConnectionRequestTag : TeaModel {
            /// <summary>
            /// The key of tag to add to the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.
            /// 
            /// The tag key can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `aliyun` or `acs:`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value to add to the resource. You can specify up to 20 tag values The tag value can be an empty string.
            /// 
            /// The tag key can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `aliyun` or `acs:`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of Express Connect circuit. Default value: **VPC**.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The maximum bandwidth of the hosted connection. Unit: Mbit/s.
        /// 
        /// Valid values: **50**, **100**, **200**, **300**, **400**, **500**, **1000**, **2000**, **4000**, **5000**, **8000**, and **10000**.
        /// </summary>
        [NameInMap("bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

    }

}
