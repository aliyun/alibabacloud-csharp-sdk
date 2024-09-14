// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class GetJobResponseBody : TeaModel {
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetJobResponseBodyJob Job { get; set; }
        public class GetJobResponseBodyJob : TeaModel {
            [NameInMap("Completed")]
            [Validation(Required=false)]
            public bool? Completed { get; set; }

            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            [NameInMap("Response")]
            [Validation(Required=false)]
            public string Response { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
