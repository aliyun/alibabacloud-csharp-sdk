// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MscOpenSubscription20210713.Models
{
    public class CreateSubscriptionItemResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubscriptionItem")]
        [Validation(Required=false)]
        public CreateSubscriptionItemResponseBodySubscriptionItem SubscriptionItem { get; set; }
        public class CreateSubscriptionItemResponseBodySubscriptionItem : TeaModel {
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            [NameInMap("ContactIds")]
            [Validation(Required=false)]
            public List<long?> ContactIds { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EmailStatus")]
            [Validation(Required=false)]
            public int? EmailStatus { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public int? ItemId { get; set; }

            [NameInMap("ItemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            [NameInMap("PmsgStatus")]
            [Validation(Required=false)]
            public int? PmsgStatus { get; set; }

            [NameInMap("SmsStatus")]
            [Validation(Required=false)]
            public int? SmsStatus { get; set; }

            [NameInMap("TtsStatus")]
            [Validation(Required=false)]
            public int? TtsStatus { get; set; }

            [NameInMap("WebhookIds")]
            [Validation(Required=false)]
            public List<long?> WebhookIds { get; set; }

            [NameInMap("WebhookStatus")]
            [Validation(Required=false)]
            public int? WebhookStatus { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
