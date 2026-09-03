// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class SendByAppShrinkRequest : TeaModel {
        [NameInMap("AndroidPayload")]
        [Validation(Required=false)]
        public string AndroidPayloadShrink { get; set; }

        [NameInMap("AndroidShortPayload")]
        [Validation(Required=false)]
        public string AndroidShortPayloadShrink { get; set; }

        [NameInMap("ChannelProperties")]
        [Validation(Required=false)]
        public string ChannelPropertiesShrink { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("HarmonyPayload")]
        [Validation(Required=false)]
        public string HarmonyPayloadShrink { get; set; }

        [NameInMap("IosPayload")]
        [Validation(Required=false)]
        public string IosPayloadShrink { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string PolicyShrink { get; set; }

        [NameInMap("ProductionMode")]
        [Validation(Required=false)]
        public bool? ProductionMode { get; set; }

        [NameInMap("ReceiptType")]
        [Validation(Required=false)]
        public int? ReceiptType { get; set; }

        [NameInMap("ReceiptUrl")]
        [Validation(Required=false)]
        public string ReceiptUrl { get; set; }

        [NameInMap("ThirdPartyId")]
        [Validation(Required=false)]
        public string ThirdPartyId { get; set; }

        [NameInMap("callbackParams")]
        [Validation(Required=false)]
        public string CallbackParams { get; set; }

    }

}
