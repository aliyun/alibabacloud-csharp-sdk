// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class DeleteAlarmRuleRequest : TeaModel {
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        [NameInMap("AlarmRuleId")]
        [Validation(Required=false)]
        public string AlarmRuleId { get; set; }

    }

}
