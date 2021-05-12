// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Address_purification20191118.Models
{
    public class GetAddressEvaluateResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public GetAddressEvaluateResponseBody Body { get; set; }

    }

}
