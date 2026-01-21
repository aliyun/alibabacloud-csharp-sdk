// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bsn20150512.Models
{
    public class ProductBindBsnResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public ProductBindBsnResponseBody Body { get; set; }

    }

}
