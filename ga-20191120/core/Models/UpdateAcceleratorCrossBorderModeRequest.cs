// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateAcceleratorCrossBorderModeRequest : TeaModel {
        /// <summary>
        /// The GA instance ID.
        /// 
        /// > The bandwidth metering method of the GA instance must be pay-by-data-transfer.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The type of transmission network of the GA instance. Valid values:
        /// 
        /// *   **bgpPro**: BGP (Multi-ISP) Pro. BGP (Multi-ISP) Pro lines are used for cross-border acceleration. You do not need to perform real-name verification.
        /// *   **private**: cross-border Express Connect circuit. Cross-border Express Connect circuits provide better acceleration performance but require real-name verification.
        /// </summary>
        [NameInMap("CrossBorderMode")]
        [Validation(Required=false)]
        public string CrossBorderMode { get; set; }

        /// <summary>
        /// The region ID of the GA instance. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
