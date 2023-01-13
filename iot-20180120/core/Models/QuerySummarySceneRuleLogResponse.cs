// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySummarySceneRuleLogResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QuerySummarySceneRuleLogResponseData Data { get; set; }
        public class QuerySummarySceneRuleLogResponseData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=true)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

            [NameInMap("LogList")]
            [Validation(Required=true)]
            public QuerySummarySceneRuleLogResponseDataLogList LogList { get; set; }
            public class QuerySummarySceneRuleLogResponseDataLogList : TeaModel {
                [NameInMap("LogInfo")]
                [Validation(Required=true)]
                public List<QuerySummarySceneRuleLogResponseDataLogListLogInfo> LogInfo { get; set; }
                public class QuerySummarySceneRuleLogResponseDataLogListLogInfo : TeaModel {
                    [NameInMap("LogTime")]
                    [Validation(Required=true)]
                    public int? LogTime { get; set; }

                    [NameInMap("Result")]
                    [Validation(Required=true)]
                    public string Result { get; set; }

                    [NameInMap("TraceId")]
                    [Validation(Required=true)]
                    public string TraceId { get; set; }

                }

            }

        }

    }

}
