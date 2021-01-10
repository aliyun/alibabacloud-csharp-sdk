// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasInspectWebruleResponseBody : TeaModel {
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
        public QueryHasInspectWebruleResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasInspectWebruleResponseBodyResultContent : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryHasInspectWebruleResponseBodyResultContentData> Data { get; set; }
            public class QueryHasInspectWebruleResponseBodyResultContentData : TeaModel {
                public string Creator { get; set; }
                public string DeleteAt { get; set; }
                public long? DeleteStatus { get; set; }
                public string Description { get; set; }
                public string FixMethod { get; set; }
                public string Gid { get; set; }
                public string Id { get; set; }
                public bool? IsIntra { get; set; }
                public string Name { get; set; }
                public string PluginId { get; set; }
                public string PluginType { get; set; }
                public string RuleStatus { get; set; }
                public string TenantId { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public string Args { get; set; }
                public List<QueryHasInspectWebruleResponseBodyResultContentDataAvailableActions> AvailableActions { get; set; }
                public class QueryHasInspectWebruleResponseBodyResultContentDataAvailableActions : TeaModel {
                    public string Code { get; set; }
                    public string Description { get; set; }
                }
            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasInspectWebruleResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasInspectWebruleResponseBodyResultContentTopErrorCode : TeaModel {
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
            public QueryHasInspectWebruleResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasInspectWebruleResponseBodyResultContentTopErrorReason : TeaModel {
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
