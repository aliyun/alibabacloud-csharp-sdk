// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasDiagnosisRuleResponseBody : TeaModel {
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
        public QueryHasDiagnosisRuleResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasDiagnosisRuleResponseBodyResultContent : TeaModel {
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
            public List<QueryHasDiagnosisRuleResponseBodyResultContentData> Data { get; set; }
            public class QueryHasDiagnosisRuleResponseBodyResultContentData : TeaModel {
                public string Id { get; set; }
                public string Name { get; set; }
                public string Description { get; set; }
                public string RuleType { get; set; }
                public string TargetType { get; set; }
                public string Creator { get; set; }
                public string UtcCreate { get; set; }
                public bool? IsReferenced { get; set; }
                public string ReferenceCount { get; set; }
                public QueryHasDiagnosisRuleResponseBodyResultContentDataRuleArg RuleArg { get; set; }
                public class QueryHasDiagnosisRuleResponseBodyResultContentDataRuleArg : TeaModel {
                    [NameInMap("InspectRuleId")]
                    [Validation(Required=false)]
                    public string InspectRuleId { get; set; }

                    [NameInMap("AllApp")]
                    [Validation(Required=false)]
                    public bool? AllApp { get; set; }

                    [NameInMap("AllProd")]
                    [Validation(Required=false)]
                    public bool? AllProd { get; set; }

                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("WorkspaceUid")]
                    [Validation(Required=false)]
                    public string WorkspaceUid { get; set; }

                    [NameInMap("RmsTenantId")]
                    [Validation(Required=false)]
                    public string RmsTenantId { get; set; }

                    [NameInMap("RmsWorkspaceId")]
                    [Validation(Required=false)]
                    public string RmsWorkspaceId { get; set; }

                    [NameInMap("QueryTime")]
                    [Validation(Required=false)]
                    public long? QueryTime { get; set; }

                    [NameInMap("SpaceTypeCode")]
                    [Validation(Required=false)]
                    public string SpaceTypeCode { get; set; }

                    [NameInMap("ProdCode")]
                    [Validation(Required=false)]
                    public string ProdCode { get; set; }

                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    [NameInMap("TenantName")]
                    [Validation(Required=false)]
                    public string TenantName { get; set; }

                    [NameInMap("WorkspaceName")]
                    [Validation(Required=false)]
                    public string WorkspaceName { get; set; }

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
            public QueryHasDiagnosisRuleResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasDiagnosisRuleResponseBodyResultContentTopErrorCode : TeaModel {
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
            public QueryHasDiagnosisRuleResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasDiagnosisRuleResponseBodyResultContentTopErrorReason : TeaModel {
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
