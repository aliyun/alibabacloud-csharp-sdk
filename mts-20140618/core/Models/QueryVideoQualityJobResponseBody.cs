// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryVideoQualityJobResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Job")]
        [Validation(Required=false)]
        public QueryVideoQualityJobResponseBodyJob Job { get; set; }
        public class QueryVideoQualityJobResponseBodyJob : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }
            [NameInMap("VideoQualityResults")]
            [Validation(Required=false)]
            public string VideoQualityResults { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
