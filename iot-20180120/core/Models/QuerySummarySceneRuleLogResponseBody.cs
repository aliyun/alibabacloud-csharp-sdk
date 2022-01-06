// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySummarySceneRuleLogResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySummarySceneRuleLogResponseBodyData Data { get; set; }
        public class QuerySummarySceneRuleLogResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("LogList")]
            [Validation(Required=false)]
            public QuerySummarySceneRuleLogResponseBodyDataLogList LogList { get; set; }
            public class QuerySummarySceneRuleLogResponseBodyDataLogList : TeaModel {
                [NameInMap("LogInfo")]
                [Validation(Required=false)]
                public List<QuerySummarySceneRuleLogResponseBodyDataLogListLogInfo> LogInfo { get; set; }
                public class QuerySummarySceneRuleLogResponseBodyDataLogListLogInfo : TeaModel {
                    [NameInMap("LogTime")]
                    [Validation(Required=false)]
                    public int? LogTime { get; set; }

                    [NameInMap("Result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    [NameInMap("TraceId")]
                    [Validation(Required=false)]
                    public string TraceId { get; set; }

                }

            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
