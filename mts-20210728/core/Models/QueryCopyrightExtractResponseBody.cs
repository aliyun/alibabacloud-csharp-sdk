// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20210728.Models
{
    public class QueryCopyrightExtractResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCopyrightExtractResponseBodyData Data { get; set; }
        public class QueryCopyrightExtractResponseBodyData : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestID")]
        [Validation(Required=false)]
        public string RequestID { get; set; }

        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public long? StatusCode { get; set; }

    }

}
