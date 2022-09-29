// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class GetBodyPersonResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBodyPersonResponseBodyData Data { get; set; }
        public class GetBodyPersonResponseBodyData : TeaModel {
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TraceCount")]
            [Validation(Required=false)]
            public long? TraceCount { get; set; }

            [NameInMap("TraceList")]
            [Validation(Required=false)]
            public List<GetBodyPersonResponseBodyDataTraceList> TraceList { get; set; }
            public class GetBodyPersonResponseBodyDataTraceList : TeaModel {
                [NameInMap("ExtraData")]
                [Validation(Required=false)]
                public string ExtraData { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
