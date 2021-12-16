// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListSipTracesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSipTracesResponseBodyData> Data { get; set; }
        public class ListSipTracesResponseBodyData : TeaModel {
            [NameInMap("CallId")]
            [Validation(Required=false)]
            public string CallId { get; set; }

            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            [NameInMap("DestinationNodeIp")]
            [Validation(Required=false)]
            public string DestinationNodeIp { get; set; }

            [NameInMap("FirstLine")]
            [Validation(Required=false)]
            public string FirstLine { get; set; }

            [NameInMap("Payload")]
            [Validation(Required=false)]
            public string Payload { get; set; }

            [NameInMap("SourceNodeIp")]
            [Validation(Required=false)]
            public string SourceNodeIp { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
