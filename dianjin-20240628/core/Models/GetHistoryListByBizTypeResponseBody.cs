// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetHistoryListByBizTypeResponseBody : TeaModel {
        [NameInMap("cost")]
        [Validation(Required=false)]
        public long? Cost { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetHistoryListByBizTypeResponseBodyData Data { get; set; }
        public class GetHistoryListByBizTypeResponseBodyData : TeaModel {
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("records")]
            [Validation(Required=false)]
            public List<GetHistoryListByBizTypeResponseBodyDataRecords> Records { get; set; }
            public class GetHistoryListByBizTypeResponseBodyDataRecords : TeaModel {
                [NameInMap("bizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("bizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("extraMessage")]
                [Validation(Required=false)]
                public object ExtraMessage { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("llmAnswer")]
                [Validation(Required=false)]
                public string LlmAnswer { get; set; }

                [NameInMap("llmPrompt")]
                [Validation(Required=false)]
                public string LlmPrompt { get; set; }

                [NameInMap("llmType")]
                [Validation(Required=false)]
                public string LlmType { get; set; }

                [NameInMap("sessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                [NameInMap("userQuery")]
                [Validation(Required=false)]
                public string UserQuery { get; set; }

            }

            [NameInMap("totalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

            [NameInMap("totalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

        }

        [NameInMap("dataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
