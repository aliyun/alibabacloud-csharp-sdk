// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasCloudarchLocalallcellResponseBody : TeaModel {
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
        public QueryHasCloudarchLocalallcellResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasCloudarchLocalallcellResponseBodyResultContent : TeaModel {
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
            public List<QueryHasCloudarchLocalallcellResponseBodyResultContentData> Data { get; set; }
            public class QueryHasCloudarchLocalallcellResponseBodyResultContentData : TeaModel {
                public string Id { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public string CellId { get; set; }
                public string CellName { get; set; }
                public string CellDisplayName { get; set; }
                public string WorkSpaceId { get; set; }
                public string WorkSpaceName { get; set; }
                public string WorkSpaceDisplayName { get; set; }
                public string EnvId { get; set; }
                public string EnvName { get; set; }
                public string EnvDisplayName { get; set; }
                public string AkeClusterId { get; set; }
                public string AkeClusterName { get; set; }
                public string AkeKubeConfig { get; set; }
            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasCloudarchLocalallcellResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasCloudarchLocalallcellResponseBodyResultContentTopErrorCode : TeaModel {
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
            public QueryHasCloudarchLocalallcellResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasCloudarchLocalallcellResponseBodyResultContentTopErrorReason : TeaModel {
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
