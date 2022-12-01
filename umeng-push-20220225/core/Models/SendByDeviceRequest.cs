// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class SendByDeviceRequest : TeaModel {
        [NameInMap("AndroidPayload")]
        [Validation(Required=false)]
        public AndroidPayload AndroidPayload { get; set; }

        [NameInMap("ChannelProperties")]
        [Validation(Required=false)]
        public ChannelProperties ChannelProperties { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DeviceTokens")]
        [Validation(Required=false)]
        public string DeviceTokens { get; set; }

        [NameInMap("IosPayload")]
        [Validation(Required=false)]
        public IosPayload IosPayload { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public Policy Policy { get; set; }

        [NameInMap("ProductionMode")]
        [Validation(Required=false)]
        public bool? ProductionMode { get; set; }

        [NameInMap("ReceiptType")]
        [Validation(Required=false)]
        public int? ReceiptType { get; set; }

        [NameInMap("ReceiptUrl")]
        [Validation(Required=false)]
        public string ReceiptUrl { get; set; }

    }

}
