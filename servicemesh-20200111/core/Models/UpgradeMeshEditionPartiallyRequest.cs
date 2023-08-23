// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpgradeMeshEditionPartiallyRequest : TeaModel {
        /// <summary>
        /// Specifies whether to upgrade the ASM gateways for the ASM instance. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// </summary>
        [NameInMap("ASMGatewayContinue")]
        [Validation(Required=false)]
        public bool? ASMGatewayContinue { get; set; }

        [NameInMap("ExpectedVersion")]
        [Validation(Required=false)]
        public string ExpectedVersion { get; set; }

        /// <summary>
        /// Specifies whether to perform an upgrade check. If the value of this parameter is set to true, only the upgrade check is performed and the ASM instance is not upgraded.
        /// </summary>
        [NameInMap("PreCheck")]
        [Validation(Required=false)]
        public bool? PreCheck { get; set; }

        /// <summary>
        /// The ASM instance ID.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// Specifies whether to upgrade the ASM instance to Professional Edition. Valid values:
        /// 
        /// *   `true`
        /// *   `false`
        /// </summary>
        [NameInMap("SwitchToPro")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? SwitchToPro { get; set; }

        /// <summary>
        /// Specifies the ASM gateways to be upgraded. Separate multiple ASM gateways with commas (,).
        /// </summary>
        [NameInMap("UpgradeGatewayRecords")]
        [Validation(Required=false)]
        public string UpgradeGatewayRecords { get; set; }

    }

}
