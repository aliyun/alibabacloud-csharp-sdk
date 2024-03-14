// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210519.Models
{
    public class GetStackResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StackInfo")]
        [Validation(Required=false)]
        public List<GetStackResponseBodyStackInfo> StackInfo { get; set; }
        public class GetStackResponseBodyStackInfo : TeaModel {
            [NameInMap("Api")]
            [Validation(Required=false)]
            public string Api { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("Exception")]
            [Validation(Required=false)]
            public string Exception { get; set; }

            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public GetStackResponseBodyStackInfoExtInfo ExtInfo { get; set; }
            public class GetStackResponseBodyStackInfoExtInfo : TeaModel {
                [NameInMap("Info")]
                [Validation(Required=false)]
                public string Info { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Line")]
            [Validation(Required=false)]
            public string Line { get; set; }

            [NameInMap("RpcId")]
            [Validation(Required=false)]
            public string RpcId { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

    }

}
