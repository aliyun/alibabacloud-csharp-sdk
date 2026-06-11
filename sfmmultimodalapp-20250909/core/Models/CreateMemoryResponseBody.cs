// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class CreateMemoryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateMemoryResponseBodyData Data { get; set; }
        public class CreateMemoryResponseBodyData : TeaModel {
            [NameInMap("MemoryNodes")]
            [Validation(Required=false)]
            public List<CreateMemoryResponseBodyDataMemoryNodes> MemoryNodes { get; set; }
            public class CreateMemoryResponseBodyDataMemoryNodes : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Event")]
                [Validation(Required=false)]
                public string Event { get; set; }

                [NameInMap("MemoryNodeId")]
                [Validation(Required=false)]
                public string MemoryNodeId { get; set; }

                [NameInMap("OldContent")]
                [Validation(Required=false)]
                public string OldContent { get; set; }

            }

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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
