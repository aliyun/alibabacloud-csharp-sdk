// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MscOpenSubscription20210713.Models
{
    public class ListWebhooksResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Webhooks")]
        [Validation(Required=false)]
        public List<ListWebhooksResponseBodyWebhooks> Webhooks { get; set; }
        public class ListWebhooksResponseBodyWebhooks : TeaModel {
            [NameInMap("ServerUrl")]
            [Validation(Required=false)]
            public string ServerUrl { get; set; }

            [NameInMap("WebhookId")]
            [Validation(Required=false)]
            public long? WebhookId { get; set; }

            [NameInMap("WebhookName")]
            [Validation(Required=false)]
            public string WebhookName { get; set; }

        }

    }

}
