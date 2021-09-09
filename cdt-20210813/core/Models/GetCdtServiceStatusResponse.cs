// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDT20210813.Models
{
    public class GetCdtServiceStatusResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public GetCdtServiceStatusResponseBody Body { get; set; }

    }

}
