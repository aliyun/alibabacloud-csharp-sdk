// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class SafeChangeQueryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SafeChangeQueryResponseBodyData Data { get; set; }
        public class SafeChangeQueryResponseBodyData : TeaModel {
            [NameInMap("ApproveResultUrl")]
            [Validation(Required=false)]
            public string ApproveResultUrl { get; set; }

            [NameInMap("ApproveStatus")]
            [Validation(Required=false)]
            public string ApproveStatus { get; set; }

            [NameInMap("ChangeCancel")]
            [Validation(Required=false)]
            public string ChangeCancel { get; set; }

            [NameInMap("ChangeEndTime")]
            [Validation(Required=false)]
            public long? ChangeEndTime { get; set; }

            [NameInMap("ChangeObject")]
            [Validation(Required=false)]
            public string ChangeObject { get; set; }

            [NameInMap("ChangeOptType")]
            [Validation(Required=false)]
            public string ChangeOptType { get; set; }

            [NameInMap("ChangeResult")]
            [Validation(Required=false)]
            public string ChangeResult { get; set; }

            [NameInMap("ChangeStartTime")]
            [Validation(Required=false)]
            public long? ChangeStartTime { get; set; }

            [NameInMap("ChangeStatus")]
            [Validation(Required=false)]
            public string ChangeStatus { get; set; }

            [NameInMap("ChangeSystem")]
            [Validation(Required=false)]
            public string ChangeSystem { get; set; }

            [NameInMap("ChangeTimes")]
            [Validation(Required=false)]
            public List<SafeChangeQueryResponseBodyDataChangeTimes> ChangeTimes { get; set; }
            public class SafeChangeQueryResponseBodyDataChangeTimes : TeaModel {
                [NameInMap("ChangeEndTime")]
                [Validation(Required=false)]
                public long? ChangeEndTime { get; set; }

                [NameInMap("ChangeStartTime")]
                [Validation(Required=false)]
                public long? ChangeStartTime { get; set; }

            }

            [NameInMap("ChangeTitle")]
            [Validation(Required=false)]
            public string ChangeTitle { get; set; }

            [NameInMap("CheckResultUrl")]
            [Validation(Required=false)]
            public string CheckResultUrl { get; set; }

            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public string CheckStatus { get; set; }

            [NameInMap("CheckholdReason")]
            [Validation(Required=false)]
            public List<string> CheckholdReason { get; set; }

            [NameInMap("ExecutorEmpId")]
            [Validation(Required=false)]
            public string ExecutorEmpId { get; set; }

            [NameInMap("ExecutorEmpName")]
            [Validation(Required=false)]
            public string ExecutorEmpName { get; set; }

            [NameInMap("SourceOrderId")]
            [Validation(Required=false)]
            public string SourceOrderId { get; set; }

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
