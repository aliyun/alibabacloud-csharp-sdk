// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleNotification : TeaModel {
        [NameInMap("contacts")]
        [Validation(Required=false)]
        public List<string> Contacts { get; set; }

        [NameInMap("customWebhooks")]
        [Validation(Required=false)]
        public List<string> CustomWebhooks { get; set; }

        [NameInMap("dingWebhooks")]
        [Validation(Required=false)]
        public List<string> DingWebhooks { get; set; }

        [NameInMap("fsWebhooks")]
        [Validation(Required=false)]
        public List<string> FsWebhooks { get; set; }

        [NameInMap("groups")]
        [Validation(Required=false)]
        public List<string> Groups { get; set; }

        [NameInMap("notifyTime")]
        [Validation(Required=false)]
        public AlertRuleTimeSpan NotifyTime { get; set; }

        [NameInMap("silenceTime")]
        [Validation(Required=false)]
        public long? SilenceTime { get; set; }

        [NameInMap("slackWebhooks")]
        [Validation(Required=false)]
        public List<string> SlackWebhooks { get; set; }

        [NameInMap("wxWebhooks")]
        [Validation(Required=false)]
        public List<string> WxWebhooks { get; set; }

    }

}
