// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class InsertAiOutboundPhoneNumsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public InsertAiOutboundPhoneNumsResponseBodyData Data { get; set; }
        public class InsertAiOutboundPhoneNumsResponseBodyData : TeaModel {
            [NameInMap("FailInfo")]
            [Validation(Required=false)]
            public List<InsertAiOutboundPhoneNumsResponseBodyDataFailInfo> FailInfo { get; set; }
            public class InsertAiOutboundPhoneNumsResponseBodyDataFailInfo : TeaModel {
                [NameInMap("BizData")]
                [Validation(Required=false)]
                public string BizData { get; set; }

                [NameInMap("Msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                [NameInMap("PhoneNum")]
                [Validation(Required=false)]
                public string PhoneNum { get; set; }

            }

            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
