// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListCustomizeRuleTestResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCustomizeRuleTestResultResponseBodyData Data { get; set; }
        public class ListCustomizeRuleTestResultResponseBodyData : TeaModel {
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListCustomizeRuleTestResultResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListCustomizeRuleTestResultResponseBodyDataPageInfo : TeaModel {
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<ListCustomizeRuleTestResultResponseBodyDataResponseData> ResponseData { get; set; }
            public class ListCustomizeRuleTestResultResponseBodyDataResponseData : TeaModel {
                [NameInMap("AlertDesc")]
                [Validation(Required=false)]
                public string AlertDesc { get; set; }

                [NameInMap("AlertDetail")]
                [Validation(Required=false)]
                public string AlertDetail { get; set; }

                [NameInMap("AlertSrcProd")]
                [Validation(Required=false)]
                public string AlertSrcProd { get; set; }

                [NameInMap("AlertSrcProdModule")]
                [Validation(Required=false)]
                public string AlertSrcProdModule { get; set; }

                [NameInMap("AttCk")]
                [Validation(Required=false)]
                public string AttCk { get; set; }

                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("LogSource")]
                [Validation(Required=false)]
                public string LogSource { get; set; }

                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public string LogTime { get; set; }

                [NameInMap("LogType")]
                [Validation(Required=false)]
                public string LogType { get; set; }

                [NameInMap("MainUserId")]
                [Validation(Required=false)]
                public string MainUserId { get; set; }

                [NameInMap("OnlineStatus")]
                [Validation(Required=false)]
                public string OnlineStatus { get; set; }

                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public string SubUserId { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
