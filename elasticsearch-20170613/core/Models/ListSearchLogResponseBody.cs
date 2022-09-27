// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListSearchLogResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListSearchLogResponseBodyHeaders Headers { get; set; }
        public class ListSearchLogResponseBodyHeaders : TeaModel {
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListSearchLogResponseBodyResult> Result { get; set; }
        public class ListSearchLogResponseBodyResult : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("contentCollection")]
            [Validation(Required=false)]
            public Dictionary<string, object> ContentCollection { get; set; }

            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

    }

}
