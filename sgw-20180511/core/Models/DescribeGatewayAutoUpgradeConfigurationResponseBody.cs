// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewayAutoUpgradeConfigurationResponseBody : TeaModel {
        [NameInMap("AutoUpgradeEndHour")]
        [Validation(Required=false)]
        public int? AutoUpgradeEndHour { get; set; }

        [NameInMap("AutoUpgradeStartHour")]
        [Validation(Required=false)]
        public int? AutoUpgradeStartHour { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IsAutoUpgrade")]
        [Validation(Required=false)]
        public bool? IsAutoUpgrade { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
