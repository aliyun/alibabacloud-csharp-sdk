// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeLinklogLogsresultResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("ResponseContentRange")]
        [Validation(Required=false)]
        public string ResponseContentRange { get; set; }

        [NameInMap("ResponseContentType")]
        [Validation(Required=false)]
        public string ResponseContentType { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetLinkeLinklogLogsresultResponseBodyResult Result { get; set; }
        public class GetLinkeLinklogLogsresultResponseBodyResult : TeaModel {
            [NameInMap("BizInfo")]
            [Validation(Required=false)]
            public string BizInfo { get; set; }
            [NameInMap("FullLogUrl")]
            [Validation(Required=false)]
            public string FullLogUrl { get; set; }
            [NameInMap("LineCount")]
            [Validation(Required=false)]
            public long? LineCount { get; set; }
            [NameInMap("LogId")]
            [Validation(Required=false)]
            public long? LogId { get; set; }
            [NameInMap("RawLogDownloadUrl")]
            [Validation(Required=false)]
            public string RawLogDownloadUrl { get; set; }
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }
            [NameInMap("SourcePath")]
            [Validation(Required=false)]
            public string SourcePath { get; set; }
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("StoreId")]
            [Validation(Required=false)]
            public long? StoreId { get; set; }
            [NameInMap("StoreName")]
            [Validation(Required=false)]
            public string StoreName { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }
            [NameInMap("TaskUrl")]
            [Validation(Required=false)]
            public string TaskUrl { get; set; }
            [NameInMap("BlockContent")]
            [Validation(Required=false)]
            public List<string> BlockContent { get; set; }
            [NameInMap("CauseResults")]
            [Validation(Required=false)]
            public List<string> CauseResults { get; set; }
            [NameInMap("Envs")]
            [Validation(Required=false)]
            public List<string> Envs { get; set; }
            [NameInMap("FeedbackOptions")]
            [Validation(Required=false)]
            public List<string> FeedbackOptions { get; set; }
            [NameInMap("FeedbackResult")]
            [Validation(Required=false)]
            public List<string> FeedbackResult { get; set; }
            [NameInMap("PatternResult")]
            [Validation(Required=false)]
            public List<string> PatternResult { get; set; }
            [NameInMap("Steps")]
            [Validation(Required=false)]
            public List<string> Steps { get; set; }
        };

    }

}
