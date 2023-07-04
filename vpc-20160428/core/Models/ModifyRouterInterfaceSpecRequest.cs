// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyRouterInterfaceSpecRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system automatically uses **RequestId** as **ClientToken**. **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the router interface is deployed.
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
        /// The ID of the router interface.
        /// </summary>
        [NameInMap("RouterInterfaceId")]
        [Validation(Required=false)]
        public string RouterInterfaceId { get; set; }

        /// <summary>
        /// The specification of the router interface. Valid specifications and bandwidth values:
        /// 
        /// *   **Mini.2**: 2 Mbit/s
        /// *   **Mini.5**: 5 Mbit/s
        /// *   **Small.1**: 10 Mbit/s
        /// *   **Small.2**: 20 Mbit/s
        /// *   **Small.5**: 50 Mbit/s
        /// *   **Middle.1**: 100 Mbit/s
        /// *   **Middle.2**: 200 Mbit/s
        /// *   **Middle.5**: 500 Mbit/s
        /// *   **Large.1**: 1,000 Mbit/s
        /// *   **Large.2**: 2,000 Mbit/s
        /// *   **Large.5**: 5,000 Mbit/s
        /// *   **Xlarge.1**: 10,000 Mbit/s
        /// 
        /// >  When **Role** is set to **AcceptingSide** (acceptor), **Spec** is set to **Negative**.
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
