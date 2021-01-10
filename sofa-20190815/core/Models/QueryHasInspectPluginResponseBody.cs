// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasInspectPluginResponseBody : TeaModel {
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
        public QueryHasInspectPluginResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasInspectPluginResponseBodyResultContent : TeaModel {
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
            public List<QueryHasInspectPluginResponseBodyResultContentData> Data { get; set; }
            public class QueryHasInspectPluginResponseBodyResultContentData : TeaModel {
                public bool? Associated { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
                public string Description { get; set; }
                public string Status { get; set; }
                public string PluginType { get; set; }
                public long? DeleteStatus { get; set; }
                public string DeleteAt { get; set; }
                public string Gid { get; set; }
                public string Creator { get; set; }
                public string TenantId { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public List<QueryHasInspectPluginResponseBodyResultContentDataTags> Tags { get; set; }
                public class QueryHasInspectPluginResponseBodyResultContentDataTags : TeaModel {
                    public string TagCode { get; set; }
                    public string Name { get; set; }
                    public string Type { get; set; }
                }
                public List<QueryHasInspectPluginResponseBodyResultContentDataAvailableActions> AvailableActions { get; set; }
                public class QueryHasInspectPluginResponseBodyResultContentDataAvailableActions : TeaModel {
                    public string Code { get; set; }
                    public string Description { get; set; }
                }
                public QueryHasInspectPluginResponseBodyResultContentDataMaintainTeam MaintainTeam { get; set; }
                public class QueryHasInspectPluginResponseBodyResultContentDataMaintainTeam : TeaModel {
                    [NameInMap("TagCode")]
                    [Validation(Required=false)]
                    public string TagCode { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }
            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasInspectPluginResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasInspectPluginResponseBodyResultContentTopErrorCode : TeaModel {
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
            public QueryHasInspectPluginResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasInspectPluginResponseBodyResultContentTopErrorReason : TeaModel {
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
