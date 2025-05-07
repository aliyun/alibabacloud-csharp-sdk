// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Buss20220822.Models
{
    public class GetSecurityEventDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSecurityEventDetailResponseBodyData Data { get; set; }
        public class GetSecurityEventDetailResponseBodyData : TeaModel {
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public string Aliuid { get; set; }

            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public string DataSource { get; set; }

            [NameInMap("EventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

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
