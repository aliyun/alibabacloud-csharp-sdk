// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasRiskPreplanforaggregationitemResponseBody : TeaModel {
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
        public QueryHasRiskPreplanforaggregationitemResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasRiskPreplanforaggregationitemResponseBodyResultContent : TeaModel {
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
            public List<QueryHasRiskPreplanforaggregationitemResponseBodyResultContentData> Data { get; set; }
            public class QueryHasRiskPreplanforaggregationitemResponseBodyResultContentData : TeaModel {
                public string Id { get; set; }
                public string UtcCreate { get; set; }
                public string UtcModified { get; set; }
                public string Name { get; set; }
                public string TenantId { get; set; }
                public string Status { get; set; }
                public string RiskLevel { get; set; }
                public string Creator { get; set; }
                public string Operator { get; set; }
                public string Description { get; set; }
                public string Type { get; set; }
                public QueryHasRiskPreplanforaggregationitemResponseBodyResultContentDataEmergencyTargetDTO EmergencyTargetDTO { get; set; }
                public class QueryHasRiskPreplanforaggregationitemResponseBodyResultContentDataEmergencyTargetDTO : TeaModel {
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                    [NameInMap("TargetValues")]
                    [Validation(Required=false)]
                    public List<string> TargetValues { get; set; }

                }
            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasRiskPreplanforaggregationitemResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasRiskPreplanforaggregationitemResponseBodyResultContentTopErrorCode : TeaModel {
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
            public QueryHasRiskPreplanforaggregationitemResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasRiskPreplanforaggregationitemResponseBodyResultContentTopErrorReason : TeaModel {
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
