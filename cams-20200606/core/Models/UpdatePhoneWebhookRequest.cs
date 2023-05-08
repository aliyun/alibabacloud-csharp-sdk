// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdatePhoneWebhookRequest : TeaModel {
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        [NameInMap("HttpFlag")]
        [Validation(Required=false)]
        public string HttpFlag { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("QueueFlag")]
        [Validation(Required=false)]
        public string QueueFlag { get; set; }

        [NameInMap("StatusCallbackUrl")]
        [Validation(Required=false)]
        public string StatusCallbackUrl { get; set; }

        [NameInMap("UpCallbackUrl")]
        [Validation(Required=false)]
        public string UpCallbackUrl { get; set; }

    }

}
