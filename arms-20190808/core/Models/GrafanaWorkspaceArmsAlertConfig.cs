// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GrafanaWorkspaceArmsAlertConfig : TeaModel {
        [NameInMap("armsAlertsEnable")]
        [Validation(Required=false)]
        public string ArmsAlertsEnable { get; set; }

        [NameInMap("armsAlertsWebhookUrl")]
        [Validation(Required=false)]
        public string ArmsAlertsWebhookUrl { get; set; }

    }

}
