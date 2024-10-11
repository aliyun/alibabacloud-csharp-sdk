// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SuperappNlp20240930.Models
{
    public class NlpAddressNormalizationResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public NlpAddressNormalizationResponseBody Body { get; set; }

    }

}
