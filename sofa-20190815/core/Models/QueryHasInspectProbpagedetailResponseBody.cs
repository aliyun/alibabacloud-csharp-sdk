// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasInspectProbpagedetailResponseBody : TeaModel {
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
        public QueryHasInspectProbpagedetailResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasInspectProbpagedetailResponseBodyResultContent : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryHasInspectProbpagedetailResponseBodyResultContentData Data { get; set; }
            public class QueryHasInspectProbpagedetailResponseBodyResultContentData : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ProdCode")]
                [Validation(Required=false)]
                public string ProdCode { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("NeedLogin")]
                [Validation(Required=false)]
                public bool? NeedLogin { get; set; }

                [NameInMap("Cookies")]
                [Validation(Required=false)]
                public string Cookies { get; set; }

                [NameInMap("DeleteDtatus")]
                [Validation(Required=false)]
                public long? DeleteDtatus { get; set; }

                [NameInMap("DeleteAt")]
                [Validation(Required=false)]
                public string DeleteAt { get; set; }

                [NameInMap("Gid")]
                [Validation(Required=false)]
                public string Gid { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }

                [NameInMap("CheckRule")]
                [Validation(Required=false)]
                public QueryHasInspectProbpagedetailResponseBodyResultContentDataCheckRule CheckRule { get; set; }
                public class QueryHasInspectProbpagedetailResponseBodyResultContentDataCheckRule : TeaModel {
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
                };

            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasInspectProbpagedetailResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasInspectProbpagedetailResponseBodyResultContentTopErrorCode : TeaModel {
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
            public QueryHasInspectProbpagedetailResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasInspectProbpagedetailResponseBodyResultContentTopErrorReason : TeaModel {
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
