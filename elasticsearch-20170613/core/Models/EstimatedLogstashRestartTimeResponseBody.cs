// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class EstimatedLogstashRestartTimeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public EstimatedLogstashRestartTimeResponseBodyResult Result { get; set; }
        public class EstimatedLogstashRestartTimeResponseBodyResult : TeaModel {
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public long? Value { get; set; }

        }

    }

}
