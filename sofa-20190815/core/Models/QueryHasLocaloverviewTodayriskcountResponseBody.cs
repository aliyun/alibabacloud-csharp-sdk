// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryHasLocaloverviewTodayriskcountResponseBody : TeaModel {
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
        public QueryHasLocaloverviewTodayriskcountResponseBodyResultContent ResultContent { get; set; }
        public class QueryHasLocaloverviewTodayriskcountResponseBodyResultContent : TeaModel {
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
            public QueryHasLocaloverviewTodayriskcountResponseBodyResultContentData Data { get; set; }
            public class QueryHasLocaloverviewTodayriskcountResponseBodyResultContentData : TeaModel {
                [NameInMap("CountTotal")]
                [Validation(Required=false)]
                public long? CountTotal { get; set; }

                [NameInMap("CountOn")]
                [Validation(Required=false)]
                public long? CountOn { get; set; }

                [NameInMap("CountProcessing")]
                [Validation(Required=false)]
                public long? CountProcessing { get; set; }

                [NameInMap("CountResolved")]
                [Validation(Required=false)]
                public long? CountResolved { get; set; }

                [NameInMap("CountOff")]
                [Validation(Required=false)]
                public long? CountOff { get; set; }

                [NameInMap("CountP0")]
                [Validation(Required=false)]
                public long? CountP0 { get; set; }

                [NameInMap("CountP1")]
                [Validation(Required=false)]
                public long? CountP1 { get; set; }

                [NameInMap("CountP2")]
                [Validation(Required=false)]
                public long? CountP2 { get; set; }

                [NameInMap("CountInfo")]
                [Validation(Required=false)]
                public long? CountInfo { get; set; }

            }
            [NameInMap("TopErrorCode")]
            [Validation(Required=false)]
            public QueryHasLocaloverviewTodayriskcountResponseBodyResultContentTopErrorCode TopErrorCode { get; set; }
            public class QueryHasLocaloverviewTodayriskcountResponseBodyResultContentTopErrorCode : TeaModel {
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
            public QueryHasLocaloverviewTodayriskcountResponseBodyResultContentTopErrorReason TopErrorReason { get; set; }
            public class QueryHasLocaloverviewTodayriskcountResponseBodyResultContentTopErrorReason : TeaModel {
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
