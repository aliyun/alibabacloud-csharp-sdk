// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAiOutboundTaskExecDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiOutboundTaskExecDetailResponseBodyData Data { get; set; }
        public class GetAiOutboundTaskExecDetailResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("HasNextPage")]
            [Validation(Required=false)]
            public bool? HasNextPage { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetAiOutboundTaskExecDetailResponseBodyDataList> List { get; set; }
            public class GetAiOutboundTaskExecDetailResponseBodyDataList : TeaModel {
                [NameInMap("BatchVersion")]
                [Validation(Required=false)]
                public int? BatchVersion { get; set; }

                [NameInMap("BizData")]
                [Validation(Required=false)]
                public string BizData { get; set; }

                [NameInMap("CallCount")]
                [Validation(Required=false)]
                public int? CallCount { get; set; }

                [NameInMap("CaseId")]
                [Validation(Required=false)]
                public long? CaseId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("LastCallResult")]
                [Validation(Required=false)]
                public string LastCallResult { get; set; }

                [NameInMap("PhoneNum")]
                [Validation(Required=false)]
                public string PhoneNum { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public int? StatusDesc { get; set; }

            }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public int? TotalResults { get; set; }

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
