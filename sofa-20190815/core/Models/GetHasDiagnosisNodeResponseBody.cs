// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetHasDiagnosisNodeResponseBody : TeaModel {
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
        public GetHasDiagnosisNodeResponseBodyResultContent ResultContent { get; set; }
        public class GetHasDiagnosisNodeResponseBodyResultContent : TeaModel {
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
            public GetHasDiagnosisNodeResponseBodyResultContentData Data { get; set; }
            public class GetHasDiagnosisNodeResponseBodyResultContentData : TeaModel {
                [NameInMap("IsReference")]
                [Validation(Required=false)]
                public bool? IsReference { get; set; }

                [NameInMap("ReferenceCount")]
                [Validation(Required=false)]
                public long? ReferenceCount { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("ExecutableStatus")]
                [Validation(Required=false)]
                public string ExecutableStatus { get; set; }

                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public string Timeout { get; set; }

                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

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

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<GetHasDiagnosisNodeResponseBodyResultContentDataTags> Tags { get; set; }
                public class GetHasDiagnosisNodeResponseBodyResultContentDataTags : TeaModel {
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
            public GetHasDiagnosisNodeResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class GetHasDiagnosisNodeResponseBodyResultContentTopErrorCode : TeaModel {
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
            public GetHasDiagnosisNodeResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class GetHasDiagnosisNodeResponseBodyResultContentTopErrorReason : TeaModel {
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
