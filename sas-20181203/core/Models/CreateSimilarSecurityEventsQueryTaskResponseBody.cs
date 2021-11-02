// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateSimilarSecurityEventsQueryTaskResponseBody : TeaModel {
        [NameInMap("CreateSimilarSecurityEventsQueryTaskResponse")]
        [Validation(Required=false)]
        public CreateSimilarSecurityEventsQueryTaskResponseBodyCreateSimilarSecurityEventsQueryTaskResponse CreateSimilarSecurityEventsQueryTaskResponse { get; set; }
        public class CreateSimilarSecurityEventsQueryTaskResponseBodyCreateSimilarSecurityEventsQueryTaskResponse : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
