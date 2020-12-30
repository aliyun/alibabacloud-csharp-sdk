// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetMailAddressMsgCallBackUrlResponseBody : TeaModel {
        [NameInMap("NotifyUrlStatus")]
        [Validation(Required=false)]
        public int? NotifyUrlStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NotifyUrl")]
        [Validation(Required=false)]
        public int? NotifyUrl { get; set; }

    }

}
