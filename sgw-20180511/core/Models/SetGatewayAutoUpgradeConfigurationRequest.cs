// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class SetGatewayAutoUpgradeConfigurationRequest : TeaModel {
        [NameInMap("AutoUpgradeEndHour")]
        [Validation(Required=false)]
        public int? AutoUpgradeEndHour { get; set; }

        [NameInMap("AutoUpgradeStartHour")]
        [Validation(Required=false)]
        public int? AutoUpgradeStartHour { get; set; }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("IsAutoUpgrade")]
        [Validation(Required=false)]
        public bool? IsAutoUpgrade { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
