// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class GetOutbounNumListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOutbounNumListResponseBodyData Data { get; set; }
        public class GetOutbounNumListResponseBodyData : TeaModel {
            [NameInMap("Num")]
            [Validation(Required=false)]
            public List<GetOutbounNumListResponseBodyDataNum> Num { get; set; }
            public class GetOutbounNumListResponseBodyDataNum : TeaModel {
                public string Description { get; set; }
                public int? Type { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("NumGroup")]
            [Validation(Required=false)]
            public List<GetOutbounNumListResponseBodyDataNumGroup> NumGroup { get; set; }
            public class GetOutbounNumListResponseBodyDataNumGroup : TeaModel {
                public string Description { get; set; }
                public int? Type { get; set; }
                public string Value { get; set; }
            }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

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
