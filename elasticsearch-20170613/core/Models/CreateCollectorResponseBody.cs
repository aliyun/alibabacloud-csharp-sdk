// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateCollectorResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateCollectorResponseBodyResult Result { get; set; }
        public class CreateCollectorResponseBodyResult : TeaModel {
            [NameInMap("resId")]
            [Validation(Required=false)]
            public string ResId { get; set; }

        }

    }

}
