// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasInspectProbpageResponseBody : TeaModel {
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
        public QueryHasInspectProbpageResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasInspectProbpageResponseBodyResultContent : TeaModel {
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
            public List<QueryHasInspectProbpageResponseBodyResultContentData> Data { get; set; }
            public class QueryHasInspectProbpageResponseBodyResultContentData : TeaModel {
                public string Name { get; set; }
                public string ProdCode { get; set; }
                public string Url { get; set; }
                public bool? NeedLogin { get; set; }
                public string Cookies { get; set; }
                public long? DeleteDtatus { get; set; }
                public string DeleteAt { get; set; }
                public string Gid { get; set; }
                public string Creator { get; set; }
                public string TenantId { get; set; }
                public string Id { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public QueryHasInspectProbpageResponseBodyResultContentDataCheckRule CheckRule { get; set; }
                public class QueryHasInspectProbpageResponseBodyResultContentDataCheckRule : TeaModel {
                    [NameInMap("Element")]
                    [Validation(Required=false)]
                    public string Element { get; set; }

                    [NameInMap("DefineTimeFlag")]
                    [Validation(Required=false)]
                    public bool? DefineTimeFlag { get; set; }

                    [NameInMap("PageLoadTimeout")]
                    [Validation(Required=false)]
                    public long? PageLoadTimeout { get; set; }

                    [NameInMap("CheckElementTimeout")]
                    [Validation(Required=false)]
                    public long? CheckElementTimeout { get; set; }

                    [NameInMap("OtherCheckElement")]
                    [Validation(Required=false)]
                    public List<string> OtherCheckElement { get; set; }

                }
            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasInspectProbpageResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasInspectProbpageResponseBodyResultContentTopErrorCode : TeaModel {
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
            public QueryHasInspectProbpageResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasInspectProbpageResponseBodyResultContentTopErrorReason : TeaModel {
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
