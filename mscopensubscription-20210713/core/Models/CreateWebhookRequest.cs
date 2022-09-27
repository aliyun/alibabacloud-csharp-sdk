// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MscOpenSubscription20210713.Models
{
    public class CreateWebhookRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Locale")]
        [Validation(Required=false)]
        public string Locale { get; set; }

        [NameInMap("ServerUrl")]
        [Validation(Required=false)]
        public string ServerUrl { get; set; }

        [NameInMap("WebhookName")]
        [Validation(Required=false)]
        public string WebhookName { get; set; }

    }

}
