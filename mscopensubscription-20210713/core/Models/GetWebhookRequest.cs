// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MscOpenSubscription20210713.Models
{
    public class GetWebhookRequest : TeaModel {
        [NameInMap("Locale")]
        [Validation(Required=false)]
        public string Locale { get; set; }

        [NameInMap("WebhookId")]
        [Validation(Required=false)]
        public long? WebhookId { get; set; }

    }

}
