// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreatePhysicalConnectionSetupOrderRequest : TeaModel {
        /// <summary>
        /// The ID of the access point.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic payments. Valid values:
        /// 
        /// *   **false** (default): disables automatic payment.
        /// *   **true**
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The connectivity provider of the Express Connect circuit. Valid values:
        /// 
        /// *   **CT**: China Telecom
        /// *   **CU**: China Unicom
        /// *   **CM**: China Mobile
        /// *   **CO**: other connectivity providers in the Chinese mainland
        /// *   **Equinix**: Equinix
        /// *   **Other**: other connectivity providers outside the Chinese mainland
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LineOperator")]
        [Validation(Required=false)]
        public string LineOperator { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The port type of the Express Connect circuit. Valid values:
        /// 
        /// *   **100Base-T**: 100 Mbit/s copper Ethernet port
        /// *   **1000Base-T** (default): 1,000 Mbit/s copper Ethernet port
        /// *   **1000Base-LX**: 1,000 Mbit/s single-mode optical port (10 km)
        /// *   **10GBase-T**: 10,000 Mbit/s copper Ethernet port
        /// *   **10GBase-LR**: 10,000 Mbit/s single-mode optical port (10 km)
        /// *   **40GBase-LR**: 40,000 Mbit/s single-mode optical port
        /// *   **100GBase-LR**: 100,000 Mbit/s single-mode optical port
        /// 
        /// >  Whether 40GBase-LR and 100GBase-LR ports can be created depends on resource supplies. For more information, contact your account manager.
        /// </summary>
        [NameInMap("PortType")]
        [Validation(Required=false)]
        public string PortType { get; set; }

        /// <summary>
        /// The ID of the redundant physical connection. The redundant physical connection must be in the **Allocated**, **Confirmed**, or **Enabled** state.
        /// </summary>
        [NameInMap("RedundantPhysicalConnectionId")]
        [Validation(Required=false)]
        public string RedundantPhysicalConnectionId { get; set; }

        /// <summary>
        /// The region ID of the Express Connect circuit.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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
