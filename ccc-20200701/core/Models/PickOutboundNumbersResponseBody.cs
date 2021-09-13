// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class PickOutboundNumbersResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<PickOutboundNumbersResponseBodyData> Data { get; set; }
        public class PickOutboundNumbersResponseBodyData : TeaModel {
            [NameInMap("Callee")]
            [Validation(Required=false)]
            public PickOutboundNumbersResponseBodyDataCallee Callee { get; set; }
            public class PickOutboundNumbersResponseBodyDataCallee : TeaModel {
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }
                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }
                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }
            };

            [NameInMap("Caller")]
            [Validation(Required=false)]
            public PickOutboundNumbersResponseBodyDataCaller Caller { get; set; }
            public class PickOutboundNumbersResponseBodyDataCaller : TeaModel {
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }
                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }
                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }
            };

        }

    }

}
