// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CheckWebhookRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

        [NameInMap("webhookType")]
        [Validation(Required=false)]
        public string WebhookType { get; set; }

    }

}
