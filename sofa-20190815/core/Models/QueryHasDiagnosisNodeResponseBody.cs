// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasDiagnosisNodeResponseBody : TeaModel {
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
        public QueryHasDiagnosisNodeResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasDiagnosisNodeResponseBodyResultContent : TeaModel {
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
            public List<QueryHasDiagnosisNodeResponseBodyResultContentData> Data { get; set; }
            public class QueryHasDiagnosisNodeResponseBodyResultContentData : TeaModel {
                public bool? IsReference { get; set; }
                public long? ReferenceCount { get; set; }
                public string Name { get; set; }
                public string Description { get; set; }
                public string NodeType { get; set; }
                public string ExecutableStatus { get; set; }
                public string Timeout { get; set; }
                public string Operator { get; set; }
                public string TenantId { get; set; }
                public string Id { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public List<QueryHasDiagnosisNodeResponseBodyResultContentDataTags> Tags { get; set; }
                public class QueryHasDiagnosisNodeResponseBodyResultContentDataTags : TeaModel {
                    public string TagCode { get; set; }
                    public string Name { get; set; }
                    public string Type { get; set; }
                }
            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasDiagnosisNodeResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasDiagnosisNodeResponseBodyResultContentTopErrorCode : TeaModel {
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
            public QueryHasDiagnosisNodeResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasDiagnosisNodeResponseBodyResultContentTopErrorReason : TeaModel {
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
