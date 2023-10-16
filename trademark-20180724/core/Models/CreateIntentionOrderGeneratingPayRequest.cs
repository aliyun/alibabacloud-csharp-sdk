// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class CreateIntentionOrderGeneratingPayRequest : TeaModel {
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("IntentionBizId")]
        [Validation(Required=false)]
        public string IntentionBizId { get; set; }

        [NameInMap("PaymentCallback")]
        [Validation(Required=false)]
        public string PaymentCallback { get; set; }

    }

}
