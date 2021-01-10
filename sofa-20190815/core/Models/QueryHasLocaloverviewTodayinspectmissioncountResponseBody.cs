// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasLocaloverviewTodayinspectmissioncountResponseBody : TeaModel {
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
        public QueryHasLocaloverviewTodayinspectmissioncountResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasLocaloverviewTodayinspectmissioncountResponseBodyResultContent : TeaModel {
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
            public QueryHasLocaloverviewTodayinspectmissioncountResponseBodyResultContentData Data { get; set; }
            public class QueryHasLocaloverviewTodayinspectmissioncountResponseBodyResultContentData : TeaModel {
                [NameInMap("CountPlan")]
                [Validation(Required=false)]
                public long? CountPlan { get; set; }

                [NameInMap("CountExecuted")]
                [Validation(Required=false)]
                public long? CountExecuted { get; set; }

            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasLocaloverviewTodayinspectmissioncountResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasLocaloverviewTodayinspectmissioncountResponseBodyResultContentTopErrorCode : TeaModel {
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
            public QueryHasLocaloverviewTodayinspectmissioncountResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasLocaloverviewTodayinspectmissioncountResponseBodyResultContentTopErrorReason : TeaModel {
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
