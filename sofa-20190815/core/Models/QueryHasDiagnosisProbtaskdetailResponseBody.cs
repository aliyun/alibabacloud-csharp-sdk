// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasDiagnosisProbtaskdetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public QueryHasDiagnosisProbtaskdetailResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasDiagnosisProbtaskdetailResponseBodyResultContent : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryHasDiagnosisProbtaskdetailResponseBodyResultContentData> Data { get; set; }
            public class QueryHasDiagnosisProbtaskdetailResponseBodyResultContentData : TeaModel {
                public string ProdCode { get; set; }
                public string PageId { get; set; }
                public string ExecutionId { get; set; }
                public string ProbTaskId { get; set; }
                public string Name { get; set; }
                public string Url { get; set; }
                public string Result { get; set; }
                public string Msg { get; set; }
                public string Id { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasDiagnosisProbtaskdetailResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasDiagnosisProbtaskdetailResponseBodyResultContentTopErrorCode : TeaModel {
                [NameInMap("ExceptionCode")]
                [Validation(Required=false)]
                public string ExceptionCode { get; set; }

                [NameInMap("ExceptionCodeDescription")]
                [Validation(Required=false)]
                public string ExceptionCodeDescription { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("Prefix")]
                [Validation(Required=false)]
                public string Prefix { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }
            [NameInMap("TopErrorReason")]
            [Validation(Required=false)]
            public QueryHasDiagnosisProbtaskdetailResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasDiagnosisProbtaskdetailResponseBodyResultContentTopErrorReason : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

            }
        };

    }

}
