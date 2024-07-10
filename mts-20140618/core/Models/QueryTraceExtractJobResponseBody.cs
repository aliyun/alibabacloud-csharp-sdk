// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryTraceExtractJobResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTraceExtractJobResponseBodyData Data { get; set; }
        public class QueryTraceExtractJobResponseBodyData : TeaModel {
            [NameInMap("Trace")]
            [Validation(Required=false)]
            public string Trace { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public long? StatusCode { get; set; }

    }

}
