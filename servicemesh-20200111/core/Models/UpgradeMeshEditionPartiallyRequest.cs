// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpgradeMeshEditionPartiallyRequest : TeaModel {
        [NameInMap("ASMGatewayContinue")]
        [Validation(Required=false)]
        public bool? ASMGatewayContinue { get; set; }

        [NameInMap("ExpectedVersion")]
        [Validation(Required=false)]
        public string ExpectedVersion { get; set; }

        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        [NameInMap("SwitchToPro")]
        [Validation(Required=false)]
        public bool? SwitchToPro { get; set; }

        [NameInMap("UpgradeGatewayRecords")]
        [Validation(Required=false)]
        public string UpgradeGatewayRecords { get; set; }

    }

}
