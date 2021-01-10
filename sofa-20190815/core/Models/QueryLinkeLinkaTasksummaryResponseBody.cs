// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeLinkaTasksummaryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryLinkeLinkaTasksummaryResponseBodyResult Result { get; set; }
        public class QueryLinkeLinkaTasksummaryResponseBodyResult : TeaModel {
            [NameInMap("Branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }
            [NameInMap("CommitId")]
            [Validation(Required=false)]
            public string CommitId { get; set; }
            [NameInMap("Costs")]
            [Validation(Required=false)]
            public long? Costs { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }
            [NameInMap("Diff")]
            [Validation(Required=false)]
            public bool? Diff { get; set; }
            [NameInMap("DiffOverflow")]
            [Validation(Required=false)]
            public bool? DiffOverflow { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }
            [NameInMap("StartCommitId")]
            [Validation(Required=false)]
            public string StartCommitId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }
            [NameInMap("TooLargeFiles")]
            [Validation(Required=false)]
            public List<string> TooLargeFiles { get; set; }
        };

    }

}
