// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryUserOmsDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryUserOmsDataResponseBodyData Data { get; set; }
        public class QueryUserOmsDataResponseBodyData : TeaModel {
            [NameInMap("Marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }
            [NameInMap("OmsData")]
            [Validation(Required=false)]
            public List<string> OmsData { get; set; }
        };

    }

}
