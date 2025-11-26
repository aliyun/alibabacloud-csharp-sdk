// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleSend : TeaModel {
        [NameInMap("action")]
        [Validation(Required=false)]
        public AlertRuleAction Action { get; set; }

        [NameInMap("notification")]
        [Validation(Required=false)]
        public AlertRuleNotification Notification { get; set; }

        [NameInMap("notifyStrategies")]
        [Validation(Required=false)]
        public List<string> NotifyStrategies { get; set; }

        [NameInMap("sendToArms")]
        [Validation(Required=false)]
        public bool? SendToArms { get; set; }

    }

}
