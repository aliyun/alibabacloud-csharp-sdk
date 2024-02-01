// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryStreamPushJobResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryStreamPushJobResponseBodyData Data { get; set; }
        public class QueryStreamPushJobResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public int? CreateTime { get; set; }

            [NameInMap("JobType")]
            [Validation(Required=false)]
            public int? JobType { get; set; }

            [NameInMap("PushStatus")]
            [Validation(Required=false)]
            public int? PushStatus { get; set; }

            [NameInMap("PushUrl")]
            [Validation(Required=false)]
            public string PushUrl { get; set; }

            [NameInMap("StreamType")]
            [Validation(Required=false)]
            public int? StreamType { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
