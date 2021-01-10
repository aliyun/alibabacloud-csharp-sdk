// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasLocaloverviewTotalcountResponseBody : TeaModel {
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
        public QueryHasLocaloverviewTotalcountResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasLocaloverviewTotalcountResponseBodyResultContent : TeaModel {
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
            public QueryHasLocaloverviewTotalcountResponseBodyResultContentData Data { get; set; }
            public class QueryHasLocaloverviewTotalcountResponseBodyResultContentData : TeaModel {
                [NameInMap("DiagnosisSceneCount")]
                [Validation(Required=false)]
                public long? DiagnosisSceneCount { get; set; }

                [NameInMap("EmergencyPlanCount")]
                [Validation(Required=false)]
                public long? EmergencyPlanCount { get; set; }

                [NameInMap("ExperimentSpecCount")]
                [Validation(Required=false)]
                public long? ExperimentSpecCount { get; set; }

                [NameInMap("InspectProdExistCount")]
                [Validation(Required=false)]
                public long? InspectProdExistCount { get; set; }

                [NameInMap("InspectRuleCount")]
                [Validation(Required=false)]
                public long? InspectRuleCount { get; set; }

                [NameInMap("ProductTotalCount")]
                [Validation(Required=false)]
                public long? ProductTotalCount { get; set; }

                [NameInMap("RiskHandledCount")]
                [Validation(Required=false)]
                public long? RiskHandledCount { get; set; }

                [NameInMap("RiskTotalCount")]
                [Validation(Required=false)]
                public long? RiskTotalCount { get; set; }

            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasLocaloverviewTotalcountResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasLocaloverviewTotalcountResponseBodyResultContentTopErrorCode : TeaModel {
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
            public QueryHasLocaloverviewTotalcountResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasLocaloverviewTotalcountResponseBodyResultContentTopErrorReason : TeaModel {
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
