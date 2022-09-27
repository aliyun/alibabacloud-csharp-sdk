// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MscOpenSubscription20210713.Models
{
    public class UpdateSubscriptionItemRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ContactIds")]
        [Validation(Required=false)]
        public List<long?> ContactIds { get; set; }

        [NameInMap("EmailStatus")]
        [Validation(Required=false)]
        public int? EmailStatus { get; set; }

        [NameInMap("ItemId")]
        [Validation(Required=false)]
        public int? ItemId { get; set; }

        [NameInMap("Locale")]
        [Validation(Required=false)]
        public string Locale { get; set; }

        [NameInMap("PmsgStatus")]
        [Validation(Required=false)]
        public int? PmsgStatus { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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

}
