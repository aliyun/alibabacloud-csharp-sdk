// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiMockContract : TeaModel {
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("responseCode")]
        [Validation(Required=false)]
        public int? ResponseCode { get; set; }

        [NameInMap("responseContent")]
        [Validation(Required=false)]
        public string ResponseContent { get; set; }

    }

}
