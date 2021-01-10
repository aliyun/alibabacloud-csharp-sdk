// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeLinkaTaskstatisticsinfoResponseBody : TeaModel {
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
        public QueryLinkeLinkaTaskstatisticsinfoResponseBodyResult Result { get; set; }
        public class QueryLinkeLinkaTaskstatisticsinfoResponseBodyResult : TeaModel {
            [NameInMap("CodeLines")]
            [Validation(Required=false)]
            public long? CodeLines { get; set; }
            [NameInMap("ContentLines")]
            [Validation(Required=false)]
            public long? ContentLines { get; set; }
            [NameInMap("Costs")]
            [Validation(Required=false)]
            public long? Costs { get; set; }
            [NameInMap("DuplicateCodeLines")]
            [Validation(Required=false)]
            public long? DuplicateCodeLines { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("PublicApis")]
            [Validation(Required=false)]
            public long? PublicApis { get; set; }
            [NameInMap("PublicCommentedApis")]
            [Validation(Required=false)]
            public long? PublicCommentedApis { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
        };

    }

}
