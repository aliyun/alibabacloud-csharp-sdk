// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasDiagnosisPlantriggerResponseBody : TeaModel {
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
        public QueryHasDiagnosisPlantriggerResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasDiagnosisPlantriggerResponseBodyResultContent : TeaModel {
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
            public List<QueryHasDiagnosisPlantriggerResponseBodyResultContentData> Data { get; set; }
            public class QueryHasDiagnosisPlantriggerResponseBodyResultContentData : TeaModel {
                public string Name { get; set; }
                public string DiagPlanId { get; set; }
                public string Type { get; set; }
                public string Code { get; set; }
                public string ScopeConfig { get; set; }
                public string Creator { get; set; }
                public string TenantId { get; set; }
                public string Id { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public QueryHasDiagnosisPlantriggerResponseBodyResultContentDataScopeConfigObj ScopeConfigObj { get; set; }
                public class QueryHasDiagnosisPlantriggerResponseBodyResultContentDataScopeConfigObj : TeaModel {
                    [NameInMap("BindType")]
                    [Validation(Required=false)]
                    public string BindType { get; set; }

                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                    [NameInMap("ProdCodes")]
                    [Validation(Required=false)]
                    public List<string> ProdCodes { get; set; }

                    [NameInMap("AppNames")]
                    [Validation(Required=false)]
                    public List<string> AppNames { get; set; }

                }
            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasDiagnosisPlantriggerResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasDiagnosisPlantriggerResponseBodyResultContentTopErrorCode : TeaModel {
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
            public QueryHasDiagnosisPlantriggerResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasDiagnosisPlantriggerResponseBodyResultContentTopErrorReason : TeaModel {
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
