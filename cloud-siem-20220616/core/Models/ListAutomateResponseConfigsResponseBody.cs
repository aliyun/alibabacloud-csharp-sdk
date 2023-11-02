// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListAutomateResponseConfigsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAutomateResponseConfigsResponseBodyData Data { get; set; }
        public class ListAutomateResponseConfigsResponseBodyData : TeaModel {
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListAutomateResponseConfigsResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListAutomateResponseConfigsResponseBodyDataPageInfo : TeaModel {
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
            public List<ListAutomateResponseConfigsResponseBodyDataResponseData> ResponseData { get; set; }
            public class ListAutomateResponseConfigsResponseBodyDataResponseData : TeaModel {
                [NameInMap("ActionConfig")]
                [Validation(Required=false)]
                public string ActionConfig { get; set; }

                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                [NameInMap("AutoResponseType")]
                [Validation(Required=false)]
                public string AutoResponseType { get; set; }

                [NameInMap("ExecutionCondition")]
                [Validation(Required=false)]
                public string ExecutionCondition { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public long? SubUserId { get; set; }

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
